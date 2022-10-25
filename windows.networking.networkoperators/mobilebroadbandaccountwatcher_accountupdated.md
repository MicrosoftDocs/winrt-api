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
> This functionality is available only to mobile operator apps and UWP apps given privileged access by mobile network operators.
> 
> If you want to use this API and publish your app to the Microsoft Store, then you'll need special approval. For more information, see the **Restricted capabilities** section in the [App capability declarations](/windows/uwp/packaging/app-capability-declarations#restricted-capabilities) topic. 

## -remarks
The network account id of the account is available in the event handler from the [NetworkAccountId](mobilebroadbandaccountupdatedeventargs_networkaccountid.md) property.


The AccountUpdated event is triggered when any of the following properties change:

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
+ [NetworkRegistrationState](mobilebroadbandnetwork_networkregistrationstate.md)
+ [PacketAttachNetworkError](mobilebroadbandnetwork_packetattachnetworkerror.md)
+ [RegistrationNetworkError](mobilebroadbandnetwork_registrationnetworkerror.md)



## -examples

## -see-also

## -capabilities
cellularDeviceIdentity, cellularDeviceControl
