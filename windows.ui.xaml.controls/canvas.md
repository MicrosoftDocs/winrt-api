---
-api-id: T:Windows.UI.Xaml.Controls.Canvas
-api-type: winrt class
---

<!-- Class syntax.
public class Canvas : Windows.UI.Xaml.Controls.Panel, Windows.UI.Xaml.Controls.ICanvas
-->

# Windows.UI.Xaml.Controls.Canvas

## -description
Defines an area within which you can explicitly position child objects, using coordinates that are relative to the [Canvas](canvas.md) area.

## -xaml-syntax
```xaml
<Canvas ...>
  oneOrMoreUIElements
</Canvas>
-or-
<Canvas .../>
```


## -remarks
[Canvas](canvas.md) is a layout panel that supports absolute positioning of child elements relative to the top left corner of the canvas.

<img alt="Canvas layout panel" src="images/controls/Canvas.png" />

A [Canvas](canvas.md) is one of the [Panel](panel.md) elements that enable layout. [Canvas](canvas.md) uses absolute positioning as its layout technique for its contained child elements. Each child element is rendered within the [Canvas](canvas.md) area. You control the positioning of elements inside the [Canvas](canvas.md) by specifying x and y coordinates. These coordinates are in pixels. The x and y coordinates are often specified by using the [Canvas.Left](canvas_left.md) and [Canvas.Top](canvas_top.md) attached properties. [Canvas.Left](canvas_left.md) specifies the object's distance from the left side of the containing [Canvas](canvas.md) (the x-coordinate), and [Canvas.Top](canvas_top.md) specifies the object's distance from the top of the containing [Canvas](canvas.md) (the y-coordinate).



> [!NOTE]
> Because absolute positioning does not take into account the size of the app window, scaling, or other user-selected sizing, using a container element that adapts to different orientations and screen settings, such as [Grid](grid.md) or [StackPanel](stackpanel.md), is often a better choice than using [Canvas](canvas.md). For more information, see [Define layouts with XAML](http://msdn.microsoft.com/library/8d4e4162-1c9c-48f4-8a94-34976fb17079).

You can nest [Canvas](canvas.md) objects. When you nest objects, the coordinates used by each object are relative to its immediate containing [Canvas](canvas.md).

Each child object of a [Canvas](canvas.md) must be a [UIElement](../windows.ui.xaml/uielement.md). In XAML, you declare child objects as content of a [Canvas](canvas.md) object element. In code, you can manipulate the collection of [Canvas](canvas.md) child objects by getting the collection that is accessed by the [Children](panel_children.md) property.

In many cases, a [Canvas](canvas.md) is used solely as a container for other objects and does not have any visible properties. A [Canvas](canvas.md) and its children (if any) are not visible if any of these conditions are true:
+ The [Visibility](../windows.ui.xaml/uielement_visibility.md) property is set to **Collapsed**.
+ The [Opacity](../windows.ui.xaml/uielement_opacity.md) property of the [Canvas](canvas.md) is 0.


The children of a [Canvas](canvas.md) (if any) are still visible even if the [Canvas](canvas.md) has any of these conditions:
+ The [Background](panel_background.md) property of the [Canvas](canvas.md) is **null**.
+ The [Height](../windows.ui.xaml/frameworkelement_height.md) or [Width](../windows.ui.xaml/frameworkelement_width.md) property of the [Canvas](canvas.md) is 0.


A [Canvas](canvas.md) with no children and with a default [Height](../windows.ui.xaml/frameworkelement_height.md) and [Width](../windows.ui.xaml/frameworkelement_width.md) of **Auto** doesn't have dimensions. This is also the case if the [Canvas](canvas.md) has children but all the children have [Visibility](../windows.ui.xaml/uielement_visibility.md) of **Collapsed**, or zero [Height](../windows.ui.xaml/frameworkelement_height.md) or [Width](../windows.ui.xaml/frameworkelement_width.md).

### Canvas XAML attached properties

[Canvas](canvas.md) is the host service class for several XAML attached properties. The purpose of these attached properties is to enable child elements in layout to report how they should be positioned in a [Canvas](canvas.md) parent.

These XAML attached properties are supported by [Canvas](canvas.md):

+ [Canvas.Left](canvas_left.md)
+ [Canvas.Top](canvas_top.md)
+ [Canvas.ZIndex](canvas_zindex.md)
In order to support XAML processor access to the attached properties, and also to expose equivalent get and set operations to code, each XAML attached property has a pair of **Get** and **Set** accessor methods. For example, the [GetLeft](canvas_getleft.md) and [SetLeft](canvas_setleft.md) methods support and provide the equivalent code-only support for [Canvas.Left](canvas_left.md). Alternatively, you can use the dependency property system to get or set the value of the attached property. Call [GetValue](../windows.ui.xaml/dependencyobject_getvalue.md) or [SetValue](../windows.ui.xaml/dependencyobject_setvalue.md), passing the arguments of the dependency property identifier to set, and a reference to the target object on which to get or set the value.

For example, to change the position of the child element using C#, first define the object inside a [Canvas](canvas.md), making sure to include the [Canvas.Left](canvas_left.md) and [Canvas.Top](canvas_top.md) properties.

```xaml
<Canvas >
  <Grid x:Name="mySquare" Width="64" Height="64" Background="Red" Canvas.Left="0" Canvas.Top = "0"></Grid>
</Canvas>
```

In the code-behind page, you can then access the position of the element, like this:

```C#
mySquare.SetValue(Canvas.LeftProperty,100);
mySquare.SetValue(Canvas.TopProperty, 100);
```


## -examples

<table>
<th align="left">XAML Controls Gallery<th>
<tr>
<td><img src="images/xaml-controls-gallery-sm.png" alt="XAML controls gallery"></img></td>
<td>
    <p>If you have the <strong style="font-weight: semi-bold">XAML Controls Gallery</strong> app installed, click here to <a href="xamlcontrolsgallery:/item/Canvas">open the app and see the Canvas in action</a>.</p>
    <ul>
    <li><a href="https://www.microsoft.com/store/productId/9MSVH128X2ZT">Get the XAML Controls Gallery app (Microsoft Store)</a></li>
    <li><a href="https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlUIBasics">Get the source code (GitHub)</a></li>
    </ul>
</td>
</tr>
</table>

This example shows how to position a rectangle 30 pixels from the left and 30 pixels from the top of a [Canvas](canvas.md).

[!code-xml[LayoutOvwCanvas1](../windows.ui.xaml/code/layout_ovw_all/CSharp/MainPage.xaml#SnippetLayoutOvwCanvas1)]
<!--<desc><p xml:space="preserve">In the following example, the <xref targtype="class_winrt" rid="w_ui_xaml_ctrl.canvas">Canvas</xref> contains a red rectangle that has <xref targtype="property_winrt" rid="w_ui_xaml_ctrl.canvas_left">Canvas.Left</xref> and <xref targtype="property_winrt" rid="w_ui_xaml_ctrl.canvas_top">Canvas.Top</xref> values of 30.  </p></desc>
    <auto_snippet sample_id="layout_ovw_all" snippet_id="LayoutOvwCanvas2"/>-->

## -see-also
[Panel](panel.md), [Define layouts](http://msdn.microsoft.com/library/8d4e4162-1c9c-48f4-8a94-34976fb17079), [Alignment, margin, and padding](http://msdn.microsoft.com/library/9412abd4-3674-4865-b07d-64c7c26e4842), [Attached properties overview](http://msdn.microsoft.com/library/098c1de0-d640-48b1-9961-d0adf33266e2), [Grid](grid.md), [StackPanel](stackpanel.md), [VariableSizedWrapGrid](variablesizedwrapgrid.md), [Controls list](http://msdn.microsoft.com/library/11172840-a63d-4f48-9db4-7baca06308ee), [Controls by function](http://msdn.microsoft.com/library/8db4347b-91d6-4659-91f2-80ecf7bbb596)
