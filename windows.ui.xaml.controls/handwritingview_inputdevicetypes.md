---
-api-id: P:Windows.UI.Xaml.Controls.HandwritingView.InputDeviceTypes
-api-type: winrt property
---

# Windows.UI.Xaml.Controls.HandwritingView.InputDeviceTypes

<!--
public Windows.UI.Core.CoreInputDeviceTypes InputDeviceTypes { get; set; }
-->

## -description

Gets or sets the input device type from which input data is collected by the [HandwritingView](handwritingview.md) to construct and render an [InkStroke](../windows.ui.input.inking/inkstroke.md). The default is [Pen](../windows.ui.core/coreinputdevicetypes.md).

## -property-value

The input device types.

## -remarks

## -see-also

## -examples

Here we specify that data from all supported input devices ([CoreInputDeviceTypes](../windows.ui.core/coreinputdevicetypes.md)) be collected by the [HandwritingView](handwritingview.md) and processed as ink input.

```csharp
handwritingView.InputDeviceTypes =
  Windows.UI.Core.CoreInputDeviceTypes.Mouse |
  Windows.UI.Core.CoreInputDeviceTypes.Pen |
  Windows.UI.Core.CoreInputDeviceTypes.Touch;

```
