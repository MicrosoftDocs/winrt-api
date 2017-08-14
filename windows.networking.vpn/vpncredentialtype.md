---
-api-id: T:Windows.Networking.Vpn.VpnCredentialType
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Networking.Vpn.VpnCredentialType : int
-->

# VpnCredentialType

## -description
Specifies the types of credentials that can be requested by the VPN platform.

## -enum-fields
### -field UsernamePassword:0
Represents a credential of type Username and Password.

### -field UsernameOtpPin:1
Represents a credential type of username, and a PIN or OTP.

### -field UsernamePasswordAndPin:2
Represents a credential type of username, password, and PIN.

### -field UsernamePasswordChange:3
Represents a password change. The current password, new password, and a confirmation of the new password will be collected.

### -field SmartCard:4
Represents a credential type of smart card.

### -field ProtectedCertificate:5
Represents a credential type of a protected certificate.

### -field UnProtectedCertificate:6
Represents a credential type of a certificate.


## -remarks

## -examples

## -see-also


## -capabilities
networkingVpnProvider
