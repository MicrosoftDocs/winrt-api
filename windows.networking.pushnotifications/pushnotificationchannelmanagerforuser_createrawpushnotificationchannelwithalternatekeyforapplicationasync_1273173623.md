---
-api-id: M:Windows.Networking.PushNotifications.PushNotificationChannelManagerForUser.CreateRawPushNotificationChannelWithAlternateKeyForApplicationAsync(Windows.Storage.Streams.IBuffer,System.String,System.String)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<PushNotificationChannel> PushNotificationChannelManagerForUser.CreateRawPushNotificationChannelWithAlternateKeyForApplicationAsync(IBuffer appServerKey, String channelId, String appId)
-->

# Windows.Networking.PushNotifications.PushNotificationChannelManagerForUser.CreateRawPushNotificationChannelWithAlternateKeyForApplicationAsync

## -description
Creates an object bound to a specified app through which you retrieve a push notification channel from Windows Push Notification Services (WNS). The specified app must be in the same package as the calling app.

## -parameters

### -param appServerKey
An uncompressed key in ANSI X9.62 format. This value is from the P-256 curve defined in the [Secure Hash Standard specification](https://nvlpubs.nist.gov/nistpubs/FIPS/NIST.FIPS.180-4.pdf).

### -param channelId
The ID of the push notification channel.

### -param appId
The package-relative application identifier (PRAID) of the app to bind to the push notification channel. The specified app must be in the same package as the calling app. For more info on the PRAID, see the **Id** attribute of the [Application](/uwp/schemas/appxpackage/appxmanifestschema/element-application#attributes-and-elements) element.

If you are hosting background task(s) in an out-of-process COM server, separate from your main application, then pass as the argument for `applicationId` the PRAID of the application that defines the `windows.backgroundTask` extension in its own package manifest.

## -returns
The object, bound to the app server specified in appServerKey, that is used to request a [PushNotificationChannel](PushNotificationChannel.md) from WNS.

## -remarks
All raw notifications sent over this channel will have the channelID attached before being delivered to the app. This allows for apps to create multiple channels and differentiate where the notifications come from.

> [!NOTE] 
> Most applications (including all third party apps) should use the [CreateRawPushNotificationChannelWithAlternateKeyForApplicationAsync](pushnotificationchannelmanagerforuser_createrawpushnotificationchannelwithalternatekeyforapplicationasync_769979127.md) without the appID parameter.


## -see-also

## -examples

