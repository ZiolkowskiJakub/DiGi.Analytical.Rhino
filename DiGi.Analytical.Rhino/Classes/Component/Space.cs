using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Core.Enums;
using DiGi.Rhino.Geometry.Spatial.Classes;
using Grasshopper.Kernel;
using System;
using System.Collections.Generic;

namespace DiGi.Analytical.Building.Rhino.Classes
{
    public class Space : VariableParameterComponent
    {
        /// <summary>
        /// Gets the unique ID for this component. Do not change this ID after release.
        /// </summary>
        public override Guid ComponentGuid => new Guid("74f30bc7-8848-4fcb-96f9-8bafccdfb5ae");

        /// <summary>
        /// Provides an Icon for the component.
        /// </summary>
        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public override GH_Exposure Exposure => GH_Exposure.primary;

        /// <summary>
        /// Initializes a new instance of the SAM_point3D class.
        /// </summary>
        public Space()
          : base("Analytical.Space", "Analytical.Space",
              "Analytical Space",
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
                result.Add(new Param(new Grasshopper.Kernel.Parameters.Param_String() { Name = "Name", NickName = "Name", Description = "Space name", Access = GH_ParamAccess.item }, ParameterVisibility.Binding));
                result.Add(new Param(new GooPoint3DParam() { Name = "Point", NickName = "Point", Description = "Point", Access = GH_ParamAccess.item }, ParameterVisibility.Binding));
                
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
                result.Add(new Param(new GooSpaceParam() { Name = "Space", NickName = "Space", Description = "Analytical Space", Access = GH_ParamAccess.item }, ParameterVisibility.Binding)); 
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

            index = Params.IndexOfInputParam("Name");
            string name = null;
            if (index == -1 || !dataAccess.GetData(index, ref name))
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            index = Params.IndexOfInputParam("Point");
            Geometry.Spatial.Classes.Point3D point3D = null;
            if (index == -1 || !dataAccess.GetData(index, ref point3D) || point3D == null)
            {
                AddRuntimeMessage(GH_RuntimeMessageLevel.Error, "Invalid data");
                return;
            }

            Building.Classes.Space space = new Building.Classes.Space(point3D, name);

            index = Params.IndexOfOutputParam("Space");
            if (index != -1)
            {
                dataAccess.SetData(index, new GooSpace(space));
            }
        }
    }
}