---
-api-id: P:Windows.System.Diagnostics.TraceReporting.PlatformDiagnosticTraceInfo.IsExclusive
-api-type: winrt property
---

<!-- Property syntax.
public bool IsExclusive { get; }
-->

# Windows.System.Diagnostics.TraceReporting.PlatformDiagnosticTraceInfo.IsExclusive

## -description
Indicates whether the trace is exclusive.

## -property-value
**true** - the trace is exclusive; **false** otherwise.

## -remarks
An exclusive trace can be the only trace running. All other traces will be throttled while an exclusive trace is running.
