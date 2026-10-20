---
-api-id: P:Windows.System.Profile.AnalyticsVersionInfo.DeviceFamily
-api-type: winrt property
---

<!-- Property syntax
public string DeviceFamily { get; }
-->

# Windows.System.Profile.AnalyticsVersionInfo.DeviceFamily

## -description
Gets a string that represents the type of device the application is running on.

## -property-value
The device family.

## -remarks
The values of this property may change over time as new device families are introduced. You should not use this property to make runtime decisions; it is intended for analytics use only. For example, you could prioritize marketing activities based on data showing which device family the majority of your customers use.

The following values are currently defined:

| Value | Device family |
|-------|---------------|
| `Windows.Desktop` | Desktop PCs and tablets |
| `Windows.Holographic` | Mixed-reality headsets (HoloLens) |
| `Windows.IoT` | IoT devices |
| `Windows.Mobile` | Mobile devices (deprecated) |
| `Windows.Team` | Surface Hub |
| `Windows.Universal` | Universal (all devices) |
| `Windows.Xbox` | Xbox consoles |

For more information about device families, see [Device families overview](/uwp/extension-sdks/device-families-overview).

## -examples

## -see-also
[Device families overview](/uwp/extension-sdks/device-families-overview)
