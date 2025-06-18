using DiGi.Rhino.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.Analytical.Building.Rhino.Classes
{
    public class GooSpace : GooSerializableObject<Interfaces.ISpace>
    {
        public GooSpace()
            : base()
        {
        }

        public GooSpace(Interfaces.ISpace space)
        {
            Value = space;
        }

        public override IGH_Goo Duplicate()
        {
            return new GooSpace(Value);
        }

    }

    public class GooSpaceParam : GooPresistentParam<GooSpace, Interfaces.ISpace>
    {
        public override Guid ComponentGuid => new Guid("77336ad8-7cd6-410a-9e13-eb59ee2ad639");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public GooSpaceParam()
            : base()
        {
        }
    }
}
