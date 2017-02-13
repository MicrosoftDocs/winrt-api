---
-api-id: P:Windows.System.Diagnostics.TraceReporting.PlatformDiagnosticTraceInfo.MaxTraceDurationFileTime
-api-type: winrt property
---

<!-- Property syntax.
public long MaxTraceDurationFileTime { get; }
-->

# Windows.System.Diagnostics.TraceReporting.PlatformDiagnosticTraceInfo.MaxTraceDurationFileTime

## -description
Trace files are circular. This property reflects the amount of time that will pass before the trace file starts writing over itself--starting at the beginning of the file.

## -property-value
The amount of time until the file overwrites itself, expressed in clock ticks.
