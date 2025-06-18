using DiGi.Analytical.Building.Classes;
using DiGi.Core.Constans;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Core.Enums;
using DiGi.Rhino.Geometry.Classes;
using Grasshopper.Kernel;
using System;
using System.Collections.Generic;

namespace DiGi.Analytical.Building.Rhino.Classes
{
    public class BuildingModels : VariableParameterComponent
    {
        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid => new Guid("63955d49-39aa-49e6-bfc6-76697cd89ca1");

        /// <summary>
        /// Provides an Icon for the component.
        /// </summary>
        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public override GH_Exposure Exposure => GH_Exposure.primary;

        /// <summary>
        /// Initializes a new instance of the SAM_point3D class.
        /// </summary>
        public BuildingModels()
          : base("Analytical.BuildingModels", "Analytical.BuildingModels",
              "Analytical BuildingModels",
              "DiGi", "DiGi.Analytical")
        {
        }

        /// <summary>
        /// Registers all the input parameters for this component.
        /// </summary>
        protected override Param[] Inputs
        {
            get
            {
                List<Param> result = new List<Param>();
                result.Add(new Param(new GooBuildingModelParam() { Name = "BuildingModels", NickName = "BuildingModels", Description = "Analytical BuildingModels", Access = GH_ParamAccess.list }, ParameterVisibility.Binding));
                result.Add(new Param(new GooPoint3DParam() { Name = "Point", NickName = "Point", Description = "Point", Access = GH_ParamAccess.item }, ParameterVisibility.Binding));
                result.Add(new Param(new Grasshopper.Kernel.Parameters.Param_Number() { Name = "Distance", NickName = "Distance", Description = "Distance from point", Access = GH_ParamAccess.item }, ParameterVisibility.Binding));

                Grasshopper.Kernel.Parameters.Param_Number param_Number = new Grasshopper.Kernel.Parameters.Param_Number() { Name = "Tolerance", NickName = "Tolerance", Description = "Tolerance", Access = GH_ParamAccess.item, Optional = true };
                param_Number.SetPersistentData(Tolerance.Distance);
                result.Add(new Param(param_Number, ParameterVisibility.Voluntary));
                
                return result.ToArray();
            }
        }

        /// <summary>
        /// Registers all the output parameters for this component.
        /// </summary>
        protected override Param[] Outputs
        {
            get
            {
                List<Param> result = new List<Param>();
                result.Add(new Param(new GooBuildingModelParam() { Name = "BuildingModels", NickName = "BuildingModels", Description = "Analytical BuildingModels", Access = GH_ParamAccess.list }, ParameterVisibility.Binding)); 
                return result.ToArray();
            }
        }

        /// <summary>
        /// This is the method that actually does the work.
        /// </summary>
        /// <param name="dataAccess">
        /// The DA object is used to retrieve from inputs and store in outputs.
        /// </param>
        protected override void SolveInstance(IGH_DataAccess dataAccess)
        {
            int index;

            index = Params.IndexOfInputParam("BuildingModels");
            List<BuildingModel> buildingModels_In = new List<BuildingModel>();
            if (index == -1 || !dataAccess.GetDataList(index, buildingModels_In) || buildingModels_In == null)
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            index = Params.IndexOfInputParam("Point");
            Point3D point3D = null;
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

            Sphere sphere = new Sphere(point3D, distance);

            List<BuildingModel> buildingModels_Out = new List<BuildingModel>();
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