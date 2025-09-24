---
-api-id: T:Windows.Networking.Connectivity.ConnectivityManager
-api-type: winrt class
---

<!-- Class syntax.
public class ConnectivityManager 
-->

# Windows.Networking.Connectivity.ConnectivityManager

## -description
Provides methods for acquiring cellular connections and managing HTTP traffic routing policies, enabling applications to control 
network traffic flow and establish connections to specific cellular APNs.

## -remarks
[ConnectivityManager](connectivitymanager.md) is a static class that provides two primary capabilities:

### Cellular connection acquisition

The [AcquireConnectionAsync](connectivitymanager_acquireconnectionasync_1960335865.md) method enables applications to establish 
connections to specific cellular Access Point Names (APNs) using [CellularApnContext](cellularapncontext.md) configurations. 
This is particularly useful for:

- Enterprise applications requiring specific APN configurations
- IoT devices needing dedicated data connections
- Applications requiring connections with specific billing or security characteristics

[!IMPORTANT]
Connection acquisition through [AcquireConnectionAsync](connectivitymanager_acquireconnectionasync_1960335865.md) requires 
appropriate cellular capabilities to be declared in the application manifest. The returned [ConnectionSession](connectionsession.md) 
must be properly disposed when the connection is no longer needed.

### HTTP traffic routing policies  

The [AddHttpRoutePolicy](connectivitymanager_addhttproutepolicy_1422666154.md) and 
[RemoveHttpRoutePolicy](connectivitymanager_removehttproutepolicy_934323036.md) methods enable enforcement of traffic routing 
on specific network adapters for designated destination suffixes. Once a [RoutePolicy](routepolicy.md) is set:

- HTTP traffic matching the policy criteria will be routed through the specified [ConnectionProfile](connectionprofile.md)
- Traffic that doesn't match routing policies will use default system routing
- Policies remain active until explicitly removed or the application terminates

### Policy-based networking scenarios

Routing policies are valuable for:
- **Multi-homed devices**: Directing specific traffic through particular network interfaces
- **VPN scenarios**: Routing traffic through VPN connections based on destination
- **Cellular cost management**: Directing non-critical traffic away from expensive cellular connections
- **Quality of Service**: Using high-quality connections for priority traffic

[!NOTE]
Routing policies only affect HTTP traffic originating from the same application that set the policy. System-wide traffic 
routing requires administrative privileges and is not supported through [ConnectivityManager](connectivitymanager.md).

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
