---
-api-id: T:Windows.Networking.NetworkOperators.MobileBroadbandNetworkRegistrationStateChangeTriggerDetails
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class MobileBroadbandNetworkRegistrationStateChangeTriggerDetails : Windows.Networking.NetworkOperators.IMobileBroadbandNetworkRegistrationStateChangeTriggerDetails
-->

# Windows.Networking.NetworkOperators.MobileBroadbandNetworkRegistrationStateChangeTriggerDetails

## -description
Provides details for a network registration state change notification.

> [!NOTE]
> This functionality is available only to mobile operator apps and UWP apps given privileged access by mobile network operators.
> 
> If you want to use this API and publish your app to the Microsoft Store, then you'll need special approval. For more information, see the **Restricted capabilities** section in the [App capability declarations](/windows/uwp/packaging/app-capability-declarations#restricted-capabilities) topic. 

## -remarks
When a background task is triggered by a mobile network registration state change notification, the [IBackgroundTaskInstance.TriggerDetails](../windows.applicationmodel.background/ibackgroundtaskinstance_triggerdetails.md) property returns an instance of this class with information specific to the triggered notification.

The operating system extends battery life by suspending applications that are not in the foreground. If your application must handle new network registration state change notifications even while suspended, you must create a background work item to handle the messages. When a new network registration state change notification arrives, the background work item will be activated. The MobileBroadbandNetworkRegistrationStateChangeTriggerDetails class provides the details of the event to your background work item code.

## -examples

## -see-also

## -capabilities
cellularDeviceIdentity, cellularDeviceControl
