using DiGi.Rhino.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.Analytical.Building.Rhino.Classes
{
    public class GooComponent : GooSerializableObject<Interfaces.IComponent>
    {
        public GooComponent()
            : base()
        {
        }

        public GooComponent(Interfaces.IComponent component)
        {
            Value = component;
        }

        public override IGH_Goo Duplicate()
        {
            return new GooComponent(Value);
        }

    }

    public class GooComponentParam : GooPresistentParam<GooComponent, Interfaces.IComponent>
    {
        public override Guid ComponentGuid => new Guid("107cc60e-c658-4a1e-b855-54620058a9d1");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public GooComponentParam()
            : base()
        {
        }
    }
}

