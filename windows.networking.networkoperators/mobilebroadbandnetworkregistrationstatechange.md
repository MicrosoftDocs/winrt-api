---
-api-id: T:Windows.Networking.NetworkOperators.MobileBroadbandNetworkRegistrationStateChange
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class MobileBroadbandNetworkRegistrationStateChange : Windows.Networking.NetworkOperators.IMobileBroadbandNetworkRegistrationStateChange
-->

# Windows.Networking.NetworkOperators.MobileBroadbandNetworkRegistrationStateChange

## -description
Provides details about one network registration state change.

> [!NOTE]
> This functionality is only available to mobile operator apps and UWP apps given privileged access by mobile network operators.


> If you want to use this API and publish your app to the Store, you will need special approval. For more information, see the **Special and restricted capabilities** section under [App capability declarations](https://docs.microsoft.com/windows/uwp/packaging/app-capability-declarations). 

## -remarks
Instances of this class are created by the system. When a network registration state change notification is sent to your app, the [MobileBroadbandNetworkRegistrationStateChangeTriggerDetails.NetworkRegistrationStateChanges](mobilebroadbandnetworkregistrationstatechangetriggerdetails_networkregistrationstatechanges.md) property that is provided with that notification contains a list of [MobileBroadbandNetworkRegistrationStateChange](mobilebroadbandnetworkregistrationstatechange.md) instances with the details of the changes associated with the notification.

## -examples

## -see-also

## -capabilities
cellularDeviceIdentity, cellularDeviceControl
