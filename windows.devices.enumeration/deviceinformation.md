---
-api-id: T:Windows.Devices.Enumeration.DeviceInformation
-api-type: winrt class
---

<!-- Class syntax.
public class DeviceInformation : Windows.Devices.Enumeration.IDeviceInformation, Windows.Devices.Enumeration.IDeviceInformation2
-->

# Windows.Devices.Enumeration.DeviceInformation

## -description

Represents a device. This class allows access to well-known device properties as well as additional properties specified during device enumeration.

## -remarks

A DeviceInformation object is composed of an identity ([DeviceInformation.Id](deviceinformation_id.md)), a kind ([DeviceInformation.Kind](deviceinformation_kind.md)), and a property bag ([DeviceInformation.Properties](deviceinformation_properties.md)). All of the other properties of a DeviceInformation object are derived from the [Properties](deviceinformation_properties.md) property bag. For example, [Name](deviceinformation_name.md) is derived from **System.ItemNameDisplay**.

Successful completion of [FindAllAsync](deviceinformation_findallasync_1257462890.md) results in a [DeviceInformationCollection](deviceinformationcollection.md) containing DeviceInformation objects.

If a call to [CreateWatcher](deviceinformation_createwatcher_1506431823.md) succeeds, a DeviceInformation object is passed to the [added](devicewatcher_added.md) event for each device that is found.

The [Name](deviceinformation_name.md) property should only be used for display purposes only and not for finding a device because the [Name](deviceinformation_name.md) can change due to localization or a user assigning a name.

[CreateFromIdAsync](deviceinformation_createfromidasync_270724983.md) creates a DeviceInformation object if successful.

The DeviceInformation class provides device information, but more specifically, it provides properties of the device interface, the interface that represents functionality that the device exposes. Multi-function devices may have more than one device interface. The physical object that a user sees as a device, is known as the device container, and has properties such as **Manufacturer** and **ModelID**. For more information about enumerating devices and recovering properties, see [Enumerate devices](/windows/uwp/devices-sensors/enumerate-devices).

## -examples

This example incrementally enumerates devices, adding them to a list each time a device is found, and also handling removals and updates.

[!code-csharp[CreateWatcherAllDevicesCs](../windows.devices.enumeration/code/CreateWatcherAllDevices/cs/BlankPage.xaml.cs#SnippetCreateWatcherAllDevicesCs)]

## -see-also

[Camera profiles sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/CameraProfile), [Camera preview frame sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=620516), [Basic camera app sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=619479), [Camera resolution sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=624252), [Custom USB device sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=620530), [Camera face detection sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=619486), [Video stabilization sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=620519), [Manual camera controls sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=627611), [High dynamic range sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=620517), [Camera Advanced Capture sample](https://github.com/Microsoft/Windows-universal-samples/tree/dev/Samples/CameraAdvancedCapture), [Bluetooth low energy sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/BluetoothLE)
