#### [DiGi\.Analytical\.Building\.Rhino](DiGi.Analytical.Building.Rhino.Overview.md 'DiGi\.Analytical\.Building\.Rhino\.Overview')

## DiGi\.Analytical\.Rhino Namespace
### Classes

<a name='DiGi.Analytical.Rhino.Inspect'></a>

## Inspect Class

```csharp
public static class Inspect
```

Inheritance [System\.Object](https://learn.microsoft.com/en-us/dotnet/api/system.object 'System\.Object') → Inspect
### Methods

<a name='DiGi.Analytical.Rhino.Inspect.Components(thisDiGi.Analytical.Building.Classes.BuildingModel)'></a>

## Inspect\.Components\(this BuildingModel\) Method

Retrieves all components associated with the specified building model, 
wrapped as a collection of [GooComponent](DiGi.Analytical.Building.Rhino.Classes.md#DiGi.Analytical.Building.Rhino.Classes.GooComponent 'DiGi\.Analytical\.Building\.Rhino\.Classes\.GooComponent')\.

```csharp
public static System.Collections.IEnumerable? Components(this DiGi.Analytical.Building.Classes.BuildingModel buildingModel);
```
#### Parameters

<a name='DiGi.Analytical.Rhino.Inspect.Components(thisDiGi.Analytical.Building.Classes.BuildingModel).buildingModel'></a>

`buildingModel` [DiGi\.Analytical\.Building\.Classes\.BuildingModel](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.classes.buildingmodel 'DiGi\.Analytical\.Building\.Classes\.BuildingModel')

The building model instance to inspect\.

#### Returns
[System\.Collections\.IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable 'System\.Collections\.IEnumerable')  
An enumerable collection of [GooComponent](DiGi.Analytical.Building.Rhino.Classes.md#DiGi.Analytical.Building.Rhino.Classes.GooComponent 'DiGi\.Analytical\.Building\.Rhino\.Classes\.GooComponent') objects, or `null` if the [buildingModel](DiGi.Analytical.Rhino.md#DiGi.Analytical.Rhino.Inspect.Components(thisDiGi.Analytical.Building.Classes.BuildingModel).buildingModel 'DiGi\.Analytical\.Rhino\.Inspect\.Components\(this DiGi\.Analytical\.Building\.Classes\.BuildingModel\)\.buildingModel') is null\.

<a name='DiGi.Analytical.Rhino.Inspect.Geometry(thisDiGi.Analytical.Building.Interfaces.ISpace)'></a>

## Inspect\.Geometry\(this ISpace\) Method

Retrieves the geometry associated with the specified space\.

```csharp
public static DiGi.Geometry.Spatial.Classes.Point3D? Geometry(this DiGi.Analytical.Building.Interfaces.ISpace? space);
```
#### Parameters

<a name='DiGi.Analytical.Rhino.Inspect.Geometry(thisDiGi.Analytical.Building.Interfaces.ISpace).space'></a>

`space` [DiGi\.Analytical\.Building\.Interfaces\.ISpace](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ispace 'DiGi\.Analytical\.Building\.Interfaces\.ISpace')

The space instance to inspect\.

#### Returns
[DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D')  
The [DiGi\.Geometry\.Spatial\.Classes\.Point3D](https://learn.microsoft.com/en-us/dotnet/api/digi.geometry.spatial.classes.point3d 'DiGi\.Geometry\.Spatial\.Classes\.Point3D') representing the geometry if successful; otherwise, `null`\.

#### Exceptions

[System\.NotImplementedException](https://learn.microsoft.com/en-us/dotnet/api/system.notimplementedexception 'System\.NotImplementedException')  
Thrown when the provided [DiGi\.Analytical\.Building\.Interfaces\.ISpace](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ispace 'DiGi\.Analytical\.Building\.Interfaces\.ISpace') is not an instance of [DiGi\.Analytical\.Building\.Classes\.Space](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.classes.space 'DiGi\.Analytical\.Building\.Classes\.Space')\.

<a name='DiGi.Analytical.Rhino.Inspect.Guid(thisDiGi.Analytical.Building.Classes.BuildingModel)'></a>

## Inspect\.Guid\(this BuildingModel\) Method

Retrieves the unique identifier of the specified building model wrapped in a [Grasshopper\.Kernel\.Types\.GH\_Guid](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_guid 'Grasshopper\.Kernel\.Types\.GH\_Guid')\.

```csharp
public static GH_Guid? Guid(this DiGi.Analytical.Building.Classes.BuildingModel? buildingModel);
```
#### Parameters

<a name='DiGi.Analytical.Rhino.Inspect.Guid(thisDiGi.Analytical.Building.Classes.BuildingModel).buildingModel'></a>

`buildingModel` [DiGi\.Analytical\.Building\.Classes\.BuildingModel](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.classes.buildingmodel 'DiGi\.Analytical\.Building\.Classes\.BuildingModel')

The building model instance to inspect\.

#### Returns
[Grasshopper\.Kernel\.Types\.GH\_Guid](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_guid 'Grasshopper\.Kernel\.Types\.GH\_Guid')  
A [Grasshopper\.Kernel\.Types\.GH\_Guid](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_guid 'Grasshopper\.Kernel\.Types\.GH\_Guid') representing the model's identity, or `null` if the [buildingModel](DiGi.Analytical.Rhino.md#DiGi.Analytical.Rhino.Inspect.Guid(thisDiGi.Analytical.Building.Classes.BuildingModel).buildingModel 'DiGi\.Analytical\.Rhino\.Inspect\.Guid\(this DiGi\.Analytical\.Building\.Classes\.BuildingModel\)\.buildingModel') is null\.

<a name='DiGi.Analytical.Rhino.Inspect.Guid(thisDiGi.Analytical.Building.Interfaces.IComponent)'></a>

## Inspect\.Guid\(this IComponent\) Method

Extracts the unique identifier of the specified component as a [Grasshopper\.Kernel\.Types\.GH\_Guid](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_guid 'Grasshopper\.Kernel\.Types\.GH\_Guid')\.

```csharp
public static GH_Guid? Guid(this DiGi.Analytical.Building.Interfaces.IComponent? component);
```
#### Parameters

<a name='DiGi.Analytical.Rhino.Inspect.Guid(thisDiGi.Analytical.Building.Interfaces.IComponent).component'></a>

`component` [DiGi\.Analytical\.Building\.Interfaces\.IComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.icomponent 'DiGi\.Analytical\.Building\.Interfaces\.IComponent')

The component to inspect\.

#### Returns
[Grasshopper\.Kernel\.Types\.GH\_Guid](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_guid 'Grasshopper\.Kernel\.Types\.GH\_Guid')  
A [Grasshopper\.Kernel\.Types\.GH\_Guid](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_guid 'Grasshopper\.Kernel\.Types\.GH\_Guid') containing the component's ID, or `null` if the component is null\.

<a name='DiGi.Analytical.Rhino.Inspect.Guid(thisDiGi.Analytical.Building.Interfaces.ISpace)'></a>

## Inspect\.Guid\(this ISpace\) Method

Retrieves the unique identifier of the specified space as a Grasshopper Guid\.

```csharp
public static GH_Guid? Guid(this DiGi.Analytical.Building.Interfaces.ISpace? space);
```
#### Parameters

<a name='DiGi.Analytical.Rhino.Inspect.Guid(thisDiGi.Analytical.Building.Interfaces.ISpace).space'></a>

`space` [DiGi\.Analytical\.Building\.Interfaces\.ISpace](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ispace 'DiGi\.Analytical\.Building\.Interfaces\.ISpace')

The space instance to inspect\.

#### Returns
[Grasshopper\.Kernel\.Types\.GH\_Guid](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_guid 'Grasshopper\.Kernel\.Types\.GH\_Guid')  
A [Grasshopper\.Kernel\.Types\.GH\_Guid](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_guid 'Grasshopper\.Kernel\.Types\.GH\_Guid') containing the space's identifier; otherwise, `null`\.

<a name='DiGi.Analytical.Rhino.Inspect.Mesh3D(thisDiGi.Analytical.Building.Interfaces.IComponent)'></a>

## Inspect\.Mesh3D\(this IComponent\) Method

Retrieves the 3D mesh representation of the specified component as a [DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooMesh3D](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.spatial.classes.goomesh3d 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooMesh3D')\.

```csharp
public static DiGi.Rhino.Geometry.Spatial.Classes.GooMesh3D? Mesh3D(this DiGi.Analytical.Building.Interfaces.IComponent? component);
```
#### Parameters

<a name='DiGi.Analytical.Rhino.Inspect.Mesh3D(thisDiGi.Analytical.Building.Interfaces.IComponent).component'></a>

`component` [DiGi\.Analytical\.Building\.Interfaces\.IComponent](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.icomponent 'DiGi\.Analytical\.Building\.Interfaces\.IComponent')

The component to inspect\.

#### Returns
[DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooMesh3D](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.spatial.classes.goomesh3d 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooMesh3D')  
A [DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooMesh3D](https://learn.microsoft.com/en-us/dotnet/api/digi.rhino.geometry.spatial.classes.goomesh3d 'DiGi\.Rhino\.Geometry\.Spatial\.Classes\.GooMesh3D') wrapper around the retrieved mesh, or `null` if the component is null or no mesh is found\.

<a name='DiGi.Analytical.Rhino.Inspect.Name(thisDiGi.Analytical.Building.Interfaces.ISpace)'></a>

## Inspect\.Name\(this ISpace\) Method

Retrieves the name of the specified space as a Grasshopper String\.

```csharp
public static GH_String? Name(this DiGi.Analytical.Building.Interfaces.ISpace? space);
```
#### Parameters

<a name='DiGi.Analytical.Rhino.Inspect.Name(thisDiGi.Analytical.Building.Interfaces.ISpace).space'></a>

`space` [DiGi\.Analytical\.Building\.Interfaces\.ISpace](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ispace 'DiGi\.Analytical\.Building\.Interfaces\.ISpace')

The space instance to inspect\.

#### Returns
[Grasshopper\.Kernel\.Types\.GH\_String](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_string 'Grasshopper\.Kernel\.Types\.GH\_String')  
A [Grasshopper\.Kernel\.Types\.GH\_String](https://learn.microsoft.com/en-us/dotnet/api/grasshopper.kernel.types.gh_string 'Grasshopper\.Kernel\.Types\.GH\_String') containing the space's name; otherwise, `null`\.

#### Exceptions

[System\.NotImplementedException](https://learn.microsoft.com/en-us/dotnet/api/system.notimplementedexception 'System\.NotImplementedException')  
Thrown when the provided [DiGi\.Analytical\.Building\.Interfaces\.ISpace](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.interfaces.ispace 'DiGi\.Analytical\.Building\.Interfaces\.ISpace') is not an instance of [DiGi\.Analytical\.Building\.Classes\.Space](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.classes.space 'DiGi\.Analytical\.Building\.Classes\.Space')\.

<a name='DiGi.Analytical.Rhino.Inspect.Spaces(thisDiGi.Analytical.Building.Classes.BuildingModel)'></a>

## Inspect\.Spaces\(this BuildingModel\) Method

Retrieves all spaces associated with the specified building model, 
wrapped as a collection of [GooSpace](DiGi.Analytical.Building.Rhino.Classes.md#DiGi.Analytical.Building.Rhino.Classes.GooSpace 'DiGi\.Analytical\.Building\.Rhino\.Classes\.GooSpace')\.

```csharp
public static System.Collections.IEnumerable? Spaces(this DiGi.Analytical.Building.Classes.BuildingModel? buildingModel);
```
#### Parameters

<a name='DiGi.Analytical.Rhino.Inspect.Spaces(thisDiGi.Analytical.Building.Classes.BuildingModel).buildingModel'></a>

`buildingModel` [DiGi\.Analytical\.Building\.Classes\.BuildingModel](https://learn.microsoft.com/en-us/dotnet/api/digi.analytical.building.classes.buildingmodel 'DiGi\.Analytical\.Building\.Classes\.BuildingModel')

The building model instance to inspect\.

#### Returns
[System\.Collections\.IEnumerable](https://learn.microsoft.com/en-us/dotnet/api/system.collections.ienumerable 'System\.Collections\.IEnumerable')  
An enumerable collection of [GooSpace](DiGi.Analytical.Building.Rhino.Classes.md#DiGi.Analytical.Building.Rhino.Classes.GooSpace 'DiGi\.Analytical\.Building\.Rhino\.Classes\.GooSpace') objects, or `null` if the [buildingModel](DiGi.Analytical.Rhino.md#DiGi.Analytical.Rhino.Inspect.Spaces(thisDiGi.Analytical.Building.Classes.BuildingModel).buildingModel 'DiGi\.Analytical\.Rhino\.Inspect\.Spaces\(this DiGi\.Analytical\.Building\.Classes\.BuildingModel\)\.buildingModel') is null\.