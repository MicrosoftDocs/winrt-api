---
-api-id: T:Windows.Devices.WiFiDirect.Services.WiFiDirectServiceSessionErrorStatus
-api-type: winrt enum
-api-device-family-note: xbox
---

<!-- Enumeration syntax
public enum Windows.Devices.WiFiDirect.Services.WiFiDirectServiceSessionErrorStatus : int
-->

# WiFiDirectServiceSessionErrorStatus

## -description
Values used in the [WiFiDirectServiceSession.ErrorStatus](wifidirectservicesession_errorstatus.md) property.

## -enum-fields
### -field Ok:0
Session status is OK.

### -field Disassociated:1
The L2 connection was disassociated unexpectedly.

### -field LocalClose:2
The session was closed from the local side of the session.

### -field RemoteClose:3
The session was closed from the remote side of the session.

### -field SystemFailure:4
A general system failure has occurred.

### -field NoResponseFromRemote:5
Session timed out due to no response from the remote side of the session.


## -remarks

## -examples

## -see-also