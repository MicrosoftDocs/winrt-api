---
-api-id: T:Windows.UI.Input.RadialControllerConfiguration
-api-type: winrt class
---

<!-- Class syntax.
public class RadialControllerConfiguration : Windows.UI.Input.IRadialControllerConfiguration, Windows.UI.Input.IRadialControllerConfiguration2
-->

# Windows.UI.Input.RadialControllerConfiguration

## -description
Provides configuration details for the [RadialController](radialcontroller.md) menu.

## -remarks

## -examples

In this example, we specify which built-in tools are displayed on the menu, and set the default tool.

1. First, in the `ModifySystemDefaults` function, we get a reference to the [RadialControllerConfiguration](radialcontrollerconfiguration.md) object for the Surface Dial (`config`) by calling [GetForCurrentView](radialcontrollerconfiguration_getforcurrentview.md).
1. Then, we call [SetDefaultMenuItems](radialcontrollerconfiguration_setdefaultmenuitems.md) to specify the default collection of built-in menu items ([Volume](radialcontrollersystemmenuitemkind.md) and [Scroll](radialcontrollersystemmenuitemkind.md)).
1. In the `Select_Volume` function, we attempt to set the default menu item to [Volume](radialcontrollersystemmenuitemkind.md) by calling [TrySelectDefaultMenuItem](radialcontrollerconfiguration_tryselectdefaultmenuitem.md).


```csharp
public sealed partial class MainPage : Page
{
  RadialControllerConfiguration config;

  private void ModifySystemDefaults(object sender, RoutedEventArgs e) 
  {
    config = RadialControllerConfiguration.GetForCurrentView();
    config.SetDefaultMenuItems(
      new[] { RadialControllerSystemMenuItemKind.Volume, 
        RadialControllerSystemMenuItemKind.Scroll });
  }

  private void Select_Volume(object sender, RoutedEventArgs e)
  {
    config = RadialControllerConfiguration.GetForCurrentView();
    config.TrySelectDefaultMenuItem(RadialControllerSystemMenuItemKind.Volume); 
  } 
}
```

In this example, we clear all built-in tools by calling [SetDefaultMenuItems](radialcontrollerconfiguration_setdefaultmenuitems.md) and passing an empty collection.

> [!IMPORTANT]
> When present, the [InkToolbar](../windows.ui.xaml.controls/inktoolbar.md) adds two custom tools to the [RadialController](radialcontroller.md) menu (pen and stroke size). These tools are not accessible through [RadialController](radialcontroller.md) APIs such as [Items](radialcontrollermenu_items.md) or [SetDefaultMenuItems](radialcontrollerconfiguration_setdefaultmenuitems.md).

```csharp
  private void ClearSystemDefaults(object sender, RoutedEventArgs e) 
  {
    config = RadialControllerConfiguration.GetForCurrentView();
    config.SetDefaultMenuItems(
      new[] { });
  }
```



## -see-also
[Windows.UI.Input Classes](windows_ui_input_classes.md), [Surface Dial interactions](https://msdn.microsoft.com/en-us/windows/uwp/input-and-devices/windows-wheel-interactions), [Universal Windows Platform samples (C# and C++)](https://go.microsoft.com/fwlink/?linkid=832713), [Windows classic desktop sample](https://aka.ms/radialcontrollerclassicsample)