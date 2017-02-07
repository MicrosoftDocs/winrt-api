---
-api-id: T:Windows.Devices.Portable.ServiceDevice
-api-type: winrt class
---

<!-- Class syntax.
public class ServiceDevice 
-->

# Windows.Devices.Portable.ServiceDevice

## -description
Provides methods for identifying a <?xm-deletion_mark author="rosshe" time="20120911T115242-0800" data="Media Transfer Protocol (MTP) "?> device service for a portable device that <?xm-deletion_mark author="rosshe" time="20120911T115253-0800" data="uses"?><?xm-insertion_mark_start author="rosshe" time="20120911T115253-0800"?> supports<?xm-insertion_mark_end?> WPD (Windows Portable Devices)<?xm-insertion_mark_start author="rosshe" time="20120911T115441-0800"?> for device enumeration<?xm-insertion_mark_end?>.

## -remarks
<?xm-deletion_mark author="rosshe" time="20120920T144554-0800" data="&lt;wdcml:rem xmlns:wdcml=&quot;http://microsoft.com/wdcml&quot;&gt;To access these services, you must declare the device service in the device capabilities section of the app manifest file.  For a list of the GUIDs representing the device services, see &lt;wdcml:xref targtype=&quot;namespace&quot; rid=&quot;w_dvc_port.windows_devices_portable&quot;&gt;Windows.Devices.Portable&lt;/wdcml:xref&gt;.&lt;/wdcml:rem&gt;"?><?xm-insertion_mark_start author="rosshe" time="20120920T144554-0800"?>To access the device services, you must declare the device service in the capabilities section of the app manifest file. For a list of the GUIDs representing the device services, see [Windows.Devices.Portable](windows_devices_portable.md).

<?xm-insertion_mark_end?>The [GetDeviceSelector](servicedevice_getdeviceselector.md) and [GetDeviceSelectorFromServiceId](servicedevice_getdeviceselectorfromserviceid.md) methods get selector strings that are passed to the [Windows.Devices.Enumeration](../windows.devices.enumeration/windows_devices_enumeration.md) API to find portable device services. The [Enumerating Common Devices](http://msdn.microsoft.com/library/2deddbba-de46-409e-ac76-87419cb03eba) tutorial explains how to use selector strings to discover available devices.

<?xm-insertion_mark_start author="rosshe" time="20120911T120409-0800"?>Examples of device services are the Media Transfer Protocol (MTP) device services that allow access to device status, contacts, calendar, tasks, and ringtones on a device. For more information, see [MTP Device Services for Windows](http://go.microsoft.com/fwlink/p/?LinkID=264914).

<?xm-insertion_mark_end?>The [Portable Device Services Sample]( http://go.microsoft.com/fwlink/p/?linkid=242031) demonstrates how to access the device service once you have discovered it.

> [!NOTE]
> Access to <?xm-deletion_mark author="rosshe" time="20120911T120350-0800" data="the MTP"?><?xm-insertion_mark_start author="rosshe" time="20120911T120350-0800"?> a<?xm-insertion_mark_end?> device service using this API is only available to Windows Store device app given privileged access to a device by the device manufacturer. For more information about Windows Store device app, see [Windows 8 Device Experience: .](http://go.microsoft.com/fwlink/p/?linkid=241442)

## -examples

## -see-also
[Windows 8 Device Experience: ](http://go.microsoft.com/fwlink/p/?linkid=241442), [Portable Device Services Sample]( http://go.microsoft.com/fwlink/p/?linkid=242031), [Enumerating Common Devices](http://msdn.microsoft.com/library/2deddbba-de46-409e-ac76-87419cb03eba)