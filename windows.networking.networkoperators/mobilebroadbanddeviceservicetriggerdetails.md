---
-api-id: T:Windows.Networking.NetworkOperators.MobileBroadbandDeviceServiceTriggerDetails
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class MobileBroadbandDeviceServiceTriggerDetails : Windows.Networking.NetworkOperators.IMobileBroadbandDeviceServiceTriggerDetails
-->

# Windows.Networking.NetworkOperators.MobileBroadbandDeviceServiceTriggerDetails

## -description
Provides details for a network device service notification.

> [!NOTE]
> This functionality is only available to mobile operator apps and UWP apps given privileged access by mobile network operators.

> If you want to use this API and publish your app to the Store, you will need special approval. For more information, see the **Special and restricted capabilities** section under [App capability declarations](https://docs.microsoft.com/windows/uwp/packaging/app-capability-declarations). 

## -remarks
When a background task is triggered by a mobile network device service notification, the [IBackgroundTaskInstance.TriggerDetails](../windows.applicationmodel.background/ibackgroundtaskinstance_triggerdetails.md) property returns an instance of this class with information specific to the triggered notification.

The operating system extends battery life by suspending applications that are not in the foreground. If your application must handle new network device service notifications even while suspended, you must create a background work item to handle the messages. When a new device service notification arrives, the background work item will be activated. The MobileBroadbandDeviceServiceTriggerDetails class provides the details of the event to your background work item code.



## -examples

## -see-also

## -capabilities
cellularDeviceIdentity, cellularDeviceControl
