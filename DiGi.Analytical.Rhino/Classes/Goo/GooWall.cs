using DiGi.Rhino.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.Analytical.Building.Rhino.Classes
{
    /// <summary>
    /// Represents a serializable wrapper for an <see cref="Interfaces.IWall"/> object, 
    /// enabling its integration and persistence within the Grasshopper environment.
    /// </summary>
    public class GooWall : GooSerializableObject<Interfaces.IWall>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GooWall"/> class.
        /// </summary>
        public GooWall()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GooWall"/> class with the specified wall value.
        /// </summary>
        /// <param name="wall">The <see cref="Interfaces.IWall"/> object to wrap.</param>
        public GooWall(Interfaces.IWall? wall)
        {
            Value = wall;
        }

        /// <summary>
        /// Creates a duplicate of the current <see cref="GooWall"/> instance.
        /// </summary>
        /// <returns>A new <see cref="IGH_Goo"/> object containing a copy of the original value.</returns>
        public override IGH_Goo Duplicate()
        {
            return new GooWall(Value);
        }
    }

    /// <summary>
    /// Provides a Grasshopper parameter type for handling and persisting 
    /// <see cref="Interfaces.IWall"/> objects using the <see cref="GooWall"/> wrapper.
    /// </summary>
    public class GooWallParam : GooPresistentParam<GooWall, Interfaces.IWall>
    {
        /// <summary>
        /// Gets the unique identifier for the wall parameter component.
        /// </summary>
        public override Guid ComponentGuid => new("9badab6e-af7f-4cf6-a022-f4f7aabc1b57");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        /// <summary>
        /// Initializes a new instance of the <see cref="GooWallParam"/> class.
        /// </summary>
        public GooWallParam()
            : base()
        {
        }
    }
}