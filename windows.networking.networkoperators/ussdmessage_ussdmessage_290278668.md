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
Creates a new instance of a [UssdMessage](ussdmessage_ussdmessage_290278668.md) and encodes the supplied string into the message payload.

> [!NOTE]
> This functionality is only available to mobile operator apps and UWP apps given privileged access by mobile network operators.



> If you want to use this API and publish your app to the Store, you will need special approval. For more information, see the **Special and restricted capabilities** section under [App capability declarations](https://docs.microsoft.com/windows/uwp/packaging/app-capability-declarations). 

## -parameters
### -param messageText
The payload for the [UssdMessage](ussdmessage_ussdmessage_290278668.md).

## -remarks
The default [UssdMessage](ussdmessage_ussdmessage_290278668.md) constructor assigns the default [DataCodingScheme](ussdmessage_datacodingscheme.md) value and encodes the string supplied to the constructor into the message payload.

## -examples

## -see-also

## -capabilities
cellularDeviceIdentity, cellularDeviceControl
