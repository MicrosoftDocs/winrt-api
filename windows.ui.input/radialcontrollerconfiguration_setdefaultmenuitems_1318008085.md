---
-api-id: M:Windows.UI.Input.RadialControllerConfiguration.SetDefaultMenuItems(Windows.Foundation.Collections.IIterable{Windows.UI.Input.RadialControllerSystemMenuItemKind})
-api-type: winrt method
---

<!-- Method syntax
public void SetDefaultMenuItems(Windows.Foundation.Collections.IIterable<Windows.UI.Input.RadialControllerSystemMenuItemKind> buttons)
-->

# Windows.UI.Input.RadialControllerConfiguration.SetDefaultMenuItems

## -description
Specifies which built-in tools are shown on the [RadialController](radialcontroller.md) menu.

> [!IMPORTANT]
> When present, the [InkToolbar](../windows.ui.xaml.controls/inktoolbar.md) adds two custom tools to the [RadialController](radialcontroller.md) menu (pen and stroke size). These tools are not accessible through [RadialController](radialcontroller.md) APIs such as [Items](radialcontrollermenu_items.md) or [SetDefaultMenuItems](radialcontrollerconfiguration_setdefaultmenuitems.md).

## -parameters
### -param buttons
The default set of commands ([RadialControllerSystemMenuItemKind](radialcontrollersystemmenuitemkind.md)) available on a [RadialController](radialcontroller.md) menu.

## -remarks

## -examples

## -see-also
[Surface Dial interactions](https://msdn.microsoft.com/en-us/windows/uwp/input-and-devices/windows-wheel-interactions), [Universal Windows Platform samples (C# and C++)](https://go.microsoft.com/fwlink/?linkid=832713), [Windows classic desktop sample](https://aka.ms/radialcontrollerclassicsample)