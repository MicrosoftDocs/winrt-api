---
-api-id: T:Windows.Networking.Connectivity.ConnectivityManager
-api-type: winrt class
---

<!-- Class syntax.
public class ConnectivityManager 
-->

# Windows.Networking.Connectivity.ConnectivityManager

## -description
Provides APIs to (1) acquire cellular connections (custom APN contexts) and (2) add or remove per‑app HTTP route
policies that direct HTTP traffic through specific connection profiles.

## -remarks
### Capabilities
1. Acquire cellular connections for a specified APN via
   [AcquireConnectionAsync](connectivitymanager_acquireconnectionasync_1960335865.md) using a
   [CellularApnContext](cellularapncontext.md).
2. Apply / remove per‑app HTTP routing via
   [AddHttpRoutePolicy](connectivitymanager_addhttproutepolicy_1422666154.md) and
   [RemoveHttpRoutePolicy](connectivitymanager_removehttproutepolicy_934323036.md) using a [RoutePolicy](routepolicy.md).

### Cellular connection acquisition
Use when you need a data session with custom APN characteristics (billing / security / isolated channel).
Typical scenarios:
- Enterprise or managed line‑of‑business apps.
- IoT / telemetry agents needing a dedicated APN.
- Billing segregation or specialized carrier feature enablement.

> [!IMPORTANT]  
> Declare required cellular capabilities in the app manifest. Dispose the returned
> [ConnectionSession](connectionsession.md) promptly to release resources.

Acquisition checklist:
- Construct a precise [CellularApnContext](cellularapncontext.md) (provider ID, APN, authentication).
- Await the session; validate resulting [ConnectionProfile](connectionprofile.md) meets required
  **NetworkConnectivityLevel**.
- Inspect [ConnectionCost](connectionprofile_getconnectioncost_1946735978.md) (roaming / metering) before starting large transfers.
- Dispose on failure paths and when no longer needed.

### HTTP route policies
[AddHttpRoutePolicy](connectivitymanager_addhttproutepolicy_1422666154.md) associates destination suffixes (host/domain) with
a specific profile to influence outbound HTTP traffic from the calling app only.

Important characteristics:
- Scope: Per‑app, HTTP only. Does not affect system‑wide routing or non‑HTTP protocols.
- Precedence: Evaluated before default system routing for matching HTTP requests.
- Lifetime: Active until removed or process termination.

Common scenarios:
| Scenario | Benefit |
| -- | -- |
| Multi‑homed optimization | Pin specific domains (e.g., CDN) to higher bandwidth / lower latency interface |
| Cost control | Route large / non‑critical endpoints over cheaper network (e.g., Wi‑Fi vs cellular) |
| VPN split behavior | Force sensitive API calls through VPN while leaving other traffic on default path |
| Diagnostics | Validate interface performance by isolating traffic to one profile |

### Route policy guidance
- Keep policies minimal; avoid broad suffixes that unintentionally capture excessive traffic.
- Remove policies when conditions change (e.g., interface down, cost now metered).
- Re‑add after network changes; profiles can become invalid following transitions.
- Log applied policies for troubleshooting; include targeted suffix and profile name.

### Security / privacy
- Do not rely on route policies for strong isolation; they influence routing but do not alter TLS endpoint validation.
- Avoid exposing internal target suffix lists in user‑visible logs.

### Error handling
- Acquisition failure: retry with backoff only if carrier policies allow; inspect exception details.
- Route policy add failure: verify profile still valid (not disconnected) and host name formatting.

> [!NOTE]  
> Policies affect only HTTP traffic from the calling application. They do not alter OS global routing tables.

## -examples

### Acquiring a cellular connection

```csharp
using Windows.Networking.Connectivity;

private async Task<ConnectionSession> AcquireCellularConnectionAsync()
{
    try
    {
        // Configure APN context for the cellular connection
        var apnContext = new CellularApnContext
        {
            ProviderId = "310260", // Example carrier ID
            AccessPointName = "internet.carrier.com",
            ProfileName = "Application Data Connection",
            AuthenticationType = CellularApnAuthenticationType.None,
            IsCompressionEnabled = true
        };
        
        Console.WriteLine("Acquiring cellular connection...");
        var connectionSession = await ConnectivityManager.AcquireConnectionAsync(apnContext);
        
        if (connectionSession?.ConnectionProfile != null)
        {
            var profile = connectionSession.ConnectionProfile;
            
            // Verify connection meets application requirements
            var connectivityLevel = profile.GetNetworkConnectivityLevel();
            if (connectivityLevel != NetworkConnectivityLevel.InternetAccess)
            {
                connectionSession.Dispose();
                throw new InvalidOperationException("Connection does not provide internet access");
            }
            
            // Check connection cost for application policy decisions
            var cost = profile.GetConnectionCost();
            if (cost.NetworkCostType == NetworkCostType.Variable && cost.Roaming)
            {
                // App-specific: warn user about roaming charges before proceeding
                bool userConsent = await ShowRoamingWarningAsync();
                if (!userConsent)
                {
                    connectionSession.Dispose();
                    return null;
                }
            }
            
            return connectionSession;
        }
        else
        {
            throw new InvalidOperationException("Failed to acquire cellular connection");
        }
    }
    catch (Exception ex)
    {
        // App-specific: log error and potentially retry with different APN settings
        LogConnectionError(ex);
        throw;
    }
}

// App-specific implementation methods  
private async Task<bool> ShowRoamingWarningAsync() { /* App-specific: user consent dialog */ return true; }
private void LogConnectionError(Exception ex) { /* App-specific: error logging */ }
```

### Managing HTTP routing policies

```csharp
private void ManageRoutingPolicies()
{
    var profiles = NetworkInformation.GetConnectionProfiles();
    
    // Find a specific connection profile to route traffic through
    var wifiProfile = profiles.FirstOrDefault(p => p.IsWlanConnectionProfile);
    var cellularProfile = profiles.FirstOrDefault(p => p.IsWwanConnectionProfile);
    
    if (wifiProfile != null && cellularProfile != null)
    {
        try
        {
            // Create routing policies
            var wifiPolicy = new RoutePolicy(wifiProfile, new HostName("cdn.contoso.com"), DomainNameType.Suffix);
            var cellularPolicy = new RoutePolicy(cellularProfile, new HostName("api.contoso.com"), DomainNameType.Suffix);
            
            // Add policies - HTTP traffic will be routed accordingly
            ConnectivityManager.AddHttpRoutePolicy(wifiPolicy);
            ConnectivityManager.AddHttpRoutePolicy(cellularPolicy);
            
            Console.WriteLine("Routing policies added:");
            Console.WriteLine($"  CDN traffic routed through: {wifiProfile.ProfileName}");
            Console.WriteLine($"  API traffic routed through: {cellularProfile.ProfileName}");
            
            // Policies will remain active until removed or app terminates
            // Remove policies when no longer needed:
            // ConnectivityManager.RemoveHttpRoutePolicy(wifiPolicy);
            // ConnectivityManager.RemoveHttpRoutePolicy(cellularPolicy);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Failed to configure routing policies: {ex.Message}");
        }
    }
}
```

## -see-also
[CellularApnContext](cellularapncontext.md),
[ConnectionProfile](connectionprofile.md),
[ConnectionSession](connectionsession.md),
[NetworkInformation](networkinformation.md),
[RoutePolicy](routepolicy.md)
