using DiGi.Rhino.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.Analytical.Building.Rhino.Classes
{
    public class GooFloor : GooSerializableObject<Interfaces.IFloor>
    {
        public GooFloor()
            : base()
        {
        }

        public GooFloor(Interfaces.IFloor floor)
        {
            Value = floor;
        }

        public override IGH_Goo Duplicate()
        {
            return new GooFloor(Value);
        }

    }

    public class GooFloorParam : GooPresistentParam<GooFloor, Interfaces.IFloor>
    {
        public override Guid ComponentGuid => new Guid("63c3a8b9-9dcd-456a-ae79-0e325d31972a");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public GooFloorParam()
            : base()
        {
        }
    }
}
