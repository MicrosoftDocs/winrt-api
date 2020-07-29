---
-api-id: P:Windows.ApplicationModel.Background.IBackgroundTaskInstance.TriggerDetails
-api-type: winrt property
---

<!-- Property syntax
public object TriggerDetails { get; }
-->

# Windows.ApplicationModel.Background.IBackgroundTaskInstance.TriggerDetails

## -description
Gets additional information associated with a background task instance.

## -property-value
Represents additional information for the background task.

If the background task is triggered by a mobile network operator notification, this property is an instance of a [NetworkOperatorNotificationEventDetails](../windows.networking.networkoperators/networkoperatornotificationeventdetails.md) class.

If the background task is triggered by a system event or time event, this property is not used.

If the background task is triggered by a [PushNotificationTrigger](pushnotificationtrigger.md), this property will contain a [RawNotification](../windows.networking.pushnotifications/rawnotification.md) object.

## -remarks

## -examples

## -see-also
