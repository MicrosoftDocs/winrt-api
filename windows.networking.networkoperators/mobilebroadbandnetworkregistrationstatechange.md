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

This functionality is only available to mobile operator apps and Windows Store app given privileged access by mobile network operators. For more information, see [Mobile Broadband: ](http://msdn.microsoft.com/library/windows/hardware/hh852368.aspx).

## -remarks
Instances of this class are created by the system. When a network registration state change notification is sent to your app, the [MobileBroadbandNetworkRegistrationStateChangeTriggerDetails.NetworkRegistrationStateChanges](mobilebroadbandnetworkregistrationstatechangetriggerdetails_networkregistrationstatechanges.md) property that is provided with that notification contains a list of [MobileBroadbandNetworkRegistrationStateChange](mobilebroadbandnetworkregistrationstatechange.md) instances with the details of the changes associated with the notification.

## -examples

## -see-also
