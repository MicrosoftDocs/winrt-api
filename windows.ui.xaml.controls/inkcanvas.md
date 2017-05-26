---
-api-id: T:Windows.UI.Xaml.Controls.InkCanvas
-api-type: winrt class
---

<!-- Class syntax.
public class InkCanvas : Windows.UI.Xaml.FrameworkElement, Windows.UI.Xaml.Controls.IInkCanvas
-->

# Windows.UI.Xaml.Controls.InkCanvas

## -description
Defines an area that receives and displays all pen input as either an ink stroke or an erase stroke (input from an eraser tip, or the pen tip when modified with an erase button).

## -xaml-syntax
```xaml
<InkCanvas .../>
```

## -remarks
By default, the [InkCanvas](inkcanvas.md) does not support ink input from devices other than pen. You must specify support for other devices through the [InputDeviceTypes](../windows.ui.input.inking/inkpresenter_inputdevicetypes.md) of an [InkPresenter](../windows.ui.input.inking/inkpresenter.md) object.

Associate an [InkToolbar](inktoolbar.md) with an [InkCanvas](inkcanvas.md) to provide a customizable and extensible collection of buttons that activate ink-related features in the [InkCanvas](inkcanvas.md). By default, the toolbar includes buttons for drawing, erasing, highlighting, and displaying a ruler.

An [InkCanvas](inkcanvas_inkcanvas.md) control is bound to a single instance of an [InkPresenter](../windows.ui.input.inking/inkpresenter.md) object (exposed through the [InkPresenter](inkcanvas_inkpresenter.md) property). This object provides all default inking functionality exposed by the [InkCanvas](inkcanvas.md), along with a comprehensive set of APIs for additional customization.

The configuration of the [InkPresenter](../windows.ui.input.inking/inkpresenter.md) determines the pointer event handling behavior of the InkCanvas. You must set [InkPresenter.InputDeviceTypes](../windows.ui.input.inking/inkpresenter_inputdevicetypes.md) to [CoreInputDeviceTypes.None](../windows.ui.input.inking/coreinputdevicetypes.md) for the [InkCanvas](inkcanvas_inkcanvas.md) to process pointer events, otherwise they are passed to the [InkPresenter](../windows.ui.input.inking/inkpresenter.md) object. 

To handle pointer events with the InkPresenter object, you must set [RightDragAction](../windows.ui.input.inking/inkinputprocessingconfiguration_rightdragaction.md) to [LeaveUnprocessed](../windows.ui.input.inking/inkinputrightdragaction.md) to pass the input through as [UnprocessedInput](../windows.ui.input.inking/inkpresenter_unprocessedinput.md) for custom processing by your app.

> [!IMPORTANT]
> The [InkPresenter](../windows.ui.input.inking/inkpresenter.md) cannot be instantiated directly.

## -examples

## -see-also
[Pen and stylus interactions](http://msdn.microsoft.com/library/3da4f2d2-5405-42a1-9ed9-3a87bcd84c43)

[Add an InkToolbar to a Universal Windows Platform (UWP) app](https://docs.microsoft.com/windows/uwp/input-and-devices/ink-toolbar)

[Get Started Tutorial: Support ink in your UWP app](https://docs.microsoft.com/windows/uwp/get-started/ink-walkthrough)

### Reference
[FrameworkElement](../windows.ui.xaml/frameworkelement.md), [InkToolbar](inktoolbar.md)

### Samples
* [Simple ink sample (C#/C++)](http://go.microsoft.com/fwlink/p/?LinkID=620312)
* [Complex ink sample (C++)](http://go.microsoft.com/fwlink/p/?LinkID=620314)
* [Ink sample (JavaScript)](http://go.microsoft.com/fwlink/p/?LinkID=620308)
* [Get Started Tutorial: Support ink in your UWP app](https://aka.ms/appsample-ink)
* [Coloring book sample](https://aka.ms/cpubsample-coloringbook)
* [Family notes sample](https://aka.ms/cpubsample-familynotessample)
