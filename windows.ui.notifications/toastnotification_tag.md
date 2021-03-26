---
-api-id: P:Windows.UI.Notifications.ToastNotification.Tag
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public string Tag { get;  set; }
-->

# Windows.UI.Notifications.ToastNotification.Tag

## -description
Gets or sets the unique identifier of this notification within the notification [Group](toastnotification_group.md).

## -property-value
Gets or sets the unique identifier of this notification within the notification [Group](toastnotification_group.md).

## -remarks
This API returns an exception if the property is set to `null` or the empty string.

The tag can be maximum 16 characters long. However, the Creators Update (15063) extends this limit to 64 characters.

## -examples

## -see-also
