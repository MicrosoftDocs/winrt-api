---
-api-id: T:Windows.UI.Xaml.Controls.FlipView
-api-type: winrt class
---

<!-- Class syntax.
public class FlipView : Windows.UI.Xaml.Controls.Primitives.Selector, Windows.UI.Xaml.Controls.IFlipView, Windows.UI.Xaml.Controls.IFlipView2
-->

# Windows.UI.Xaml.Controls.FlipView

## -description
Represents an items control that displays one item at a time, and enables "flip" behavior for traversing its collection of items.

## -xaml-syntax
```xaml
<FlipView .../>
```


## -remarks
Use a [FlipView](flipview.md) to present a collection of items that the user views sequentially, one at a time. It's useful for displaying a gallery of images or the pages of a magazine.

[FlipView](flipview.md) is an [ItemsControl](itemscontrol.md), so it can contain a collection of items of any type. To populate the view, add items to the [Items](itemscontrol_items.md) collection, or set the [ItemsSource](itemscontrol_itemssource.md) property to a data source.

By default, a data item is displayed in the [FlipView](flipview.md) as the string representation of the data object it's bound to. To specify exactly how items in the [FlipView](flipview.md) are displayed, you create a [DataTemplate](../windows.ui.xaml/datatemplate.md) to define the layout of controls used to display an individual item. The controls in the layout can be bound to properties of a data object, or have content defined inline. You assign the [DataTemplate](../windows.ui.xaml/datatemplate.md) to the [ItemTemplate](itemscontrol_itemtemplate.md) property of the [FlipView](flipview.md).

For more info, see these topics:
+ [Quickstart: Adding FlipView controls](http://msdn.microsoft.com/library/74f359a7-a228-4dbd-ac9e-1226fac477fd)
+ [How to add a flip  view](http://msdn.microsoft.com/library/fd01cc83-c8ea-460e-84cb-4c5bda7f528c)


> [!NOTE]
> When a user flips through [FlipView](flipview.md) content using touch interaction, a [SelectionChanged](../windows.ui.xaml.controls.primitives/selector_selectionchanged.md) event occurs only when touch manipulations are complete. This means that when a user flips through content quickly, individual [SelectionChanged](../windows.ui.xaml.controls.primitives/selector_selectionchanged.md) events are not always generated for every item because the manipulation is still occurring.

For more examples, see [XAML FlipView sample](http://go.microsoft.com/fwlink/p/?LinkID=311760).

### Control style and template

You can modify the default [Style](../windows.ui.xaml/style.md) and [ControlTemplate](controltemplate.md) to give the control a unique appearance. For information about modifying a control's style and template, see [Styling controls](https://msdn.microsoft.com/windows/uwp/controls-and-patterns/styling-controls). The default style, template, and resources that define the look of the control are included in the generic.xaml file. For design purposes, generic.xaml is available in the \(Program Files)\Windows Kits\10\DesignTime\CommonConfiguration\Neutral\UAP\&lt;SDK version&gt;\Generic folder from a Windows Software Development Kit (SDK) installation. Styles and resources from different versions of the SDK might have different values.

Starting in Windows 10, version 1607 (Windows Software Development Kit (SDK) version 10.0.14393.0), generic.xaml includes resources that you can use to modify the colors of a control in different visual states without modifying the control template. In apps that target this software development kit (SDK) or later, modifying these resources is preferred to setting properties such as [Background](control_background.md) and [Foreground](control_foreground.md). For more info, see the [Light-weight styling](https://msdn.microsoft.com/windows/uwp/controls-and-patterns/styling-controls) section of the [Styling controls](https://msdn.microsoft.com/windows/uwp/controls-and-patterns/styling-controls) article.

This table shows the resources used by the [FlipView](flipview.md) control.

<table>
   <tr><th>Resource key</th><th>Description</th></tr>
   <tr><td>FlipViewBackground</td><td>Control background color</td></tr>
   <tr><td>FlipViewNextPreviousArrowForeground</td><td>Button arrow color</td></tr>
   <tr><td>FlipViewNextPreviousArrowForegroundPointerOver</td><td>Button arrow color on hover</td></tr>
   <tr><td>FlipViewNextPreviousArrowForegroundPressed</td><td>Button arrow color when pressed</td></tr>
   <tr><td>FlipViewNextPreviousButtonBackground</td><td>Button background color at rest</td></tr>
   <tr><td>FlipViewNextPreviousButtonBackgroundPointerOver</td><td>Button background color on hover</td></tr>
   <tr><td>FlipViewNextPreviousButtonBackgroundPressed</td><td>Button background color when pressed</td></tr>
   <tr><td>FlipViewNextPreviousButtonBorderBrush</td><td>Button border color at rest</td></tr>
   <tr><td>FlipViewNextPreviousButtonBorderBrushPointerOver</td><td>Button border color on hover</td></tr>
   <tr><td>FlipViewNextPreviousButtonBorderBrushPressed</td><td>Button border color when pressed</td></tr>
</table>

## -examples

<table>
<th align="left">XAML Controls Gallery<th>
<tr>
<td><img src="images/xaml-controls-gallery-sm.png" alt="XAML controls gallery"></img></td>
<td>
    <p>If you have the <strong style="font-weight: semi-bold">XAML Controls Gallery</strong> app installed, click here to <a href="xamlcontrolsgallery:/item/FlipView">open the app and see the FlipView in action</a>.</p>
    <ul>
    <li><a href="https://www.microsoft.com/store/productId/9MSVH128X2ZT">Get the XAML Controls Gallery app (Microsoft Store)</a></li>
    <li><a href="https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlUIBasics">Get the source code (GitHub)</a></li>
    </ul>
</td>
</tr>
</table>

In this example, the [ItemTemplate](itemscontrol_itemtemplate.md) of a [FlipView](flipview.md) is defined inline.

[!code-xml[FlipViewItemTemplate](../windows.ui.xaml.controls/code/ListAndGridViewSnippets/csharp/SplitPage.xaml#SnippetFlipViewItemTemplate)]

## -see-also
[Selector](../windows.ui.xaml.controls.primitives/selector.md), [FlipView styles and templates](http://msdn.microsoft.com/library/9db798b1-06b7-40e3-add2-c89676b2bfdb), [XAML FlipView sample](http://go.microsoft.com/fwlink/p/?LinkID=311760), [Guidelines for flip view controls](https://docs.microsoft.com/windows/uwp/design/controls-and-patterns/flipview)
