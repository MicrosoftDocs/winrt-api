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
Gets or sets the encoding scheme of the payload of this [UssdMessage](ussdmessage_ussdmessage_290278668.md).

> [!NOTE]
> This functionality is available only to mobile operator apps and UWP apps given privileged access by mobile network operators.
> 
> If you want to use this API and publish your app to the Microsoft Store, then you'll need special approval. For more information, see the **Restricted capabilities** section in the [App capability declarations](/windows/uwp/packaging/app-capability-declarations#restricted-capabilities) topic. 

## -property-value
The encoding scheme of the payload of this [UssdMessage](ussdmessage_ussdmessage_290278668.md).

## -remarks
The data coding scheme is part of the USSD protocol. It is defined in 3GPP TS 23.038 chapter 5, *CBS Data Coding Scheme*
<!--Should/can we provide a link to the referenced document?-->
.

When a message is encoded in the default coding scheme, you can access the payload as text using the [PayloadAsText](ussdmessage_payloadastext.md) property.

## -examples

## -see-also

## -capabilities
cellularDeviceIdentity, cellularDeviceControl
