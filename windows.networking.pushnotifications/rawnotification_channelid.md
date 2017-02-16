---
-api-id: P:Windows.Networking.PushNotifications.RawNotification.ChannelId
-api-type: winrt property
---

<!-- Property syntax.
public string ChannelId { get; }
-->

# Windows.Networking.PushNotifications.RawNotification.ChannelId

## -description
Gets the Channel ID of the raw notification.

## -property-value
A string that contains the app-defined Channel ID, as set by the app server.

## -remarks
This is only valid for notifications sent over a channel created by [CreateRawPushNotificationChannelWithAlternateKeyForApplicationAsync](pushnotificationchannelmanagerforuser_createrawpushnotificationchannelwithalternatekeyforapplicationasync_769979127.md). If notification are sent over a channel created with [CreatePushNotificationChannelForApplicationAsync](pushnotificationchannelmanagerforuser_createpushnotificationchannelforapplicationasync_1900738870.md), this will be null.

## -see-also

## -examples

