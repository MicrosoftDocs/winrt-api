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

> **Explore this functionality in more depth as part of our [App features, start to finish](http://msdn.microsoft.com/library/77ccbeed-9429-4d15-8d9d-72f271ac2c86) series**
> [Hierarchical navigation, start to finish (XAML)](XREF:TODO:m_narratives.hierarchical_navigation_pattern_mca)

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

A [HubSectionCollection](hubsectioncollection.md) is enumerable, so you can use language-specific syntax such as **foreach** in C# to enumerate the items in the collection. The compiler does the type-casting for you and you won't need to cast to `IEnumerable` explicitly. If you do need to cast explicitly, for example if you want to call [GetEnumerator](XREF:TODO:M:System.Collections.Generic.IEnumerable`1.GetEnumerator), cast to [IEnumerable&lt;T&gt;](XREF:TODO:T:System.Collections.Generic.IEnumerable`1) with a [HubSection](hubsection.md) constraint.


<!--End NET note for IEnumerable support-->

## -examples

## -see-also
[Control](control.md), [Hub](hub.md), [HubSection](hubsection.md), [HubSectionHeaderClickEventArgs](hubsectionheaderclickeventargs.md), [ISemanticZoomInformation](isemanticzoominformation.md), [IVector(HubSection)](../windows.foundation.collections/ivector_1.md), [IIterable(HubSection)](../windows.foundation.collections/iiterable_1.md), [AppBar](appbar.md), [CommandBar](commandbar.md), [Your first app - Part 3: Navigation, layout, and views](XREF:TODO:m_getstarted.part_3__navigation__layout__and_views_xaml), [Your first app - Add navigation and views in a C++ Windows Store app (tutorial 3 of 4)](XREF:TODO:m_getstarted.navigation__layout_and_views_cpp), [Navigation](http://msdn.microsoft.com/library/742c1c18-c7b1-47b7-866c-726eeb8235ec), [Adding app bars (XAML)](http://msdn.microsoft.com/library/9915aea1-e738-4c4b-a838-85625055fa06), [XAML Hub control sample](http://go.microsoft.com/fwlink/p/?LinkID=310072), [XAML AppBar control sample](http://go.microsoft.com/fwlink/p/?LinkID=242388), [XAML Navigation sample](http://go.microsoft.com/fwlink/p/?LinkID=389440), [
      Navigation design basics for ](http://msdn.microsoft.com/library/b65d33ba-aafe-434d-b6d5-1a0c49f59664), [Guidelines for app bars](http://msdn.microsoft.com/library/e39f876e-347c-40c9-a89c-c8c1bc623b2a), [Bottom app bar](http://msdn.microsoft.com/library/e39f876e-347c-40c9-a89c-c8c1bc623b2a), [Top app bar](http://msdn.microsoft.com/library/e39f876e-347c-40c9-a89c-c8c1bc623b2a)