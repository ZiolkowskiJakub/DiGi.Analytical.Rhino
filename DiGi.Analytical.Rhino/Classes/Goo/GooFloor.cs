using DiGi.Rhino.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.Analytical.Building.Rhino.Classes
{
    public class GooRoof : GooSerializableObject<Interfaces.IRoof>
    {
        public GooRoof()
            : base()
        {
        }

        public GooRoof(Interfaces.IRoof roof)
        {
            Value = roof;
        }

        public override IGH_Goo Duplicate()
        {
            return new GooRoof(Value);
        }

    }

    public class GooRoofParam : GooPresistentParam<GooRoof, Interfaces.IRoof>
    {
        public override Guid ComponentGuid => new Guid("7077831e-6d74-4fb1-8380-9519f0c15c1e");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public GooRoofParam()
            : base()
        {
        }
    }
}
