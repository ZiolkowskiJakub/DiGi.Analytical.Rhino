using DiGi.Rhino.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.Analytical.Building.Rhino.Classes
{
    /// <summary>
    /// Represents a serializable Goo wrapper for roof objects, enabling them to be passed through Grasshopper components.
    /// </summary>
    public class GooRoof : GooSerializableObject<Interfaces.IRoof>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GooRoof"/> class.
        /// </summary>
        public GooRoof()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GooRoof"/> class with a specified roof value.
        /// </summary>
        /// <param name="roof">The roof object to wrap.</param>
        public GooRoof(Interfaces.IRoof? roof)
        {
            Value = roof;
        }

        /// <summary>
        /// Creates a duplicate of the current <see cref="GooRoof"/> instance.
        /// </summary>
        /// <returns>A new <see cref="IGH_Goo"/> object containing a copy of the original value.</returns>
        public override IGH_Goo Duplicate()
        {
            return new GooRoof(Value);
        }
    }

    /// <summary>
    /// The Grasshopper parameter component used to hold and manage <see cref="GooRoof"/> objects.
    /// </summary>
    public class GooRoofParam : GooPresistentParam<GooRoof, Interfaces.IRoof>
    {
        /// <summary>
        /// Gets the unique identifier for the <see cref="GooRoofParam"/> component.
        /// </summary>
        public override Guid ComponentGuid => new("7077831e-6d74-4fb1-8380-9519f0c15c1e");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        /// <summary>
        /// Initializes a new instance of the <see cref="GooRoofParam"/> class.
        /// </summary>
        public GooRoofParam()
            : base()
        {
        }
    }
}