---
-api-id: M:Windows.Networking.NetworkOperators.NetworkOperatorTetheringAccessPointConfiguration.IsAuthenticationKindSupportedAsync(Windows.Networking.NetworkOperators.TetheringWiFiAuthenticationKind)
-api-type: winrt method
---

# Windows.Networking.NetworkOperators.NetworkOperatorTetheringAccessPointConfiguration.IsAuthenticationKindSupportedAsync(Windows.Networking.NetworkOperators.TetheringWiFiAuthenticationKind)

<!--
public Windows.Foundation.IAsyncOperation<bool> IsAuthenticationKindSupportedAsync (Windows.Networking.NetworkOperators.TetheringWiFiAuthenticationKind authenticationKind);
-->


## -description

Asynchronously retrieves a value indicating whether the Wi-Fi adapter allows configuring the access point with a specific authentication kind.

## -parameters

### -param authenticationKind

A [TetheringWiFiAuthenticationKind](./tetheringwifiauthenticationkind.md) enumeration value, specifying the authentication kind to query about.

## -returns

An asynchronous operation object which, when it completes, contains `true` if the authentication kind is supported; otherwise, `false`.

## -remarks

## -see-also

## -examples

The code example below lists two public methods: for setting the band and the authentication kind for a tethering connection. There's also an example private method for fetching the current tethering configuration of the active internet connection on the machine. The tethering configuration object contains the band and authentication kind properties that are being set, and it's the sole parameter for the [ConfigureAccessPointAsync](./networkoperatortetheringmanager_configureaccesspointasync_1399951422.md) API that's used to apply the changes.

In **Main**, the first few lines of code set the band (using the 6 GHz value, if it's available). Also notice the use of the [ApiInformation](/uwp/api/windows.foundation.metadata.apiinformation) class to check whether a particular authentication kind is supported. After that, the code sets the authentication kind. This code demonstrates the use of enumeration values from [TetheringWiFiBand](./tetheringwifiband.md) and [TetheringWiFiAuthenticationKind](./tetheringwifiauthenticationkind.md).

In the public methods **SetBandForWiFiAccessPointAsync** and **SetAuthenticationKindForWiFiAccessPointAsync**, the code showcases the following:

* Fetching the AP configuration for the active internet connection on the machine.
* Updating the band and authentication kind properties on the configuration object ([NetworkOperatorTetheringAccessPointConfiguration](./networkoperatortetheringaccesspointconfiguration.md)).
* Applying the updated configuration, and returning the successfully applied configuration (or `null` in the case of failure).

```csharp
using System;
using System.Threading.Tasks;
using Windows.Foundation.Metadata;
using Windows.Networking.NetworkOperators;
using Windows.Networking.Connectivity;

namespace DemoApp
{
    class DemoClass
    {
        private static NetworkOperatorTetheringAccessPointConfiguration GetCurrentAPConfig()
        {
            // Get the connection profile associated with the internet connection currently used by the local machine.
            ConnectionProfile currentConnectionProfile = NetworkInformation.GetInternetConnectionProfile();
            if (currentConnectionProfile == null)
            {
                throw new InvalidOperationException("Machine isn't connected to the internet.");
            }

            NetworkOperatorTetheringManager tetheringManager =
                NetworkOperatorTetheringManager.CreateFromConnectionProfile(currentConnectionProfile);

            NetworkOperatorTetheringAccessPointConfiguration configuration =
                tetheringManager.GetCurrentAccessPointConfiguration();

            return configuration;
        }

        public static async Task<NetworkOperatorTetheringAccessPointConfiguration>
            SetBandForWiFiAccessPointAsync(TetheringWiFiBand wifiBand)
        {
            NetworkOperatorTetheringAccessPointConfiguration configuration = GetCurrentAPConfig();

            if (!await configuration.IsBandSupportedAsync(wifiBand))
            {
                throw new ArgumentException("Band parameter isn't supported on AP.");
            }

            configuration.Band = wifiBand;

            try
            {
                await tetheringManager.ConfigureAccessPointAsync(configuration);

                return configuration;
            }
            catch
            {
                return null;
            }
        }

        public static async Task<NetworkOperatorTetheringAccessPointConfiguration>
            SetAuthenticationKindForWiFiAccessPointAsync(TetheringWiFiAuthenticationKind wiFiAuthenticationKind)
        {
            if (!ApiInformation.IsApiContractPresent("Windows.Foundation.UniversalApiContract", 16))
            {
                throw new InvalidOperationException("OS doesn't support configuring auth.");
            }

            NetworkOperatorTetheringAccessPointConfiguration configuration = GetCurrentAPConfig();

            if (!await configuration.IsAuthenticationKindSupportedAsync(wiFiAuthenticationKind))
            {
                throw new ArgumentException("Authentication kind parameter isn't supported on AP.");
            }

            configuration.AuthenticationKind = wiFiAuthenticationKind;

            try
            {
                await tetheringManager.ConfigureAccessPointAsync(configuration);

                return configuration;
            }
            catch
            {
                return null;
            }
        }

        public static void Main()
        {
            NetworkOperatorTetheringAccessPointConfiguration sampleResult1 = null;
            if (ApiInformation.IsEnumNamedValuePresent(
                "Windows.Networking.NetworkOperators.TetheringWiFiBand", "SixGigahertz"))
            {
                sampleResult1 = await SetBandForWiFiAccessPointAsync(TetheringWiFiBand.SixGigahertz);
            }
            else
            {
                sampleResult1 = await SetBandForWiFiAccessPointAsync(TetheringWiFiBand.FiveGigahertz);
            }

            NetworkOperatorTetheringAccessPointConfiguration sampleResult2 =
                await SetAuthenticationKindForWiFiAccessPointAsync(TetheringWiFiAuthenticationKind.Wpa3);
        }
    }
}
```

## -capabilities
wiFiControl
