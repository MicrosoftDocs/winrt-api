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
Gets the raw payload of this [UssdMessage](ussdmessage_ussdmessage_290278668.md).

> [!NOTE]
> This functionality is available only to mobile operator apps and UWP apps given privileged access by mobile network operators.
> 
> If you want to use this API and publish your app to the Microsoft Store, then you'll need special approval. For more information, see the **Restricted capabilities** section in the [App capability declarations](/windows/uwp/packaging/app-capability-declarations#restricted-capabilities) topic. 

## -returns
The raw payload of this [UssdMessage](ussdmessage_ussdmessage_290278668.md).

## -remarks
The [DataCodingScheme](ussdmessage_datacodingscheme.md) property identifies how the payload is encoded.

The maximum size of the raw payload is 160 bytes.

## -examples

## -see-also

## -capabilities
cellularDeviceIdentity, cellularDeviceControl
