using DiGi.Rhino.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.Analytical.Building.Rhino.Classes
{
    public class GooWall : GooSerializableObject<Interfaces.IWall>
    {
        public GooWall()
            : base()
        {
        }

        public GooWall(Interfaces.IWall wall)
        {
            Value = wall;
        }

        public override IGH_Goo Duplicate()
        {
            return new GooWall(Value);
        }

    }

    public class GooWallParam : GooPresistentParam<GooWall, Interfaces.IWall>
    {
        public override Guid ComponentGuid => new Guid("9badab6e-af7f-4cf6-a022-f4f7aabc1b57");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public GooWallParam()
            : base()
        {
        }
    }
}
