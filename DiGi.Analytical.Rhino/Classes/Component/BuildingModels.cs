using DiGi.Analytical.Building.Classes;
using DiGi.Core.Constants;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Core.Enums;
using DiGi.Rhino.Geometry.Spatial.Classes;
using Grasshopper.Kernel;
using System;
using System.Collections.Generic;

namespace DiGi.Analytical.Building.Rhino.Classes
{
    /// <summary>
    /// Provides a Grasshopper component that filters building models based on their spatial proximity to a given point within a specified distance and tolerance.
    /// </summary>
    public class BuildingModels : VariableParameterComponent
    {
        /// <summary>
        /// Gets the unique identifier for this component. This ID must remain constant after release to ensure document compatibility.
        /// </summary>
        public override Guid ComponentGuid => new("63955d49-39aa-49e6-bfc6-76697cd89ca1");

        /// <summary>
        /// Gets the exposure level of the component, which determines its execution priority and visibility in the Grasshopper canvas.
        /// </summary>
        public override GH_Exposure Exposure => GH_Exposure.primary;

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildingModels"/> class with specified name, description, and category.
        /// </summary>
        public BuildingModels()
          : base("Analytical.BuildingModels", "Analytical.BuildingModels",
              "Analytical BuildingModels",
              "DiGi", "DiGi.Analytical")
        {
        }

        /// <summary>
        /// Registers and configures the input parameters for the component, including building models, a reference point, distance, and an optional tolerance.
        /// </summary>
        protected override Param[] Inputs
        {
            get
            {
                List<Param> result =
                [
                    new Param(new GooBuildingModelParam() { Name = "BuildingModels", NickName = "BuildingModels", Description = "Analytical BuildingModels", Access = GH_ParamAccess.list }, ParameterVisibility.Binding),
                    new Param(new GooPoint3DParam() { Name = "Point", NickName = "Point", Description = "Point", Access = GH_ParamAccess.item }, ParameterVisibility.Binding),
                    new Param(new Grasshopper.Kernel.Parameters.Param_Number() { Name = "Distance", NickName = "Distance", Description = "Distance from point", Access = GH_ParamAccess.item }, ParameterVisibility.Binding),
                ];

                Grasshopper.Kernel.Parameters.Param_Number param_Number = new() { Name = "Tolerance", NickName = "Tolerance", Description = "Tolerance", Access = GH_ParamAccess.item, Optional = true };
                param_Number.SetPersistentData(Tolerance.Distance);
                result.Add(new Param(param_Number, ParameterVisibility.Voluntary));

                return [.. result];
            }
        }

        /// <summary>
        /// Registers and configures the output parameters for the component, returning the filtered list of building models.
        /// </summary>
        protected override Param[] Outputs
        {
            get
            {
                List<Param> result =
                [
                    new Param(new GooBuildingModelParam() { Name = "BuildingModels", NickName = "BuildingModels", Description = "Analytical BuildingModels", Access = GH_ParamAccess.list }, ParameterVisibility.Binding),
                ];
                return [.. result];
            }
        }

        /// <summary>
        /// Performs the main computation of the component: retrieves input data, filters building models that are inside a sphere defined by the point and distance, and sets the output list.
        /// </summary>
        /// <param name="dataAccess">The <see cref="IGH_DataAccess"/> object used to retrieve values from inputs and store results in outputs.</param>
        protected override void SolveInstance(IGH_DataAccess dataAccess)
        {
            int index;

            index = Params.IndexOfInputParam("BuildingModels");
            List<BuildingModel> buildingModels_In = [];
            if (index == -1 || !dataAccess.GetDataList(index, buildingModels_In) || buildingModels_In == null)
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            index = Params.IndexOfInputParam("Point");
            DiGi.Geometry.Spatial.Classes.Point3D? point3D = null;
            if (index == -1 || !dataAccess.GetData(index, ref point3D) || point3D == null)
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            index = Params.IndexOfInputParam("Distance");
            double distance = double.NaN;
            if (index == -1 || !dataAccess.GetData(index, ref distance) || double.IsNaN(distance))
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            index = Params.IndexOfInputParam("Tolerance");
            double tolerance = Tolerance.Distance;
            if (index == -1 || !dataAccess.GetData(index, ref tolerance) || double.IsNaN(tolerance))
            {
                tolerance = Tolerance.Distance;
            }

            Sphere sphere = new(point3D, distance);

            List<BuildingModel> buildingModels_Out = [];
            foreach (BuildingModel buildingModel_In in buildingModels_In)
            {
                if (buildingModels_In != null && buildingModel_In.Inside(sphere, tolerance))
                {
                    buildingModels_Out.Add(buildingModel_In);
                }
            }

            index = Params.IndexOfOutputParam("BuildingModels");
            if (index != -1)
            {
                dataAccess.SetDataList(index, buildingModels_Out.ConvertAll(x => new GooBuildingModel(x)));
            }
        }
    }
}