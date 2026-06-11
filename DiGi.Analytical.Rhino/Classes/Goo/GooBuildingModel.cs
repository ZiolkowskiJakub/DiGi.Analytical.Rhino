using DiGi.Analytical.Building.Interfaces;
using DiGi.Core;
using DiGi.Geometry.Core.Interfaces;
using DiGi.Geometry.Spatial.Interfaces;
using DiGi.Rhino.Geometry.Core.Classes;
using Grasshopper.Kernel.Types;
using System;

namespace DiGi.Analytical.Building.Rhino.Classes
{
    /// <summary>
    /// Represents a Grasshopper Goo wrapper for the building model, enabling serialization and baking capabilities within the Rhino/Grasshopper environment.
    /// </summary>
    public class GooBuildingModel : GooBakeAwareSerializableObject<Building.Classes.BuildingModel>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GooBuildingModel"/> class.
        /// </summary>
        public GooBuildingModel()
            : base()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GooBuildingModel"/> class with the specified building model.
        /// </summary>
        /// <param name="buildingModel">The building model to be wrapped in the Goo object.</param>
        public GooBuildingModel(Building.Classes.BuildingModel? buildingModel)
        {
            Value = buildingModel;
        }

        /// <summary>
        /// Gets the collection of geometries associated with the building model that can be baked into the Rhino document.
        /// </summary>
        /// <value>An array of <see cref="IGeometry"/> objects derived from the building model's components.</value>
        public override IGeometry[]? Geometries
        {
            get
            {
                return Value?.GetComponents<IComponent>()?.ConvertAll(x => x.Geometry3D<IPlanar>())?.FilterNulls()?.ToArray();
            }
        }

        /// <summary>
        /// Creates a duplicate of the current Goo object.
        /// </summary>
        /// <returns>A new <see cref="IGH_Goo"/> instance containing the same building model value.</returns>
        public override IGH_Goo Duplicate()
        {
            return new GooBuildingModel(Value);
        }
    }

    /// <summary>
    /// Represents the Grasshopper parameter type used to handle and transport <see cref="GooBuildingModel"/> objects.
    /// </summary>
    public class GooBuildingModelParam : GooBakeAwareSerializableParam<GooBuildingModel, Building.Classes.BuildingModel>
    {
        /// <summary>
        /// Gets the unique identifier for the building model parameter component.
        /// </summary>
        /// <value>The <see cref="Guid"/> associated with this parameter type.</value>
        public override Guid ComponentGuid => new("1ab45874-ffa1-42ed-af8d-9b2702fd3294");

        //protected override System.Drawing.Bitmap Icon => Resources.DiGi_Small;
    }
}