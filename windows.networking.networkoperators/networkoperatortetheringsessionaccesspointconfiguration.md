---
-api-id: T:Windows.Networking.NetworkOperators.NetworkOperatorTetheringSessionAccessPointConfiguration
-api-type: winrt class
---

# Windows.Networking.NetworkOperators.NetworkOperatorTetheringSessionAccessPointConfiguration

<!--
public sealed class NetworkOperatorTetheringSessionAccessPointConfiguration
-->


## -description

Represents a per-session tethering configuration.

**NetworkOperatorTetheringSessionAccessPointConfiguration** contains the same fields and helper methods as [NetworkOperatorTetheringAccessPointConfiguration](./networkoperatortetheringaccesspointconfiguration.md) does, with several additions.

## -remarks

The purpose of this class is to specify the per-session tethering configuration when starting the tethering session via [StartTetheringAsync](./networkoperatortetheringmanager_starttetheringasync_1060696031.md). The additional members of this per-session-only class are typically values that aren't currently configurable by users via Windows **Settings**.

## -see-also

## -examples

```csharp
using System;
using System.Threading.Tasks;
using Windows.Foundation.Metadata;
using Windows.Networking.NetworkOperators;
using Windows.Networking.Connectivity;

namespace TetheringApiDemoApp
{
  static class TetheringApiDemoClass
  {
    // Sample desired per-session access point configuration values.
    private const string DesiredSsid = "DemoSsid";

    private const string DesiredPassphrase = "DemoPassphrase";

    private const TetheringWiFiBand DesiredBand =
      TetheringWiFiBand.SixGigahertz;

    private const TetheringWiFiAuthenticationKind DesiredAuthenticationKind =
      TetheringWiFiAuthenticationKind.Wpa3;

    private const TetheringWiFiPerformancePriority DesiredPerformancePriority =
      TetheringWiFiPerformancePriority.TetheringOverStation;

    public static void VerifyPerSessionTetheringApiSupport()
    {
      if (!ApiInformation.IsApiContractPresent("Windows.Foundation.UniversalApiContract", 17))
      {
        throw new InvalidOperationException(
          "This OS doesn't support per-session tethering configurations.");
      }
    }

    public static NetworkOperatorTetheringManager GetTetheringManagerForCurrentConnection()
    {
      // Get the connection profile associated with the internet connection currently used by the local machine.
      ConnectionProfile currentConnectionProfile = NetworkInformation.GetInternetConnectionProfile();

      if (currentConnectionProfile == null)
      {
        throw new InvalidOperationException("Machine isn't connected to the internet.");
      }

      TetheringCapability tetheringCapability =
        NetworkOperatorTetheringManager.GetTetheringCapabilityFromConnectionProfile(currentConnectionProfile);

      if (tetheringCapability != TetheringCapability.Enabled)
      {
        throw new InvalidOperationException(
          $"Tethering is disabled on this machine. Reason code: {tetheringCapability}.");
      }

      return NetworkOperatorTetheringManager.CreateFromConnectionProfile(currentConnectionProfile);
    }

    public static async Task<NetworkOperatorTetheringSessionAccessPointConfiguration>
      SetUpSessionConfigurationAsync(NetworkOperatorTetheringManager tetheringManager)
    {
      NetworkOperatorTetheringSessionAccessPointConfiguration sessionConfiguration =
         new NetworkOperatorTetheringSessionAccessPointConfiguration();

      sessionConfiguration.Ssid = DesiredSsid;
      sessionConfiguration.Passphrase = DesiredPassphrase;

      if (await sessionConfiguration.IsBandSupportedAsync(DesiredBand))
      {
        sessionConfiguration.Band = DesiredBand;
      }
      else
      {
        throw new InvalidOperationException("Desired band isn't supported.");
      }

      if (await sessionConfiguration.IsAuthenticationKindSupportedAsync(DesiredAuthenticationKind))
      {
        sessionConfiguration.AuthenticationKind = DesiredAuthenticationKind;
      }
      else
      {
        throw new InvalidOperationException("Desired authentication kind isn't supported.");
      }

      sessionConfiguration.PerformancePriority = DesiredPerformancePriority;

      return sessionConfiguration;
    }

    public static async Task StartTetheringSessionAsync(
      NetworkOperatorTetheringManager tetheringManager,
      NetworkOperatorTetheringSessionAccessPointConfiguration sessionConfiguration)
    {
      TetheringOperationStatus operationResult =
        await tetheringManager.StartTetheringAsync(sessionConfiguration);

      if (operationResult.Status == TetheringOperationStatus.Success)
      {
        Console.WriteLine("Tethering started successfully.");
      }
      else if (operationResult.Status == TetheringOperationStatus.AlreadyOn)
      {
        // Custom error message for AlreadyOn status.
        Console.WriteLine("Tethering is already on.");
      }
      else if (operationResult.Status == TetheringOperationStatus.RadioRestriction)
      {
        // Custom error message for RadioRestriction status.
        Console.WriteLine(
          "Can't start tethering at 6 GHz due to radio restrictions (2x2 + dual radio).");
      }
      else if (operationResult.Status == TetheringOperationStatus.BandInterference)
      {
        // Custom error message for BandInterference status.
        Console.WriteLine(
          "Can't start tethering at 6 GHz because a 5 GHz connection interferes.");
      }
      else
      {
        // Generic error message for all other statuses.
        Console.WriteLine(
          $"Failed to start tethering: {operationResult.AdditionalErrorMessage}.");
      }
    }

    public static async Task Main()
    {
      try
      {
        VerifyPerSessionTetheringApiSupport();

        NetworkOperatorTetheringManager tetheringManager = GetTetheringManagerForCurrentConnection();

        NetworkOperatorTetheringSessionAccessPointConfiguration sessionConfiguration =
          await SetUpSessionConfigurationAsync(tetheringManager);

        await StartTetheringSessionAsync(tetheringManager, sessionConfiguration);
      }
      catch (InvalidOperationException ex)
      {
        Console.WriteLine($"Failed to initialize tethering configuration: {ex.Message}.");
      }
      catch (Exception ex)
      {
        Console.WriteLine($"Unexpected error: {ex.Message}.");
      }
    }
  }
}
```
