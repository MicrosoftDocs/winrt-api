---
-api-id: T:Windows.UI.StartScreen.TileOptions
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.StartScreen.TileOptions : uint
-->

# TileOptions

## -description
> [!NOTE]
> TileOptions may be altered or unavailable for releases after Windows 8.1. Instead, use the properties specified in each value.

Specifies options available to a secondary tile.

## -enum-fields
### -field None:0
Default. Do not show the name on a secondary tile of any size.

### -field ShowNameOnLogo:1
Display the name on the medium version of the tile.

### -field ShowNameOnWideLogo:2
Display the name on the wide version of the tile.

### -field CopyOnDeployment:4
The tile will be reacquired from the cloud when the parent app is installed by the user, using their Microsoft account, on another computer.

> [!NOTE]
> As of Windows 8.1, secondary tile roaming is the default behavior. In Windows 8, you opted into roaming; as of Windows 8.1, you opt out. If Windows detects that the running version of the tile's app dates from before Windows 8.1, the absence of **CopyOnDeployment** is seen as equivalent to [RoamingEnabled](secondarytile_roamingenabled.md) ="false".


## -remarks

## -examples

## -see-also
[Secondary tiles sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Secondary%20tiles%20sample)
