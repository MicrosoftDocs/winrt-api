---
-api-id: T:Windows.Networking.Connectivity.AttributedNetworkUsage
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class AttributedNetworkUsage : Windows.Networking.Connectivity.IAttributedNetworkUsage
-->

# Windows.Networking.Connectivity.AttributedNetworkUsage

## -description
Provides access to property values containing information on current usage of the attributed network connection.

## -remarks
The AttributedNetworkUsage class is retrieved from a [ConnectionProfile](connectionprofile.md) by calling the [GetAttributedNetworkUsageAsync](connectionprofile_getattributednetworkusageasync_1743384794.md) method.

> [!NOTE]
> Data usage tracking is not supported when an app is run on the emulator under Microsoft Visual Studio 2013 Update 2 instead of an actual device. As a result, the [GetAttributedNetworkUsageAsync](connectionprofile_getattributednetworkusageasync_1743384794.md) method in a Windows Phone 8.x app will fail when run on the emulator.

## -examples

## -see-also
[ConnectionProfile](connectionprofile.md), [GetAttributedNetworkUsageAsync](connectionprofile_getattributednetworkusageasync_1743384794.md)
