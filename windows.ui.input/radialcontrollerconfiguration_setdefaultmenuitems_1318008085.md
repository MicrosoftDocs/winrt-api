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
> When present, the [InkToolbar](../windows.ui.xaml.controls/inktoolbar.md) adds two custom tools to the [RadialController](radialcontroller.md) menu (pen and stroke size). These tools are not accessible through [RadialController](radialcontroller.md) APIs such as [Items](radialcontrollermenu_items.md) or SetDefaultMenuItems.

## -parameters
### -param buttons
The default set of commands ([RadialControllerSystemMenuItemKind](radialcontrollersystemmenuitemkind.md)) available on a [RadialController](radialcontroller.md) menu.

## -remarks
[RadialController](radialcontroller.md) menu operations, including [CreateFromKnownIcon](radialcontrollermenuitem_createfromknownicon_1665769620.md), [CreateFromIcon](radialcontrollermenuitem_createfromicon_2066467533.md), [CreateFromFontGlyph](radialcontrollermenuitem_createfromfontglyph_679326837.md), [CreateFromFontGlyph](radialcontrollermenuitem_createfromfontglyph_63723173.md), [ResetToDefaultMenuItems](radialcontrollerconfiguration_resettodefaultmenuitems_461236227.md), SetDefaultMenuItems, and [TrySelectDefaultMenuItem](radialcontrollerconfiguration_tryselectdefaultmenuitem_1342621095.md), should be performed on the UI thread. Doing so in a background worker thread can cause issues with event handlers on the UI thread.

## -examples

## -see-also
[Surface Dial interactions](/windows/uwp/input-and-devices/windows-wheel-interactions), [Universal Windows Platform samples (C# and C++)](https://go.microsoft.com/fwlink/?linkid=832713), [Windows desktop sample](https://aka.ms/radialcontrollerclassicsample)
