---
-api-id: M:Windows.Networking.Vpn.VpnChannel.RequestCredentialsAsync(Windows.Networking.Vpn.VpnCredentialType,System.UInt32,Windows.Security.Cryptography.Certificates.Certificate)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Networking.Vpn.VpnCredential> RequestCredentialsAsync(Windows.Networking.Vpn.VpnCredentialType credType, System.UInt32 credOptions, Windows.Security.Cryptography.Certificates.Certificate certificate)
-->

# Windows.Networking.Vpn.VpnChannel.RequestCredentialsAsync

## -description
VPN platform to collect credentials from the user. If user interaction is required to obtain a credential or consent, the platform provides the necessary user interaction. A VPN plug-in must request credentials before using any type of credential, even if the intent is not to invoke user interaction for it.

## -parameters
### -param credType
An enum value indicating the type of credential to collect.

### -param credOptions
Specifies the values defining whether a requested credential is a retry case, or should be used for single sign on.

See [VpnChannelRequestCredentialsOptions](vpnchannelrequestcredentialsoptions.md) for possible values.

### -param certificate
A certificate to be used in validating the credential.

## -returns
An asynchronous retrieval operation on a [VpnCredential](vpncredential.md) object containing the main credentials of the requested type, and secondary credentials for change and expiration cases.

## -remarks

## -examples

## -see-also
[RequestCredentialsAsync(VpnCredentialType, UInt32)](vpnchannel_requestcredentialsasync_1507562089.md), [RequestCredentialsAsync(VpnCredentialType)](vpnchannel_requestcredentialsasync_1579978651.md)

## -capabilities
networkingVpnProvider
