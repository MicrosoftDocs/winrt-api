---
-api-id: M:Windows.Networking.Connectivity.NetworkInformation.GetLanIdentifiers
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.Collections.IVectorView<Windows.Networking.Connectivity.LanIdentifier> GetLanIdentifiers()
-->

# Windows.Networking.Connectivity.NetworkInformation.GetLanIdentifiers

## -description

> [!NOTE]
> **Some information relates to pre-released product, which may be substantially modified before it's commercially released. Microsoft makes no warranties, express or implied, with respect to the information provided here.**

> [!IMPORTANT]
> This API will be affected by upcoming changes to operating system behavior, planned for fall 2024. For more info, see [Changes to API behavior for Wi-Fi access and location](/windows/win32/nativewifi/wi-fi-access-location-changes).

Gets an array of [LanIdentifier](lanidentifier.md) objects that contain locality information for each [NetworkAdapter](networkadapter.md) object that currently connected to a network.

## -returns
An array of **LanIdentifier** objects.

## -remarks
For examples of how to retrieve [LanIdentifier](lanidentifier.md) objects and access the information they represent, see [How to retrieve network adapter and locality information](/previous-versions/windows/apps/hh465167(v=win.10)).

## -examples

## -see-also
