---
-api-id: T:Windows.ApplicationModel.AppService.StatelessAppServiceResponseStatus
-api-type: winrt enum
ms.custom: 19H1
---

<!-- Enumeration syntax.
public enum StatelessAppServiceResponseStatus : int
-->

# Windows.ApplicationModel.AppService.StatelessAppServiceResponseStatus

## -description
Indicates success or failure of a SendStatelessMessageAsync operation.

## -enum-fields
### -field Unknown:10
An unknown error occurred.

### -field Success:0
The operation completed succesfully.

### -field ResourceLimitsExceeded:7
The operation failed due to resource limits being exceeded.

### -field RemoteSystemUnavailable:4
The operation failed due to the remote system being unavailable.

### -field RemoteSystemNotSupportedByApp:5
The operation failed due to the app service on the remote system missing the SupportsRemoteSystems flag.

### -field NotAuthorized:6
The operation failed due to authorization.

### -field MessageSizeTooLarge:8
The operation failed due to the message size being too large.

### -field Failure:9
The operation failed.

### -field AppUnavailable:2
The operation failed due to the app failing to start.

### -field AppServiceUnavailable:3
The operation failed due to the app not supporting the requested app service.

### -field AppNotInstalled:1
The operation failed due to the app not being presented on the remote system.

### -field AuthenticationError:11
The operation failed due to unsuccessful account authentication. The user must re-validate the account to continue.

### -field DisabledByPolicy:13
The operation failed, as the app service needed service or capabilities disabled by some policies on the local or remote device.

### -field NetworkNotAvailable:12
The operation failed due to lack of an internet connection.

### -field WebServiceUnavailable:14
The operation failed because one or more necessary cloud services were temporarily unavailable.

## -remarks
Indicates success or failure of a SendStatelessMessageAsync operation.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 2004 | 19041 | AuthenticationError |
| 2004 | 19041 | DisabledByPolicy |
| 2004 | 19041 | NetworkNotAvailable |
| 2004 | 19041 | WebServiceUnavailable |

## -see-also

## -examples
