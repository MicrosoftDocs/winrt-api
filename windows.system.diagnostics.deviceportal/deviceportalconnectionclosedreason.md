---
-api-id: T:Windows.System.Diagnostics.DevicePortal.DevicePortalConnectionClosedReason
-api-type: winrt enum
---

<!-- Enumeration syntax.
public enum DevicePortalConnectionClosedReason : int 
-->

# Windows.System.Diagnostics.DevicePortal.DevicePortalConnectionClosedReason

## -description
Contains values that explain why a device portal connection was closed.

## -enum-fields
### -field UserNotPresent:4
The WTS active console user was missing.

### -field Unknown:0
The connection closed for an unknown reason.

### -field ServiceTerminated:5
Windows Device Portal has shut down.

### -field ResourceLimitsExceeded:1
Windows Devices Portal closed the connection because the resource limit was exceeded.

### -field ProtocolError:2
The connection closed because of an unrecognized app service message.

### -field NotAuthorized:3
The app is missing the appropriate capability to use a device portal.

## -remarks

## -see-also

## -examples

