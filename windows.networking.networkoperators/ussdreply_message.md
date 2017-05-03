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
> This functionality is only available to mobile operator apps and Windows Store app given privileged access by mobile network operators.

For permission to use this API, please reach out to [Network Operators API Permissions](mailto:netopperm@microsoft.com).

For technical help with this API, please reach out to [Network Operators API Help](mailto:netophelp@microsoft.com)

## -property-value
The message for the USSD response.

## -remarks
A message is present only if the [ResultCode](ussdreply_resultcode.md) property returns **ActionRequired** or **NoActionRequired**; otherwise the [Message](ussdreply_message.md) property returns **null**.

## -examples

## -see-also
