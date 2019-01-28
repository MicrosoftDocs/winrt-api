---
-api-id: T:Windows.UI.Xaml.Controls.HubSectionCollection
-api-type: winrt class
---

<!-- Class syntax.
public class HubSectionCollection : Windows.Foundation.Collections.IIterable<Windows.UI.Xaml.Controls.HubSection>, Windows.Foundation.Collections.IVector<Windows.UI.Xaml.Controls.HubSection>
-->

# Windows.UI.Xaml.Controls.HubSectionCollection

## -description
Represents an ordered collection of [HubSection](hubsection.md) objects.

## -xaml-syntax
```xaml
<Hub>
  oneOrMoreChildren
</Hub>
```


## -remarks
<!--Hub.Sections doesn't seem to be using this type yet, so this needs to be confirmed.-->
A [HubSectionCollection](hubsectioncollection.md) is the type of object that you get from the [Sections](hub_sections.md) property of a [Hub](hub.md). All the properties that use a [HubSectionCollection](hubsectioncollection.md) in the Windows Runtime  API are read-only properties, where the property is initialized with zero items when an object is first instantiated. But you can then add, remove or query items in the collection at run time, using the [HubSectionCollection](hubsectioncollection.md) properties and methods.


<!--Begin NET note for IEnumerable support-->
### Enumerating the collection in C# or Microsoft Visual Basic

A [HubSectionCollection](hubsectioncollection.md) is enumerable, so you can use language-specific syntax such as **foreach** in C# to enumerate the items in the collection. The compiler does the type-casting for you and you won't need to cast to `IEnumerable` explicitly. If you do need to cast explicitly, for example if you want to call [GetEnumerator](https://docs.microsoft.com/dotnet/api/system.collections.ienumerable.getenumerator), cast to [IEnumerable<T>](https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1) with a [HubSection](hubsection.md) constraint.


<!--End NET note for IEnumerable support-->

## -examples

## -see-also
[Control](control.md), [Hub](hub.md), [HubSection](hubsection.md), [HubSectionHeaderClickEventArgs](hubsectionheaderclickeventargs.md), [ISemanticZoomInformation](isemanticzoominformation.md), [IVector(HubSection)](../windows.foundation.collections/ivector_1.md), [IIterable(HubSection)](../windows.foundation.collections/iiterable_1.md)