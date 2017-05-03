---
-api-id: P:Windows.UI.Notifications.TileFlyoutNotification.Content
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.Data.Xml.Dom.XmlDocument Content { get; }
-->

# Windows.UI.Notifications.TileFlyoutNotification.Content

## -description
Gets the XML description of the current tile flyout (mix view) notification. This content can then be examined or manipulated as necessary.

> [!NOTE]
> A tile flyout notification always includes the entire flyout. To update any part of the notification, you must resend the entire notification. For instance, to update the content of only one of the flyout's sub-tiles while leaving the rest of the notification unchanged, call this method to get the current XML payload, alter only the attributes of the specific **subtile** element, and resend the full payload in a new notification.

## -property-value
The XML content of the current tile flyout notification.

## -remarks

## -examples

## -see-also
