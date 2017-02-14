---
-api-id: T:Windows.Devices.Portable.ServiceDevice
-api-type: winrt class
---

<!-- Class syntax.
public class ServiceDevice 
-->

# Windows.Devices.Portable.ServiceDevice

## -description
Provides methods for identifying a device service for a portable device that supports WPD (Windows Portable Devices) for device enumeration.

## -remarks
To access these services, you must declare the device service in the device capabilities section of the app manifest file.  For a list of the GUIDs representing the device services, see [Windows.Devices.Portable](https://docs.microsoft.com/uwp/api/Windows.Devices.Portable). To access the device services, you must declare the device service in the capabilities section of the app manifest file. For a list of the GUIDs representing the device services, see [Windows.Devices.Portable](windows_devices_portable.md).

The [GetDeviceSelector](servicedevice_getdeviceselector.md) and [GetDeviceSelectorFromServiceId](servicedevice_getdeviceselectorfromserviceid.md) methods get selector strings that are passed to the [Windows.Devices.Enumeration](../windows.devices.enumeration/windows_devices_enumeration.md) API to find portable device services. The [Enumerating Common Devices](http://msdn.microsoft.com/library/2deddbba-de46-409e-ac76-87419cb03eba) tutorial explains how to use selector strings to discover available devices.

Examples of device services are the Media Transfer Protocol (MTP) device services that allow access to device status, contacts, calendar, tasks, and ringtones on a device. For more information, see [MTP Device Services for Windows](http://go.microsoft.com/fwlink/p/?LinkID=264914).

The [Portable Device Services Sample]( http://go.microsoft.com/fwlink/p/?linkid=242031) demonstrates how to access the device service once you have discovered it.

> [!NOTE]
> Access to a device service using this API is only available to Windows Store device app given privileged access to a device by the device manufacturer. For more information about Windows Store device app, see [Windows 8 Device Experience: .](http://go.microsoft.com/fwlink/p/?linkid=241442)

## -examples

## -see-also
[Windows 8 Device Experience: ](http://go.microsoft.com/fwlink/p/?linkid=241442), [Portable Device Services Sample]( http://go.microsoft.com/fwlink/p/?linkid=242031), [Enumerating Common Devices](http://msdn.microsoft.com/library/2deddbba-de46-409e-ac76-87419cb03eba)