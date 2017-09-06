---
-api-id: T:Windows.UI.Xaml.Controls.InkToolbarToggleButton
-api-type: winrt class
---

<!-- Class syntax.
public class InkToolbarToggleButton : Windows.UI.Xaml.Controls.CheckBox, Windows.UI.Xaml.Controls.IInkToolbarToggleButton
-->

# Windows.UI.Xaml.Controls.InkToolbarToggleButton

## -description
Represents an object that provides infrastructure for both built-in and custom toggle buttons on an [InkToolbar](inktoolbar.md).

## -remarks

The [InkToolbarToggleButton](inktoolbartogglebutton.md) class cannot be instantiated directly. For user interface purposes, treat [InkToolbarToggleButton](inktoolbartogglebutton.md) as an abstract base class. Use the various built-in and custom [InkToolbar](inktoolbar.md) buttons instead.

By default, the [InkToolbar](inktoolbar.md) contains the following built-in buttons:
Radio group toggle buttons

+ [InkToolbarBallpointPenButton](inktoolbarballpointpenbutton.md)
+ [InkToolbarPencilButton](inktoolbarpencilbutton.md)
+ [InkToolbarHighlighterButton](inktoolbarhighlighterbutton.md)
+ [InkToolbarEraserButton](inktoolbareraserbutton.md)

Standalone toggle button

+ [InkToolbarRulerButton](inktoolbarrulerbutton.md)


### **InkToolbarToggleButton** derived classes

[InkToolbarToggleButton](inktoolbartogglebutton.md) is the base class for:

Standalone toggle button (built-in)

+ [InkToolbarRulerButton](inktoolbarrulerbutton.md)

Custom toggle buttons

+ [InkToolbarCustomToggleButton](inktoolbarcustomtogglebutton.md)


## -examples

## -see-also
[Pen and stylus interactions](http://msdn.microsoft.com/library/3da4f2d2-5405-42a1-9ed9-3a87bcd84c43), [Add an InkToolbar to a Universal Windows Platform (UWP) app](https://docs.microsoft.com/windows/uwp/input-and-devices/ink-toolbar), [Get Started Tutorial: Support ink in your UWP app](https://docs.microsoft.com/windows/uwp/get-started/ink-walkthrough), [CheckBox](checkbox.md), [Ink sample (JavaScript)](http://go.microsoft.com/fwlink/p/?LinkID=620308), [Get Started Tutorial: Support ink in your UWP app](https://aka.ms/appsample-ink), [Coloring book sample](https://aka.ms/cpubsample-coloringbook), [Family notes sample](https://aka.ms/cpubsample-familynotessample)
