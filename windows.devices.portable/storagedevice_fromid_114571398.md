---
-api-id: M:Windows.Devices.Portable.StorageDevice.FromId(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Storage.StorageFolder FromId(System.String deviceId)
-->

# Windows.Devices.Portable.StorageDevice.FromId

## -description
Gets a [StorageFolder](../windows.storage/storagefolder.md) object from a DeviceInformation Id for a removable storage device.

## -parameters
### -param deviceId
The [DeviceInformation](../windows.devices.enumeration/deviceinformation.md) ID that identifies the removable storage device. This id can be retrieved from [Windows.Devices.Enumeration](../windows.devices.enumeration/windows_devices_enumeration.md) or the [DeviceInformationId](../windows.applicationmodel.activation/deviceactivatedeventargs_deviceinformationid.md) property of the AutoPlay device event arguments. For more information, see [Quickstart: Register an app for an AutoPlay device](http://msdn.microsoft.com/library/6a3b8910-ebec-427b-bcba-7ce3fa3f878a). In order for [FromId](storagedevice_fromid.md) to succeed, the app must declare both the removableStorage capability as shown in the [App capability declarations](http://msdn.microsoft.com/library/25b18ba5-e584-4537-9f19-bb2c8c52dfe1) and file type associations for the files it wishes to access on the device as shown in [How to handle file activation](http://msdn.microsoft.com/library/cd540a91-5276-4a89-b517-85cea866172c). For more information, see the [Removable Storage sample](http://go.microsoft.com/fwlink/p/?LinkID=242035).

## -returns
The storage folder object that represents the removable storage device and provides access to content on the device.

## -remarks
Pass the selector string from [GetDeviceSelector](storagedevice_getdeviceselector.md) to the Windows.Devices.Enumeration API to get a collection of [DeviceInformation](../windows.devices.enumeration/deviceinformation.md) objects representing storage devices. Select the [DeviceInformation](../windows.devices.enumeration/deviceinformation.md) object for the storage you want to access, and use its [Id](../windows.devices.enumeration/deviceinformation_id.md) property as the *deviceInformationId* parameter to [FromId](storagedevice_fromid.md).

## -examples

## -see-also
[DeviceInformation](../windows.devices.enumeration/deviceinformation.md), [DeviceInformation.Id](../windows.devices.enumeration/deviceinformation_id.md), [Enumerating Common Devices](http://msdn.microsoft.com/library/2deddbba-de46-409e-ac76-87419cb03eba)

## -capabilities
removableStorage