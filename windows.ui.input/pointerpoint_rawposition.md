---
-api-id: P:Windows.UI.Input.PointerPoint.RawPosition
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Point RawPosition { get; }
-->

# Windows.UI.Input.PointerPoint.RawPosition

## -description
Gets the raw location of the pointer input in client coordinates.

## -property-value
The client coordinates, in device-independent pixel (DIP).

## -remarks
[RawPosition](pointerpoint_rawposition.md) contains the client coordinates of the input pointer as reported by the input device. Under some circumstances, such as input prediction, this data can be modified by the system to compensate for hardware latency or message latency due to inherent delays in sensing and processing the pointer location on the digitizer.

See [Position](pointerpoint_position.md) for more information on handling modified input data.

## -examples

## -see-also
[Position](pointerpoint_position.md)