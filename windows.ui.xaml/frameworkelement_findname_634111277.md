---
-api-id: M:Windows.UI.Xaml.FrameworkElement.FindName(System.String)
-api-type: winrt method
---

<!-- Method syntax
public object FindName(System.String name)
-->

# Windows.UI.Xaml.FrameworkElement.FindName

## -description
Retrieves an object that has the specified identifier name.



## -parameters
### -param name
The name of the requested object.

## -returns
The requested object. This can be null if no matching object was found in the current XAML namescope.

## -remarks
> [!IMPORTANT]
> In order to use the FindName method effectively, you should understand the concept of a XAML namescope, and how a XAML namescope is created at XAML load time and then referenced and possibly modified at run time. For more info see [XAML namescopes](/windows/uwp/xaml-platform/xaml-namescopes).

The most common usage of FindName in your Windows Runtime code will be from within the generated **InitializeComponent** call for a XAML page. In this situation, FindName is invoked only after the XAML page is loaded. **InitializeComponent** provides the infrastructure such that any object that was instantiated by XAML loading can conveniently be accessed by your code-behind code. You can then reference the objects as a variable that shares the same name as the markup-declared [x:Name attribute](/windows/uwp/xaml-platform/x-name-attribute).

A run-time API such as FindName is working against a run-time object tree of the app as it exists in memory. When part of this object tree is created from templates or run-time loaded XAML, a XAML namescope is typically not contiguous within that object tree. The result is that there might be a named object in the object tree that a given FindName scope cannot find. The discontinuities between XAML namescopes that you might encounter in typical application scenarios are when objects are created by applying a template, or when objects are created by a call to [XamlReader.Load](../windows.ui.xaml.markup/xamlreader_load_1077941801.md) and subsequently added to the object tree.

If you return an unexpected null result for FindName, try these techniques:
+ For named objects that come from a template, if you are defining or deriving from a control, you can call [GetTemplateChild](../windows.ui.xaml.controls/control_gettemplatechild_501346084.md) from the scope of the object where the template is applied. You must be in a derived-class definition scope in order to use [GetTemplateChild](../windows.ui.xaml.controls/control_gettemplatechild_501346084.md), because it is a protected method of [Control](../windows.ui.xaml.controls/control.md).
+ If you are not in a derived-class definition scope, you may be able to enter the visual tree of a template, by using [VisualTreeHelper](../windows.ui.xaml.media/visualtreehelper.md) at a point in object lifetime after the template is applied (handle the [Loaded](frameworkelement_loaded.md) event). [VisualTreeHelper](../windows.ui.xaml.media/visualtreehelper.md) uses a parent-child metaphor for walking the tree, rather than using the XAML namescope concept. Walking the tree generally requires a specific knowledge of the control's composition as it comes from a given template. You can use [VisualTreeHelper.GetChild](../windows.ui.xaml.media/visualtreehelper.md) on the control to get the control's applied template root, and call FindName specifically on the template root to access elements that are named within the template XAML.
+ For the [XamlReader.Load](../windows.ui.xaml.markup/xamlreader_load_1077941801.md) case, you should preserve a reference to the return value of the [XamlReader.Load](../windows.ui.xaml.markup/xamlreader_load_1077941801.md) call, which is an object that will become the owner or basis of the created XAML namescope that is relevant. Then call FindName from that scope instead.


The object returned by FindName is not necessarily a [FrameworkElement](frameworkelement.md). For example, you might apply a name to an animation storyboard, and the various animation storyboard types do not derive from [FrameworkElement](frameworkelement.md).

The [Name](frameworkelement_name.md) property for an object (or the similar [x:Name attribute](/windows/uwp/xaml-platform/x-name-attribute)) is assigned by specifying an attribute on an object element in XAML markup. You can set a [Name](frameworkelement_name.md) value after the initial source XAML is loaded, but this technique has some limitations (see Remarks in [Name](frameworkelement_name.md)).

[TextElement](../windows.ui.xaml.documents/textelement.md) defines a similar [FindName](../windows.ui.xaml.documents/textelement_findname_634111277.md). This enables a **FindName** behavior in the object model, which is not limited to [FrameworkElement](frameworkelement.md). Calls by either implementation of **FindName** can traverse into a mixed [FrameworkElement](frameworkelement.md) / text element object tree, and use a common XAML namescope so that a FrameworkElement.FindName call can find a named text element, and vice versa.

[Name](frameworkelement_name.md) values that are added or changed at run time in the object tree will update into the acting XAML namescope at that level in the object tree. In other words, if you create a new [FrameworkElement](frameworkelement.md), give it a [Name](frameworkelement_name.md), then add it to the object tree, calling FindName from within that XAML namescope can find and return the code-created object.

## -examples

## -see-also
[Name](frameworkelement_name.md), [XAML namescopes](/windows/uwp/xaml-platform/xaml-namescopes), [x:Name attribute](/windows/uwp/xaml-platform/x-name-attribute)
