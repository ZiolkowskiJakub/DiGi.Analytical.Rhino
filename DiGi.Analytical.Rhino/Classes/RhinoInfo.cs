using Grasshopper.Kernel;
using System;
using System.Drawing;

namespace DiGi.Analytical.Building.Rhino.Classes
{
    /// <summary>
    /// Provides assembly information for the DiGi Analytical Building Rhino plugin.
    /// This class is used by Grasshopper to identify the library and display metadata within the Rhino environment.
    /// </summary>
    public class RhinoInfo : GH_AssemblyInfo
    {
        /// <summary>
        /// Gets the name of the GHA library as it will be displayed in the Grasshopper interface.
        /// </summary>
        /// <value>The string "DiGi.Analytical.Building.Rhino".</value>
        public override string Name => "DiGi.Analytical.Building.Rhino";

        /// <summary>
        /// Gets a 24x24 pixel bitmap to represent this GHA library in the Grasshopper UI.
        /// </summary>
        /// <value>Returns <see langword="null"/> as no icon is currently provided.</value>
        public override Bitmap? Icon => null;

        /// <summary>
        /// Gets a short string describing the purpose and functionality of this GHA library.
        /// </summary>
        /// <value>An empty string.</value>
        public override string Description => "";

        /// <summary>
        /// Gets the unique identifier (GUID) for this assembly.
        /// </summary>
        /// <value>A <see cref="Guid"/> with value "886667e5-8cdc-4cd7-9718-de3ec0d324e0".</value>
        public override Guid Id => new("886667e5-8cdc-4cd7-9718-de3ec0d324e0");

        /// <summary>
        /// Gets the name of the individual or company responsible for creating this library.
        /// </summary>
        /// <value>The string "Jakub Ziolkowski".</value>
        public override string AuthorName => "Jakub Ziolkowski";

        /// <summary>
        /// Gets the preferred contact details for the author of this library.
        /// </summary>
        /// <value>The email address "jakubziolkowski@digiproject.uk".</value>
        public override string AuthorContact => "jakubziolkowski@digiproject.uk";
    }
}