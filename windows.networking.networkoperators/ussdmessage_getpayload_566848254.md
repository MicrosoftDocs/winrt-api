---
-api-id: M:Windows.Networking.NetworkOperators.UssdMessage.GetPayload
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public byte[] GetPayload()
-->

# Windows.Networking.NetworkOperators.UssdMessage.GetPayload

## -description
Gets the raw payload of this [UssdMessage](ussdmessage_ussdmessage.md).

> [!NOTE]
> This functionality is only available to mobile operator apps and Windows Store app given privileged access by mobile network operators.

For permission to use this API, please reach out to [Network Operators API Permissions](mailto:netopperm@microsoft.com).

For technical help with this API, please reach out to [Network Operators API Help](mailto:netophelp@microsoft.com)

## -returns
The raw payload of this [UssdMessage](ussdmessage_ussdmessage.md).

## -remarks
The [DataCodingScheme](ussdmessage_datacodingscheme.md) property identifies how the payload is encoded.

The maximum size of the raw payload is 160 bytes.

## -examples

## -see-also
