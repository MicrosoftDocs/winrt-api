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
Sets the raw payload of this [UssdMessage](ussdmessage_ussdmessage_290278668.md).

> [!NOTE]
> This functionality is only available to mobile operator apps and UWP apps given privileged access by mobile network operators.



> If you want to use this API and publish your app to the Store, you will need special approval. For more information, see the **Special and restricted capabilities** section under [App capability declarations](https://docs.microsoft.com/windows/uwp/packaging/app-capability-declarations). 

## -parameters
### -param value
The raw payload of this [UssdMessage](ussdmessage_ussdmessage_290278668.md).

## -remarks
When you set the raw payload for a [UssdMessage](ussdmessage.md), you must first set the [DataCodingScheme](ussdmessage_datacodingscheme.md) property to the encoding scheme for the message. If you do not set the [DataCodingScheme](ussdmessage_datacodingscheme.md) property, the default coding scheme is used.

If you use the default coding scheme, you can access the payload as text using the [PayloadAsText](ussdmessage_payloadastext.md) property.

The maximum size of the raw payload is 160 bytes.

## -examples

## -see-also

## -capabilities
cellularDeviceIdentity, cellularDeviceControl
