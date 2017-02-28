---
-api-id: M:Windows.UI.Notifications.NotificationData.#ctor(Windows.Foundation.Collections.IIterable{Windows.Foundation.Collections.IKeyValuePair{System.String,System.String}},System.UInt32)
-api-type: winrt method
---

<!-- Method syntax.
public NotificationData.NotificationData(IIterable<String>> initialValues, UInt32 sequenceNumber)
-->

# Windows.UI.Notifications.NotificationData.NotificationData

## -description
Creates a new [NotificationData](notificationdata.md) that contains the specified values and the specified sequence number. 

## -parameters

### -param initialValues
A collection of keys and values for the new [NotificationData](notificationdata.md), such as "progressValue", "0".

### -param sequenceNumber
A value greater than or equal to 0 that specifies the sequence number of the new notification data. When multiple [NotificationData](notificationdata.md) objects are received, the system displays the [NotificationData](notificationdata.md) with the greatest non-zero number. Setting this value to 0 causes it to always displays.  

## -remarks

## -see-also

## -examples

