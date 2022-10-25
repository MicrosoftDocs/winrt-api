---
-api-id: M:Windows.Networking.NetworkOperators.UssdMessage.#ctor(System.String)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public UssdMessage(System.String messageText)
-->

# Windows.Networking.NetworkOperators.UssdMessage.UssdMessage

## -description
Creates a new instance of a UssdMessage and encodes the supplied string into the message payload.

> [!NOTE]
> This functionality is available only to mobile operator apps and UWP apps given privileged access by mobile network operators.
> 
> If you want to use this API and publish your app to the Microsoft Store, then you'll need special approval. For more information, see the **Restricted capabilities** section in the [App capability declarations](/windows/uwp/packaging/app-capability-declarations#restricted-capabilities) topic. 

## -parameters
### -param messageText
The payload for the UssdMessage.

## -remarks
The default UssdMessage constructor assigns the default [DataCodingScheme](ussdmessage_datacodingscheme.md) value and encodes the string supplied to the constructor into the message payload.

## -examples

## -see-also

## -capabilities
cellularDeviceIdentity, cellularDeviceControl
