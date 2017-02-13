---
-api-id: P:Windows.System.Diagnostics.TraceReporting.PlatformDiagnosticTraceRuntimeInfo.RuntimeFileTime
-api-type: winrt property
---

<!-- Property syntax.
public long RuntimeFileTime { get; }
-->

# Windows.System.Diagnostics.TraceReporting.PlatformDiagnosticTraceRuntimeInfo.RuntimeFileTime

## -description
The timestamp (in ticks) for the trace.

## -property-value
The timestamp for the trace file.

## -remarks
A Windows file time is a 64-bit value that represents the number of 100-nanosecond intervals that have elapsed since 12:00 midnight, January 1, 1601 A.D. (C.E.) Coordinated Universal Time (UTC). Windows uses a file time to record when an application creates, accesses, or writes to a file.

Convert the return value to a DateTime with DateTime.FromFileTimeUtc();
