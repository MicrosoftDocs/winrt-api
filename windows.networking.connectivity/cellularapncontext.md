---
-api-id: T:Windows.Networking.Connectivity.CellularApnContext
-api-type: winrt class
---

<!-- Class syntax.
public class CellularApnContext : Windows.Networking.Connectivity.ICellularApnContext
-->

# Windows.Networking.Connectivity.CellularApnContext

## -description
This class contains properties used to specify an Access Point Name (APN) for a 3GPP based cellular Data Connection (PDP context). 

## -remarks
A [CellularApnContext](cellularapncontext.md) object is passed with a 
[ConnectivityManager.AcquireConnectionAsync](connectivitymanager_acquireconnectionasync_1960335865.md) call to establish a 
connection to a specific cellular Access Point Name (APN).

### APN configuration properties

The [CellularApnContext](cellularapncontext.md) class provides comprehensive configuration for cellular data connections:

**Core APN settings:**
- [AccessPointName](cellularapncontext_accesspointname.md): The APN string provided by the carrier
- [ProviderId](cellularapncontext_providerid.md): Identifier for the network service provider
- [ProfileName](cellularapncontext_profilename.md): User-friendly name for the APN profile (Windows 10 version 1803 and later)

**Authentication configuration:**
- [UserName](cellularapncontext_username.md) and [Password](cellularapncontext_password.md): Credentials for APN authentication
- [AuthenticationType](cellularapncontext_authenticationtype.md): Authentication method (None, PAP, CHAP, MSCHAPv2)

**Connection options:**
- [IsCompressionEnabled](cellularapncontext_iscompressionenabled.md): Whether data compression should be enabled

> [!IMPORTANT]
> APN configurations must match the settings provided by your cellular carrier. Incorrect APN settings will prevent successful 
> cellular data connections. Contact your carrier for the correct APN configuration values.

### APN connection lifecycle

When using [CellularApnContext](cellularapncontext.md) with 
[ConnectivityManager.AcquireConnectionAsync](connectivitymanager_acquireconnectionasync_1960335865.md):

1. Create and configure a [CellularApnContext](cellularapncontext.md) object with the appropriate APN settings
2. Call [AcquireConnectionAsync](connectivitymanager_acquireconnectionasync_1960335865.md) to request a connection
3. Use the returned [ConnectionSession](connectionsession.md) to access the connection
4. Dispose of the [ConnectionSession](connectionsession.md) when the connection is no longer needed

### Carrier-specific considerations

Different carriers may require different APN configurations:
- Some carriers use empty or default APN names for standard data plans
- Enterprise or special-purpose data plans may require specific APN configurations
- International roaming may require different APN settings than domestic connections

Always verify APN settings with your carrier before deployment.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1803 | 17134 | ProfileName |

## -examples

## -see-also
[CellularApnAuthenticationType](cellularapnauthenticationtype.md),
[ConnectionProfile](connectionprofile.md),
[ConnectionSession](connectionsession.md),
[ConnectivityManager](connectivitymanager.md),
[ConnectivityManager.AcquireConnectionAsync](connectivitymanager_acquireconnectionasync_1960335865.md)
