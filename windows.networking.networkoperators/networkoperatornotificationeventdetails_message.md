---
-api-id: P:Windows.Networking.NetworkOperators.NetworkOperatorNotificationEventDetails.Message
-api-type: winrt property
---

<!-- Property syntax
public string Message { get; }
-->

# Windows.Networking.NetworkOperators.NetworkOperatorNotificationEventDetails.Message

## -description
Gets the message for the network operator notification.

> [!NOTE]
> This functionality is only available to mobile operator apps and Windows Store app given privileged access by mobile network operators.

For permission to use this API, please reach out to [Network Operators API Permissions](mailto:netopperm@microsoft.com).

For technical help with this API, please reach out to [Network Operators API Help](mailto:netophelp@microsoft.com)

## -property-value
The message for the network operator notification.

## -remarks
If the data-coding scheme is Unicode, the message is a plaintext string that has already been decoded. If it is an operator-defined scheme, the message is a hex-encoded string representing an array of bytes.

## -examples

## -see-also
