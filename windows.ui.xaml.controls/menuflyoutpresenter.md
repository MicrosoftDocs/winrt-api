---
-api-id: T:Windows.UI.Xaml.Controls.MenuFlyoutPresenter
-api-type: winrt class
---

<!-- Class syntax.
public class MenuFlyoutPresenter : Windows.UI.Xaml.Controls.ItemsControl, Windows.UI.Xaml.Controls.IMenuFlyoutPresenter, Windows.UI.Xaml.Controls.IMenuFlyoutPresenter2
-->

# Windows.UI.Xaml.Controls.MenuFlyoutPresenter

## -description
Displays the content of a [MenuFlyout](menuflyout.md) control.



## -remarks
You don't typically use a MenuFlyoutPresenter directly, either in XAML or code. Instead, you reference the MenuFlyoutPresenter type as the [TargetType](../windows.ui.xaml/style_targettype.md) of the style you use for the [MenuFlyout.MenuFlyoutPresenterStyle](menuflyout_menuflyoutpresenterstyle.md) property. Then, you use style [Setter](../windows.ui.xaml/setter.md) elements to set the various [Control](control.md) properties that influence the appearance of the [MenuFlyout](menuflyout.md) through this presenter. For example you can use a [Setter](../windows.ui.xaml/setter.md) to set the [Width](../windows.ui.xaml/frameworkelement_width.md) of the [MenuFlyout](menuflyout.md):
```xaml
<MenuFlyout x:Name="optionFlyout">
  <MenuFlyout.MenuFlyoutPresenterStyle>
    <Style TargetType="MenuFlyoutPresenter">
      <Setter Property="Width" Value="300"/>
    </Style>
  </MenuFlyout.MenuFlyoutPresenterStyle>
<!--menu items go here-->
</MenuFlyout>
```

The MenuFlyoutPresenter class is not a [ContentPresenter](contentpresenter.md) derived class, it's actually a control (derived from [ItemsControl](itemscontrol.md)) that plays a special role when creating the visual tree for a [MenuFlyout](menuflyout.md).

### Control style and template

You can modify the default [Style](../windows.ui.xaml/style.md) and [ControlTemplate](controltemplate.md) to give the control a unique appearance. For information about modifying a control's style and template, see [Styling controls](/windows/uwp/controls-and-patterns/styling-controls). The default style, template, and resources that define the look of the control are included in the `generic.xaml` file. For design purposes, `generic.xaml` is available locally with the SDK or NuGet package installation.

- **[WinUI Styles (recommended)](/windows/apps/design/style/xaml-styles#winui-and-styles):** For updated styles from WinUI, see `\Users\<username>\.nuget\packages\microsoft.ui.xaml\<version>\lib\uap10.0\Microsoft.UI.Xaml\Themes\generic.xaml`.
- **Non-WinUI styles:** For built-in styles, see `%ProgramFiles(x86)%\Windows Kits\10\DesignTime\CommonConfiguration\Neutral\UAP\<SDK version>\Generic\generic.xaml`.

Locations might be different if you customized the installation. Styles and resources from different versions of the SDK might have different values.

XAML also includes resources that you can use to modify the colors of a control in different visual states without modifying the control template. Modifying these resources is preferred to setting properties such as [Background](control_background.md) and [Foreground](control_foreground.md). For more info, see the [Light-weight styling](/windows/apps/design/style/xaml-styles#lightweight-styling) section of the [XAML styles](/windows/apps/design/style/xaml-styles) article. Light-weight styling resources are available starting in Windows 10, version 1607 (SDK 14393).

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1511 | 10586 | TemplateSettings |
| 1903 | 18362 | IsDefaultShadowEnabled |

## -examples

## -see-also
[ItemsControl](itemscontrol.md), [IItemContainerMapping](iitemcontainermapping.md), [MenuFlyout](menuflyout.md)
