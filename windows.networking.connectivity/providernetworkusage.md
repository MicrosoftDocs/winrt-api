---
-api-id: T:Windows.Networking.Connectivity.ProviderNetworkUsage
-api-type: winrt class
---

<!-- Class syntax.
public class ProviderNetworkUsage 
-->

# Windows.Networking.Connectivity.ProviderNetworkUsage

## -description
Represents network usage statistics grouped by provider, returned by the 
[ConnectionProfile.GetProviderNetworkUsageAsync](connectionprofile_getprovidernetworkusageasync_1442391607.md) method.

## -remarks
[ProviderNetworkUsage](providernetworkusage.md) provides network usage data aggregated by network service provider, allowing 
applications to understand data consumption patterns across different providers. This is particularly useful for devices that may 
connect through multiple cellular providers or for applications that need to track usage across different network services.

For comprehensive usage tracking patterns and best practices, see 
[GetNetworkUsageAsync](connectionprofile_getnetworkusageasync_665790436.md).

### Properties

- **[BytesSent](providernetworkusage_bytessent.md)**: Total bytes transmitted through this provider
- **[BytesReceived](providernetworkusage_bytesreceived.md)**: Total bytes received through this provider
- **[ProviderId](providernetworkusage_providerid.md)**: Identifier for the network service provider

> [!NOTE]
> Provider network usage statistics are only available for connections where provider information can be determined. Not all 
> network connection types support provider-level usage tracking.

### Usage scenarios

Provider network usage data is valuable for:
- **Multi-carrier device management**: Tracking usage across different cellular providers
- **Cost optimization**: Understanding which providers are consuming more data
- **Network analytics**: Analyzing usage patterns by provider
- **Billing reconciliation**: Matching usage data with provider billing information

### Data accuracy considerations

Like other usage statistics, provider network usage data may have limitations:
- Data may be collected and reported at different intervals
- Some connection types may not support detailed provider tracking
- System-level network activities may not be included in application-specific queries

## -examples

## -see-also
[AttributedNetworkUsage](attributednetworkusage.md),
[ConnectionProfile.GetProviderNetworkUsageAsync](connectionprofile_getprovidernetworkusageasync_1442391607.md),
[GetAttributedNetworkUsageAsync](connectionprofile_getattributednetworkusageasync_1743384794.md),
[GetNetworkUsageAsync](connectionprofile_getnetworkusageasync_665790436.md),
[NetworkUsage](networkusage.md),
[NetworkUsageStates](networkusagestates.md)

