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
1. Construct and populate `CellularApnContext`.
2. Call `AcquireConnectionAsync`.
3. Validate resulting `ConnectionProfile` (e.g., `GetNetworkConnectivityLevel()`).
4. Use connection (respect cost / roaming).
5. Dispose `ConnectionSession`.

### Best practices
| Concern | Guidance |
| -- | -- |
| Incorrect APN | Connection acquisition fails silently or yields no Internet access—validate with carrier docs |
| Authentication failures | Retry only with corrected credentials; avoid tight loops |
| Roaming cost | Inspect `ConnectionProfile.GetConnectionCost()` before large transfers |
| Resource cleanup | Always dispose `ConnectionSession` (including failure paths) |
| Minimal config | Omit optional fields unless required (avoid sending empty credentials) |

> [!IMPORTANT]  
> Carrier provisioning rules determine success. Use only officially supplied APN values; guessing can cause repeated failures or account issues.

### Carrier / deployment notes
- Some networks accept an empty APN for default plans.
- Specialized / enterprise plans may mandate unique APN plus credentials.
- Roaming contexts can require different APN values—reacquire if registration state transitions.

### Error handling
- Capture exceptions from `AcquireConnectionAsync`; log APN (non-secret parts) and auth type, not credentials.
- Provide user remediation path (e.g., prompt to correct credentials or confirm roaming charges).

### Version additions
| Windows version | Added |
| -- | -- |
| 1803 | ProfileName |

> [!NOTE]  
> Future platform updates may introduce new authentication types—treat unknown enum values conservatively (fail closed or prompt).


## -examples

## -see-also
[CellularApnAuthenticationType](cellularapnauthenticationtype.md),
[ConnectionProfile](connectionprofile.md),
[ConnectionSession](connectionsession.md),
[ConnectivityManager](connectivitymanager.md),
[ConnectivityManager.AcquireConnectionAsync](connectivitymanager_acquireconnectionasync_1960335865.md)
