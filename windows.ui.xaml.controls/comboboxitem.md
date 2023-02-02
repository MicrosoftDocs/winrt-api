---
-api-id: T:Windows.UI.Xaml.Controls.ComboBoxItem
-api-type: winrt class
---

<!-- Class syntax.
public class ComboBoxItem : Windows.UI.Xaml.Controls.Primitives.SelectorItem, Windows.UI.Xaml.Controls.IComboBoxItem
-->

# Windows.UI.Xaml.Controls.ComboBoxItem

## -description
Represents the container for an item in a [ComboBox](combobox.md) control.


## -xaml-syntax
```xaml
<ComboBoxItem .../>
-or-
<ComboBoxItem ...>
  content
</ComboBoxItem>
```


## -remarks
The ComboBoxItem class provides the container for items displayed in a [ComboBox](combobox.md) control. You populate the [ComboBox](combobox.md) by adding objects directly to its [Items](itemscontrol_items.md) collection or by binding its [ItemsSource](itemscontrol_itemssource.md) property to a data source. When items are added to the [ComboBox](combobox.md), a ComboBoxItem container is created automatically for each item in the collection.

You can specify the look of the ComboBoxItem by setting the [ComboBox](combobox.md)'s [ItemContainerStyle](itemscontrol_itemcontainerstyle.md) property to a [Style](../windows.ui.xaml/style.md) with a [TargetType](../windows.ui.xaml/style_targettype.md) of ComboBoxItem.

### Control style and template

You can modify the default [Style](../windows.ui.xaml/style.md) and [ControlTemplate](controltemplate.md) to give the control a unique appearance. For information about modifying a control's style and template, see [XAML styles](/windows/apps/design/style/xaml-styles). XAML also includes resources that you can use to modify the colors of a control in different visual states without modifying the control template. Modifying these resources is preferred to setting properties such as [Background](control_background.md) and [Foreground](control_foreground.md). For more info, see the [Light-weight styling](/windows/apps/design/style/xaml-styles#lightweight-styling) section of the [XAML styles](/windows/apps/design/style/xaml-styles) article.

**WinUI Styles (recommended):** When you use the updated styles from WinUI 2.6 or later, the resources for this control are listed in the [ThemeDictionaries](/windows/apps/design/style/xaml-theme-resources) section of the [ComboBox_themeresources.xaml](https://github.com/microsoft/microsoft-ui-xaml/blob/main/dev/ComboBox/ComboBox_themeresources.xaml) file on GitHub. The `ResourceKey` value for each `StaticResource` references a brush and color in the [Common_themeresources_any.xaml](https://github.com/microsoft/microsoft-ui-xaml/blob/main/dev/CommonStyles/Common_themeresources_any.xaml) file.

**Non-WinUI styles:** When you use the built-in styles, the default style, template, and resources that define the look of the control are included in the generic.xaml file. For design purposes, generic.xaml is available in the \(Program Files)\Windows Kits\10\DesignTime\CommonConfiguration\Neutral\UAP\ &lt;SDK version&gt;\Generic folder from a Windows SDK installation. Light-weight styling resources are available starting in Windows 10, version 1607 (SDK 14393). Styles and resources from different versions of the SDK might have different values.

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Combo box](/windows/uwp/design/controls-and-patterns/combo-box).
>
> If you have the **WinUI 2 Gallery** app installed, click here to [open the app and see the ComboBox in action](winui2gallery:/item/ComboBox).
> + [Get the WinUI 2 Gallery app (Microsoft Store)](https://www.microsoft.com/store/productId/9MSVH128X2ZT)
> + [Get the source code (GitHub)](https://github.com/Microsoft/WinUI-Gallery)

## -see-also
[SelectorItem](../windows.ui.xaml.controls.primitives/selectoritem.md), [ComboBox](combobox.md), [ItemContainerStyle](itemscontrol_itemcontainerstyle.md)
