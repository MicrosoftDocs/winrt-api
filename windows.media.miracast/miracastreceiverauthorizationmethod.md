---
-api-id: T:Windows.Media.Miracast.MiracastReceiverAuthorizationMethod
-api-type: winrt enum
ms.custom: 19H1
---

<!-- Enumeration syntax.
public enum MiracastReceiverAuthorizationMethod : int 
-->

# Windows.Media.Miracast.MiracastReceiverAuthorizationMethod

## -description

Specifies the method used to authorize incoming Miracast connections.

## -enum-fields
### -field PinDisplayRequired:3

The Miracast Receiver will display a PIN and the Miracast transmitter must enter it.

### -field PinDisplayIfRequested:2

The Miracast Receiver will display a PIN only if the Miracast transmitter requests the use of a PIN.

### -field None:0

Automatically accept new Miracast connections.

### -field ConfirmConnection:1

The Miracast Receiver will ask the user to accept or reject the incoming connection.

## -remarks

## -see-also

## -examples

