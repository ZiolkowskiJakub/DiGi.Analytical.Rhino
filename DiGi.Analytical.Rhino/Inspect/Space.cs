using DiGi.Analytical.Building.Classes;
using DiGi.Analytical.Building.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Rhino.Core.Classes;
using Grasshopper.Kernel.Types;

namespace DiGi.Analytical.Rhino
{
    public static partial class Inspect
    {
        [Inspect("Geometry", "Geometry", "Geometry")]
        public static Point3D? Geometry(this ISpace? space)
        {
            if (space == null)
            {
                return null;
            }

            return space is not Space space_Temp ? throw new System.NotImplementedException() : space_Temp.Geometry;
        }

        [Inspect("Guid", "Guid", "Guid")]
        public static GH_Guid? Guid(this ISpace? space)
        {
            if (space == null)
            {
                return null;
            }

            return new GH_Guid(space.Guid);
        }

        [Inspect("Name", "Name", "Name")]
        public static GH_String? Name(this ISpace? space)
        {
            if (space == null)
            {
                return null;
            }

            return space is not Space space_Temp ? throw new System.NotImplementedException() : new GH_String(space_Temp.Name);
        }
    }
}