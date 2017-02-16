---
-api-id: P:Windows.Networking.NetworkOperators.NetworkOperatorNotificationEventDetails.SmsMessage
-api-type: winrt property
---

<!-- Property syntax
public Windows.Devices.Sms.ISmsMessage SmsMessage { get; }
-->

# Windows.Networking.NetworkOperators.NetworkOperatorNotificationEventDetails.SmsMessage

## -description
Gets an SMS message for the mobile broadband account that received the notification.

> [!NOTE]
> This functionality is only available to mobile operator apps and Windows Store app given privileged access by mobile network operators.

For permission to use this API, please reach out to [Network Operators API Permissions](mailto:netopperm@microsoft.com).

For technical help with this API, please reach out to [Network Operators API Help](mailto:netophelp@microsoft.com)

## -property-value
If the network operator notification is triggered by a new mobile network operator SMS, it contains the SMS message object for the network operator notification. **NULL** if no SMS message was received as part of the notification.

## -remarks

## -examples

## -see-also
