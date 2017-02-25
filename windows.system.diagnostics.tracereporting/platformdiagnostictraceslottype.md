---
-api-id: T:Windows.System.Diagnostics.TraceReporting.PlatformDiagnosticTraceSlotType
-api-type: winrt enumeration
---

<!-- Enumeration syntax.
public enum PlatformDiagnosticTraceSlotType : int {
	Alternative = 0
	AlwaysOn = 1
	Mini = 2
}
-->

# Windows.System.Diagnostics.TraceReporting.PlatformDiagnosticTraceSlotType
## -description
Describes the slot type that a trace can be assigned to.

## -enum-fields

## -field Mini:2
Always running, low impact traces, are assigned to this slot.

## -field AlwaysOn:1
A slot for long running traces. Traces in this slot are circular (they don't grow indefinitely ). This slot might be used to run a diagnostic trace for an infrequent failure. With the trace always running, you can gather trace information that immediately preceded the failure.

## -field Alternative:0
Traces that run briefly are assigned to this slot. For example, a user initiated trace that is started while the user reproduces a scenario, and then stops the trace, is assigned to this slot.

## -remarks
> [!IMPORTANT]
> Only first-party applications should use this type.  

A slot is used to manage the priority of the traces that are assigned to that slot.
