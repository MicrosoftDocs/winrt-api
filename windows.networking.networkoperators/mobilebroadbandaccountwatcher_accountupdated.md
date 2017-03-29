---
-api-id: E:Windows.Networking.NetworkOperators.MobileBroadbandAccountWatcher.AccountUpdated
-api-type: winrt event
-api-device-family-note: xbox
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler AccountUpdated<Windows.Networking.NetworkOperators.MobileBroadbandAccountWatcher,  Windows.Networking.NetworkOperators.MobileBroadbandAccountUpdatedEventArgs>
-->

# Windows.Networking.NetworkOperators.MobileBroadbandAccountWatcher.AccountUpdated

## -description
Occurs when a Mobile Broadband Account is updated on the client.

> [!NOTE]
> This functionality is only available to mobile operator apps and Windows Store app given privileged access by mobile network operators.

For permission to use this API, please reach out to [Network Operators API Permissions](mailto:netopperm@microsoft.com).

For technical help with this API, please reach out to [Network Operators API Help](mailto:netophelp@microsoft.com)

## -remarks
The network account id of the account is available in the event handler from the [NetworkAccountId](mobilebroadbandaccountupdatedeventargs_networkaccountid.md) property.


The [AccountUpdated](mobilebroadbandaccountwatcher_accountupdated.md) event is triggered when any of the following properties change:

+ [MobileBroadbandDeviceInformation](mobilebroadbanddeviceinformation.md) class:

+ [CellularClass](mobilebroadbanddeviceinformation_cellularclass.md)
+ [CurrentRadioState](mobilebroadbanddeviceinformation_currentradiostate.md)
+ [CustomDataClass](mobilebroadbanddeviceinformation_customdataclass.md)
+ [DataClasses](mobilebroadbanddeviceinformation_dataclasses.md)
+ [MobileEquipmentId](mobilebroadbanddeviceinformation_mobileequipmentid.md)
+ [DeviceType](mobilebroadbanddeviceinformation_devicetype.md)
+ [FirmwareInformation](mobilebroadbanddeviceinformation_firmwareinformation.md)
+ [Manufacturer](mobilebroadbanddeviceinformation_manufacturer.md)
+ [Model](mobilebroadbanddeviceinformation_model.md)
+ [SimIccId](mobilebroadbanddeviceinformation_simiccid.md)
+ [SubscriberId](mobilebroadbanddeviceinformation_subscriberid.md)
+ [TelephoneNumbers](mobilebroadbanddeviceinformation_telephonenumbers.md)

+ [MobileBroadbandNetwork](mobilebroadbandnetwork.md) class:

+ [AccessPointName](mobilebroadbandnetwork_accesspointname.md)
+ [AccessPointName](mobilebroadbandnetwork_accesspointname.md)
+ [NetworkRegistrationState](mobilebroadbandnetwork_networkregistrationstate.md)
+ [PacketAttachNetworkError](mobilebroadbandnetwork_packetattachnetworkerror.md)
+ [RegistrationNetworkError](mobilebroadbandnetwork_registrationnetworkerror.md)



## -examples

## -see-also
