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
The following example shows how to get an interface ID using [GetDeviceSelector](storagedevice_getdeviceselector.md) and the [Windows.Devices.Enumeration](../windows.devices.enumeration/windows_devices_enumeration.md) API. It also shows how to pass it to [FromId](storagedevice_fromid.md) to get a [StorageFolder](../windows.storage/storagefolder.md) for a removable storage device.

```javascript
    Enum = Windows.Devices.Enumeration;

    // Enumerate removable storage devices.
    // The success callback selects the removable storage to use.
    function pickStorageToGetImageFrom() {
        Enum.DeviceInformation.findAllAsync(
        Windows.Devices.Portable.StorageDevice.getDeviceSelector(),
        null).then(
            successCallback,
            errorCallback);
    }

    // Handler that's called when removable storages are found.
    // storageDevices: A collection of type
    // Windows.Devices.Enumeration.DeviceInformationCollection.
    // This example just takes the first storage found in the list.
    function successCallback(storageDevices) {
        var removableStorage = null;
        if (storageDevices.length) {
            try {
                // Get the StorageFoler from the id for the first removable storage device
                removableStorage = Windows.Devices.Portable.StorageDevice.fromId(
                storageDevices.getAt(0).id);
                // document.getElementById("output").innerHTML = storageDevices.getAt(0).name; 
            } catch (e) {
                document.getElementById("output").innerHTML =
                "Error: " + e.message;
            }
            if (removableStorage != null) {
                getImageFiles(removableStorage);
            }
        } else {
            document.getElementById("output").innerHTML =
                "No removable storage devices were found.";
        }
    }
```

The following examples show the syntax of a call to [FromId](storagedevice_fromid.md) in C# and C++.

```csharp
var folder = StorageDevice.FromId(deviceInformationId);
```

```cpp
StorageFolder^ folder = StorageDevice::FromId(deviceInformationId);
```



## -see-also
[Removable Storage Sample](http://go.microsoft.com/fwlink/p/?linkid=242035)

## -capabilities
removableStorage