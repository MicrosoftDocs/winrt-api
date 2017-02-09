---
-api-id: T:Windows.System.Diagnostics.Telemetry.PlatformTelemetryRegistrationStatus
-api-type: winrt enumeration
---

<!-- Enumeration syntax.
public enum PlatformTelemetryRegistrationStatus : int {
	SettingsOutOfRange = 1
	Success = 0
	UnknownFailure = 2
}
-->

# Windows.System.Diagnostics.Telemetry.PlatformTelemetryRegistrationStatus

## -description
Provides information about the status of registering a client with the Connected User Experience and Telemetry component.

## -enum-fields

## -field UnknownFailure:2
Registration failed for another unknown reason.

## -field Success:0
Registration is successful or the app has already been registered.

## -field SettingsOutOfRange:1
The registration settings are invalid.

## -remarks
> [!IMPORTANT]
> Only first-party applications should use this type.

## -see-also

## -examples

