---
-api-id: P:Windows.Networking.NetworkOperators.UssdMessage.DataCodingScheme
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public byte DataCodingScheme { get;  set; }
-->

# Windows.Networking.NetworkOperators.UssdMessage.DataCodingScheme

## -description
Gets or sets the encoding scheme of the payload of this [UssdMessage](ussdmessage_ussdmessage.md).

> [!NOTE]
> This functionality is only available to mobile operator apps and Windows Store app given privileged access by mobile network operators.

For permission to use this API, please reach out to [Network Operators API Permissions](mailto:netopperm@microsoft.com).

For technical help with this API, please reach out to [Network Operators API Help](mailto:netophelp@microsoft.com)

## -property-value
The encoding scheme of the payload of this [UssdMessage](ussdmessage_ussdmessage.md).

## -remarks
The data coding scheme is part of the USSD protocol. It is defined in 3GPP TS 23.038 chapter 5, *CBS Data Coding Scheme*
<!--Should/can we provide a link to the referenced document?-->
.

When a message is encoded in the default coding scheme, you can access the payload as text using the [PayloadAsText](ussdmessage_payloadastext.md) property.

## -examples

## -see-also
