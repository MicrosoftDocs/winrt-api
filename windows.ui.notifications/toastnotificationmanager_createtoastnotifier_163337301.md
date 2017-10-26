---
-api-id: M:Windows.UI.Notifications.ToastNotificationManager.CreateToastNotifier(System.String)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.UI.Notifications.ToastNotifier CreateToastNotifier(System.String applicationId)
-->

# Windows.UI.Notifications.ToastNotificationManager.CreateToastNotifier

## -description
Creates and initializes a new instance of the [ToastNotification](toastnotification.md), bound to a specified app, usually another app in the same package.

## -parameters
### -param applicationId
The unique ID of the app.

> [!NOTE]
> You can't send a toast notification to a secondary tile, so this must be the ID of an app tile.

## -returns
The object you will use to send the toast notification to the tile.

## -remarks
The app identified by *applicationId* must belong to the same package as the caller.

Use this form of the method if your app uses a background voice-over-Internet protocol (VOIP) agent, to specify the app ID required to show a toast in that case.

### Sending toast notifications from desktop apps

Generally, sending a toast notification from a desktop app is the same as sending it from a UWP app. However, you should be aware of these differences and requirements: 
+ For a desktop app to display a toast, the app must have a shortcut on the Start screen.
+ The shortcut must have an [AppUserModelID](http://msdn.microsoft.com/library/ebce2d99-6f20-4545-9f12-d79cd8d0828f).
+ Desktop apps cannot schedule a toast.


For more information, see these topics: 
+ [How to enable desktop toast notifications through an AppUserModelID](http://msdn.microsoft.com/library/bb32cd0a-99e6-47dc-a913-39a7b3027314)
+ [Quickstart: Sending a toast notification from the desktop](http://msdn.microsoft.com/library/1d20ed75-e24a-4e60-91ab-cfcbe902a68e)


## -examples

## -see-also
[CreateToastNotifier](toastnotificationmanager_createtoastnotifier_1346219381.md), [Toast notifications sample](http://go.microsoft.com/fwlink/p/?linkid=231503), [Sending toast notifications from desktop apps sample](http://go.microsoft.com/fwlink/p/?linkid=231503), [Toast XML schema](https://docs.microsoft.com/uwp/schemas/tiles/toastschema/schema-root), [Toast notification overview](http://msdn.microsoft.com/library/14a07fce-d631-4bad-ab99-305b703713e6), [Quickstart: Sending a toast notification](http://msdn.microsoft.com/library/098df37c-4d40-4499-b809-ccb651da1cba), [Quickstart: Sending a toast push notification](http://msdn.microsoft.com/library/bb962e30-6c95-4186-8a0e-6683140e17c7), [Quickstart: Sending a toast notification from the desktop](http://msdn.microsoft.com/library/1d20ed75-e24a-4e60-91ab-cfcbe902a68e), [Guidelines and checklist for toast notifications](http://msdn.microsoft.com/library/002951e3-3d2d-454a-a0b7-daa5c1e7178a), [How to handle activation from a toast notification](http://msdn.microsoft.com/library/74ba3513-0a52-46a0-8769-ed58abe7c05a), [How to opt in for toast notifications](http://msdn.microsoft.com/library/809cdd36-6de1-4de0-88b2-62b46cafdb28), [How to schedule a toast notification](http://msdn.microsoft.com/library/18a09413-1679-4606-8175-346f4fe6a4f8), [How to enable desktop toast notifications through an AppUserModelID](http://msdn.microsoft.com/library/bb32cd0a-99e6-47dc-a913-39a7b3027314), [The toast template catalog](http://msdn.microsoft.com/library/1a437614-4259-426b-8e3f-ca57368b2e7a), [Toast audio options](http://msdn.microsoft.com/library/12185879-1f9b-4bdc-99e7-a6f2f62806cb)