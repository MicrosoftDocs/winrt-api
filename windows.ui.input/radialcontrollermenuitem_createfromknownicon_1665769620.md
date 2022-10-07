---
-api-id: M:Windows.UI.Input.RadialControllerMenuItem.CreateFromKnownIcon(System.String,Windows.UI.Input.RadialControllerMenuKnownIcon)
-api-type: winrt method
---

<!-- Method syntax
public Windows.UI.Input.RadialControllerMenuItem CreateFromKnownIcon(System.String displayText, Windows.UI.Input.RadialControllerMenuKnownIcon value)
-->

# Windows.UI.Input.RadialControllerMenuItem.CreateFromKnownIcon

## -description
Creates a custom tool (using the specified text string and system icon) on the [RadialController](radialcontroller.md) menu.

## -parameters
### -param displayText
The text string to display for the custom tool.

### -param value
The system icon to display for the custom tool.

## -returns
The custom tool.

## -remarks
[RadialController](radialcontroller.md) menu operations, including CreateFromKnownIcon, [CreateFromIcon](radialcontrollermenuitem_createfromicon_2066467533.md), [CreateFromFontGlyph](radialcontrollermenuitem_createfromfontglyph_679326837.md), [CreateFromFontGlyph](radialcontrollermenuitem_createfromfontglyph_63723173.md), [ResetToDefaultMenuItems](radialcontrollerconfiguration_resettodefaultmenuitems_461236227.md), [SetDefaultMenuItems](radialcontrollerconfiguration_setdefaultmenuitems_1318008085.md), and [TrySelectDefaultMenuItem](radialcontrollerconfiguration_tryselectdefaultmenuitem_1342621095.md), should be performed on the UI thread. Doing so in a background worker thread can cause issues with event handlers on the UI thread.

[UX guidelines](/windows/uwp/input-and-devices/windows-wheel-interactions) for the Surface Dial recommend the following:

**Text**
+ Names should be short to fit inside the central circle of the wheel menu
+ Names should clearly identify the primary action (a complementary action can be implied)   
+ Scroll indicates the effect of both rotation directions
+ Undo specifies a primary action, but redo (the complementary action) can be inferred and easily discovered by the user

## -examples

## -see-also

[CreateFromIcon](radialcontrollermenuitem_createfromicon_2066467533.md), [CreateFromFontGlyph(String displayText, String glyph, String fontFamily)](radialcontrollermenuitem_createfromfontglyph_63723173.md), [CreateFromFontGlyph(String displayText, String glyph, String fontFamily, Uri fontUri)](radialcontrollermenuitem_createfromfontglyph_679326837.md), [Surface Dial interactions](/windows/uwp/input-and-devices/windows-wheel-interactions)
 [Universal Windows Platform samples (C# and C++)](https://go.microsoft.com/fwlink/?linkid=832713), [Windows desktop sample](https://aka.ms/radialcontrollerclassicsample)
