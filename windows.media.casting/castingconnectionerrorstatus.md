---
-api-id: T:Windows.Media.Casting.CastingConnectionErrorStatus
-api-type: winrt enum
-api-device-family-note: xbox
---

<!-- Enumeration syntax
public enum Windows.Media.Casting.CastingConnectionErrorStatus : int
-->

# CastingConnectionErrorStatus

## -description
Indicates the error status when starting or ending a casting connection.

## -enum-fields
### -field Succeeded:0
Starting or ending the connection was successful.

### -field DeviceDidNotRespond:1
The device did not respond to the attempt to start or end theconnection.

### -field DeviceError:2
The device returned an error when attempting to start or end the connection.

### -field DeviceLocked:3
The device was locked and a start or end the connection could not be made.

### -field ProtectedPlaybackFailed:4
The device could not provide protected playback.

### -field InvalidCastingSource:5
The casting source was invalid.

### -field Unknown:6
An unknown error occurred when attempting to start or end the connection.


## -remarks

## -examples

## -see-also