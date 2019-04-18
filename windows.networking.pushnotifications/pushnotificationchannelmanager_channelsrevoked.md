---
-api-id: E:Windows.Networking.PushNotifications.PushNotificationChannelManager.ChannelsRevoked
-api-type: winrt event
ms.custom: 19H1
---

<!-- Event syntax.
static public event EventHandler ChannelsRevoked<PushNotificationChannelsRevokedEventArgs>
-->

# Windows.Networking.PushNotifications.PushNotificationChannelManager.ChannelsRevoked

## -description
Raised when your push channel is revoked, so that you can immediately request a new channel. This minimizes any downtime resulting from using a revoked WNS channel. The event arguments type is [PushNotificationChannelsRevokedEventArgs](pushnotificationchannelsrevokedeventargs.md).

## -remarks

You create a push channel to receive push notifications from your service via WNS. These channels are not permanent, and may change for a variety of reasons (the most common being that channels expire after thirty days). There are also events that can occur within the platform that revoke the channel (for example, the global device ID changes). But you needn't request a new channel every time your app launches, if you use this event.

## -see-also

## -examples

```csharp
// Create the manager, and subscribe to the ChannelsRevoked event.

PushNotificationChannel channel = null;
PushNotificationChannelManager.ChannelsRevoked += OnChannelsRevoked;

try
{
    // Create the channel manager for the user.
    PushNotificationChannelManagerForUser channelManagerForUser = PushNotificationChannelManager.GetDefault();

    // Create the channel.
    channel = await channelManagerForUser.CreatePushNotificationChannelForApplicationAsync();

    // If the channel isn't null, send to app service.
    if (channel != null)
    {
        sendChannelURIToServer(channel.Uri);
    }
}
catch (Exception e){ ... }

...

private async void OnChannelsRevoked(PushNotificationChannelsRevokedEventArgs e)
{
    // PushNotificationChannelsRevokedEventArgs has no members.
    // Previous channel was revoked, time to create a new channel as shown above.
    ...
}    
```
