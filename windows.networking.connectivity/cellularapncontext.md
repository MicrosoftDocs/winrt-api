---
-api-id: T:Windows.Networking.Connectivity.CellularApnContext
-api-type: winrt class
---

<!-- Class syntax.
public class CellularApnContext : Windows.Networking.Connectivity.ICellularApnContext
-->

# Windows.Networking.Connectivity.CellularApnContext

## -description
Defines properties used to specify an Access Point Name (APN) for a cellular data connection request.

## -remarks
### Usage
Pass an instance to [ConnectivityManager.AcquireConnectionAsync](connectivitymanager_acquireconnectionasync_1960335865.md) to request a cellular data session with the specified APN parameters. The returned [ConnectionSession](connectionsession.md) encapsulates the acquired connection; dispose it to release resources.

### Properties
| Category | Member | Purpose |
| -- | -- | -- |
| Core | [AccessPointName](cellularapncontext_accesspointname.md) | APN string supplied by carrier (may be empty for default) |
| Core | [ProviderId](cellularapncontext_providerid.md) | Carrier identifier (MCC+MNC) |
| Core | [ProfileName](cellularapncontext_profilename.md) | Friendly label for the APN profile |
| Auth | [UserName](cellularapncontext_username.md) / [Password](cellularapncontext_password.md) | Credentials (if required) |
| Auth | [AuthenticationType](cellularapncontext_authenticationtype.md) | Auth protocol (None, Pap, Chap, Mschapv2) |
| Option | [IsCompressionEnabled](cellularapncontext_iscompressionenabled.md) | Request link-layer compression (if supported) |

### Lifecycle
1. Construct and populate the `CellularApnContext` instance.
2. Call [AcquireConnectionAsync](connectivitymanager_acquireconnectionasync_1960335865.md).
3. Validate the resulting [ConnectionProfile](connectionprofile.md) (for example, [GetNetworkConnectivityLevel](connectionprofile_getnetworkconnectivitylevel_33807014.md)).
4. Use the connection while respecting cost and roaming constraints.
5. Dispose the returned [ConnectionSession](connectionsession.md).

### Best practices
| Concern | Guidance |
| -- | -- |
| Incorrect APN | Connection acquisition fails silently or yields no Internet access. Validate with carrier documentation. |
| Authentication failures | Retry only with corrected credentials; avoid tight loops |
| Roaming cost | Inspect [ConnectionProfile.GetConnectionCost](connectionprofile_getconnectioncost_2051899034.md) before large transfers |
| Resource cleanup | Always dispose the [ConnectionSession](connectionsession.md) (including failure paths) |
| Minimal config | Omit optional fields unless required (avoid sending empty credentials) |

> [!IMPORTANT]
> Carrier provisioning rules determine success. Use only officially supplied APN values; guessing can cause repeated failures or account issues.

### Carrier / deployment notes
- Some networks accept an empty APN for default plans.
- Specialized / enterprise plans may mandate unique APN plus credentials.
- Roaming contexts can require different APN values. Reacquire if the registration state transitions.

### Error handling
- Capture exceptions from [AcquireConnectionAsync](connectivitymanager_acquireconnectionasync_1960335865.md); log APN (non-secret parts) and auth type, not credentials.
- Provide user remediation path (e.g., prompt to correct credentials or confirm roaming charges).

### Version history
| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1803 | 17134 | ProfileName |

> [!NOTE]
> Future platform updates may introduce new authentication types. Treat unknown enum values conservatively (fail closed or prompt).


## -examples

## -see-also

[CellularApnAuthenticationType](cellularapnauthenticationtype.md),
[ConnectionProfile](connectionprofile.md),
[ConnectivityManager](connectivitymanager.md)
