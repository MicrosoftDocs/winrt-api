---
-api-id: T:Windows.UI.Xaml.Controls.UIElementCollection
-api-type: winrt class
---

<!-- Class syntax.
public class UIElementCollection : Windows.Foundation.Collections.IIterable<Windows.UI.Xaml.UIElement>, Windows.Foundation.Collections.IVector<Windows.UI.Xaml.UIElement>, Windows.UI.Xaml.Controls.IUIElementCollection
-->

# Windows.UI.Xaml.Controls.UIElementCollection

## -description
Represents an ordered collection of [UIElement](../windows.ui.xaml/uielement.md) objects.

## -xaml-syntax
```xaml
<panelobject>
  oneOrMoreChildren
</panelobject>
```


## -remarks
A [UIElementCollection](uielementcollection.md) is the type of object that you get from the [Children](panel_children.md) property of a [Panel](panel.md). For example, if you get a value from Grid.Children, that value is a [UIElementCollection](uielementcollection.md) instance. All the properties that use a [UIElementCollection](uielementcollection.md) in the Windows Runtime  API are read-only properties, where the property is initialized with zero items when an object is first instantiated. But you can then add, remove or query items in the collection at run time, using the [UIElementCollection](uielementcollection.md) properties and methods.

The type of the items in the [UIElementCollection](uielementcollection.md) is constrained as [UIElement](../windows.ui.xaml/uielement.md). But [UIElement](../windows.ui.xaml/uielement.md) is a base element class in Windows Runtime using XAML, so there are hundreds of element types that can be treated as a [UIElement](../windows.ui.xaml/uielement.md) and can thus be one of the items in a [UIElementCollection](uielementcollection.md).




<!--Begin NET note for IEnumerable support-->
### Enumerating the collection in C# or Microsoft Visual Basic

A [UIElementCollection](uielementcollection.md) is enumerable, so you can use language-specific syntax such as **foreach** in C# to enumerate the items in the [UIElementCollection](uielementcollection.md). The compiler does the type-casting for you and you won't need to cast to `IEnumerable<UIElement>` explicitly. If you do need to cast explicitly, for example if you want to call [GetEnumerator](https://docs.microsoft.com/dotnet/api/system.collections.ienumerable.getenumerator), cast to [IEnumerable<T>](https://docs.microsoft.com/dotnet/api/system.collections.generic.ienumerable-1) with a [UIElement](../windows.ui.xaml/uielement.md) constraint.


<!--End NET note for IEnumerable support-->

## -examples

## -see-also
[Children](panel_children.md), [IVector&lt;T&gt;](../windows.foundation.collections/ivector_1.md), [IIterable&lt;T&gt;](../windows.foundation.collections/iiterable_1.md), [IList<T>](https://docs.microsoft.com/dotnet/api/system.collections.generic.ilist-1), [VisualTreeHelper](../windows.ui.xaml.media/visualtreehelper.md), [UIElement](../windows.ui.xaml/uielement.md)