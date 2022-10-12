---
-api-id: M:Windows.UI.Input.RadialControllerMenuItem.CreateFromIcon(System.String,Windows.Storage.Streams.RandomAccessStreamReference)
-api-type: winrt method
---

<!-- Method syntax
public Windows.UI.Input.RadialControllerMenuItem CreateFromIcon(System.String displayText, Windows.Storage.Streams.RandomAccessStreamReference icon)
-->

# Windows.UI.Input.RadialControllerMenuItem.CreateFromIcon

## -description
Creates a custom tool (using the specified text string and custom icon) on the [RadialController](radialcontroller.md) menu.

## -parameters
### -param displayText
The text string to display for the custom tool.

### -param icon
The custom icon to display for the custom tool.

## -returns
The custom tool.

## -remarks
[RadialController](radialcontroller.md) menu operations, including [CreateFromKnownIcon](radialcontrollermenuitem_createfromknownicon_1665769620.md), CreateFromIcon, [CreateFromFontGlyph](radialcontrollermenuitem_createfromfontglyph_679326837.md), [CreateFromFontGlyph](radialcontrollermenuitem_createfromfontglyph_63723173.md), [ResetToDefaultMenuItems](radialcontrollerconfiguration_resettodefaultmenuitems_461236227.md), [SetDefaultMenuItems](radialcontrollerconfiguration_setdefaultmenuitems_1318008085.md), and [TrySelectDefaultMenuItem](radialcontrollerconfiguration_tryselectdefaultmenuitem_1342621095.md), should be performed on the UI thread. Doing so in a background worker thread can cause issues with event handlers on the UI thread.

[UX guidelines](/windows/uwp/input-and-devices/windows-wheel-interactions) for the Surface Dial recommend the following:

**Text**
+ Names should be short to fit inside the central circle of the wheel menu
+ Names should clearly identify the primary action (a complementary action can be implied)   
+ Scroll indicates the effect of both rotation directions
+ Undo specifies a primary action, but redo (the complementary action) can be inferred and easily discovered by the user

**Icons**
+ Provide a high-quality 64 x 64 pixel PNG image (44 x 44 is the smallest supported)
+ Ensure the background is transparent
+ The icon should fill most of the image
+ A white icon should have a black outline to be visible in high contrast mode


## -examples

## -see-also

[CreateFromKnownIcon](radialcontrollermenuitem_createfromknownicon_1665769620.md), [CreateFromFontGlyph(String displayText, String glyph, String fontFamily)](radialcontrollermenuitem_createfromfontglyph_63723173.md), [CreateFromFontGlyph(String displayText, String glyph, String fontFamily, Uri fontUri)](radialcontrollermenuitem_createfromfontglyph_679326837.md), [Surface Dial interactions](/windows/uwp/input-and-devices/windows-wheel-interactions), [Universal Windows Platform samples (C# and C++)](https://go.microsoft.com/fwlink/?linkid=832713), [Windows desktop sample](https://aka.ms/radialcontrollerclassicsample)
