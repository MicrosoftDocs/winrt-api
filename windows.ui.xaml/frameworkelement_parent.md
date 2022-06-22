---
-api-id: P:Windows.UI.Xaml.FrameworkElement.Parent
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.DependencyObject Parent { get; }
-->

# Windows.UI.Xaml.FrameworkElement.Parent

## -description
Gets the parent object of this [FrameworkElement](frameworkelement.md) in the object tree.



## -property-value
The parent object of this object in the object tree.

## -remarks
Parent can be null if an object was instantiated, but is not attached to an object that eventually connects to a page object root. In the default Windows Runtime classes, the parent of a [FrameworkElement](frameworkelement.md) can also be expected to be a [FrameworkElement](frameworkelement.md) subclass if it's not null. But custom classes might introduce a content model where this assumption is not true.

Note that the parent of an object can change if you adjust your app's object tree at run time. You typically should get the parent object value immediately before you need it for other operations, and should not rely on the value past this point.

 Parent is read-only. You can change the parent of an object in most cases, but is done through manipulation of collections of the existing parent and a new parent. For example, you can add or remove from [Children](../windows.ui.xaml.controls/panel_children.md) of a [Panel](../windows.ui.xaml.controls/panel.md).

Generally, you can conceive of the object tree of a UWP app using C++, C#, or Visual Basic as representing a nested series of objects and property values. If a given object has one or more contained children held in some type of **Content** or **Children** property, then Parent describes the inverse of that relationship. Most of the time, Parent is the same value as returned by [VisualTreeHelper](../windows.ui.xaml.media/visualtreehelper.md)  API. However, there may be cases where Parent reports a different parent than [VisualTreeHelper](../windows.ui.xaml.media/visualtreehelper.md) does.

## -examples

## -see-also
[Define layouts with XAML](/windows/uwp/layout/layouts-with-xaml), [XAML overview](/windows/uwp/xaml-platform/xaml-overview), [VisualTreeHelper.GetParent](../windows.ui.xaml.media/visualtreehelper_getparent_1152000793.md)
