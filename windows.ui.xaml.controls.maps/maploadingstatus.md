---
-api-id: T:Windows.UI.Xaml.Controls.Maps.MapLoadingStatus
-api-type: winrt enum
ms.custom: 19H1
---

<!-- Enumeration syntax
public enum Windows.UI.Xaml.Controls.Maps.MapLoadingStatus : int
-->

# MapLoadingStatus

## -description

Specifies the [LoadingStatus](mapcontrol_loadingstatus.md) of the [MapControl](mapcontrol.md).

## -enum-fields

### -field Loading:0

The map is loading.

### -field Loaded:1

The map is loaded.

### -field DataUnavailable:2

Map data is unavailable.

### -field DownloadedMapsManagerUnavailable:3

Downloaded maps manager is unavailable

## -remarks

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1511 | 10586 | DataUnavailable |
| 1903 | 18362 | DownloadedMapsManagerUnavailable |

## -examples

## -see-also
[Display maps with 2D, 3D, and Streetside views](/windows/uwp/maps-and-location/display-maps)
