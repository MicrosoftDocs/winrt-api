---
-api-id: M:Windows.ApplicationModel.Background.BackgroundTaskBuilder.SetTrigger(Windows.ApplicationModel.Background.IBackgroundTrigger)
-api-type: winrt method
---

<!-- Method syntax
public void SetTrigger(Windows.ApplicationModel.Background.IBackgroundTrigger trigger)
-->

# Windows.ApplicationModel.Background.BackgroundTaskBuilder.SetTrigger

## -description
Sets the event trigger for a background task.

## -parameters
### -param trigger
An instance of an event trigger object such as a [SystemTrigger](systemtrigger.md), [TimeTrigger](timetrigger.md), or [NetworkOperatorNotificationTrigger](networkoperatornotificationtrigger.md).

## -remarks
In addition to specifying the type of event trigger for a background task, an application must also enable background tasks that use the event trigger type in the `<Extensions><Extension><BackgroundTasks>` section of its manifest. Valid types include the following:
+ `<Task Type="audio"/>`
+ `<Task Type="timer"/>`
+ `<Task Type="systemEvent"/>`
+ `<Task Type="pushNotification"/>`
+ `<Task Type="realTimeCommunication"/>`

If the background task type is not specified or specified incorrectly in the manifest, calls that attempt to use that kind of background task will fail.

List of triggers:

| Trigger | Description |
|----------|---------------|
| [ActivitySensorTrigger](activitysensortrigger.md) | Used when your application needs to respond to the activity sensor. |
| [AppBroadcastTrigger](appbroadcasttrigger.md) | Trigger a background task to run when an application starts gameplay broadcasting. |
| [ApplicationTrigger](applicationtrigger.md) | Trigger a background tasks from within your application. |
| [AppointmentStoreNotificationTrigger](appointmentstorenotificationtrigger.md) | Trigger to launch a background task for processing changes to the appointment store. |
| [BluetoothLEAdvertisementPublisherTrigger](bluetoothleadvertisementpublishertrigger.md) | Represents a trigger that is registered to advertise a Bluetooth LE advertisement in the background. |
| [CachedFileUpdaterTrigger](cachedfileupdatertrigger.md) | Trigger a background task to enable the Cached File Updater contract. |
| [ChatMessageNotificationTrigger](chatmessagenotificationtrigger.md) | Represents a trigger that is activated when there is a notification for a text message. |
| [ChatMessageReceivedNotificationTrigger](chatmessagereceivednotificationtrigger.md) | Represents a trigger that launches a background task that handles any incoming message that might need to be filtered according to its content. |
| [CommunicaionBlockingAppSetAsActiveTrigger](communicationblockingappsetasactivetrigger.md) | Represents a trigger to activate a communication blocking application when it is selected as the preferred blocking app. |
| [ContactStoreNotificationTrigger](contactstorenotificationtrigger.md) | Represents a trigger that launches a background task for processing changes to the contacts store. |
| [ContentPrefetchTrigger](contentprefetchtrigger.md) | Provides the ability to run custom handlers when prefetching web resources. |
| [CustomSystemEventTrigger](customsystemeventtrigger.md) | A custom system trigger that you can define . |
| [DeviceConnectionChangeTrigger](deviceconnectionchangetrigger.md) | Represents an event that an application can trigger to initiate a long-running update (firmware or settings) of a device. |
| [DeviceManufacturerNotificationTrigger](devicemanufacturernotificationtrigger.md) | Represents an event that an application can trigger to initiate a long-running update (firmware or settings) of a device. |
| [DeviceUseTrigger](deviceusetrigger.md) | Represents an event that a Windows Runtime app can trigger to initiate a long-running operation with a device or sensor. |
| [EmailStoreNotificationTrigger](emailstorenotificationtrigger.md) | Represents a trigger that enables notification of changes to the email store. |
| [GattCharacteristicNotificationTrigger](gattcharacteristicnotificationtrigger.md) | Represents a trigger that launches a background task when an incoming change notification is received for a Bluetooth LE GATT characteristic. |
| [GattServiceProviderTrigger](gattserviceprovidertrigger.md) | Constructs a Generic Attributes (GATT) service that can be persisted in the background. |
| [GeovisitTrigger](geovisittrigger.md) | Represents an event that triggers a Visits-related background task. |
| [LocationTrigger](locationtrigger.md) | Represents a location event that triggers a background task. This is used for Geofencing. |
| [MaintenanceTrigger](maintenancetrigger.md) | Represents a maintenance trigger which runs only when the system is connected to AC power. |
| [MediaProcessingTrigger](mediaprocessingtrigger.md) | Represents a trigger that launches a background task for performing media processing. |
| [MobileBroadbandDeviceServiceNotificationTrigger](mobilebroadbanddeviceservicenotificationtrigger.md) | Represents a trigger that activates when the network sends SIM tool commands. Apps receiving this notification then process the SIM tool commands. |
| [MobileBroadbandPcoDataChangeTrigger](mobilebroadbandpcodatachangetrigger.md) | Represents a cellular protocol configuration option change event that triggers a background task to run. |
| [MobileBroadbandPinLockStateChangeTrigger](mobilebroadbandpinlockstatechangetrigger.md) | Represents a trigger that indicates when the SIM PIN lock state has changed. |
| [MobileBroadbandRadioStateChangeTrigger](mobilebroadbandradiostatechangetrigger.md) | Represents a trigger that indicates when mobile broadband radio state has changed. For example, this trigger activates when a mobile device transitions to or from airplane mode. |
| [MobileBroadbandRegistrationStateChangeTrigger](mobilebroadbandregistrationstatechangetrigger.md) | Represents a trigger that indicates when mobile broadband registration state has changed. For example, this trigger activates when a mobile device transitions to or from Roaming. |
| [NetworkOperatorDataUsageTrigger](networkoperatordatausagetrigger.md) | Represents a trigger that launches a background task when the local data counters estimate that usage (bytes sent and received) on the mobile broadband interface has changed by an actionable threshold. |
| [NetworkOperatorHotspotAuthenticationTrigger](networkoperatorhotspotauthenticationtrigger.md) | Represents a mobile network operator hotspot authentication trigger. |
| [NetworkOperatorNotificationTrigger](networkoperatornotificationtrigger.md) | Represents a mobile network operator notification trigger. |
| [PaymentAppCanMakePaymentTrigger](paymentappcanmakepaymenttrigger.md) | Represents a PaymentAppCanMakePayment trigger. |
| [PhoneTrigger](phonetrigger.md) | Represents a phone event that triggers a background task. |
| [PushNotificationTrigger](pushnotificationtrigger.md) | Represents a trigger that invokes a background work item on the app in response to the receipt of a raw notification. |
| [RcsEndUserMessageAvailableTrigger](rcsendusermessageavailabletrigger.md) | Represents a trigger that launches a background task when a new Rich Communication Services (RCS) message is available. |
| [RfcommConnectionTrigger](rfcommconnectiontrigger.md) | Represents a trigger that launches a background task when an RFCOMM inbound or outbound connections are established. |
| [SecondaryAuthenticationFactorAuthenticationTrigger](secondaryauthenticationfactorauthenticationtrigger.md) | Represents a trigger that launches a background task on behalf of a companion device. |
| [SensorDataThresholdTrigger](sensordatathresholdtrigger.md) | Represents a trigger that responds when a threshold limit for a sensor is crossed. |
| [SmartCardTrigger](smartcardtrigger.md) | Represents an event triggered by a smart card. |
| [SmsMessageReceivedTrigger](smsmessagereceivedtrigger.md) | Represents a trigger that is raised when an SMS message has arrived. |
| [SocketActivityTrigger](socketactivitytrigger.md) | Represents a trigger that launches a background task for handling socket activity. |
| [StorageLibraryChangeTrackerTrigger](storagelibrarychangetrackertrigger.md) | Represents a file change within a StorageFolder that triggers a background task to run. |
| [StorageLibraryContentChangedTrigger](storagelibrarycontentchangedtrigger.md) | Creates a trigger that will fire when a file is changed in a specified library. |
| [SystemCondition](systemcondition.md) | Represents a system condition that must be in effect for a background task to run. |
| [SystemTrigger](systemtrigger.md) | Represents a system event that triggers a background task to run. |
| [TetheringEntitlementCheckTrigger](tetheringentitlementchecktrigger.md) | Represents a tethering event that triggers a background task to run. |
| [TimeTrigger](timetrigger.md) | Represents a time event that triggers a background task to run. |
| [ToastNotificationActionTrigger](toastnotificationactiontrigger.md) | Represents an event that causes a background task to run when the user performs an action on an interactive toast notification. |
| [ToastNotificationHistoryChangedTrigger](toastnotificationhistorychangedtrigger.md) | Represents an event that causes a background task to run when the history of toast notifications for the app is cleared, when one or more toast notifications are added to or removed from the notification history for the app, or when one or more toast notifications for the app expire and are removed from the notification history. |
| [UserNotificationChangedTrigger](usernotificationchangedtrigger.md) | Represents a trigger that fires when a UserNotification is added or removed. |

## -examples

## -see-also

