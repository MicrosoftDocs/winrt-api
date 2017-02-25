---
-api-id: T:Windows.System.Diagnostics.TraceReporting.PlatformDiagnosticTraceSlotState
-api-type: winrt enumeration
---

<!-- Enumeration syntax.
public enum PlatformDiagnosticTraceSlotState : int {
	NotRunning = 0
	Running = 1
	Throttled = 2
}
-->

# Windows.System.Diagnostics.TraceReporting.PlatformDiagnosticTraceSlotState

## -description
Describes the state of a trace.

## -enum-fields

## -field Throttled:2
The trace is not running because another trace has higher priority, or the device is running on battery power.

## -field Running:1
The trace is running.

## -field NotRunning:0
The trace is not currently running.

## -remarks
> [!IMPORTANT]
> Only first-party applications should use this type.
