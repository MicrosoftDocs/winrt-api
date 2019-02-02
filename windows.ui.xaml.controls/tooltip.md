---
-api-id: T:Windows.UI.Xaml.Controls.ToolTip
-api-type: winrt class
---

<!-- Class syntax.
public class ToolTip : Windows.UI.Xaml.Controls.ContentControl, Windows.UI.Xaml.Controls.IToolTip
-->

# Windows.UI.Xaml.Controls.ToolTip

## -description

Represents a control that creates a pop-up window that displays information for an element in the UI.

## -xaml-syntax

```xaml
<ToolTip .../>
-or-
<ToolTip ...>
  singleObject
</ToolTip ...>
-or-
<ToolTip ...>stringContent</ToolTip>
```


## -remarks

A [ToolTip](tooltip.md) is a short description that is linked to another control or object. [ToolTip](tooltip.md) s help users understand unfamiliar objects that aren't described directly in the UI. They display automatically when the user presses and holds or hovers the mouse pointer over a control. The [ToolTip](tooltip.md) disappears after a short time, or when the user moves the pointer.

Here's a [ToolTip](tooltip.md) for a [Button](button.md).

<img alt="Tool tip control" src="images/controls/ToolTip.png" />

For design guidelines, see [Guidelines for tooltips](https://msdn.microsoft.com/library/a21bb12b-301e-40c9-b84b-c055fd43d307).

### Usage

A [ToolTip](tooltip.md) must be assigned to another UI element that is its owner. The [ToolTipService](tooltipservice.md) class provides static methods to display a [ToolTip](tooltip.md).

+ In XAML, use the [ToolTipService.Tooltip](tooltipservice_tooltip.md) attached property to assign the [ToolTip](tooltip.md) to an owner.
```xaml
<Button Content="Submit" ToolTipService.ToolTip="Click to submit"/>
```


+ In code, use the [ToolTipService.SetToolTip](tooltipservice_settooltip_1924909593.md) method to assign the [ToolTip](tooltip.md) to an owner.
```xaml
<Button x:Name="submitButton" Content="Submit"/>
```

```csharp
ToolTip toolTip = new ToolTip();
toolTip.Content = "Click to submit";
ToolTipService.SetToolTip(submitButton, toolTip);
```


You can use any object as the [Content](contentcontrol_content.md) of a [ToolTip](tooltip.md). Here's an example of using an [Image](image.md) in a [ToolTip](tooltip.md).

```xaml
<TextBlock Text="store logo">
    <ToolTipService.ToolTip>
        <Image Source="Assets/StoreLogo.png"/>
    </ToolTipService.ToolTip>
</TextBlock> 
```

### Placement

By default, a [ToolTip](tooltip.md) is displayed centered above the pointer. The placement is not constrained by the app window, so the [ToolTip](tooltip.md) might be displayed partially or completely outside of the app window bounds.

If a [ToolTip](tooltip.md) obscures the content it is referring to, you can adjust it's placement. Use the [Placement](tooltip_placement.md) property or [ToolTipService.Placement](tooltipservice_placement.md) attached property to place the [ToolTip](tooltip.md) above, below, left, or right of the pointer. You can set the [VerticalOffset](tooltip_verticaloffset.md) and [HorizontalOffset](tooltip_horizontaloffset.md) properties to change the distance between the pointer and the [ToolTip](tooltip.md).

### Control style and template

You can modify the default [Style](../windows.ui.xaml/style.md) and [ControlTemplate](controltemplate.md) to give the control a unique appearance. For information about modifying a control's style and template, see [Styling controls](https://msdn.microsoft.com/windows/uwp/controls-and-patterns/styling-controls). The default style, template, and resources that define the look of the control are included in the generic.xaml file. For design purposes, generic.xaml is available in the \(Program Files)\Windows Kits\10\DesignTime\CommonConfiguration\Neutral\UAP\&lt;SDK version&gt;\Generic folder from a Windows Software Development Kit (SDK) installation. Styles and resources from different versions of the SDK might have different values.

Starting in Windows 10, version 1607 (Windows Software Development Kit (SDK) version 10.0.14393.0), generic.xaml includes resources that you can use to modify the colors of a control in different visual states without modifying the control template. In apps that target this software development kit (SDK) or later, modifying these resources is preferred to setting properties such as [Background](control_background.md) and [Foreground](control_foreground.md). For more info, see the [Light-weight styling](https://msdn.microsoft.com/windows/uwp/controls-and-patterns/styling-controls) section of the [Styling controls](https://msdn.microsoft.com/windows/uwp/controls-and-patterns/styling-controls) article.

This table shows the resources used by the [ToolTip](tooltip.md) control.

<table>
   <tr><th>Resource key</th><th>Description</th></tr>
   <tr><td>ToolTipForeground</td><td>Text color in tool tip</td></tr>
   <tr><td>ToolTipBackground</td><td>Background color</td></tr>
   <tr><td>ToolTipBorderBrush</td><td>Border color</td></tr>
</table>

### Notes for previous versions

> **Windows 8.x**
>   [ToolTip](tooltip.md) is intended only for use in Windows. The [ToolTip](tooltip.md) type is available in Windows Phone projects for compatibility with universal project templates, but the [ToolTip](tooltip.md) is not shown in the Windows Phone  UI.

   [ToolTip](tooltip.md) is displayed only within the bounds of the app window. It's placement might be adjusted to stay within those bounds.

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Tooltips](/windows/uwp/design/controls-and-patterns/tooltips).
>
> If you have the **XAML Controls Gallery** app installed, click here to [open the app and see the ToolTip in action](xamlcontrolsgallery:/item/ToolTip).
> + [Get the XAML Controls Gallery app (Microsoft Store)](https://www.microsoft.com/store/productId/9MSVH128X2ZT)
> + [Get the source code (GitHub)](https://github.com/Microsoft/Xaml-Controls-Gallery)

This example demonstrates basic tooltips and the properties for placement.

[!code-xml[1](../windows.ui.xaml.controls.primitives/code/System.Windows.Controls.ToolTip/csharp/Page.xaml#Snippet1)]

## -see-also
[ContentControl](contentcontrol.md), [ToolTipService](tooltipservice.md), [Tooltips overview](https://docs.microsoft.com/windows/uwp/design/controls-and-patterns/tooltips), [ToolTip styles and templates](https://msdn.microsoft.com/library/96bcc21c-9ebb-4624-96f5-08f83fe748b8), [XAML essential controls sample](https://go.microsoft.com/fwlink/p/?linkid=226951)
