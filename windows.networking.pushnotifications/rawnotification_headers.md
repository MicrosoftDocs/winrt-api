---
-api-id: P:Windows.Networking.PushNotifications.RawNotification.Headers
-api-type: winrt property
---

<!-- Property syntax.
public IMapView<string, string> Headers { get; }
-->

# Windows.Networking.PushNotifications.RawNotification.Headers

## -description
Gets the raw header content from the notification.

## -property-value
A map view of the header values. See remarks for the header format.

## -remarks
Header format:
```syntax
Content-Encoding: aesgcm
Crypto-Key: dh=<PUBLICKEY>
Encryption: salt=<SALT>
```

For more information and to learn how headers are defined, see [Message Encryption for Web Push](https://tools.ietf.org/html/draft-ietf-webpush-encryption-03), section 3.2. 

The header content is for notifications sent using a channel created with [CreateRawPushNotificationChannelWithAlternateKeyForApplicationAsync](pushnotificationchannelmanagerforuser_createrawpushnotificationchannelwithalternatekeyforapplicationasync_769979127.md) and pushed to WNS using the Webpush protocol with VAPID authentication. For any other type of push notification, the header value is null.

## -see-also

## -examples

