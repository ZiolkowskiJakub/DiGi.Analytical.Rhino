using DiGi.Rhino.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.Analytical.Building.Rhino.Classes
{
    public class GooBuildingModel : GooSerializableObject<Building.Classes.BuildingModel>
    {
        public GooBuildingModel()
            : base()
        {
        }

        public GooBuildingModel(Building.Classes.BuildingModel buildingModel)
        {
            Value = buildingModel;
        }

        public override IGH_Goo Duplicate()
        {
            return new GooBuildingModel(Value);
        }

    }

    public class GooBuildingModelParam : GooPresistentParam<GooBuildingModel, Building.Classes.BuildingModel>
    {
        public override Guid ComponentGuid => new Guid("1ab45874-ffa1-42ed-af8d-9b2702fd3294");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        public GooBuildingModelParam()
            : base()
        {
        }
    }
}