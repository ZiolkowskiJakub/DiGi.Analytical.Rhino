using DiGi.Rhino.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.Analytical.Building.Rhino.Classes
{
    /// <summary>
    /// Represents a serializable wrapper for an <see cref="Interfaces.IComponent"/> object, 
    /// enabling its integration and persistence within the Grasshopper Goo system.
    /// </summary>
    public class GooComponent : GooSerializableObject<Interfaces.IComponent>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GooComponent"/> class.
        /// </summary>
        public GooComponent()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GooComponent"/> class with the specified component value.
        /// </summary>
        /// <param name="component">The <see cref="Interfaces.IComponent"/> instance to wrap.</param>
        public GooComponent(Interfaces.IComponent? component)
        {
            Value = component;
        }

        /// <summary>
        /// Creates a duplicate of the current <see cref="GooComponent"/> instance.
        /// </summary>
        /// <returns>A new <see cref="IGH_Goo"/> object containing the same value as the original.</returns>
        public override IGH_Goo Duplicate()
        {
            return new GooComponent(Value);
        }
    }

    /// <summary>
    /// Provides a persistent Grasshopper parameter implementation for handling <see cref="GooComponent"/> data.
    /// </summary>
    public class GooComponentParam : GooPresistentParam<GooComponent, Interfaces.IComponent>
    {
        /// <summary>
        /// Gets the unique identifier associated with this component parameter type.
        /// </summary>
        public override Guid ComponentGuid => new("107cc60e-c658-4a1e-b855-54620058a9d1");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;

        /// <summary>
        /// Initializes a new instance of the <see cref="GooComponentParam"/> class.
        /// </summary>
        public GooComponentParam()
            : base()
        {
        }
    }
}