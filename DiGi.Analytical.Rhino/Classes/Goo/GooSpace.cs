using DiGi.Rhino.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.Analytical.Building.Rhino.Classes
{
    /// <summary>
    /// Represents a Grasshopper Goo wrapper for an <see cref="Interfaces.ISpace"/> object, 
    /// enabling its serialization and transport within the Grasshopper environment.
    /// </summary>
    public class GooSpace : GooSerializableObject<Interfaces.ISpace>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GooSpace"/> class.
        /// </summary>
        public GooSpace()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GooSpace"/> class with the specified space object.
        /// </summary>
        /// <param name="space">The <see cref="Interfaces.ISpace"/> instance to be wrapped.</param>
        public GooSpace(Interfaces.ISpace? space)
        {
            Value = space;
        }

        /// <summary>
        /// Creates a duplicate of the current Goo object.
        /// </summary>
        /// <returns>A new <see cref="IGH_Goo"/> instance containing a copy of the original value.</returns>
        public override IGH_Goo Duplicate()
        {
            return new GooSpace(Value);
        }
    }

    /// <summary>
    /// Represents the Grasshopper parameter component used to manage and display 
    /// <see cref="GooSpace"/> objects on the canvas.
    /// </summary>
    public class GooSpaceParam : GooPresistentParam<GooSpace, Interfaces.ISpace>
    {
        /// <summary>
        /// Gets the unique identifier for the <see cref="GooSpaceParam"/> component.
        /// </summary>
        public override Guid ComponentGuid => new("77336ad8-7cd6-410a-9e13-eb59ee2ad639");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        /// <summary>
        /// Initializes a new instance of the <see cref="GooSpaceParam"/> class.
        /// </summary>
        public GooSpaceParam()
            : base()
        {
        }
    }
}