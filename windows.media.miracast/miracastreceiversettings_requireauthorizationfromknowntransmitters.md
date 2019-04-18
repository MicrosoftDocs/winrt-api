---
-api-id: P:Windows.Media.Miracast.MiracastReceiverSettings.RequireAuthorizationFromKnownTransmitters
-api-type: winrt property
ms.custom: 19H1
---

<!-- Property syntax.
public bool RequireAuthorizationFromKnownTransmitters { get;  set; }
-->

# Windows.Media.Miracast.MiracastReceiverSettings.RequireAuthorizationFromKnownTransmitters

## -description

Specifies if authorization should be required by Miracast Transmitters that are already known to the Miracast Receiver.

## -property-value

True if authorization should be required by Miracast Transmitters that are already known to the Miracast Receiver.

## -remarks

The authorization method is configured through [AuthorizationMethod](miracastreceiversettings_authorizationmethod.md). 
A Miracast Transmitter becomes known if a Miracast connection was received previously, and was not rejected.
Use [MiracastReceiver.RemoveKnownTransmitter](miracastreceiver_removeknowntransmitter_1355701555.md) and [MiracastReceiver.ClearKnownTransmitters](miracastreceiver_clearknowntransmitters_1513662921.md) to manage the list of known Miracast Transmitters.

## -see-also

[AuthorizationMethod](miracastreceiversettings_authorizationmethod.md),
[MiracastReceiverStatus.KnownTransmitters](miracastreceiverstatus_knowntransmitters.md),
[MiracastReceiver.RemoveKnownTransmitter](miracastreceiver_removeknowntransmitter_1355701555.md),
[MiracastReceiver.ClearKnownTransmitters](miracastreceiver_clearknowntransmitters_1513662921.md)

## -examples

