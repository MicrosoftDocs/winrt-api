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
Creates a new instance of a [UssdMessage](ussdmessage_ussdmessage.md) and encodes the supplied string into the message payload.

> [!NOTE]
> This functionality is only available to mobile operator apps and Windows Store app given privileged access by mobile network operators.

For permission to use this API, please reach out to [Network Operators API Permissions](mailto:netopperm@microsoft.com).

For technical help with this API, please reach out to [Network Operators API Help](mailto:netophelp@microsoft.com)

## -parameters
### -param messageText
The payload for the [UssdMessage](ussdmessage_ussdmessage.md).

## -remarks
The default [UssdMessage](ussdmessage_ussdmessage.md) constructor assigns the default [DataCodingScheme](ussdmessage_datacodingscheme.md) value and encodes the string supplied to the constructor into the message payload.

## -examples

## -see-also
