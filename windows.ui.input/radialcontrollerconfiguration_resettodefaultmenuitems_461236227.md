---
-api-id: M:Windows.UI.Input.RadialControllerConfiguration.ResetToDefaultMenuItems
-api-type: winrt method
---

<!-- Method syntax
public void ResetToDefaultMenuItems()
-->

# Windows.UI.Input.RadialControllerConfiguration.ResetToDefaultMenuItems

## -description
Restores the [RadialController](radialcontroller.md) menu to the default configuration.

## -remarks
[RadialController](radialcontroller.md) menu operations, including [CreateFromKnownIcon](radialcontrollermenuitem_createfromknownicon_1665769620.md), [CreateFromIcon](radialcontrollermenuitem_createfromicon_2066467533.md), [CreateFromFontGlyph](radialcontrollermenuitem_createfromfontglyph_679326837.md), [CreateFromFontGlyph](radialcontrollermenuitem_createfromfontglyph_63723173.md), ResetToDefaultMenuItems, [SetDefaultMenuItems](radialcontrollerconfiguration_setdefaultmenuitems_1318008085.md), and [TrySelectDefaultMenuItem](radialcontrollerconfiguration_tryselectdefaultmenuitem_1342621095.md), should be performed on the UI thread. Doing so in a background worker thread can cause issues with event handlers on the UI thread.

## -examples

## -see-also
[Surface Dial interactions](/windows/uwp/input-and-devices/windows-wheel-interactions), [Universal Windows Platform samples (C# and C++)](https://go.microsoft.com/fwlink/?linkid=832713), [Windows desktop sample](https://aka.ms/radialcontrollerclassicsample)
