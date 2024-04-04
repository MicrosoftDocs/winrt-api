---
-api-id: T:Windows.Networking.NetworkOperators.NetworkOperatorTetheringSessionAccessPointConfiguration
-api-type: winrt class
---

# Windows.Networking.NetworkOperators.NetworkOperatorTetheringSessionAccessPointConfiguration

<!--
public sealed class NetworkOperatorTetheringSessionAccessPointConfiguration
-->


## -description

Contains all per-session configuration fields used to configure the Wi-Fi tethering hotspot, plus relevant helper methods.

**NetworkOperatorTetheringSessionAccessPointConfiguration** contains the same fields and helper methods as its persistent counterpart [NetworkOperatorTetheringAccessPointConfiguration](./networkoperatortetheringaccesspointconfiguration.md) does, with several additions. But all the configurable properties from **NetworkOperatorTetheringSessionAccessPointConfiguration** are treated as per-session, including all the shared properties.

**NetworkOperatorTetheringSessionAccessPointConfiguration** is used primarily in combination with [StartTetheringAsync](./networkoperatortetheringmanager_starttetheringasync_1060696031.md) to specify the per-session tethering configuration. Doing so won't clear or alter the existing persistent configuration. Calling **StartTetheringAsync** with no parameters always uses the persistent configuration pre-configured via [ConfigureAccessPointAsync](./networkoperatortetheringmanager_configureaccesspointasync_1399951422.md).

## -remarks

Tethering is a feature that allows a Windows device to function as a mobile hotspot: providing internet connections to other devices over Wi-Fi or Bluetooth. Four persistent fields can be configured on the Wi-Fi tethering hotspot: the network SSID, the network password, the network wireless frequency band (for example, 2.4 GHz, 5 GHz, 6 GHz), and the network authentication algorithm (for example, WPA2, WPA3). Once set, all of those fields persist between tethering sessions; meaning that the values are stored in non-volatile storage.

But you can also start a tethering session using an entirely per-session configuration. A per-session tethering configuration doesn't persist between tethering sessions, and doesn't alter the current persistent configuration. A per-session field is *performance priority*.

So the purpose of **NetworkOperatorTetheringSessionAccessPointConfiguration** is to specify the per-session tethering configuration when starting the tethering session via [StartTetheringAsync](./networkoperatortetheringmanager_starttetheringasync_1060696031.md). The additional members of this per-session-only class are typically values that aren't currently configurable by users via Windows **Settings**.

## -see-also

## -examples

The tethering API in the **Windows.Networking.NetworkOperators** namespace provides a comprehensive set of functionalities that enable you to programmatically configure and control tethering (that is, sharing a device's internet connection with other devices). The code example below demonstrates the use of per-session tethering configurations.

With the per-session tethering configurations, you can temporarily override the persistent tethering hotspot configuration without permanently altering it. That's particularly useful when a temporary setting is required. For example, when connecting an HMD to a PC by using mobile hotspot, but when you want to make things as seamless as possible by connecting the device via a temporary Wi-Fi network, without revealing the configuration details to the user, and without altering the user's current mobile hotspot configuration.

Moreover, to achieve a low latency and low jitter connection to the PC, you might want to use a 6 GHz connection. If the user's PC is connected to the internet via a 5 GHz Wi-Fi connection, then the mobile hotspot can't be started on the 6 GHz band. So there's a per-session parameter, [PerformancePriority](./networkoperatortetheringsessionaccesspointconfiguration_performancepriority.md), that tells the driver how to prioritize performance between the tethering hotspot and the station connection. The [Default](./tetheringwifiperformancepriority.md) constant tells the driver to prioritize the station connection over everything else. On the other hand, [TetheringOverStation](./tetheringwifiperformancepriority.md) tells the driver to prioritize the performance of the tethering hotspot, thus allowing the driver to downgrade the station connection to 2.4 GHz if needed. This is all to offer the user as much of a seamless experience as possible, without requiring them to personally change the hotspot configuration and station connection.

The code sample below showcases:

* **API support verification**. It's important that your app tests whether the operating system it happens to be running on supports per-session tethering configurations. To do that, use the [ApiInformation.IsApiContractPresent](/uwp/api/windows.foundation.metadata.apiinformation.isapicontractpresent) method.
* **Obtaining the tethering manager**. The code sample's locally-defined **GetTetheringManagerForCurrentConnection** method identifies the internet connection profile in use, and retrieves a tethering manager that corresponds to that profile. The tethering manager is later used to retrieve the primary access point configuration, and start the actual tethering session.
* **Setting up the session configuration**. You can derive a tethering session configuration from the existing primary configuration, or set one up from scratch. You can then set or modify various parameters, like the SSID, passphrase, band, authentication kind, and performance priority.
* **Starting the tethering session**. The session configuration can be passed to the [StartTetheringAsync](./networkoperatortetheringmanager_starttetheringasync_1060696031.md) method to initiate the tethering session. This method also provides extensive feedback through the [TetheringOperationStatus](./tetheringoperationstatus.md) enum, offering a nuanced understanding of the operation's result.

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

## -capabilities
wiFiControl
