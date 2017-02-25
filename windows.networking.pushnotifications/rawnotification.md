---
-api-id: T:Windows.Networking.PushNotifications.RawNotification
-api-type: winrt class
---

<!-- Class syntax.
public class RawNotification : Windows.Networking.PushNotifications.IRawNotification, Windows.Networking.PushNotifications.IRawNotification2
-->

# Windows.Networking.PushNotifications.RawNotification

## -description
Encapsulates the app-defined content of a raw notification (a push notification that does not involve UI). Its contents can be used in an app's background task, if the app has that capability, or otherwise consumed by the app and acted on as needed.

## -remarks
A [RawNotification](rawnotification.md) object is obtained through the [TriggerDetails](../windows.applicationmodel.background/ibackgroundtaskinstance_triggerdetails.md) property.

A background task that is intended to run in response to a notification must be registered with a [PushNotificationTrigger](../windows.applicationmodel.background/pushnotificationtrigger.md). If it is not registered, the task will not run when a raw notification is received. For more info, see [Raw notification overview](http://msdn.microsoft.com/library/a867c75d-d16e-4ab5-8b44-614eeb9179c7).

## -examples

## -see-also
[PushNotificationTrigger](../windows.applicationmodel.background/pushnotificationtrigger.md), [Raw notifications sample](http://go.microsoft.com/fwlink/p/?linkid=241553), [Raw notification overview](http://msdn.microsoft.com/library/a867c75d-d16e-4ab5-8b44-614eeb9179c7), [Guidelines and checklist for raw notifications](http://msdn.microsoft.com/library/edcb7417-fa2a-4652-81be-9b39e24b2c09), [Quickstart: Creating and registering a raw notification background task](http://msdn.microsoft.com/library/c182fded-75ab-4349-bfd0-d11732fd845e), [Quickstart: Intercepting push notifications for running apps](http://msdn.microsoft.com/library/2bb0a1ab-7b7c-4331-8dad-d5441dd61b06)