---
-api-id: M:Windows.Devices.WiFi.WiFiAdapter.GetWpsConfigurationAsync(Windows.Devices.WiFi.WiFiAvailableNetwork)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<WiFiWpsConfigurationResult> WiFiAdapter.GetWpsConfigurationAsync(WiFiAvailableNetwork availableNetwork)
-->

# Windows.Devices.WiFi.WiFiAdapter.GetWpsConfigurationAsync

## -description

> [!IMPORTANT]
> Location consent is now required for Wi-Fi BSSID access. For details on how this affects apps using Wi-Fi or location APIs,
> see [Changes to API behavior for Wi-Fi access and location](/windows/win32/nativewifi/wi-fi-access-location-changes).

Performs WPS discovery to query the WPS methods supported by the network.
## -parameters
### -param availableNetwork
An available Wi-Fi network. See WiFiAvailableNetwork class.
## -returns
On successful completion, returns a [WiFiWpsConfigurationResult](WiFiWpsConfigurationResult.md).
## -remarks

## -see-also
[WiFiWpsConfigurationResult](WiFiWpsConfigurationResult.md), [WiFiAvailableNetwork](WiFiAvailableNetwork.md)
## -examples

