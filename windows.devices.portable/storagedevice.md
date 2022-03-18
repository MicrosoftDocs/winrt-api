---
-api-id: T:Windows.Devices.Portable.StorageDevice
-api-type: winrt class
---

<!-- Class syntax.
public class StorageDevice 
-->

# Windows.Devices.Portable.StorageDevice

## -description
Provides methods for accessing the storage functionality of a portable device that supports WPD. Removable storage devices include:

+ USB mass storage flash drives and cameras
+ Media Transfer Protocol (MTP) music players, phones, and cameras
+ Picture Transfer Protocol (PTP) cameras

## -remarks
To access the device services, you must declare the device service in the capabilities section of the app manifest file. For a list of the GUIDs representing the device services, see [Windows.Devices.Portable](windows_devices_portable.md).

## -examples

The following example shows the syntax of a call to [FromId](storagedevice_fromid_114571398.md).

```csharp
var folder = StorageDevice.FromId(deviceInformationId);
```

```cppwinrt
StorageFolder folder{ StorageDevice::FromId(deviceInformationId) };
```

```cppcx
StorageFolder^ folder = StorageDevice::FromId(deviceInformationId);
```

## -see-also
[Removable Storage Sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/%5BC%23%5D-Windows%208.1%20Store%20app%20samples/Removable%20storage%20sample)

## -capabilities
removableStorage
