---
-api-id: P:Windows.Networking.BackgroundTransfer.BackgroundDownloader.SuccessToastNotification
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Notifications.ToastNotification SuccessToastNotification { get;  set; }
-->

# Windows.Networking.BackgroundTransfer.BackgroundDownloader.SuccessToastNotification

## -description
Gets or sets the [ToastNotification](../windows.ui.notifications/toastnotification.md) that defines the content, associated metadata, and events used in a toast notification to indicate success of a download to the user.

## -property-value
The [ToastNotification](../windows.ui.notifications/toastnotification.md) used to indicate download success.

## -remarks
An app that uses [Windows.Networking.BackgroundTransfer](windows_networking_backgroundtransfer.md) to communicate through a toast notification must declare that it is **Toast capable** in the app manifest file. The **Toast capable** setting is located under the **Notifications** section of **Application** tab. Set the **Toast capable** option to "Yes" so the app can receive toast notifications.

If **Toast capable** is not enabled in the app manifest, then any toast settings in the [Windows.Networking.BackgroundTransfer](windows_networking_backgroundtransfer.md) namespace will be silently ignored and no toasts notifications will be received by the app.

> [!NOTE]
> A user can manually disable or enable toast notifications for your app at any time.

For more information on toast notifications, see [Sending toast notifications](http://msdn.microsoft.com/library/9ec1d052-cff8-415c-aba0-90b088c64039) and [How to opt in for toast notifications](http://msdn.microsoft.com/library/2d7db7c4-6f5e-47bf-89b6-8ac7a43e2011).

## -examples

## -see-also
[How to opt in for toast notifications](http://msdn.microsoft.com/library/2d7db7c4-6f5e-47bf-89b6-8ac7a43e2011), [ToastNotification](../windows.ui.notifications/toastnotification.md)