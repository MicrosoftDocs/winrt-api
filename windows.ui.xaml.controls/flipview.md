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

> [!TIP]
> For more info, design guidance, and code examples, see [Flip view](/windows/uwp/design/controls-and-patterns/flipview).

Use a FlipView to present a collection of items that the user views sequentially, one at a time. It's useful for displaying a gallery of images or the pages of a magazine.

FlipView is an [ItemsControl](itemscontrol.md), so it can contain a collection of items of any type. To populate the view, add items to the [Items](itemscontrol_items.md) collection, or set the [ItemsSource](itemscontrol_itemssource.md) property to a data source.

By default, a data item is displayed in the FlipView as the string representation of the data object it's bound to. To specify exactly how items in the FlipView are displayed, you create a [DataTemplate](../windows.ui.xaml/datatemplate.md) to define the layout of controls used to display an individual item. The controls in the layout can be bound to properties of a data object, or have content defined inline. You assign the [DataTemplate](../windows.ui.xaml/datatemplate.md) to the [ItemTemplate](itemscontrol_itemtemplate.md) property of the FlipView.

For more info, see these topics:
+ [Quickstart: Adding FlipView controls](/previous-versions/windows/apps/hh781233(v=win.10))
+ [How to add a flip  view](/previous-versions/windows/apps/jj150601(v=win.10))


> [!NOTE]
> When a user flips through FlipView content using touch interaction, a [SelectionChanged](../windows.ui.xaml.controls.primitives/selector_selectionchanged.md) event occurs only when touch manipulations are complete. This means that when a user flips through content quickly, individual [SelectionChanged](../windows.ui.xaml.controls.primitives/selector_selectionchanged.md) events are not always generated for every item because the manipulation is still occurring.

If you need to handle pointer events for a [UIElement](../windows.ui.xaml/uielement.md) in a scrollable view (such as a ScrollViewer), you must explicitly disable support for manipulation events on the element in the view by calling [UIElement.CancelDirectManipulation()](../windows.ui.xaml/uielement_canceldirectmanipulations_1164631120.md). To re-enable manipulation events in the view, call [UIElement.TryStartDirectManipulation()](../windows.ui.xaml/uielement_trystartdirectmanipulation_1983346775.md).

For more examples, see [XAML FlipView sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/XAML%20FlipView%20control%20sample).

### Control style and template

You can modify the default [Style](../windows.ui.xaml/style.md) and [ControlTemplate](controltemplate.md) to give the control a unique appearance. For information about modifying a control's style and template, see [Styling controls](/windows/uwp/controls-and-patterns/styling-controls). The default style, template, and resources that define the look of the control are included in the `generic.xaml` file. For design purposes, `generic.xaml` is available locally with the SDK or NuGet package installation.

- **[WinUI Styles (recommended)](/windows/apps/design/style/xaml-styles#winui-and-styles):** For updated styles from WinUI, see `\Users\<username>\.nuget\packages\microsoft.ui.xaml\<version>\lib\uap10.0\Microsoft.UI.Xaml\Themes\generic.xaml`.
- **Non-WinUI styles:** For built-in styles, see `%ProgramFiles(x86)%\Windows Kits\10\DesignTime\CommonConfiguration\Neutral\UAP\<SDK version>\Generic\generic.xaml`.

Locations might be different if you customized the installation. Styles and resources from different versions of the SDK might have different values.

XAML also includes resources that you can use to modify the colors of a control in different visual states without modifying the control template. Modifying these resources is preferred to setting properties such as [Background](control_background.md) and [Foreground](control_foreground.md). For more info, see the [Light-weight styling](/windows/apps/design/style/xaml-styles#lightweight-styling) section of the [XAML styles](/windows/apps/design/style/xaml-styles) article. Light-weight styling resources are available starting in Windows 10, version 1607 (SDK 14393).

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Flip view](/windows/apps/design/controls/flipview).

> [!div class="nextstepaction"]
> [Open the WinUI 2 Gallery app and see the FlipView in action](winui2gallery:/item/FlipView)

> The **WinUI 2 Gallery** app includes interactive examples of most WinUI 2 controls, features, and functionality. Get the app from the [Microsoft Store](https://www.microsoft.com/store/productId/9MSVH128X2ZT) or get the source code on [GitHub](https://github.com/Microsoft/WinUI-Gallery/tree/winui2).

In this example, the [ItemTemplate](itemscontrol_itemtemplate.md) of a FlipView is defined inline.

[!code-xaml[FlipViewItemTemplate](../windows.ui.xaml.controls/code/ListAndGridViewSnippets/csharp/SplitPage.xaml#SnippetFlipViewItemTemplate)]

## -see-also
[Selector](../windows.ui.xaml.controls.primitives/selector.md), [XAML FlipView sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/XAML%20FlipView%20control%20sample), [Guidelines for flip view controls](/windows/uwp/design/controls-and-patterns/flipview)
