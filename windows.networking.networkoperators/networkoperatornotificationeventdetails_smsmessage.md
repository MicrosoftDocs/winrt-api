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
> This functionality is only available to mobile operator apps and UWP apps given privileged access by mobile network operators.



> If you want to use this API and publish your app to the Store, you will need special approval. For more information, see the **Special and restricted capabilities** section under [App capability declarations](/windows/uwp/packaging/app-capability-declarations). 

## -property-value
If the network operator notification is triggered by a new mobile network operator SMS, it contains the SMS message object for the network operator notification. **NULL** if no SMS message was received as part of the notification.

## -remarks

## -examples

## -see-also

## -capabilities
cellularDeviceIdentity, cellularDeviceControl
