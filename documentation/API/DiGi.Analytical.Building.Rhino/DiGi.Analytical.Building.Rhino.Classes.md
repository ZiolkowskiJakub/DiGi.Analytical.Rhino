#### [DiGi\.Analytical\.Building\.Rhino](DiGi.Analytical.Building.Rhino.Overview.md 'DiGi\.Analytical\.Building\.Rhino\.Overview')

## DiGi\.Analytical\.Building\.Rhino\.Classes Namespace
### Classes

<a name='DiGi.Analytical.Building.Rhino.Classes.BuildingModels'></a>

## BuildingModels Class

Provides a Grasshopper component that filters building models based on their spatial proximity to a given point within a specified distance and tolerance\.

```csharp
public class BuildingModels : DiGi.Rhino.Core.Classes.VariableParameterComponent
```

Inheritance [Grasshopper\.Kernel\.GH\_Component](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_component 'Grasshopper\.Kernel\.GH\_Component') → [DiGi\.Rhino\.Core\.Classes\.Component](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.component 'DiGi\.Rhino\.Core\.Classes\.Component') → [Grasshopper\.Kernel\.IGH\_VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_variableparametercomponent 'Grasshopper\.Kernel\.IGH\_VariableParameterComponent') → [DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.variableparametercomponent 'DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent') → BuildingModels
### Constructors

<a name='DiGi.Analytical.Building.Rhino.Classes.BuildingModels.BuildingModels()'></a>

## BuildingModels\(\) Constructor

Initializes a new instance of the [BuildingModels](DiGi.Analytical.Building.Rhino.Classes.md#DiGi.Analytical.Building.Rhino.Classes.BuildingModels 'DiGi\.Analytical\.Building\.Rhino\.Classes\.BuildingModels') class with specified name, description, and category\.

```csharp
public BuildingModels();
```
### Properties

<a name='DiGi.Analytical.Building.Rhino.Classes.BuildingModels.ComponentGuid'></a>

## BuildingModels\.ComponentGuid Property

Gets the unique identifier for this component\. This ID must remain constant after release to ensure document compatibility\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Analytical.Building.Rhino.Classes.BuildingModels.Exposure'></a>

## BuildingModels\.Exposure Property

Gets the exposure level of the component, which determines its execution priority and visibility in the Grasshopper canvas\.

```csharp
public override GH_Exposure Exposure { get; }
```

#### Property Value
[Grasshopper\.Kernel\.GH\_Exposure](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_exposure 'Grasshopper\.Kernel\.GH\_Exposure')

<a name='DiGi.Analytical.Building.Rhino.Classes.BuildingModels.Inputs'></a>

## BuildingModels\.Inputs Property

Registers and configures the input parameters for the component, including building models, a reference point, distance, and an optional tolerance\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Inputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

<a name='DiGi.Analytical.Building.Rhino.Classes.BuildingModels.Outputs'></a>

## BuildingModels\.Outputs Property

Registers and configures the output parameters for the component, returning the filtered list of building models\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Outputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')
### Methods

<a name='DiGi.Analytical.Building.Rhino.Classes.BuildingModels.SolveInstance(IGH_DataAccess)'></a>

## BuildingModels\.SolveInstance\(IGH\_DataAccess\) Method

Performs the main computation of the component: retrieves input data, filters building models that are inside a sphere defined by the point and distance, and sets the output list\.

```csharp
protected override void SolveInstance(IGH_DataAccess dataAccess);
```
#### Parameters

<a name='DiGi.Analytical.Building.Rhino.Classes.BuildingModels.SolveInstance(IGH_DataAccess).dataAccess'></a>

`dataAccess` [Grasshopper\.Kernel\.IGH\_DataAccess](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_dataaccess 'Grasshopper\.Kernel\.IGH\_DataAccess')

The [Grasshopper\.Kernel\.IGH\_DataAccess](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_dataaccess 'Grasshopper\.Kernel\.IGH\_DataAccess') object used to retrieve values from inputs and store results in outputs\.

<a name='DiGi.Analytical.Building.Rhino.Classes.GooBuildingModel'></a>

## GooBuildingModel Class

Represents a Grasshopper Goo wrapper for the building model, enabling serialization and baking capabilities within the Rhino/Grasshopper environment\.

```csharp
public class GooBuildingModel : DiGi.Rhino.Geometry.Core.Classes.GooBakeAwareSerializableObject<DiGi.Analytical.Building.Classes.BuildingModel>
```

Inheritance [Grasshopper\.Kernel\.Types\.GH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_goo 'Grasshopper\.Kernel\.Types\.GH\_Goo') → [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') → [GH\_IO\.GH\_ISerializable](https://learn.microsoft.com/en-us/dotnet/api/gh_io.gh_iserializable 'GH\_IO\.GH\_ISerializable') → [DiGi\.Rhino\.Core\.Classes\.GooObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1')[DiGi\.Analytical\.Building\.Classes\.BuildingModel](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.classes.buildingmodel 'DiGi\.Analytical\.Building\.Classes\.BuildingModel')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1') → [DiGi\.Rhino\.Core\.Classes\.GooSerializableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1')[DiGi\.Analytical\.Building\.Classes\.BuildingModel](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.classes.buildingmodel 'DiGi\.Analytical\.Building\.Classes\.BuildingModel')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1') → [Grasshopper\.Kernel\.IGH\_PreviewData](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_previewdata 'Grasshopper\.Kernel\.IGH\_PreviewData') → [Grasshopper\.Kernel\.IGH\_BakeAwareData](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_bakeawaredata 'Grasshopper\.Kernel\.IGH\_BakeAwareData') → [DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.core.classes.goobakeawareserializableobject-1 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableObject\`1')[DiGi\.Analytical\.Building\.Classes\.BuildingModel](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.classes.buildingmodel 'DiGi\.Analytical\.Building\.Classes\.BuildingModel')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.core.classes.goobakeawareserializableobject-1 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableObject\`1') → GooBuildingModel
### Constructors

<a name='DiGi.Analytical.Building.Rhino.Classes.GooBuildingModel.GooBuildingModel()'></a>

## GooBuildingModel\(\) Constructor

Initializes a new instance of the [GooBuildingModel](DiGi.Analytical.Building.Rhino.Classes.md#DiGi.Analytical.Building.Rhino.Classes.GooBuildingModel 'DiGi\.Analytical\.Building\.Rhino\.Classes\.GooBuildingModel') class\.

```csharp
public GooBuildingModel();
```

<a name='DiGi.Analytical.Building.Rhino.Classes.GooBuildingModel.GooBuildingModel(DiGi.Analytical.Building.Classes.BuildingModel)'></a>

## GooBuildingModel\(BuildingModel\) Constructor

Initializes a new instance of the [GooBuildingModel](DiGi.Analytical.Building.Rhino.Classes.md#DiGi.Analytical.Building.Rhino.Classes.GooBuildingModel 'DiGi\.Analytical\.Building\.Rhino\.Classes\.GooBuildingModel') class with the specified building model\.

```csharp
public GooBuildingModel(DiGi.Analytical.Building.Classes.BuildingModel? buildingModel);
```
#### Parameters

<a name='DiGi.Analytical.Building.Rhino.Classes.GooBuildingModel.GooBuildingModel(DiGi.Analytical.Building.Classes.BuildingModel).buildingModel'></a>

`buildingModel` [DiGi\.Analytical\.Building\.Classes\.BuildingModel](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.classes.buildingmodel 'DiGi\.Analytical\.Building\.Classes\.BuildingModel')

The building model to be wrapped in the Goo object\.
### Properties

<a name='DiGi.Analytical.Building.Rhino.Classes.GooBuildingModel.Geometries'></a>

## GooBuildingModel\.Geometries Property

Gets the collection of geometries associated with the building model that can be baked into the Rhino document\.

```csharp
public override DiGi.Geometry.Core.Interfaces.IGeometry[]? Geometries { get; }
```

Implements [Geometries](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.core.interfaces.igoobakeawareserializableobject.geometries 'DiGi\.Rhino\.Geometry\.Core\.Interfaces\.IGooBakeAwareSerializableObject\.Geometries')

#### Property Value
[DiGi\.Geometry\.Core\.Interfaces\.IGeometry](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometry 'DiGi\.Geometry\.Core\.Interfaces\.IGeometry')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')  
An array of [DiGi\.Geometry\.Core\.Interfaces\.IGeometry](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.core.interfaces.igeometry 'DiGi\.Geometry\.Core\.Interfaces\.IGeometry') objects derived from the building model's components\.
### Methods

<a name='DiGi.Analytical.Building.Rhino.Classes.GooBuildingModel.Duplicate()'></a>

## GooBuildingModel\.Duplicate\(\) Method

Creates a duplicate of the current Goo object\.

```csharp
public override IGH_Goo Duplicate();
```

#### Returns
[Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo')  
A new [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') instance containing the same building model value\.

<a name='DiGi.Analytical.Building.Rhino.Classes.GooBuildingModelParam'></a>

## GooBuildingModelParam Class

Represents the Grasshopper parameter type used to handle and transport [GooBuildingModel](DiGi.Analytical.Building.Rhino.Classes.md#DiGi.Analytical.Building.Rhino.Classes.GooBuildingModel 'DiGi\.Analytical\.Building\.Rhino\.Classes\.GooBuildingModel') objects\.

```csharp
public class GooBuildingModelParam : DiGi.Rhino.Geometry.Core.Classes.GooBakeAwareSerializableParam<DiGi.Analytical.Building.Rhino.Classes.GooBuildingModel, DiGi.Analytical.Building.Classes.BuildingModel>
```

Inheritance [Grasshopper\.Kernel\.GH\_PersistentParam](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_persistentparam 'Grasshopper\.Kernel\.GH\_PersistentParam') → [DiGi\.Rhino\.Core\.Classes\.GooPresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[GooBuildingModel](DiGi.Analytical.Building.Rhino.Classes.md#DiGi.Analytical.Building.Rhino.Classes.GooBuildingModel 'DiGi\.Analytical\.Building\.Rhino\.Classes\.GooBuildingModel')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[DiGi\.Analytical\.Building\.Classes\.BuildingModel](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.classes.buildingmodel 'DiGi\.Analytical\.Building\.Classes\.BuildingModel')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2') → [DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2')[GooBuildingModel](DiGi.Analytical.Building.Rhino.Classes.md#DiGi.Analytical.Building.Rhino.Classes.GooBuildingModel 'DiGi\.Analytical\.Building\.Rhino\.Classes\.GooBuildingModel')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2')[DiGi\.Analytical\.Building\.Classes\.BuildingModel](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.classes.buildingmodel 'DiGi\.Analytical\.Building\.Classes\.BuildingModel')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializablepresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooSerializablePresistentParam\`2') → [Grasshopper\.Kernel\.IGH\_PreviewObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_previewobject 'Grasshopper\.Kernel\.IGH\_PreviewObject') → [Grasshopper\.Kernel\.IGH\_BakeAwareObject](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_bakeawareobject 'Grasshopper\.Kernel\.IGH\_BakeAwareObject') → [DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.core.classes.goobakeawareserializableparam-2 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableParam\`2')[GooBuildingModel](DiGi.Analytical.Building.Rhino.Classes.md#DiGi.Analytical.Building.Rhino.Classes.GooBuildingModel 'DiGi\.Analytical\.Building\.Rhino\.Classes\.GooBuildingModel')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.core.classes.goobakeawareserializableparam-2 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableParam\`2')[DiGi\.Analytical\.Building\.Classes\.BuildingModel](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.classes.buildingmodel 'DiGi\.Analytical\.Building\.Classes\.BuildingModel')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.core.classes.goobakeawareserializableparam-2 'DiGi\.Rhino\.Geometry\.Core\.Classes\.GooBakeAwareSerializableParam\`2') → GooBuildingModelParam
### Properties

<a name='DiGi.Analytical.Building.Rhino.Classes.GooBuildingModelParam.ComponentGuid'></a>

## GooBuildingModelParam\.ComponentGuid Property

Gets the unique identifier for the building model parameter component\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')  
The [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid') associated with this parameter type\.

<a name='DiGi.Analytical.Building.Rhino.Classes.GooComponent'></a>

## GooComponent Class

Represents a serializable wrapper for an [DiGi\.Analytical\.Building\.Interfaces\.IComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.icomponent 'DiGi\.Analytical\.Building\.Interfaces\.IComponent') object, 
enabling its integration and persistence within the Grasshopper Goo system\.

```csharp
public class GooComponent : DiGi.Rhino.Core.Classes.GooSerializableObject<DiGi.Analytical.Building.Interfaces.IComponent>
```

Inheritance [Grasshopper\.Kernel\.Types\.GH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_goo 'Grasshopper\.Kernel\.Types\.GH\_Goo') → [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') → [GH\_IO\.GH\_ISerializable](https://learn.microsoft.com/en-us/dotnet/api/gh_io.gh_iserializable 'GH\_IO\.GH\_ISerializable') → [DiGi\.Rhino\.Core\.Classes\.GooObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1')[DiGi\.Analytical\.Building\.Interfaces\.IComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.icomponent 'DiGi\.Analytical\.Building\.Interfaces\.IComponent')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1') → [DiGi\.Rhino\.Core\.Classes\.GooSerializableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1')[DiGi\.Analytical\.Building\.Interfaces\.IComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.icomponent 'DiGi\.Analytical\.Building\.Interfaces\.IComponent')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1') → GooComponent
### Constructors

<a name='DiGi.Analytical.Building.Rhino.Classes.GooComponent.GooComponent()'></a>

## GooComponent\(\) Constructor

Initializes a new instance of the [GooComponent](DiGi.Analytical.Building.Rhino.Classes.md#DiGi.Analytical.Building.Rhino.Classes.GooComponent 'DiGi\.Analytical\.Building\.Rhino\.Classes\.GooComponent') class\.

```csharp
public GooComponent();
```

<a name='DiGi.Analytical.Building.Rhino.Classes.GooComponent.GooComponent(DiGi.Analytical.Building.Interfaces.IComponent)'></a>

## GooComponent\(IComponent\) Constructor

Initializes a new instance of the [GooComponent](DiGi.Analytical.Building.Rhino.Classes.md#DiGi.Analytical.Building.Rhino.Classes.GooComponent 'DiGi\.Analytical\.Building\.Rhino\.Classes\.GooComponent') class with the specified component value\.

```csharp
public GooComponent(DiGi.Analytical.Building.Interfaces.IComponent? component);
```
#### Parameters

<a name='DiGi.Analytical.Building.Rhino.Classes.GooComponent.GooComponent(DiGi.Analytical.Building.Interfaces.IComponent).component'></a>

`component` [DiGi\.Analytical\.Building\.Interfaces\.IComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.icomponent 'DiGi\.Analytical\.Building\.Interfaces\.IComponent')

The [DiGi\.Analytical\.Building\.Interfaces\.IComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.icomponent 'DiGi\.Analytical\.Building\.Interfaces\.IComponent') instance to wrap\.
### Methods

<a name='DiGi.Analytical.Building.Rhino.Classes.GooComponent.Duplicate()'></a>

## GooComponent\.Duplicate\(\) Method

Creates a duplicate of the current [GooComponent](DiGi.Analytical.Building.Rhino.Classes.md#DiGi.Analytical.Building.Rhino.Classes.GooComponent 'DiGi\.Analytical\.Building\.Rhino\.Classes\.GooComponent') instance\.

```csharp
public override IGH_Goo Duplicate();
```

#### Returns
[Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo')  
A new [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') object containing the same value as the original\.

<a name='DiGi.Analytical.Building.Rhino.Classes.GooComponentParam'></a>

## GooComponentParam Class

Provides a persistent Grasshopper parameter implementation for handling [GooComponent](DiGi.Analytical.Building.Rhino.Classes.md#DiGi.Analytical.Building.Rhino.Classes.GooComponent 'DiGi\.Analytical\.Building\.Rhino\.Classes\.GooComponent') data\.

```csharp
public class GooComponentParam : DiGi.Rhino.Core.Classes.GooPresistentParam<DiGi.Analytical.Building.Rhino.Classes.GooComponent, DiGi.Analytical.Building.Interfaces.IComponent>
```

Inheritance [Grasshopper\.Kernel\.GH\_PersistentParam](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_persistentparam 'Grasshopper\.Kernel\.GH\_PersistentParam') → [DiGi\.Rhino\.Core\.Classes\.GooPresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[GooComponent](DiGi.Analytical.Building.Rhino.Classes.md#DiGi.Analytical.Building.Rhino.Classes.GooComponent 'DiGi\.Analytical\.Building\.Rhino\.Classes\.GooComponent')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[DiGi\.Analytical\.Building\.Interfaces\.IComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.icomponent 'DiGi\.Analytical\.Building\.Interfaces\.IComponent')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2') → GooComponentParam
### Constructors

<a name='DiGi.Analytical.Building.Rhino.Classes.GooComponentParam.GooComponentParam()'></a>

## GooComponentParam\(\) Constructor

Initializes a new instance of the [GooComponentParam](DiGi.Analytical.Building.Rhino.Classes.md#DiGi.Analytical.Building.Rhino.Classes.GooComponentParam 'DiGi\.Analytical\.Building\.Rhino\.Classes\.GooComponentParam') class\.

```csharp
public GooComponentParam();
```
### Properties

<a name='DiGi.Analytical.Building.Rhino.Classes.GooComponentParam.ComponentGuid'></a>

## GooComponentParam\.ComponentGuid Property

Gets the unique identifier associated with this component parameter type\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Analytical.Building.Rhino.Classes.GooFloor'></a>

## GooFloor Class

Represents a serializable wrapper for an [DiGi\.Analytical\.Building\.Interfaces\.IFloor](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ifloor 'DiGi\.Analytical\.Building\.Interfaces\.IFloor') object, 
enabling its integration and persistence within the Grasshopper environment\.

```csharp
public class GooFloor : DiGi.Rhino.Core.Classes.GooSerializableObject<DiGi.Analytical.Building.Interfaces.IFloor>
```

Inheritance [Grasshopper\.Kernel\.Types\.GH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_goo 'Grasshopper\.Kernel\.Types\.GH\_Goo') → [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') → [GH\_IO\.GH\_ISerializable](https://learn.microsoft.com/en-us/dotnet/api/gh_io.gh_iserializable 'GH\_IO\.GH\_ISerializable') → [DiGi\.Rhino\.Core\.Classes\.GooObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1')[DiGi\.Analytical\.Building\.Interfaces\.IFloor](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ifloor 'DiGi\.Analytical\.Building\.Interfaces\.IFloor')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1') → [DiGi\.Rhino\.Core\.Classes\.GooSerializableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1')[DiGi\.Analytical\.Building\.Interfaces\.IFloor](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ifloor 'DiGi\.Analytical\.Building\.Interfaces\.IFloor')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1') → GooFloor
### Constructors

<a name='DiGi.Analytical.Building.Rhino.Classes.GooFloor.GooFloor()'></a>

## GooFloor\(\) Constructor

Initializes a new instance of the [GooFloor](DiGi.Analytical.Building.Rhino.Classes.md#DiGi.Analytical.Building.Rhino.Classes.GooFloor 'DiGi\.Analytical\.Building\.Rhino\.Classes\.GooFloor') class\.

```csharp
public GooFloor();
```

<a name='DiGi.Analytical.Building.Rhino.Classes.GooFloor.GooFloor(DiGi.Analytical.Building.Interfaces.IFloor)'></a>

## GooFloor\(IFloor\) Constructor

Initializes a new instance of the [GooFloor](DiGi.Analytical.Building.Rhino.Classes.md#DiGi.Analytical.Building.Rhino.Classes.GooFloor 'DiGi\.Analytical\.Building\.Rhino\.Classes\.GooFloor') class with the specified floor value\.

```csharp
public GooFloor(DiGi.Analytical.Building.Interfaces.IFloor? floor);
```
#### Parameters

<a name='DiGi.Analytical.Building.Rhino.Classes.GooFloor.GooFloor(DiGi.Analytical.Building.Interfaces.IFloor).floor'></a>

`floor` [DiGi\.Analytical\.Building\.Interfaces\.IFloor](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ifloor 'DiGi\.Analytical\.Building\.Interfaces\.IFloor')

The [DiGi\.Analytical\.Building\.Interfaces\.IFloor](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ifloor 'DiGi\.Analytical\.Building\.Interfaces\.IFloor') instance to wrap\.
### Methods

<a name='DiGi.Analytical.Building.Rhino.Classes.GooFloor.Duplicate()'></a>

## GooFloor\.Duplicate\(\) Method

Creates a duplicate of the current [GooFloor](DiGi.Analytical.Building.Rhino.Classes.md#DiGi.Analytical.Building.Rhino.Classes.GooFloor 'DiGi\.Analytical\.Building\.Rhino\.Classes\.GooFloor') object\.

```csharp
public override IGH_Goo Duplicate();
```

#### Returns
[Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo')  
A new [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') instance containing a copy of the original value\.

<a name='DiGi.Analytical.Building.Rhino.Classes.GooFloorParam'></a>

## GooFloorParam Class

Represents the Grasshopper parameter component used to manage and transfer 
[GooFloor](DiGi.Analytical.Building.Rhino.Classes.md#DiGi.Analytical.Building.Rhino.Classes.GooFloor 'DiGi\.Analytical\.Building\.Rhino\.Classes\.GooFloor') objects\.

```csharp
public class GooFloorParam : DiGi.Rhino.Core.Classes.GooPresistentParam<DiGi.Analytical.Building.Rhino.Classes.GooFloor, DiGi.Analytical.Building.Interfaces.IFloor>
```

Inheritance [Grasshopper\.Kernel\.GH\_PersistentParam](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_persistentparam 'Grasshopper\.Kernel\.GH\_PersistentParam') → [DiGi\.Rhino\.Core\.Classes\.GooPresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[GooFloor](DiGi.Analytical.Building.Rhino.Classes.md#DiGi.Analytical.Building.Rhino.Classes.GooFloor 'DiGi\.Analytical\.Building\.Rhino\.Classes\.GooFloor')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[DiGi\.Analytical\.Building\.Interfaces\.IFloor](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ifloor 'DiGi\.Analytical\.Building\.Interfaces\.IFloor')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2') → GooFloorParam
### Constructors

<a name='DiGi.Analytical.Building.Rhino.Classes.GooFloorParam.GooFloorParam()'></a>

## GooFloorParam\(\) Constructor

Initializes a new instance of the [GooFloorParam](DiGi.Analytical.Building.Rhino.Classes.md#DiGi.Analytical.Building.Rhino.Classes.GooFloorParam 'DiGi\.Analytical\.Building\.Rhino\.Classes\.GooFloorParam') class\.

```csharp
public GooFloorParam();
```
### Properties

<a name='DiGi.Analytical.Building.Rhino.Classes.GooFloorParam.ComponentGuid'></a>

## GooFloorParam\.ComponentGuid Property

Gets the unique identifier for the [GooFloorParam](DiGi.Analytical.Building.Rhino.Classes.md#DiGi.Analytical.Building.Rhino.Classes.GooFloorParam 'DiGi\.Analytical\.Building\.Rhino\.Classes\.GooFloorParam') component\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Analytical.Building.Rhino.Classes.GooRoof'></a>

## GooRoof Class

Represents a serializable Goo wrapper for roof objects, enabling them to be passed through Grasshopper components\.

```csharp
public class GooRoof : DiGi.Rhino.Core.Classes.GooSerializableObject<DiGi.Analytical.Building.Interfaces.IRoof>
```

Inheritance [Grasshopper\.Kernel\.Types\.GH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_goo 'Grasshopper\.Kernel\.Types\.GH\_Goo') → [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') → [GH\_IO\.GH\_ISerializable](https://learn.microsoft.com/en-us/dotnet/api/gh_io.gh_iserializable 'GH\_IO\.GH\_ISerializable') → [DiGi\.Rhino\.Core\.Classes\.GooObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1')[DiGi\.Analytical\.Building\.Interfaces\.IRoof](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iroof 'DiGi\.Analytical\.Building\.Interfaces\.IRoof')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1') → [DiGi\.Rhino\.Core\.Classes\.GooSerializableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1')[DiGi\.Analytical\.Building\.Interfaces\.IRoof](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iroof 'DiGi\.Analytical\.Building\.Interfaces\.IRoof')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1') → GooRoof
### Constructors

<a name='DiGi.Analytical.Building.Rhino.Classes.GooRoof.GooRoof()'></a>

## GooRoof\(\) Constructor

Initializes a new instance of the [GooRoof](DiGi.Analytical.Building.Rhino.Classes.md#DiGi.Analytical.Building.Rhino.Classes.GooRoof 'DiGi\.Analytical\.Building\.Rhino\.Classes\.GooRoof') class\.

```csharp
public GooRoof();
```

<a name='DiGi.Analytical.Building.Rhino.Classes.GooRoof.GooRoof(DiGi.Analytical.Building.Interfaces.IRoof)'></a>

## GooRoof\(IRoof\) Constructor

Initializes a new instance of the [GooRoof](DiGi.Analytical.Building.Rhino.Classes.md#DiGi.Analytical.Building.Rhino.Classes.GooRoof 'DiGi\.Analytical\.Building\.Rhino\.Classes\.GooRoof') class with a specified roof value\.

```csharp
public GooRoof(DiGi.Analytical.Building.Interfaces.IRoof? roof);
```
#### Parameters

<a name='DiGi.Analytical.Building.Rhino.Classes.GooRoof.GooRoof(DiGi.Analytical.Building.Interfaces.IRoof).roof'></a>

`roof` [DiGi\.Analytical\.Building\.Interfaces\.IRoof](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iroof 'DiGi\.Analytical\.Building\.Interfaces\.IRoof')

The roof object to wrap\.
### Methods

<a name='DiGi.Analytical.Building.Rhino.Classes.GooRoof.Duplicate()'></a>

## GooRoof\.Duplicate\(\) Method

Creates a duplicate of the current [GooRoof](DiGi.Analytical.Building.Rhino.Classes.md#DiGi.Analytical.Building.Rhino.Classes.GooRoof 'DiGi\.Analytical\.Building\.Rhino\.Classes\.GooRoof') instance\.

```csharp
public override IGH_Goo Duplicate();
```

#### Returns
[Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo')  
A new [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') object containing a copy of the original value\.

<a name='DiGi.Analytical.Building.Rhino.Classes.GooRoofParam'></a>

## GooRoofParam Class

The Grasshopper parameter component used to hold and manage [GooRoof](DiGi.Analytical.Building.Rhino.Classes.md#DiGi.Analytical.Building.Rhino.Classes.GooRoof 'DiGi\.Analytical\.Building\.Rhino\.Classes\.GooRoof') objects\.

```csharp
public class GooRoofParam : DiGi.Rhino.Core.Classes.GooPresistentParam<DiGi.Analytical.Building.Rhino.Classes.GooRoof, DiGi.Analytical.Building.Interfaces.IRoof>
```

Inheritance [Grasshopper\.Kernel\.GH\_PersistentParam](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_persistentparam 'Grasshopper\.Kernel\.GH\_PersistentParam') → [DiGi\.Rhino\.Core\.Classes\.GooPresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[GooRoof](DiGi.Analytical.Building.Rhino.Classes.md#DiGi.Analytical.Building.Rhino.Classes.GooRoof 'DiGi\.Analytical\.Building\.Rhino\.Classes\.GooRoof')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[DiGi\.Analytical\.Building\.Interfaces\.IRoof](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iroof 'DiGi\.Analytical\.Building\.Interfaces\.IRoof')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2') → GooRoofParam
### Constructors

<a name='DiGi.Analytical.Building.Rhino.Classes.GooRoofParam.GooRoofParam()'></a>

## GooRoofParam\(\) Constructor

Initializes a new instance of the [GooRoofParam](DiGi.Analytical.Building.Rhino.Classes.md#DiGi.Analytical.Building.Rhino.Classes.GooRoofParam 'DiGi\.Analytical\.Building\.Rhino\.Classes\.GooRoofParam') class\.

```csharp
public GooRoofParam();
```
### Properties

<a name='DiGi.Analytical.Building.Rhino.Classes.GooRoofParam.ComponentGuid'></a>

## GooRoofParam\.ComponentGuid Property

Gets the unique identifier for the [GooRoofParam](DiGi.Analytical.Building.Rhino.Classes.md#DiGi.Analytical.Building.Rhino.Classes.GooRoofParam 'DiGi\.Analytical\.Building\.Rhino\.Classes\.GooRoofParam') component\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Analytical.Building.Rhino.Classes.GooSpace'></a>

## GooSpace Class

Represents a Grasshopper Goo wrapper for an [DiGi\.Analytical\.Building\.Interfaces\.ISpace](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ispace 'DiGi\.Analytical\.Building\.Interfaces\.ISpace') object, 
enabling its serialization and transport within the Grasshopper environment\.

```csharp
public class GooSpace : DiGi.Rhino.Core.Classes.GooSerializableObject<DiGi.Analytical.Building.Interfaces.ISpace>
```

Inheritance [Grasshopper\.Kernel\.Types\.GH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_goo 'Grasshopper\.Kernel\.Types\.GH\_Goo') → [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') → [GH\_IO\.GH\_ISerializable](https://learn.microsoft.com/en-us/dotnet/api/gh_io.gh_iserializable 'GH\_IO\.GH\_ISerializable') → [DiGi\.Rhino\.Core\.Classes\.GooObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1')[DiGi\.Analytical\.Building\.Interfaces\.ISpace](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ispace 'DiGi\.Analytical\.Building\.Interfaces\.ISpace')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1') → [DiGi\.Rhino\.Core\.Classes\.GooSerializableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1')[DiGi\.Analytical\.Building\.Interfaces\.ISpace](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ispace 'DiGi\.Analytical\.Building\.Interfaces\.ISpace')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1') → GooSpace
### Constructors

<a name='DiGi.Analytical.Building.Rhino.Classes.GooSpace.GooSpace()'></a>

## GooSpace\(\) Constructor

Initializes a new instance of the [GooSpace](DiGi.Analytical.Building.Rhino.Classes.md#DiGi.Analytical.Building.Rhino.Classes.GooSpace 'DiGi\.Analytical\.Building\.Rhino\.Classes\.GooSpace') class\.

```csharp
public GooSpace();
```

<a name='DiGi.Analytical.Building.Rhino.Classes.GooSpace.GooSpace(DiGi.Analytical.Building.Interfaces.ISpace)'></a>

## GooSpace\(ISpace\) Constructor

Initializes a new instance of the [GooSpace](DiGi.Analytical.Building.Rhino.Classes.md#DiGi.Analytical.Building.Rhino.Classes.GooSpace 'DiGi\.Analytical\.Building\.Rhino\.Classes\.GooSpace') class with the specified space object\.

```csharp
public GooSpace(DiGi.Analytical.Building.Interfaces.ISpace? space);
```
#### Parameters

<a name='DiGi.Analytical.Building.Rhino.Classes.GooSpace.GooSpace(DiGi.Analytical.Building.Interfaces.ISpace).space'></a>

`space` [DiGi\.Analytical\.Building\.Interfaces\.ISpace](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ispace 'DiGi\.Analytical\.Building\.Interfaces\.ISpace')

The [DiGi\.Analytical\.Building\.Interfaces\.ISpace](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ispace 'DiGi\.Analytical\.Building\.Interfaces\.ISpace') instance to be wrapped\.
### Methods

<a name='DiGi.Analytical.Building.Rhino.Classes.GooSpace.Duplicate()'></a>

## GooSpace\.Duplicate\(\) Method

Creates a duplicate of the current Goo object\.

```csharp
public override IGH_Goo Duplicate();
```

#### Returns
[Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo')  
A new [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') instance containing a copy of the original value\.

<a name='DiGi.Analytical.Building.Rhino.Classes.GooSpaceParam'></a>

## GooSpaceParam Class

Represents the Grasshopper parameter component used to manage and display 
[GooSpace](DiGi.Analytical.Building.Rhino.Classes.md#DiGi.Analytical.Building.Rhino.Classes.GooSpace 'DiGi\.Analytical\.Building\.Rhino\.Classes\.GooSpace') objects on the canvas\.

```csharp
public class GooSpaceParam : DiGi.Rhino.Core.Classes.GooPresistentParam<DiGi.Analytical.Building.Rhino.Classes.GooSpace, DiGi.Analytical.Building.Interfaces.ISpace>
```

Inheritance [Grasshopper\.Kernel\.GH\_PersistentParam](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_persistentparam 'Grasshopper\.Kernel\.GH\_PersistentParam') → [DiGi\.Rhino\.Core\.Classes\.GooPresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[GooSpace](DiGi.Analytical.Building.Rhino.Classes.md#DiGi.Analytical.Building.Rhino.Classes.GooSpace 'DiGi\.Analytical\.Building\.Rhino\.Classes\.GooSpace')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[DiGi\.Analytical\.Building\.Interfaces\.ISpace](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ispace 'DiGi\.Analytical\.Building\.Interfaces\.ISpace')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2') → GooSpaceParam
### Constructors

<a name='DiGi.Analytical.Building.Rhino.Classes.GooSpaceParam.GooSpaceParam()'></a>

## GooSpaceParam\(\) Constructor

Initializes a new instance of the [GooSpaceParam](DiGi.Analytical.Building.Rhino.Classes.md#DiGi.Analytical.Building.Rhino.Classes.GooSpaceParam 'DiGi\.Analytical\.Building\.Rhino\.Classes\.GooSpaceParam') class\.

```csharp
public GooSpaceParam();
```
### Properties

<a name='DiGi.Analytical.Building.Rhino.Classes.GooSpaceParam.ComponentGuid'></a>

## GooSpaceParam\.ComponentGuid Property

Gets the unique identifier for the [GooSpaceParam](DiGi.Analytical.Building.Rhino.Classes.md#DiGi.Analytical.Building.Rhino.Classes.GooSpaceParam 'DiGi\.Analytical\.Building\.Rhino\.Classes\.GooSpaceParam') component\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Analytical.Building.Rhino.Classes.GooWall'></a>

## GooWall Class

Represents a serializable wrapper for an [DiGi\.Analytical\.Building\.Interfaces\.IWall](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iwall 'DiGi\.Analytical\.Building\.Interfaces\.IWall') object, 
enabling its integration and persistence within the Grasshopper environment\.

```csharp
public class GooWall : DiGi.Rhino.Core.Classes.GooSerializableObject<DiGi.Analytical.Building.Interfaces.IWall>
```

Inheritance [Grasshopper\.Kernel\.Types\.GH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_goo 'Grasshopper\.Kernel\.Types\.GH\_Goo') → [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') → [GH\_IO\.GH\_ISerializable](https://learn.microsoft.com/en-us/dotnet/api/gh_io.gh_iserializable 'GH\_IO\.GH\_ISerializable') → [DiGi\.Rhino\.Core\.Classes\.GooObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1')[DiGi\.Analytical\.Building\.Interfaces\.IWall](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iwall 'DiGi\.Analytical\.Building\.Interfaces\.IWall')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooobject-1 'DiGi\.Rhino\.Core\.Classes\.GooObject\`1') → [DiGi\.Rhino\.Core\.Classes\.GooSerializableObject&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1')[DiGi\.Analytical\.Building\.Interfaces\.IWall](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iwall 'DiGi\.Analytical\.Building\.Interfaces\.IWall')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.gooserializableobject-1 'DiGi\.Rhino\.Core\.Classes\.GooSerializableObject\`1') → GooWall
### Constructors

<a name='DiGi.Analytical.Building.Rhino.Classes.GooWall.GooWall()'></a>

## GooWall\(\) Constructor

Initializes a new instance of the [GooWall](DiGi.Analytical.Building.Rhino.Classes.md#DiGi.Analytical.Building.Rhino.Classes.GooWall 'DiGi\.Analytical\.Building\.Rhino\.Classes\.GooWall') class\.

```csharp
public GooWall();
```

<a name='DiGi.Analytical.Building.Rhino.Classes.GooWall.GooWall(DiGi.Analytical.Building.Interfaces.IWall)'></a>

## GooWall\(IWall\) Constructor

Initializes a new instance of the [GooWall](DiGi.Analytical.Building.Rhino.Classes.md#DiGi.Analytical.Building.Rhino.Classes.GooWall 'DiGi\.Analytical\.Building\.Rhino\.Classes\.GooWall') class with the specified wall value\.

```csharp
public GooWall(DiGi.Analytical.Building.Interfaces.IWall? wall);
```
#### Parameters

<a name='DiGi.Analytical.Building.Rhino.Classes.GooWall.GooWall(DiGi.Analytical.Building.Interfaces.IWall).wall'></a>

`wall` [DiGi\.Analytical\.Building\.Interfaces\.IWall](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iwall 'DiGi\.Analytical\.Building\.Interfaces\.IWall')

The [DiGi\.Analytical\.Building\.Interfaces\.IWall](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iwall 'DiGi\.Analytical\.Building\.Interfaces\.IWall') object to wrap\.
### Methods

<a name='DiGi.Analytical.Building.Rhino.Classes.GooWall.Duplicate()'></a>

## GooWall\.Duplicate\(\) Method

Creates a duplicate of the current [GooWall](DiGi.Analytical.Building.Rhino.Classes.md#DiGi.Analytical.Building.Rhino.Classes.GooWall 'DiGi\.Analytical\.Building\.Rhino\.Classes\.GooWall') instance\.

```csharp
public override IGH_Goo Duplicate();
```

#### Returns
[Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo')  
A new [Grasshopper\.Kernel\.Types\.IGH\_Goo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.igh_goo 'Grasshopper\.Kernel\.Types\.IGH\_Goo') object containing a copy of the original value\.

<a name='DiGi.Analytical.Building.Rhino.Classes.GooWallParam'></a>

## GooWallParam Class

Provides a Grasshopper parameter type for handling and persisting 
[DiGi\.Analytical\.Building\.Interfaces\.IWall](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iwall 'DiGi\.Analytical\.Building\.Interfaces\.IWall') objects using the [GooWall](DiGi.Analytical.Building.Rhino.Classes.md#DiGi.Analytical.Building.Rhino.Classes.GooWall 'DiGi\.Analytical\.Building\.Rhino\.Classes\.GooWall') wrapper\.

```csharp
public class GooWallParam : DiGi.Rhino.Core.Classes.GooPresistentParam<DiGi.Analytical.Building.Rhino.Classes.GooWall, DiGi.Analytical.Building.Interfaces.IWall>
```

Inheritance [Grasshopper\.Kernel\.GH\_PersistentParam](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_persistentparam 'Grasshopper\.Kernel\.GH\_PersistentParam') → [DiGi\.Rhino\.Core\.Classes\.GooPresistentParam&lt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[GooWall](DiGi.Analytical.Building.Rhino.Classes.md#DiGi.Analytical.Building.Rhino.Classes.GooWall 'DiGi\.Analytical\.Building\.Rhino\.Classes\.GooWall')[,](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2')[DiGi\.Analytical\.Building\.Interfaces\.IWall](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.iwall 'DiGi\.Analytical\.Building\.Interfaces\.IWall')[&gt;](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.goopresistentparam-2 'DiGi\.Rhino\.Core\.Classes\.GooPresistentParam\`2') → GooWallParam
### Constructors

<a name='DiGi.Analytical.Building.Rhino.Classes.GooWallParam.GooWallParam()'></a>

## GooWallParam\(\) Constructor

Initializes a new instance of the [GooWallParam](DiGi.Analytical.Building.Rhino.Classes.md#DiGi.Analytical.Building.Rhino.Classes.GooWallParam 'DiGi\.Analytical\.Building\.Rhino\.Classes\.GooWallParam') class\.

```csharp
public GooWallParam();
```
### Properties

<a name='DiGi.Analytical.Building.Rhino.Classes.GooWallParam.ComponentGuid'></a>

## GooWallParam\.ComponentGuid Property

Gets the unique identifier for the wall parameter component\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Analytical.Building.Rhino.Classes.RhinoInfo'></a>

## RhinoInfo Class

Provides assembly information for the DiGi Analytical Building Rhino plugin\.
This class is used by Grasshopper to identify the library and display metadata within the Rhino environment\.

```csharp
public class RhinoInfo
```

Inheritance [Grasshopper\.Kernel\.GH\_AssemblyInfo](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_assemblyinfo 'Grasshopper\.Kernel\.GH\_AssemblyInfo') → RhinoInfo
### Properties

<a name='DiGi.Analytical.Building.Rhino.Classes.RhinoInfo.AuthorContact'></a>

## RhinoInfo\.AuthorContact Property

Gets the preferred contact details for the author of this library\.

```csharp
public override string AuthorContact { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The email address "jakubziolkowski@digiproject\.uk"\.

<a name='DiGi.Analytical.Building.Rhino.Classes.RhinoInfo.AuthorName'></a>

## RhinoInfo\.AuthorName Property

Gets the name of the individual or company responsible for creating this library\.

```csharp
public override string AuthorName { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The string "Jakub Ziolkowski"\.

<a name='DiGi.Analytical.Building.Rhino.Classes.RhinoInfo.Description'></a>

## RhinoInfo\.Description Property

Gets a short string describing the purpose and functionality of this GHA library\.

```csharp
public override string Description { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
An empty string\.

<a name='DiGi.Analytical.Building.Rhino.Classes.RhinoInfo.Icon'></a>

## RhinoInfo\.Icon Property

Gets a 24x24 pixel bitmap to represent this GHA library in the Grasshopper UI\.

```csharp
public override System.Drawing.Bitmap? Icon { get; }
```

#### Property Value
[System\.Drawing\.Bitmap](https://learn.microsoft.com/en-us/dotnet/api/system.drawing.bitmap 'System\.Drawing\.Bitmap')  
Returns [null](https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/null 'https://docs\.microsoft\.com/en\-us/dotnet/csharp/language\-reference/keywords/null') as no icon is currently provided\.

<a name='DiGi.Analytical.Building.Rhino.Classes.RhinoInfo.Id'></a>

## RhinoInfo\.Id Property

Gets the unique identifier \(GUID\) for this assembly\.

```csharp
public override System.Guid Id { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')  
A [System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid') with value "886667e5\-8cdc\-4cd7\-9718\-de3ec0d324e0"\.

<a name='DiGi.Analytical.Building.Rhino.Classes.RhinoInfo.Name'></a>

## RhinoInfo\.Name Property

Gets the name of the GHA library as it will be displayed in the Grasshopper interface\.

```csharp
public override string Name { get; }
```

#### Property Value
[System\.String](https://learn.microsoft.com/en-us/dotnet/api/system.string 'System\.String')  
The string "DiGi\.Analytical\.Building\.Rhino"\.

<a name='DiGi.Analytical.Building.Rhino.Classes.Space'></a>

## Space Class

Represents a Grasshopper component that creates an analytical space based on a name and a spatial point\.

```csharp
public class Space : DiGi.Rhino.Core.Classes.VariableParameterComponent
```

Inheritance [Grasshopper\.Kernel\.GH\_Component](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_component 'Grasshopper\.Kernel\.GH\_Component') → [DiGi\.Rhino\.Core\.Classes\.Component](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.component 'DiGi\.Rhino\.Core\.Classes\.Component') → [Grasshopper\.Kernel\.IGH\_VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_variableparametercomponent 'Grasshopper\.Kernel\.IGH\_VariableParameterComponent') → [DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.variableparametercomponent 'DiGi\.Rhino\.Core\.Classes\.VariableParameterComponent') → Space
### Constructors

<a name='DiGi.Analytical.Building.Rhino.Classes.Space.Space()'></a>

## Space\(\) Constructor

Initializes a new instance of the [Space](DiGi.Analytical.Building.Rhino.Classes.md#DiGi.Analytical.Building.Rhino.Classes.Space 'DiGi\.Analytical\.Building\.Rhino\.Classes\.Space') class\.

```csharp
public Space();
```
### Properties

<a name='DiGi.Analytical.Building.Rhino.Classes.Space.ComponentGuid'></a>

## Space\.ComponentGuid Property

Gets the unique ID for this component\. Do not change this ID after release\.

```csharp
public override System.Guid ComponentGuid { get; }
```

#### Property Value
[System\.Guid](https://learn.microsoft.com/en-us/dotnet/api/system.guid 'System\.Guid')

<a name='DiGi.Analytical.Building.Rhino.Classes.Space.Exposure'></a>

## Space\.Exposure Property

Gets the exposure level of the component, determining how it handles data flow\.

```csharp
public override GH_Exposure Exposure { get; }
```

#### Property Value
[Grasshopper\.Kernel\.GH\_Exposure](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.gh_exposure 'Grasshopper\.Kernel\.GH\_Exposure')

<a name='DiGi.Analytical.Building.Rhino.Classes.Space.Inputs'></a>

## Space\.Inputs Property

Registers all the input parameters for this component, including Name and Point\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Inputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')

<a name='DiGi.Analytical.Building.Rhino.Classes.Space.Outputs'></a>

## Space\.Outputs Property

Registers all the output parameters for this component, providing the resulting analytical space\.

```csharp
protected override DiGi.Rhino.Core.Classes.Param[] Outputs { protected get; }
```

#### Property Value
[DiGi\.Rhino\.Core\.Classes\.Param](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.core.classes.param 'DiGi\.Rhino\.Core\.Classes\.Param')[\[\]](https://learn.microsoft.com/en-us/dotnet/api/system.array 'System\.Array')
### Methods

<a name='DiGi.Analytical.Building.Rhino.Classes.Space.SolveInstance(IGH_DataAccess)'></a>

## Space\.SolveInstance\(IGH\_DataAccess\) Method

This is the method that actually does the work\. It retrieves input data, instantiates a building space, and sets the output\.

```csharp
protected override void SolveInstance(IGH_DataAccess dataAccess);
```
#### Parameters

<a name='DiGi.Analytical.Building.Rhino.Classes.Space.SolveInstance(IGH_DataAccess).dataAccess'></a>

`dataAccess` [Grasshopper\.Kernel\.IGH\_DataAccess](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.igh_dataaccess 'Grasshopper\.Kernel\.IGH\_DataAccess')

The DA object used to retrieve from inputs and store in outputs\.