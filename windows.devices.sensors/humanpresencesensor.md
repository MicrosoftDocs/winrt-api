---
-api-id: T:Windows.Devices.Sensors.HumanPresenceSensor
-api-type: winrt class
---

# Windows.Devices.Sensors.HumanPresenceSensor

<!--
public sealed class HumanPresenceSensor
-->

## -description

Represents a sensor that detects whether a user is present, absent, or not interacting with their device.

<!-- > [!Important]
> To access a human presence sensor, you must declare the `Motion activity` capability in your [app package manifest](/uwp/schemas/appxpackage/appx-package-manifest). For more details, see [App capability declarations](/windows/uwp/packaging/app-capability-declarations).
 -->
## -remarks

Presence detection can have a significant impact on security, responsiveness, and performance.

- Devices can be locked automatically when left unattended to protect sensitive files and other info.
- User intent can be inferred to reduce the response time required from detection to authentication or interaction.
- Battery life can be preserved by reducing unnecessary screen idle time.

## -see-also

[HumanPresenceSensorReading](humanpresencesensorreading.md), [HumanPresenceFeatures](humanpresencefeatures.md), [HumanPresenceSettings](humanpresencesettings.md), [Device experiences - Presence sensing](/windows-hardware/design/device-experiences/sensors-presence-sensing), [Device experiences - Wake on approach](/windows-hardware/design/device-experiences/sensors-presence-wake-on-approach), [Device experiences - Lock on leave](/windows-hardware/design/device-experiences/sensors-presence-lock-on-leave), [Device experiences - Adaptive dimming](/windows-hardware/design/device-experiences/sensors-presence-adaptive-dimming)

## -examples
