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

An InkCanvas has default Height and Width properties of zero, unless it is the child of an element that automatically sizes its child elements, such as [StackPanel](stackpanel.md) or [Grid](grid.md) controls.

InkCanvas has maximum height and width dimensions of 2^21 physical pixels.

By default, the InkCanvas does not support ink input from devices other than pen. You must specify support for other devices through the [InputDeviceTypes](../windows.ui.input.inking/inkpresenter_inputdevicetypes.md) of an [InkPresenter](../windows.ui.input.inking/inkpresenter.md) object.

Associate an [InkToolbar](inktoolbar.md) with an InkCanvas to provide a customizable and extensible collection of buttons that activate ink-related features in the InkCanvas. By default, the toolbar includes buttons for drawing, erasing, highlighting, and displaying a ruler.

An [InkCanvas](inkcanvas_inkcanvas_1221375020.md) control is bound to a single instance of an [InkPresenter](../windows.ui.input.inking/inkpresenter.md) object (exposed through the [InkPresenter](inkcanvas_inkpresenter.md) property). This object provides all default inking functionality exposed by the InkCanvas, along with a comprehensive set of APIs for additional customization.

The configuration of the [InkPresenter](../windows.ui.input.inking/inkpresenter.md) determines the pointer event handling behavior of the InkCanvas. You must set [InkPresenter.InputDeviceTypes](../windows.ui.input.inking/inkpresenter_inputdevicetypes.md) to [CoreInputDeviceTypes.None](../windows.ui.core/coreinputdevicetypes.md) for the [InkCanvas](inkcanvas_inkcanvas_1221375020.md) to process pointer events, otherwise they are passed to the [InkPresenter](../windows.ui.input.inking/inkpresenter.md) object. 

To handle pointer events with the InkPresenter object, you must set [RightDragAction](../windows.ui.input.inking/inkinputprocessingconfiguration_rightdragaction.md) to [LeaveUnprocessed](../windows.ui.input.inking/inkinputrightdragaction.md) to pass the input through as [UnprocessedInput](../windows.ui.input.inking/inkpresenter_unprocessedinput.md) for custom processing by your app.

The InkCanvas control doesn't work if a [Transform3D](../windows.ui.xaml/uielement_transform3d.md) is set on the control or on any element in the XAML tree above the control.

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Inking controls](/windows/uwp/design/controls-and-patterns/inking-controls).
>
> If you have the **WinUI 2 Gallery** app installed, click here to [open the app and see the InkCanvas in action](winui2gallery:/item/InkCanvas).
> + [Get the WinUI 2 Gallery app (Microsoft Store)](https://www.microsoft.com/store/productId/9MSVH128X2ZT)
> + [Get the source code (GitHub)](https://github.com/Microsoft/WinUI-Gallery)

## -see-also

[Pen and stylus interactions](/windows/uwp/input-and-devices/pen-and-stylus-interactions), [Add an InkToolbar to a Universal Windows Platform (UWP) app](/windows/uwp/input-and-devices/ink-toolbar), [Get Started Tutorial: Support ink in your UWP app](/windows/uwp/get-started/ink-walkthrough), [FrameworkElement](../windows.ui.xaml/frameworkelement.md), [InkToolbar](inktoolbar.md), [Simple ink sample (C#/C++)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SimpleInk), [Complex ink sample (C++)](https://go.microsoft.com/fwlink/p/?LinkID=620314), [Get Started Tutorial: Support ink in your UWP app](https://aka.ms/appsample-ink), [Coloring book sample](https://aka.ms/cpubsample-coloringbook), [Family notes sample](https://aka.ms/cpubsample-familynotessample)
