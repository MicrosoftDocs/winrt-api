---
-api-id: T:Windows.System.Power.Thermal.PowerThermalChannelDiagnostics
-api-type: winrt class
---

# Windows.System.Power.Thermal.PowerThermalChannelDiagnostics

<!--
public sealed class PowerThermalChannelDiagnostics
-->


## -description

Provides APIs for retrieving diagnostics, health indicators, and recent samples for power/thermal channels.

## -remarks

Get an instance of this class from the singleton [PowerThermalChannelDiagnostics.Current](./powerthermalchanneldiagnostics_current.md).

The diagnostics class does not claim exclusive ownership of channels and should not be used as a replacement for a Consumer when exclusive ownership is required. Avoid using this class during tuning scenarios; if the backend driver is not running, methods may throw HRESULT_FROM_WIN32(ERROR_SERVICE_NOT_ACTIVE).

## -see-also

## -examples


