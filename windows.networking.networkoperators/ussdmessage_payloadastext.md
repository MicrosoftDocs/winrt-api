---
-api-id: P:Windows.Networking.NetworkOperators.UssdMessage.PayloadAsText
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public string PayloadAsText { get;  set; }
-->

# Windows.Networking.NetworkOperators.UssdMessage.PayloadAsText

## -description
Gets or sets the payload of this [UssdMessage](ussdmessage_ussdmessage_290278668.md) as text.

> [!NOTE]
> This functionality is available only to mobile operator apps and UWP apps given privileged access by mobile network operators.
> 
> If you want to use this API and publish your app to the Microsoft Store, then you'll need special approval. For more information, see the **Restricted capabilities** section in the [App capability declarations](/windows/uwp/packaging/app-capability-declarations#restricted-capabilities) topic. 

## -property-value
The payload of this [UssdMessage](ussdmessage_ussdmessage_290278668.md) as text.

## -remarks
The PayloadAsText property can be used with the default [DataCodingScheme](ussdmessage_datacodingscheme.md) value, which supports only ASCII characters. The maximum length of a message is using the default data-coding scheme is 182 characters.

## -examples

## -see-also

## -capabilities
cellularDeviceIdentity, cellularDeviceControl
