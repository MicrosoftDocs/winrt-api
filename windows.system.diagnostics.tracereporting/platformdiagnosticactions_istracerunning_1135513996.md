---
-api-id: M:Windows.System.Diagnostics.TraceReporting.PlatformDiagnosticActions.IsTraceRunning(Windows.System.Diagnostics.TraceReporting.PlatformDiagnosticTraceSlotType,System.Guid,System.UInt64)
-api-type: winrt method
---

<!-- Method syntax.
public PlatformDiagnosticTraceSlotState PlatformDiagnosticActions.IsTraceRunning(PlatformDiagnosticTraceSlotType slotType, Guid scenarioId, UInt64 traceProfileHash)
-->

# Windows.System.Diagnostics.TraceReporting.PlatformDiagnosticActions.IsTraceRunning


## -description

Whether a trace for the specified scenario is in progress.

## -parameters

### -param slotType

The slot for the scenario.

### -param scenarioId

The scenario identifier.

### -param traceProfileHash

The trace profile identifier.

## -returns

**True** if the specified trace is running; **false** otherwise.

## -remarks

Get a profile's hash from [GetKnownTraceList](platformdiagnosticactions_getknowntracelist_1006537213.md)

## -see-also

[PlatformDiagnosticTraceInfo](platformdiagnostictraceinfo.md)

