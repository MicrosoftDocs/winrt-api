---
-api-id: P:Windows.Networking.BackgroundTransfer.BackgroundUploader.SuccessToastNotification
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Notifications.ToastNotification SuccessToastNotification { get;  set; }
-->

# Windows.Networking.BackgroundTransfer.BackgroundUploader.SuccessToastNotification

## -description
Gets or sets the [ToastNotification](../windows.ui.notifications/toastnotification.md) that defines the content, associated metadata, and events used in a toast notification to indicate success of an upload to the user.

## -property-value
The [ToastNotification](../windows.ui.notifications/toastnotification.md) used to indicate upload success.

## -remarks
An app that uses [Windows.Networking.BackgroundTransfer](windows_networking_backgroundtransfer.md) to communicate through a toast notification must declare that it is **Toast capable** in the app manifest file. The **Toast capable** setting is located under the **Notifications** section of **Application** tab. Set the **Toast capable** option to "Yes" so the app can receive toast notifications.

If **Toast capable** is not enabled in the app manifest, then any toast settings in the [Windows.Networking.BackgroundTransfer](windows_networking_backgroundtransfer.md) namespace will be silently ignored and no toasts notifications will be received by the app.

> [!NOTE]
> A user can manually disable or enable toast notifications for your app at any time.

For more information on toast notifications, see [Sending toast notifications](/previous-versions/windows/apps/hh868266(v=win.10)) and [How to opt in for toast notifications](/previous-versions/windows/apps/hh868218(v=win.10)).

## -examples

## -see-also
[How to opt in for toast notifications](/previous-versions/windows/apps/hh868218(v=win.10)), [ToastNotification](../windows.ui.notifications/toastnotification.md)
