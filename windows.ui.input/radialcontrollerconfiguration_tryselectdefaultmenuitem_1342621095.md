---
-api-id: M:Windows.UI.Input.RadialControllerConfiguration.TrySelectDefaultMenuItem(Windows.UI.Input.RadialControllerSystemMenuItemKind)
-api-type: winrt method
---

<!-- Method syntax
public bool TrySelectDefaultMenuItem(Windows.UI.Input.RadialControllerSystemMenuItemKind type)
-->

# Windows.UI.Input.RadialControllerConfiguration.TrySelectDefaultMenuItem

## -description
Attempts to select and activate a tool from the collection of built-in [RadialController](radialcontroller.md) tools supported for the current app context.

## -parameters
### -param type
The built-in tool to select and activate.

## -returns
**true** if the tool can be selected; otherwise **false**.

## -remarks
[RadialController](radialcontroller.md) menu operations, including [CreateFromKnownIcon](radialcontrollermenuitem_createfromknownicon_1665769620.md), [CreateFromIcon](radialcontrollermenuitem_createfromicon_2066467533.md), [CreateFromFontGlyph](radialcontrollermenuitem_createfromfontglyph_679326837.md), [CreateFromFontGlyph](radialcontrollermenuitem_createfromfontglyph_63723173.md), [ResetToDefaultMenuItems](radialcontrollerconfiguration_resettodefaultmenuitems_461236227.md), [SetDefaultMenuItems](radialcontrollerconfiguration_setdefaultmenuitems_1318008085.md), and TrySelectDefaultMenuItem, should be performed on the UI thread. Doing so in a background worker thread can cause issues with event handlers on the UI thread.

## -examples

## -see-also
[Surface Dial interactions](/windows/uwp/input-and-devices/windows-wheel-interactions), [Universal Windows Platform samples (C# and C++)](https://go.microsoft.com/fwlink/?linkid=832713), [Windows desktop sample](https://aka.ms/radialcontrollerclassicsample)
