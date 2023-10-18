---
-api-id: T:Windows.Devices.WiFi.WiFiPhyKind
-api-type: winrt enum
-api-device-family-note: xbox
---

<!-- Enumeration syntax
public enum Windows.Devices.WiFi.WiFiPhyKind : int
-->

# WiFiPhyKind

## -description

> [!NOTE]
> **Some information relates to pre-released product, which may be substantially modified before it's commercially released. Microsoft makes no warranties, express or implied, with respect to the information provided here.**

> [!IMPORTANT]
> This API will be affected by upcoming changes to operating system behavior, planned for fall 2024. For more info, see [Changes to API behavior for Wi-Fi access and location](/windows/win32/nativewifi/wi-fi-access-location-changes).

Describes PHY types supported by standard 802.11.

## -enum-fields
### -field Unknown:0
Unspecified PHY type

### -field Fhss:1
Frequency-hopping, spread-spectrum (FHSS) PHY.

### -field Dsss:2
Direct sequence, spread-spectrum (DSSS) PHY.

### -field IRBaseband:3
Infrared (IR) baseband PHY.

### -field Ofdm:4
Orthogonal frequency division multiplex (OFDM) PHY.

### -field Hrdsss:5
High-rated DSSS (HRDSSS) PHY.

### -field Erp:6
Extended Rate (ERP) PHY.

### -field HT:7
High Throughput (HT) PHY for 802.11n PHY.

### -field Vht:8
Very High Throughput (VHT) PHY for 802.11ac PHY.

### -field Dmg:9
Directional multi-gigabit (DMG) PHY for 802.11ad.

### -field HE:10
High-Efficiency Wireless (HEW) PHY for 802.11ax.

## -remarks

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | Dmg |
| 1809 | 17763 | HE |

## -examples

## -see-also
