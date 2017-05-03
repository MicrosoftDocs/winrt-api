---
-api-id: P:Windows.UI.Input.Inking.InkPresenter.InputDeviceTypes
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.UI.Core.CoreInputDeviceTypes InputDeviceTypes { get;  set; }
-->

# Windows.UI.Input.Inking.InkPresenter.InputDeviceTypes

## -description
Gets or sets the input device type from which input data is collected by the [InkPresenter](inkpresenter.md) to construct and render an [InkStroke](inkstroke.md). The default is [Pen](../windows.ui.core/coreinputdevicetypes.md).

## -property-value
The input device types.

## -remarks
If you set this property to [None](../windows.ui.core/coreinputdevicetypes.md), you should remove listeners for all pointer events, including [PointerEntered](inkunprocessedinput_pointerentered.md), [PointerHovered](inkunprocessedinput_pointerhovered.md), and [PointerExited](inkunprocessedinput_pointerexited.md). In this case, pointer events are passed to the InkCanvas object and not to the InkPresenter object through [InkPresenter.UnprocessedInput](inkpresenter_unprocessedinput.md).

## -examples
Here we specify that data from all supported input devices ([CoreInputDeviceTypes](../windows.ui.core/coreinputdevicetypes.md)) be collected by the [InkPresenter](inkpresenter.md) and processed as ink input.

```csharp
inkCanvas.InkPresenter.InputDeviceTypes = 
  Windows.UI.Core.CoreInputDeviceTypes.Mouse | 
  Windows.UI.Core.CoreInputDeviceTypes.Pen | 
  Windows.UI.Core.CoreInputDeviceTypes.Touch;

```



## -see-also
[Pen and stylus interactions](http://msdn.microsoft.com/library/3da4f2d2-5405-42a1-9ed9-3a87bcd84c43), [Ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620308), [Simple ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620312), [Complex ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620314)