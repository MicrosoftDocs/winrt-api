---
-api-id: T:Windows.System.Power.Thermal.PowerThermalBackEndStatus
-api-type: winrt enum
---

# Windows.System.Power.Thermal.PowerThermalBackEndStatus

<!--
public enum PowerThermalBackEndStatus
-->

## -description

Represents the backend operational state of the power/thermal subsystem. Use values to determine whether the backend is started or stopped.

## -enum-fields

### -field Stopped: 0

The power/thermal backend is not running.

### -field Started: 1

The power/thermal backend is running and responsive.

## -remarks

**PowerThermalBackEndStatus** is expected to be **Started** in normal operation; **Stopped** typically indicates the MPTF backend was restarted (for example, during tuning). Clients should stop reading or publishing data while the backend is Stopped and resume when it reports **Started**. The enum is preferred over a Boolean for clarity and is not expected to be extended.

## -see-also

## -examples


