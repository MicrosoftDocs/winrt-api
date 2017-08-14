---
-api-id: T:Windows.Networking.Vpn.VpnManagementErrorStatus
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Networking.Vpn.VpnManagementErrorStatus : int
-->

# VpnManagementErrorStatus

## -description
Describes the known VPN management errors.

## -enum-fields
### -field Ok:0
No error.

### -field Other:1
Other

### -field InvalidXmlSyntax:2
Invalid XML syntax

### -field ProfileNameTooLong:3
The profile name is too long.

### -field ProfileInvalidAppId:4
The app id is invalid.

### -field AccessDenied:5
Access is denied.

### -field CannotFindProfile:6
A specified profile cannot be found.

### -field AlreadyDisconnecting:7
The connection is in the process of being disconnected.

### -field AlreadyConnected:8
The connection already exists.

### -field GeneralAuthenticationFailure:9
Connection failed during authentication. No further details available.

### -field EapFailure:10
EAP authentication has failed.

### -field SmartCardFailure:11
Smart Card authentication has failed.

### -field CertificateFailure:12
Certificate authentication has failed.

### -field ServerConfiguration:13
The server configuration is invalid.

### -field NoConnection:14
No internet connection is available.

### -field ServerConnection:15
Can't connect to the server.

### -field UserNamePassword:16
User name/password authentication has failed.

### -field DnsNotResolvable:17
A given hostname was not resolvable through the available DNS.

### -field InvalidIP:18
A given IP address was invalid.


## -remarks

## -examples

## -see-also


## -capabilities
networkingVpnProvider
