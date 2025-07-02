using DiGi.Analytical.Building.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Geometry.Spatial.Classes;
using Grasshopper.Kernel.Types;

namespace DiGi.Analytical.Rhino
{
    public static partial class Inspect
    {
        [Inspect("Guid", "Guid", "Guid")]
        public static GH_Guid Guid(this IComponent component)
        {
            if (component == null)
            {
                return null;
            }

            return new GH_Guid(component.Guid);
        }

        [Inspect("Mesh3D", "Mesh3D", "Mesh3D")]
        public static GooMesh3D Mesh3D(this IComponent component)
        {
            if (component == null)
            {
                return null;
            }

            Mesh3D mesh3D = Building.Query.Mesh3D(component);

            return mesh3D == null ? null : new GooMesh3D(mesh3D);
        }
    }
}