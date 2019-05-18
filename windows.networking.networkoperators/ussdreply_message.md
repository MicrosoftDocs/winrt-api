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
> This functionality is only available to mobile operator apps and UWP apps given privileged access by mobile network operators.



> If you want to use this API and publish your app to the Store, you will need special approval. For more information, see the **Special and restricted capabilities** section under [App capability declarations](https://docs.microsoft.com/windows/uwp/packaging/app-capability-declarations). 

## -property-value
The message for the USSD response.

## -remarks
A message is present only if the [ResultCode](ussdreply_resultcode.md) property returns **ActionRequired** or **NoActionRequired**; otherwise the Message property returns **null**.

## -examples

## -see-also

## -capabilities
cellularDeviceIdentity, cellularDeviceControl
