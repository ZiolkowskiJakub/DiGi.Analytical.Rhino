using DiGi.Rhino.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.Analytical.Building.Rhino.Classes
{
    /// <summary>
    /// Represents a serializable wrapper for an <see cref="Interfaces.IFloor"/> object, 
    /// enabling its integration and persistence within the Grasshopper environment.
    /// </summary>
    public class GooFloor : GooSerializableObject<Interfaces.IFloor>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GooFloor"/> class.
        /// </summary>
        public GooFloor()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GooFloor"/> class with the specified floor value.
        /// </summary>
        /// <param name="floor">The <see cref="Interfaces.IFloor"/> instance to wrap.</param>
        public GooFloor(Interfaces.IFloor? floor)
        {
            Value = floor;
        }

        /// <summary>
        /// Creates a duplicate of the current <see cref="GooFloor"/> object.
        /// </summary>
        /// <returns>A new <see cref="IGH_Goo"/> instance containing a copy of the original value.</returns>
        public override IGH_Goo Duplicate()
        {
            return new GooFloor(Value);
        }
    }

    /// <summary>
    /// Represents the Grasshopper parameter component used to manage and transfer 
    /// <see cref="GooFloor"/> objects.
    /// </summary>
    public class GooFloorParam : GooPresistentParam<GooFloor, Interfaces.IFloor>
    {
        /// <summary>
        /// Gets the unique identifier for the <see cref="GooFloorParam"/> component.
        /// </summary>
        public override Guid ComponentGuid => new("63c3a8b9-9dcd-456a-ae79-0e325d31972a");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        /// <summary>
        /// Initializes a new instance of the <see cref="GooFloorParam"/> class.
        /// </summary>
        public GooFloorParam()
            : base()
        {
        }
    }
}