---
-api-id: M:Windows.Networking.Vpn.VpnChannel.RequestCredentials(Windows.Networking.Vpn.VpnCredentialType,System.Boolean,System.Boolean,Windows.Security.Cryptography.Certificates.Certificate)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Networking.Vpn.VpnPickedCredential RequestCredentials(Windows.Networking.Vpn.VpnCredentialType credType, System.Boolean isRetry, System.Boolean isSingleSignOnCredential, Windows.Security.Cryptography.Certificates.Certificate certificate)
-->

# Windows.Networking.Vpn.VpnChannel.RequestCredentials

## -description
Request the VPN platform to collect credentials from the user. The plug-in can specify the type and form of credentials to collect. The result is an object containing the main credentials depending on the type and the secondary credentials for change and expiration cases.

## -parameters
### -param credType
An enum value indicating type of credential to collect.

### -param isRetry
If the request is a retry from as previous failed attempt, it is TRUE; otherwise, it is FALSE.

### -param isSingleSignOnCredential
If the credential should be used by all applications operating over the VPN tunnel and authenticating to resources on the VPN, it is TRUE; otherwise, it is FALSE. This provides a single sign on experience over the VPN.

### -param certificate
The certificate that can be optionally passed to indicate the platform its intention of use and obtain consent and unlock its protection.

## -returns
An object containing the main credentials and any other transitional credentials filled by the user.

## -remarks
If the function succeeds, the return value is **S_OK**, otherwise the function will return an error HRESULT value describing the specific failure. If the plug-in is not connected, the error is **E_ACCESSDENIED**. If there is no more memory available, the error is **E_OUTOFMEMORY**.

> [!NOTE]
> Any call to this API outside of a connected VPN plug-in will fail, as activity and interactions between the VPN plug-in and the system are controlled by the VPN profile.

## -examples

## -see-also


## -capabilities
networkingVpnProvider
