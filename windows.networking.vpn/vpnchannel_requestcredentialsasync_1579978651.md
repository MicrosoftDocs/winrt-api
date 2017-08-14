---
-api-id: M:Windows.Networking.Vpn.VpnChannel.RequestCredentialsAsync(Windows.Networking.Vpn.VpnCredentialType)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Networking.Vpn.VpnCredential> RequestCredentialsAsync(Windows.Networking.Vpn.VpnCredentialType credType)
-->

# Windows.Networking.Vpn.VpnChannel.RequestCredentialsAsync

## -description
Requests the VPN platform to collect credentials of a given credential type from the user.

## -parameters
### -param credType
An enum value indicating the type of credential to collect.

## -returns
An asynchronous retrieval operation on a [VpnCredential](vpncredential.md) object containing the main credentials of the requested type, and secondary credentials for change and expiration cases.

## -remarks

## -examples

## -see-also
[RequestCredentialsAsync(VpnCredentialType, UInt32, Certificate)](vpnchannel_requestcredentialsasync_1445007973.md), [RequestCredentialsAsync(VpnCredentialType, UInt32)](vpnchannel_requestcredentialsasync_1507562089.md)

## -capabilities
networkingVpnProvider
