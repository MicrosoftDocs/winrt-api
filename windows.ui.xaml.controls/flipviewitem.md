---
-api-id: T:Windows.UI.Xaml.Controls.FlipViewItem
-api-type: winrt class
---

<!-- Class syntax.
public class FlipViewItem : Windows.UI.Xaml.Controls.Primitives.SelectorItem, Windows.UI.Xaml.Controls.IFlipViewItem
-->

# Windows.UI.Xaml.Controls.FlipViewItem

## -description
Represents the container for an item in a [FlipView](flipview.md) control.



## -xaml-syntax
```xaml
<FlipViewItem .../>
```


## -remarks
The FlipViewItem class provides the container for items displayed in a [FlipView](flipview.md) control. You populate the [FlipView](flipview.md) by adding objects directly to its [Items](itemscontrol_items.md) collection or by binding its [ItemsSource](itemscontrol_itemssource.md) property to a data source. When items are added to the [FlipView](flipview.md), a FlipViewItem container is created automatically for each item in the collection.

You can specify the look of the FlipViewItem by setting the [FlipView](flipview.md)'s [ItemContainerStyle](itemscontrol_itemcontainerstyle.md) property to a [Style](../windows.ui.xaml/style.md) with a [TargetType](../windows.ui.xaml/style_targettype.md) of FlipViewItem.

### Control style and template

You can modify the default [Style](../windows.ui.xaml/style.md) and [ControlTemplate](controltemplate.md) to give the control a unique appearance. For information about modifying a control's style and template, see [Styling controls](/windows/uwp/controls-and-patterns/styling-controls). The default style, template, and resources that define the look of the control are included in the `generic.xaml` file. For design purposes, `generic.xaml` is available locally with the SDK or NuGet package installation.

- **[WinUI Styles (recommended)](/windows/apps/design/style/xaml-styles#winui-and-styles):** For updated styles from WinUI, see `\Users\<username>\.nuget\packages\microsoft.ui.xaml\<version>\lib\uap10.0\Microsoft.UI.Xaml\Themes\generic.xaml`.
- **Non-WinUI styles:** For built-in styles, see `%ProgramFiles(x86)%\Windows Kits\10\DesignTime\CommonConfiguration\Neutral\UAP\<SDK version>\Generic\generic.xaml`.

Locations might be different if you customized the installation. Styles and resources from different versions of the SDK might have different values.

XAML also includes resources that you can use to modify the colors of a control in different visual states without modifying the control template. Modifying these resources is preferred to setting properties such as [Background](control_background.md) and [Foreground](control_foreground.md). For more info, see the [Light-weight styling](/windows/apps/design/style/xaml-styles#lightweight-styling) section of the [XAML styles](/windows/apps/design/style/xaml-styles) article. Light-weight styling resources are available starting in Windows 10, version 1607 (SDK 14393).

### Notes for previous versions

> **Windows 8.x**
> In an app compiled for Windows 8.1, FlipViewItem handles pointer focus differently than in an app compiled for Windows 8.

+ In an app compiled for Windows 8, the event order is [PointerPressed](../windows.ui.xaml/uielement_pointerpressed.md) &gt; [GotFocus](../windows.ui.xaml/uielement_gotfocus.md) &gt; [PointerReleased](../windows.ui.xaml/uielement_pointerreleased.md). FlipViewItem does not mark the [PointerReleased](../windows.ui.xaml/uielement_pointerreleased.md) event as [Handled](../windows.ui.xaml.input/pointerroutedeventargs_handled.md).
+ In an app compiled for Windows 8.1, the event order is [PointerPressed](../windows.ui.xaml/uielement_pointerpressed.md) &gt; [GotFocus](../windows.ui.xaml/uielement_gotfocus.md). FlipViewItem marks the [PointerReleased](../windows.ui.xaml/uielement_pointerreleased.md) event as [Handled](../windows.ui.xaml.input/pointerroutedeventargs_handled.md).


## -examples

## -see-also
[SelectorItem](../windows.ui.xaml.controls.primitives/selectoritem.md), [FlipView](flipview.md), [ItemContainerStyle](itemscontrol_itemcontainerstyle.md)
