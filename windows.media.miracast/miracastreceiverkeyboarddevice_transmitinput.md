---
-api-id: P:Windows.Media.Miracast.MiracastReceiverKeyboardDevice.TransmitInput
-api-type: winrt property
ms.custom: 19H1
---

<!-- Property syntax.
public bool TransmitInput { get;  set; }
-->

# Windows.Media.Miracast.MiracastReceiverKeyboardDevice.TransmitInput

## -description

Controls if the Miracast Receiver offers to transmit keyboard input to the Miracast Transmitter.

## -property-value

True if the Miracast Receiver offers to transmit keyboard input to the Miracast Transmitter.

## -remarks

Keyboard input will only be transmitted if the device on which the Miracast Receiver is running supports capturing keyboard input, and if the Miracast Transmitter is requesting to receive keyboard input.
Use [IsTransmittingInput](miracastreceiverkeyboarddevice_istransmittinginput.md) to determine if keyboard input is actually being transmitted.

## -see-also

[IsTransmittingInput](miracastreceiverkeyboarddevice_istransmittinginput.md)

## -examples

