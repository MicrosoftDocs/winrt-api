---
-api-id: T:Windows.Devices.Portable.ServiceDeviceType
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Devices.Portable.ServiceDeviceType : int
-->

# ServiceDeviceType

## -description
Indicates the type of a portable device service.

## -enum-fields
### -field CalendarService:0
A service that provides calendar information.

### -field ContactsService:1
A service that tracks contacts.

### -field DeviceStatusService:2
A device status service.

### -field NotesService:3
A note-taking service.

### -field RingtonesService:4
A service that provides ringtones for a phone.

### -field SmsService:5
An short message service (SMS) messaging service.

### -field TasksService:6
A service for tracking tasks.


## -remarks
To access the device services, you must declare the device service in the capabilities section of the app manifest file. For a list of the GUIDs representing the device services, see [Windows.Devices.Portable](windows_devices_portable.md).

## -examples

## -see-also