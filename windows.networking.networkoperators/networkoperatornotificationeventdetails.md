---
-api-id: T:Windows.Networking.NetworkOperators.NetworkOperatorNotificationEventDetails
-api-type: winrt class
---

<!-- Class syntax.
public class NetworkOperatorNotificationEventDetails : Windows.Networking.NetworkOperators.INetworkOperatorNotificationEventDetails, Windows.Networking.NetworkOperators.INetworkOperatorTetheringEntitlementCheck
-->

# Windows.Networking.NetworkOperators.NetworkOperatorNotificationEventDetails

## -description
Provides details for a network operator notification.

> [!NOTE]
> This functionality is available only to mobile operator apps and UWP apps given privileged access by mobile network operators.
> 
> If you want to use this API and publish your app to the Microsoft Store, then you'll need special approval. For more information, see the **Restricted capabilities** section in the [App capability declarations](/windows/uwp/packaging/app-capability-declarations#restricted-capabilities) topic. 

## -remarks
The operating system extends battery life by suspending applications that are not in the foreground. If your application must handle new custom network operator messages even while suspended, you must create a background work item to handle the messages. When a new operator message arrives, the background work item will be activated. The NetworkOperatorNotificationEventDetails class provides the details of the event to your background work item code.

## -examples

## -see-also

## -capabilities
cellularDeviceIdentity, cellularDeviceControl
