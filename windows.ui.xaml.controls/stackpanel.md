---
-api-id: T:Windows.UI.Xaml.Controls.StackPanel
-api-type: winrt class
---

<!-- Class syntax.
public class StackPanel : Windows.UI.Xaml.Controls.Panel, Windows.UI.Xaml.Controls.IInsertionPanel, Windows.UI.Xaml.Controls.IStackPanel, Windows.UI.Xaml.Controls.IStackPanel2, Windows.UI.Xaml.Controls.Primitives.IScrollSnapPointsInfo
-->

# Windows.UI.Xaml.Controls.StackPanel

## -description
Arranges child elements into a single line that can be oriented horizontally or vertically.

## -xaml-syntax
```xaml
<StackPanel .../>
-or-
<StackPanel ...>
  oneOrMoreChildren
</StackPanel>

```


## -remarks

> [!TIP]
> For more info, design guidance, and code examples, see [Layout panels](/windows/uwp/design/layout/layout-panels#stackpanel).

StackPanel is a layout panel that arranges child elements into a single line that can be oriented horizontally or vertically.

<img alt="Stack panel layout control" src="images/controls/StackPanel.png" />

By default, StackPanel stacks items vertically from top to bottom in the order they are declared. You can set the [Orientation](stackpanel_orientation.md) property to **Horizontal** to stack items from left to right.

You can insert items into a StackPanel at a specific location using the [Insert](uielementcollection_insert.md) method in code-behind.

### Border properties

StackPanel defines border properties that let you draw a border around the StackPanel without using an additional [Border](border.md) element. The properties are [StackPanel.BorderBrush](stackpanel_borderbrush.md), [StackPanel.BorderThickness](stackpanel_borderthickness.md), [StackPanel.CornerRadius](stackpanel_cornerradius.md), and [StackPanel.Padding](stackpanel_padding.md).

```xaml
<StackPanel BorderBrush="Red" BorderThickness="2" CornerRadius="10" Padding="12">
    <TextBlock Text="Hello World!"/>
</StackPanel>
```

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | GetInsertionIndexes |
| 1709 | 16299 | Spacing |
| 1809 | 17763 | BackgroundSizing |

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Layout panels](/windows/uwp/design/layout/layout-panels#stackpanel).
>
> If you have the **XAML Controls Gallery** app installed, click here to [open the app and see the StackPanel in action](xamlcontrolsgallery:/item/StackPanel).
> + [Get the XAML Controls Gallery app (Microsoft Store)](https://www.microsoft.com/store/productId/9MSVH128X2ZT)
> + [Get the source code (GitHub)](https://github.com/Microsoft/Xaml-Controls-Gallery)

The following example shows how to create a StackPanel of items.

[!code-xaml[LayoutOvwStackPanel_1](../windows.ui.xaml/code/layout_ovw_all/CSharp/MainPage.xaml#SnippetLayoutOvwStackPanel_1)]

[!code-xaml[02](../windows.ui.xaml.controls/code/StackPanel1/csharp/Page.xaml#Snippet02)]

[!code-csharp[01](../windows.ui.xaml.controls/code/StackPanel1/csharp/Page.xaml.cs#Snippet01)]

[!code-vb[01](../windows.ui.xaml.controls/code/StackPanel1/vbnet/Page.xaml.vb#Snippet01)]

## -see-also
[Panel](panel.md), [IScrollSnapPointsInfo](../windows.ui.xaml.controls.primitives/iscrollsnappointsinfo.md), [Define layouts](https://docs.microsoft.com/windows/uwp/layout/layouts-with-xaml), [Alignment, margin, and padding](https://docs.microsoft.com/windows/uwp/layout/alignment-margin-padding), [Canvas](canvas.md), [Grid](grid.md), [ItemsStackPanel](itemsstackpanel.md), [VariableSizedWrapGrid](variablesizedwrapgrid.md), [VirtualizingStackPanel](virtualizingstackpanel.md), [Controls list](https://docs.microsoft.com/windows/uwp/design/controls-and-patterns/), [Controls by function](https://docs.microsoft.com/windows/uwp/controls-and-patterns/controls-by-function)
347b-91d6-4659-91f2-80ecf7bbb596)
