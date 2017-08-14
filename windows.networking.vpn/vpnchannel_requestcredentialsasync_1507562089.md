---
-api-id: M:Windows.Networking.Vpn.VpnChannel.RequestCredentialsAsync(Windows.Networking.Vpn.VpnCredentialType,System.UInt32)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Networking.Vpn.VpnCredential> RequestCredentialsAsync(Windows.Networking.Vpn.VpnCredentialType credType, System.UInt32 credOptions)
-->

# Windows.Networking.Vpn.VpnChannel.RequestCredentialsAsync

## -description
Requests the VPN platform to collect credentials from the user. The plug-in can specify the type and form of credentials to collect. The result is an object containing the main credentials depending on the type, and the secondary credentials for change and expiration cases.

## -parameters
### -param credType
An enum value indicating the type of credential to collect.

### -param credOptions
Specifies the values defining whether a requested credential is a retry case, or should be used for single sign on.

See [VpnChannelRequestCredentialsOptions](vpnchannelrequestcredentialsoptions.md) for possible values.

## -returns
An asynchronous retrieval operation on a [VpnCredential](vpncredential.md) object containing the main credentials of the requested type, and secondary credentials for change and expiration cases.

## -remarks

## -examples

## -see-also
[RequestCredentialsAsync(VpnCredentialType, UInt32, Certificate)](vpnchannel_requestcredentialsasync_1445007973.md), [RequestCredentialsAsync(VpnCredentialType)](vpnchannel_requestcredentialsasync_1579978651.md)

## -capabilities
networkingVpnProvider
