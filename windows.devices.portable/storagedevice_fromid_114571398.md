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
The [DeviceInformation](../windows.devices.enumeration/deviceinformation.md) ID that identifies the removable storage device. This id can be retrieved from [Windows.Devices.Enumeration](../windows.devices.enumeration/windows_devices_enumeration.md) or the [DeviceInformationId](../windows.applicationmodel.activation/deviceactivatedeventargs_deviceinformationid.md) property of the AutoPlay device event arguments. For more information, see [Quickstart: Register an app for an AutoPlay device](/previous-versions/windows/apps/jj160497(v=win.10)). In order for FromId to succeed, the app must declare both the removableStorage capability as shown in the [App capability declarations](/windows/uwp/packaging/app-capability-declarations) and file type associations for the files it wishes to access on the device as shown in [How to handle file activation](/previous-versions/windows/apps/hh452684(v=win.10)). For more information, see the [Removable Storage sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/%5BC%23%5D-Windows%208.1%20Store%20app%20samples/Removable%20storage%20sample).

## -returns
The storage folder object that represents the removable storage device and provides access to content on the device.

## -remarks
Pass the selector string from [GetDeviceSelector](storagedevice_getdeviceselector_838466080.md) to the Windows.Devices.Enumeration API to get a collection of [DeviceInformation](../windows.devices.enumeration/deviceinformation.md) objects representing storage devices. Select the [DeviceInformation](../windows.devices.enumeration/deviceinformation.md) object for the storage you want to access, and use its [Id](../windows.devices.enumeration/deviceinformation_id.md) property as the *deviceInformationId* parameter to FromId.

## -examples

## -see-also
[DeviceInformation](../windows.devices.enumeration/deviceinformation.md), [DeviceInformation.Id](../windows.devices.enumeration/deviceinformation_id.md), [Enumerating Common Devices](/previous-versions/windows/apps/hh464974(v=win.10))

## -capabilities
removableStorage
