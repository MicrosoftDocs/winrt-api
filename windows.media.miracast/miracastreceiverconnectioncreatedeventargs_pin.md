---
-api-id: P:Windows.Media.Miracast.MiracastReceiverConnectionCreatedEventArgs.Pin
-api-type: winrt property
ms.custom: 19H1
---

<!-- Property syntax.
public string Pin { get; }
-->

# Windows.Media.Miracast.MiracastReceiverConnectionCreatedEventArgs.Pin

## -description

Getes the PIN that must be entered by the Miracast Transmitter device, or an empty string if PIN authentication is not in use.

## -property-value

The PIN, or an empty string if PIN authentication is not used.

## -remarks

If the string is not empty, the app should display the PIN so that it can be entered on the Miracast Transmitter device.
The connection will be automatically disconnected if the PIN is not entered by the Miracast Transmitter in approximately 30 seconds.

## -see-also

## -examples

