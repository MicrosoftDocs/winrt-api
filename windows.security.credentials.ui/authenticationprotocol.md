---
-api-id: T:Windows.Security.Credentials.UI.AuthenticationProtocol
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Security.Credentials.UI.AuthenticationProtocol : int
-->

# AuthenticationProtocol

## -description
Identifies which authentication protocol to use.

## -enum-fields
### -field Basic:0
The authentication protocol is basic. Credentials are returned to the caller as plaintext.

### -field Digest:1
The authentication protocol is digest. Credentials are returned to the caller as plaintext.

### -field Ntlm:2
The authentication protocol is NTLM. Credentials are transformed before being returned to the caller.

### -field Kerberos:3
The authentication protocol is Kerberos. Credentials are transformed before being returned to the caller.

### -field Negotiate:4
The authentication protocol is negotiate, including negotiate extensions. Credentials are transformed before being returned to the caller.

### -field CredSsp:5
The authentication protocol is for remote access using the Credential Security Support Provider (CredSSP) protocol.

### -field Custom:6
The authentication protocol is anything other than the previous ones. Credentials are returned to the caller as plaintext.


## -remarks

## -examples

## -see-also