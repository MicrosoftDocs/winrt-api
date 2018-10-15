---
-api-id: P:Windows.UI.Input.PointerPoint.RawPosition
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Point RawPosition { get; }
-->

# Windows.UI.Input.PointerPoint.RawPosition

## -description

Gets the client coordinates of the input pointer as reported by the input device.

## -property-value

The client coordinates, in device-independent pixels (DIP).

## -remarks

Under some circumstances, such as touch targeting near a [UIElement](../windows.ui.xaml/uielement.md), this data might be modified by the system.

If your app supports complex inking, where accuracy and performance is critical, we recommend using the [RawPosition](pointerpoint_rawposition.md) data to handle input prediction when managing hardware or message latency due to delays in sensing and processing of the pointer location on the digitizer.

See [Position](pointerpoint_position.md) for more information on handling modified input data.

## -examples

## -see-also

[Position](pointerpoint_position.md)