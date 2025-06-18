using DiGi.Analytical.Building.Interfaces;
using DiGi.Analytical.Building.Rhino.Classes;
using DiGi.Rhino.Core.Classes;
using Grasshopper.Kernel.Types;
using System.Collections;

namespace DiGi.Analytical.Rhino
{
    public static partial class Inspect
    {
        [Inspect("Components", "Components", "BuildingModel Components")]
        public static IEnumerable Components(this Building.Classes.BuildingModel buildingModel)
        {
            if (buildingModel == null)
            {
                return null;
            }

            return buildingModel.GetComponents<IComponent>()?.ConvertAll(x => new GooComponent(x));
        }

        [Inspect("Guid", "Guid", "Guid")]
        public static GH_Guid Guid(this Building.Classes.BuildingModel buildingModel)
        {
            if (buildingModel == null)
            {
                return null;
            }

            return new GH_Guid(buildingModel.Guid);
        }

        [Inspect("Spaces", "Spaces", "BuildingModel Spaces")]
        public static IEnumerable Spaces(this Building.Classes.BuildingModel buildingModel)
        {
            if (buildingModel == null)
            {
                return null;
            }

            return buildingModel.GetSpaces<ISpace>()?.ConvertAll(x => new GooSpace(x));
        }
    }
}

