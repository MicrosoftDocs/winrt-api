---
-api-id: T:Windows.Networking.NetworkOperators.UssdResultCode
-api-type: winrt enum
-api-device-family-note: xbox
---

<!-- Enumeration syntax
public enum Windows.Networking.NetworkOperators.UssdResultCode : int
-->

# UssdResultCode

## -description
Describes the USSD response codes for messages sent to the network.

> [!NOTE]
> This functionality is available only to mobile operator apps and UWP apps given privileged access by mobile network operators.
> 
> If you want to use this API and publish your app to the Microsoft Store, then you'll need special approval. For more information, see the **Restricted capabilities** section in the [App capability declarations](/windows/uwp/packaging/app-capability-declarations#restricted-capabilities) topic. 

## -enum-fields
### -field NoActionRequired:0
The USSD message that was received is either a USSD notification from the network or a response to an earlier request. No further information is necessary. The USSD session is closed.

### -field ActionRequired:1
The USSD message that was received is either a USSD request from the network or a response to a message sent to the network. Additional information is needed. The USSD session is open.

### -field Terminated:2
The USSD session has been terminated by the network or a local client.

### -field OtherLocalClient:3
The previous USSD request failed because another local client has an active USSD session.

### -field OperationNotSupported:4
The previous USSD request failed because the request was invalid or cannot be handled by the driver, device, or network.

### -field NetworkTimeout:5
The USSD session has been closed because there was no response from the network.


## -remarks

## -examples

## -see-also
## -capabilities
cellularDeviceIdentity, cellularDeviceControl
