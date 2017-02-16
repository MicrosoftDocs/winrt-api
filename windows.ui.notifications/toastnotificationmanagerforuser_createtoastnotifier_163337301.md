---
-api-id: M:Windows.UI.Notifications.ToastNotificationManagerForUser.CreateToastNotifier(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.UI.Notifications.ToastNotifier CreateToastNotifier(System.String applicationId)
-->

# Windows.UI.Notifications.ToastNotificationManagerForUser.CreateToastNotifier

## -description
Creates a new [ToastNotification](toastnotification.md) for the bound [user](toastnotificationmanagerforuser_user.md) and the specified app, usually another app in the same package.

## -parameters
### -param applicationId
The unique ID of the app.

> [!NOTE]
> You can't send a toast notification to a secondary tile, so this must be the ID of an app tile.

## -returns
The object you will use to send the toast notification to the tile.

## -remarks

## -examples

## -see-also
[CreateToastNotifier](toastnotificationmanagerforuser_createtoastnotifier_1346219381.md)