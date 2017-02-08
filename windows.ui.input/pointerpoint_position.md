---
-api-id: P:Windows.UI.Input.PointerPoint.Position
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Point Position { get; }
-->

# Windows.UI.Input.PointerPoint.Position

## -description
Gets the location of the pointer input in client coordinates.

## -property-value
The client coordinates, in device-independent pixel (DIP).

## -remarks
[Position](pointerpoint_position.md) contains the client coordinates of the pointer input as interpreted by the system. Under some circumstances, such as input prediction, this data can be modified by the system to compensate for hardware latency or message latency due to inherent delays in sensing and processing the pointer location on the digitizer.

See [RawPosition](pointerpoint_rawposition.md) for information on handling raw input data.

## -examples

## -see-also
[RawPosition](pointerpoint_rawposition.md)