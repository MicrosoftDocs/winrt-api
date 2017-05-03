---
-api-id: T:Windows.Devices.PointOfService.CashDrawerStatusKind
-api-type: winrt enum
-api-device-family-note: xbox
---

<!-- Enumeration syntax
public enum Windows.Devices.PointOfService.CashDrawerStatusKind : int
-->

# CashDrawerStatusKind

## -description
Defines the constants that indicate the cash drawer power status.

## -enum-fields
### -field Online:0
The device is powered on and ready to use.

### -field Off:1
The device is powered off or detached from the terminal.

### -field Offline:2
The device is powered on but is not available to respond to requests.

### -field OffOrOffline:3
The device is either off or offline, but the current state can not be distinguished.

### -field Extended:4
The device status is not any of the above states. This is available so a POS driver can provide custom notifications to the app.


## -remarks

## -examples

## -see-also