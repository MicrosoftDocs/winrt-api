---
-api-id: P:Windows.Networking.NetworkOperators.UssdReply.Message
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.Networking.NetworkOperators.UssdMessage Message { get; }
-->

# Windows.Networking.NetworkOperators.UssdReply.Message

## -description
Gets the message for the USSD response.

> [!NOTE]
> This functionality is available only to mobile operator apps and UWP apps given privileged access by mobile network operators.
> 
> If you want to use this API and publish your app to the Microsoft Store, then you'll need special approval. For more information, see the **Restricted capabilities** section in the [App capability declarations](/windows/uwp/packaging/app-capability-declarations#restricted-capabilities) topic. 

## -property-value
The message for the USSD response.

## -remarks
A message is present only if the [ResultCode](ussdreply_resultcode.md) property returns **ActionRequired** or **NoActionRequired**; otherwise the Message property returns **null**.

## -examples

## -see-also

## -capabilities
cellularDeviceIdentity, cellularDeviceControl
