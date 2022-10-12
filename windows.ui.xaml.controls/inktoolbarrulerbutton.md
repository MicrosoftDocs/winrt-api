---
-api-id: T:Windows.UI.Xaml.Controls.InkToolbarRulerButton
-api-type: winrt class
---

<!-- Class syntax.
public class InkToolbarRulerButton : Windows.UI.Xaml.Controls.InkToolbarToggleButton, Windows.UI.Xaml.Controls.IInkToolbarRulerButton
-->

# Windows.UI.Xaml.Controls.InkToolbarRulerButton

## -description

Represents an [InkToolbar](inktoolbar.md) button that sets the state of the built-in ruler tool to on or off.

## -remarks
Apps that target Windows Creators Update (SDK 15063) or later should use the [InkToolbarStencilButton](inktoolbarstencilbutton.md) object instead of this object. If your app also supports previous versions, see [Version adaptive apps: Use new APIs while maintaining compatibility with previous versions](/windows/uwp/debug-test-perf/version-adaptive-apps) for more info.

The [InkToolbar](inktoolbar.md) consists of two distinct groups of button types:

+ One group of "tool" buttons containing the built-in drawing ([InkToolbarBallpointPenButton](inktoolbarballpointpenbutton.md), [InkToolbarPencilButton](inktoolbarpencilbutton.md)), erasing ([InkToolbarEraserButton](inktoolbareraserbutton.md)), and highlighting ([InkToolbarHighlighterButton](inktoolbarhighlighterbutton.md)) buttons. Custom tools ([InkToolbarCustomPenButton](inktoolbarcustompenbutton.md) and [InkToolbarCustomToolButton](inktoolbarcustomtoolbutton.md)) are added here.

    > Feature selection is mutually exclusive.

+ A second group of "toggle" buttons containing the built-in stencil ([InkToolbarStencilButton](inktoolbarstencilbutton.md)) button (or the InkToolbarRulerButton button). Custom toggles ([InkToolbarCustomToggleButton](inktoolbarcustomtogglebutton.md)) are added here.

    > Features are not mutually exclusive and can be used concurrently with other active tools.

## -examples

## -see-also
[Pen and stylus interactions](/windows/uwp/input-and-devices/pen-and-stylus-interactions), [Add an InkToolbar to a Universal Windows Platform (UWP) app](/windows/uwp/input-and-devices/ink-toolbar), [Get Started Tutorial: Support ink in your UWP app](/windows/uwp/get-started/ink-walkthrough), [InkToolbarToggleButton](inktoolbartogglebutton.md), [IsRulerButtonChecked](inktoolbar_isrulerbuttonchecked.md), [IsRulerButtonCheckedChanged](inktoolbar_isrulerbuttoncheckedchanged.md), [Ink sample (JavaScript)](https://github.com/microsoft/Windows-universal-samples/tree/main/archived/Ink), [Get Started Tutorial: Support ink in your UWP app](https://aka.ms/appsample-ink), [Coloring book sample](https://aka.ms/cpubsample-coloringbook), [Family notes sample](https://aka.ms/cpubsample-familynotessample)
