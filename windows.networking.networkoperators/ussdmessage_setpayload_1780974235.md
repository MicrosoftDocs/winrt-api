---
-api-id: M:Windows.Networking.NetworkOperators.UssdMessage.SetPayload(System.Byte[])
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public void SetPayload(System.Byte[] value)
-->

# Windows.Networking.NetworkOperators.UssdMessage.SetPayload

## -description
Sets the raw payload of this [UssdMessage](ussdmessage_ussdmessage.md).

> [!NOTE]
> This functionality is only available to mobile operator apps and Windows Store app given privileged access by mobile network operators.

For permission to use this API, please reach out to [Network Operators API Permissions](mailto:netopperm@microsoft.com).

For technical help with this API, please reach out to [Network Operators API Help](mailto:netophelp@microsoft.com)

## -parameters
### -param value
The raw payload of this [UssdMessage](ussdmessage_ussdmessage.md).

## -remarks
When you set the raw payload for a [UssdMessage](ussdmessage.md), you must first set the [DataCodingScheme](ussdmessage_datacodingscheme.md) property to the encoding scheme for the message. If you do not set the [DataCodingScheme](ussdmessage_datacodingscheme.md) property, the default coding scheme is used.

If you use the default coding scheme, you can access the payload as text using the [PayloadAsText](ussdmessage_payloadastext.md) property.

The maximum size of the raw payload is 160 bytes.

## -examples

## -see-also
