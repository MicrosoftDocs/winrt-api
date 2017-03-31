---
-api-id: T:Windows.Security.Credentials.KeyCredentialStatus
-api-type: winrt enum
-api-device-family-note: xbox
---

<!-- Enumeration syntax
public enum Windows.Security.Credentials.KeyCredentialStatus : int
-->

# KeyCredentialStatus

## -description
Represents the status of a key credential request.

## -enum-fields
### -field Success:0
The operation was successful.

### -field UnknownError:1
An unknown error occurred.

### -field NotFound:2
The credential could not be found.

### -field UserCanceled:3
The request was cancelled by the user.

### -field UserPrefersPassword:4
The user prefers to enter a password.

### -field CredentialAlreadyExists:5
The credential already exists.

### -field SecurityDeviceLocked:6
The security device was locked.


## -remarks

## -examples

## -see-also