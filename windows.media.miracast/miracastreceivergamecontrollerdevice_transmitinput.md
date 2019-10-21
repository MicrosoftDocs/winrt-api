---
-api-id: P:Windows.Media.Miracast.MiracastReceiverGameControllerDevice.TransmitInput
-api-type: winrt property
ms.custom: 19H1
---

<!-- Property syntax.
public bool TransmitInput { get;  set; }
-->

# Windows.Media.Miracast.MiracastReceiverGameControllerDevice.TransmitInput

## -description

Controls if the Miracast Receiver offers to transmit game controller input to the Miracast Transmitter.

## -property-value

True if the Miracast Receiver offers to transmit game controller input to the Miracast Transmitter.

## -remarks

Game controller input will only be transmitted if the device on which the Miracast Receiver is running supports capturing game controller input, and if the Miracast Transmitter is requesting to receive game controller input.
Use [IsTransmittingInput](miracastreceivergamecontrollerdevice_istransmittinginput.md) to determine if game controller input is actually being transmitted.

## -see-also

[IsTransmittingInput](miracastreceivergamecontrollerdevice_istransmittinginput.md)

## -examples

