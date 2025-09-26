---
-api-id: T:Windows.Networking.Connectivity.ProxyConfiguration
-api-type: winrt class
---

<!-- Class syntax.
public class ProxyConfiguration : Windows.Networking.Connectivity.IProxyConfiguration
-->

# Windows.Networking.Connectivity.ProxyConfiguration

## -description
Represents resolved proxy settings (proxy endpoints and direct-connect flag) for a specific target URI.

## -remarks
### Retrieval
Call [NetworkInformation.GetProxyConfigurationAsync](networkinformation_getproxyconfigurationasync_1451648549.md) with a
target URI. The returned [ProxyConfiguration](proxyconfiguration.md) instance applies only to that URI (host + scheme /
port context).

### Resolution scope
The *uri* parameter can include a hostname or IP plus port/service or protocol scheme. Resolution accounts for:
- User/system proxy settings
- Auto‑config (PAC / WPAD) logic
- Per‑protocol overrides

### Automatic handling
> [!NOTE]  
> Higher-level APIs (for example [StreamSocket](../windows.networking.sockets/streamsocket.md)) automatically honor
> proxy settings; most apps do not need to manually resolve or apply proxies.

### Properties
- **[ProxyUris](proxyconfiguration_proxyuris.md)**: Ordered proxy candidates (may be empty).
- **[CanConnectDirectly](proxyconfiguration_canconnectdirectly.md)**: Indicates direct connection is permitted if no proxy succeeds.

### Usage scenarios
| Scenario | Rationale |
| -- | -- |
| Diagnostics tooling | Display active proxy chain and fallback logic |
| Custom HTTP stack / legacy interop | Apply resolved proxy list manually |
| Policy validation | Verify PAC script output or admin configuration |
| User assistance UI | Show which proxy governs a failing connection |

### Handling results
- Empty **ProxyUris** with **CanConnectDirectly** = `true`: connect directly.
- Empty **ProxyUris** with **CanConnectDirectly** = `false`: treat as blocked (no route); surface appropriate error.
- Multiple URIs: attempt in order; honor fail‑over semantics (stop after first successful tunnel).

### Best practices
- Cache only for short durations; proxy auto‑config can change during a session (network transitions).
- Re‑resolve after network status changes, sign‑in events, or detection of repeated proxy failures.
- Do not rewrite or reorder returned URIs; preserve precedence.

### Failure / fallback
If connection attempts through all proxies fail:
1. Re‑resolve to detect configuration change.
2. If unchanged and **CanConnectDirectly** is `true`, fall back to direct.
3. Log proxy failure metrics (status codes / connection errors) for diagnostics.

### Security considerations
- Avoid exposing raw proxy credentials or PAC script internals in UI/logs.
- Treat proxy URIs as potentially sensitive environment configuration.

For additional automatic proxy behavior discussion, see
[StreamSocket](../windows.networking.sockets/streamsocket.md).

## -examples

## -see-also
[ConnectionProfile](connectionprofile.md),
[NetworkInformation](networkinformation.md),
[NetworkInformation.GetProxyConfigurationAsync](networkinformation_getproxyconfigurationasync_1451648549.md),
[StreamSocket](../windows.networking.sockets/streamsocket.md)

## -capabilities
internetClient, privateNetworkClientServer
