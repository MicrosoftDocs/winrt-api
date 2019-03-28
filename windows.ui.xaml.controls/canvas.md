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

> [!TIP]
> For more info, design guidance, and code examples, see [Layout panels](/windows/uwp/design/layout/layout-panels#canvas).

[Canvas](canvas.md) is a layout panel that supports absolute positioning of child elements relative to the top left corner of the canvas.

<img alt="Canvas layout panel" src="images/controls/Canvas.png" />

A [Canvas](canvas.md) is one of the [Panel](panel.md) elements that enable layout. [Canvas](canvas.md) uses absolute positioning as its layout technique for its contained child elements. Each child element is rendered within the [Canvas](canvas.md) area. You control the positioning of elements inside the [Canvas](canvas.md) by specifying x and y coordinates. These coordinates are in pixels. The x and y coordinates are often specified by using the [Canvas.Left](canvas_left.md) and [Canvas.Top](canvas_top.md) attached properties. [Canvas.Left](canvas_left.md) specifies the object's distance from the left side of the containing [Canvas](canvas.md) (the x-coordinate), and [Canvas.Top](canvas_top.md) specifies the object's distance from the top of the containing [Canvas](canvas.md) (the y-coordinate).



> [!NOTE]
> Because absolute positioning does not take into account the size of the app window, scaling, or other user-selected sizing, using a container element that adapts to different orientations and screen settings, such as [Grid](grid.md) or [StackPanel](stackpanel.md), is often a better choice than using [Canvas](canvas.md). For more information, see [Define layouts with XAML](https://msdn.microsoft.com/library/8d4e4162-1c9c-48f4-8a94-34976fb17079).

You can nest [Canvas](canvas.md) objects. When you nest objects, the coordinates used by each object are relative to its immediate containing [Canvas](canvas.md).

Each child object of a [Canvas](canvas.md) must be a [UIElement](../windows.ui.xaml/uielement.md). In XAML, you declare child objects as content of a [Canvas](canvas.md) object element. In code, you can manipulate the collection of [Canvas](canvas.md) child objects by getting the collection that is accessed by the [Children](panel_children.md) property.

In many cases, a [Canvas](canvas.md) is used solely as a container for other objects and does not have any visible properties. A [Canvas](canvas.md) and its children (if any) are not visible if any of these conditions are true:
+ The [Visibility](../windows.ui.xaml/uielement_visibility.md) property is set to **Collapsed**.
+ The [Opacity](../windows.ui.xaml/uielement_opacity.md) property of the [Canvas](canvas.md) is 0.


The children of a [Canvas](canvas.md) (if any) are still visible even if the [Canvas](canvas.md) has any of these conditions:
+ The [Background](panel_background.md) property of the [Canvas](canvas.md) is **null**.
+ The [Height](../windows.ui.xaml/frameworkelement_height.md) or [Width](../windows.ui.xaml/frameworkelement_width.md) property of the [Canvas](canvas.md) is 0.


A [Canvas](canvas.md) with no children and with a default [Height](../windows.ui.xaml/frameworkelement_height.md) and [Width](../windows.ui.xaml/frameworkelement_width.md) of **Auto** doesn't have dimensions. This is also the case if the [Canvas](canvas.md) has children but all the children have [Visibility](../windows.ui.xaml/uielement_visibility.md) of **Collapsed**, or zero [Height](../windows.ui.xaml/frameworkelement_height.md) or [Width](../windows.ui.xaml/frameworkelement_width.md).

### XAML attached properties

Canvas is the host service class for several [XAML attached properties](https://docs.microsoft.com/windows/uwp/xaml-platform/attached-properties-overview).

In order to support XAML processor access to the attached properties, and also to expose equivalent _get_ and _set_ operations to code, each XAML attached property has a pair of Get and Set accessor methods. Another way to get or set the value in code is to use the dependency property system, calling either [GetValue](../windows.ui.xaml/dependencyobject_getvalue_1188551207.md) or [SetValue](../windows.ui.xaml/dependencyobject_setvalue_52578133.md) and passing the identifier field as the dependency property identifier.

| Attached property | Description |
| - | - |
| Left | Gets or sets the distance between the left side of an object and the left side of its parent Canvas.<ul><li>Type: Double</li><li>Identifier field: <a href="https://docs.microsoft.com/uwp/api/windows.ui.xaml.controls.canvas.leftproperty">LeftProperty</a></li><li>Accessor methods: <a href="https://docs.microsoft.com/uwp/api/windows.ui.xaml.controls.canvas.getleft">GetLeft</a>, <a href="https://docs.microsoft.com/uwp/api/windows.ui.xaml.controls.canvas.setleft">SetLeft</a></li></ul> The Left value is the horizontal offset between the left edge of the parent Canvas and where the target element should be placed. You typically specify positive integer numbers. Non-integer Double values are allowed but can potentially cause subpixel rendering issues; see UseLayoutRounding. |
| Top | Gets or sets the distance between the top of an element and the top of its parent Canvas.<ul><li>Type: Double</li><li>Identifier field: <a href="https://docs.microsoft.com/uwp/api/windows.ui.xaml.controls.canvas.topproperty">TopProperty</a></li><li>Accessor methods: <a href="https://docs.microsoft.com/uwp/api/windows.ui.xaml.controls.canvas.gettop">GetTop</a>, <a href="https://docs.microsoft.com/uwp/api/windows.ui.xaml.controls.canvas.settop">SetTop</a></li></ul> The Top value is the vertical offset between the top edge of the parent Canvas and where the target element should be placed. You typically specify positive integer numbers. Non-integer Double values are allowed but can potentially cause subpixel rendering issues; see UseLayoutRounding.<br/>A Canvas.Top value is interpreted by the most immediate parent Canvas element from where the value is set. The value is used along with Canvas.Left to specify the layout characteristics of each child element of a Canvas. |
| ZIndex | Gets or sets the Z-order of an element when that element is presented in its parent Canvas layout container.<ul><li>Type: Int32</li><li>Identifier field: <a href="https://docs.microsoft.com/uwp/api/windows.ui.xaml.controls.canvas.zindexproperty">ZIndexProperty</a></li><li>Accessor methods: <a href="https://docs.microsoft.com/uwp/api/windows.ui.xaml.controls.canvas.getzindex">GetZIndex</a>, <a href="https://docs.microsoft.com/uwp/api/windows.ui.xaml.controls.canvas.setzindex">SetZIndex</a></li></ul> Canvas.ZIndex declares the draw order for the child elements of a Canvas. This matters when there is overlap between any of the bounds of the child elements. A higher z-order value will draw on top of a lower z-order value. If no value is set, the default is -1. If there is a draw order issue where elements share one or more pixels of layout space in a Canvas and the z-index values are the same, then the last element declared in XAML (or the highest index element in the Children collection if using code) is the element that draws on top.<br/>You typically use values 0 and greater but negative values are permitted. A negative value, such as -99, places the object even farther from the foreground than any default value.<br/>A value is interpreted by the most immediate parent Canvas element from where the value is set. The value is used to explicitly define the draw order in cases where child elements overlap. |

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Layout panels](/windows/uwp/design/layout/layout-panels#canvas).
>
> If you have the **XAML Controls Gallery** app installed, click here to [open the app and see the Canvas in action](xamlcontrolsgallery:/item/Canvas).
> + [Get the XAML Controls Gallery app (Microsoft Store)](https://www.microsoft.com/store/productId/9MSVH128X2ZT)
> + [Get the source code (GitHub)](https://github.com/Microsoft/Xaml-Controls-Gallery)

<table>
<th align="left">XAML Controls Gallery<th>
<tr>
<td><img src="images/xaml-controls-gallery-sm.png" alt="XAML controls gallery"></img></td>
<td>
    <p>If you have the <strong style="font-weight: semi-bold">XAML Controls Gallery</strong> app installed, click here to <a href="xamlcontrolsgallery:/item/Canvas">open the app and see the Canvas in action</a>.</p>
    <ul>
    <li><a href="https://www.microsoft.com/store/productId/9MSVH128X2ZT">Get the XAML Controls Gallery app (Microsoft Store)</a></li>
    <li><a href="https://github.com/Microsoft/Xaml-Controls-Gallery">Get the source code (GitHub)</a></li>
    </ul>
</td>
</tr>
</table>

This example shows how to position a rectangle 30 pixels from the left and 30 pixels from the top of a [Canvas](canvas.md).

[!code-xml[LayoutOvwCanvas1](../windows.ui.xaml/code/layout_ovw_all/CSharp/MainPage.xaml#SnippetLayoutOvwCanvas1)]
<!--<desc><p xml:space="preserve">In the following example, the <xref targtype="class_winrt" rid="w_ui_xaml_ctrl.canvas">Canvas</xref> contains a red rectangle that has <xref targtype="property_winrt" rid="w_ui_xaml_ctrl.canvas_left">Canvas.Left</xref> and <xref targtype="property_winrt" rid="w_ui_xaml_ctrl.canvas_top">Canvas.Top</xref> values of 30.  </p></desc>
    <auto_snippet sample_id="layout_ovw_all" snippet_id="LayoutOvwCanvas2"/>-->

## -see-also
[Panel](panel.md), [Define layouts](https://msdn.microsoft.com/library/8d4e4162-1c9c-48f4-8a94-34976fb17079), [Alignment, margin, and padding](https://msdn.microsoft.com/library/9412abd4-3674-4865-b07d-64c7c26e4842), [Attached properties overview](https://msdn.microsoft.com/library/098c1de0-d640-48b1-9961-d0adf33266e2), [Grid](grid.md), [StackPanel](stackpanel.md), [VariableSizedWrapGrid](variablesizedwrapgrid.md), [Controls list](https://msdn.microsoft.com/library/11172840-a63d-4f48-9db4-7baca06308ee), [Controls by function](https://msdn.microsoft.com/library/8db4347b-91d6-4659-91f2-80ecf7bbb596)
