---
-api-id: T:Windows.Services.Maps.Guidance.GuidanceAudioMeasurementSystem
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Services.Maps.Guidance.GuidanceAudioMeasurementSystem : int
-->

# GuidanceAudioMeasurementSystem

## -description
Specifies the measurement system used for audio guidance.

> [!NOTE]
> This API is not available to all Windows apps. Unless your developer account is specially provisioned by Microsoft, calls to this API will fail at runtime. For more information about the [Windows.Services.Maps.Guidance](windows_services_maps_guidance.md) namespace, please work with your Microsoft Account Team representative.

## -enum-fields
### -field Meters:0
The metric system.

### -field MilesAndYards:1
The imperial system.

### -field MilesAndFeet:2
The United States customary system.


## -remarks
Regardless of the measurement system used for audio guidance ([AudioMeasurementSystem](guidancenavigator_audiomeasurementsystem.md)), the metric system is always used for distance and speed API values.

## -examples

## -see-also