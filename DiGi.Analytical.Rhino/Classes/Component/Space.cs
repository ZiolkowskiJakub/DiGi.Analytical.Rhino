using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Core.Enums;
using DiGi.Rhino.Geometry.Spatial.Classes;
using Grasshopper.Kernel;
using System;
using System.Collections.Generic;

namespace DiGi.Analytical.Building.Rhino.Classes
{
    /// <summary>
    /// Represents a Grasshopper component that creates an analytical space based on a name and a spatial point.
    /// </summary>
    public class Space : VariableParameterComponent
    {
        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid => new("74f30bc7-8848-4fcb-96f9-8bafccdfb5ae");

        /// <summary>
        /// Gets the exposure level of the component, determining how it handles data flow.
        /// </summary>
        public override GH_Exposure Exposure => GH_Exposure.primary;

        /// <summary>
        /// Initializes a new instance of the <see cref="Space"/> class.
        /// </summary>
        public Space()
          : base("Analytical.Space", "Analytical.Space",
              "Analytical Space",
              "DiGi", "DiGi.Analytical")
        {
        }

        /// <summary>
        /// Registers all the input parameters for this component, including Name and Point.
        /// </summary>
        protected override Param[] Inputs
        {
            get
            {
                List<Param> result =
                [
                    new Param(new Grasshopper.Kernel.Parameters.Param_String() { Name = "Name", NickName = "Name", Description = "Space name", Access = GH_ParamAccess.item }, ParameterVisibility.Binding),
                    new Param(new GooPoint3DParam() { Name = "Point", NickName = "Point", Description = "Point", Access = GH_ParamAccess.item }, ParameterVisibility.Binding),
                ];

                return [.. result];
            }
        }

        /// <summary>
        /// Registers all the output parameters for this component, providing the resulting analytical space.
        /// </summary>
        protected override Param[] Outputs
        {
            get
            {
                List<Param> result =
                [
                    new Param(new GooSpaceParam() { Name = "Space", NickName = "Space", Description = "Analytical Space", Access = GH_ParamAccess.item }, ParameterVisibility.Binding),
                ];
                return [.. result];
            }
        }

        /// <summary>
        /// This is the method that actually does the work. It retrieves input data, instantiates a building space, and sets the output.
        /// </summary>
        /// <param name="dataAccess">The DA object used to retrieve from inputs and store in outputs.</param>
        protected override void SolveInstance(IGH_DataAccess dataAccess)
        {
            int index;

            index = Params.IndexOfInputParam("Name");
            string? name = null;
            if (index == -1 || !dataAccess.GetData(index, ref name))
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            index = Params.IndexOfInputParam("Point");
            Geometry.Spatial.Classes.Point3D? point3D = null;
            if (index == -1 || !dataAccess.GetData(index, ref point3D) || point3D == null)
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            Building.Classes.Space space = new(point3D, name);

            index = Params.IndexOfOutputParam("Space");
            if (index != -1)
            {
                dataAccess.SetData(index, new GooSpace(space));
            }
        }
    }
}