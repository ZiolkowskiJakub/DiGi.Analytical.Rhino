using DiGi.Analytical.Building.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Rhino.Core.Classes;
using DiGi.Rhino.Geometry.Spatial.Classes;
using Grasshopper.Kernel.Types;

namespace DiGi.Analytical.Rhino
{
    public static partial class Inspect
    {
        /// <summary>
        /// Extracts the unique identifier of the specified component as a <see cref="GH_Guid"/>.
        /// </summary>
        /// <param name="component">The component to inspect.</param>
        /// <returns>A <see cref="GH_Guid"/> containing the component's ID, or <c>null</c> if the component is null.</returns>
        [Inspect("Guid", "Guid", "Guid")]
        public static GH_Guid? Guid(this IComponent? component)
        {
            if (component == null)
            {
                return null;
            }

            return new GH_Guid(component.Guid);
        }

        /// <summary>
        /// Retrieves the 3D mesh representation of the specified component as a <see cref="GooMesh3D"/>.
        /// </summary>
        /// <param name="component">The component to inspect.</param>
        /// <returns>A <see cref="GooMesh3D"/> wrapper around the retrieved mesh, or <c>null</c> if the component is null or no mesh is found.</returns>
        [Inspect("Mesh3D", "Mesh3D", "Mesh3D")]
        public static GooMesh3D? Mesh3D(this IComponent? component)
        {
            if (component == null)
            {
                return null;
            }

            Mesh3D? mesh3D = Building.Query.Mesh3D(component);

            return mesh3D == null ? null : new GooMesh3D(mesh3D);
        }
    }
}