---
-api-id: P:Windows.UI.Input.RadialController.Menu
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Input.RadialControllerMenu Menu { get; }
-->

# Windows.UI.Input.RadialController.Menu

## -description
Gets a reference to the menu associated with the [RadialController](radialcontroller.md) object.

## -property-value
The integrated menu of contextual app commands associated with the [RadialController](radialcontroller.md) object.

## -remarks
[RadialController](radialcontroller.md) menu operations, including [CreateFromKnownIcon](radialcontrollermenuitem_createfromknownicon_1665769620.md), [CreateFromIcon](radialcontrollermenuitem_createfromicon_2066467533.md), [CreateFromFontGlyph](radialcontrollermenuitem_createfromfontglyph_679326837.md), [CreateFromFontGlyph](radialcontrollermenuitem_createfromfontglyph_63723173.md), [ResetToDefaultMenuItems](radialcontrollerconfiguration_resettodefaultmenuitems_461236227.md), [SetDefaultMenuItems](radialcontrollerconfiguration_setdefaultmenuitems_1318008085.md), and [TrySelectDefaultMenuItem](radialcontrollerconfiguration_tryselectdefaultmenuitem_1342621095.md), should be performed on the UI thread. Doing so in a background worker thread can cause issues with event handlers on the UI thread.

## -examples

## -see-also
[Surface Dial interactions](/windows/uwp/input-and-devices/windows-wheel-interactions), [Universal Windows Platform samples (C# and C++)](https://go.microsoft.com/fwlink/?linkid=832713), [Windows desktop sample](https://aka.ms/radialcontrollerclassicsample)