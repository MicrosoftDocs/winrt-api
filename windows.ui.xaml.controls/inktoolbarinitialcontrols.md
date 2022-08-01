---
-api-id: T:Windows.UI.Xaml.Controls.InkToolbarInitialControls
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Xaml.Controls.InkToolbarInitialControls : int
-->

# InkToolbarInitialControls

## -description
Defines constants that specify the built-in buttons ([InitialControls](inktoolbar_initialcontrols.md)) added to an [InkToolbar](inktoolbar.md) at initialization.

## -enum-fields
### -field All:0
All built-in buttons are added.

### -field None:1
No built-in buttons are added.

### -field PensOnly:2

All built-in pen buttons are added:

+ [InkToolbarBallpointPenButton](inktoolbarballpointpenbutton.md)
+ [InkToolbarPencilButton](inktoolbarpencilbutton.md)
+ [InkToolbarHighlighterButton](inktoolbarhighlighterbutton.md)


### -field AllExceptPens:3

All built-in, non-pen buttons are added:

+ [InkToolbarEraserButton](inktoolbareraserbutton.md)
+ [InkToolbarRulerButton](inktoolbarrulerbutton.md)



## -remarks

## -examples

## -see-also
[Pen and stylus interactions](/windows/uwp/input-and-devices/pen-and-stylus-interactions), [Add an InkToolbar to a Universal Windows Platform (UWP) app](/windows/uwp/input-and-devices/ink-toolbar), [Get Started Tutorial: Support ink in your UWP app](/windows/uwp/get-started/ink-walkthrough), [Ink sample (JavaScript)](https://github.com/microsoft/Windows-universal-samples/tree/main/archived/Ink), [Get Started Tutorial: Support ink in your UWP app](https://aka.ms/appsample-ink), [Coloring book sample](https://aka.ms/cpubsample-coloringbook), [Family notes sample](https://aka.ms/cpubsample-familynotessample)
