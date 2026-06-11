using DiGi.Analytical.Building.Classes;
using DiGi.Analytical.Building.Interfaces;
using DiGi.Geometry.Spatial.Classes;
using DiGi.Rhino.Core.Classes;
using Grasshopper.Kernel.Types;

namespace DiGi.Analytical.Rhino
{
    public static partial class Inspect
    {
        /// <summary>
        /// Retrieves the geometry associated with the specified space.
        /// </summary>
        /// <param name="space">The space instance to inspect.</param>
        /// <returns>The <see cref="Point3D"/> representing the geometry if successful; otherwise, <c>null</c>.</returns>
        /// <exception cref="System.NotImplementedException">Thrown when the provided <see cref="ISpace"/> is not an instance of <see cref="Space"/>.</exception>
        [Inspect("Geometry", "Geometry", "Geometry")]
        public static Point3D? Geometry(this ISpace? space)
        {
            if (space == null)
            {
                return null;
            }

            return space is not Space space_Temp ? throw new System.NotImplementedException() : space_Temp.Geometry;
        }

        /// <summary>
        /// Retrieves the unique identifier of the specified space as a Grasshopper Guid.
        /// </summary>
        /// <param name="space">The space instance to inspect.</param>
        /// <returns>A <see cref="GH_Guid"/> containing the space's identifier; otherwise, <c>null</c>.</returns>
        [Inspect("Guid", "Guid", "Guid")]
        public static GH_Guid? Guid(this ISpace? space)
        {
            if (space == null)
            {
                return null;
            }

            return new GH_Guid(space.Guid);
        }

        /// <summary>
        /// Retrieves the name of the specified space as a Grasshopper String.
        /// </summary>
        /// <param name="space">The space instance to inspect.</param>
        /// <returns>A <see cref="GH_String"/> containing the space's name; otherwise, <c>null</c>.</returns>
        /// <exception cref="System.NotImplementedException">Thrown when the provided <see cref="ISpace"/> is not an instance of <see cref="Space"/>.</exception>
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