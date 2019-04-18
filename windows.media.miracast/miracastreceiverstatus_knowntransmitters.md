---
-api-id: P:Windows.Media.Miracast.MiracastReceiverStatus.KnownTransmitters
-api-type: winrt property
ms.custom: 19H1
---

<!-- Property syntax.
public IVectorView<MiracastTransmitter> KnownTransmitters { get; }
-->

# Windows.Media.Miracast.MiracastReceiverStatus.KnownTransmitters

## -description

Returns the collection of Miracast Transmitters that are currently known to the [MiracastReceiver](miracastreceiver.md).

## -property-value

The collection of Miracast Transmitters that are currently known to the Miracast Receiver.

## -remarks

A Miracast Transmitter becomes known if a Miracast connection was received previously, and was not rejected.
Use [MiracastReceiver.RemoveKnownTransmitter](miracastreceiver_removeknowntransmitter_1355701555.md) and [MiracastReceiver.ClearKnownTransmitters](miracastreceiver_clearknowntransmitters_1513662921.md) to manage the list of known Miracast Transmitters.

## -see-also

[MiracastReceiver.RemoveKnownTransmitter](miracastreceiver_removeknowntransmitter_1355701555.md),
[MiracastReceiver.ClearKnownTransmitters](miracastreceiver_clearknowntransmitters_1513662921.md)

## -examples

