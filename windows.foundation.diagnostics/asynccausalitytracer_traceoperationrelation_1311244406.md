---
-api-id: M:Windows.Foundation.Diagnostics.AsyncCausalityTracer.TraceOperationRelation(Windows.Foundation.Diagnostics.CausalityTraceLevel,Windows.Foundation.Diagnostics.CausalitySource,System.Guid,System.UInt64,Windows.Foundation.Diagnostics.CausalityRelation)
-api-type: winrt method
---

<!-- Method syntax
public void TraceOperationRelation(Windows.Foundation.Diagnostics.CausalityTraceLevel traceLevel, Windows.Foundation.Diagnostics.CausalitySource source, System.Guid platformId, System.UInt64 operationId, Windows.Foundation.Diagnostics.CausalityRelation relation)
-->

# Windows.Foundation.Diagnostics.AsyncCausalityTracer.TraceOperationRelation

## -description
Logs the relation between the currently running synchronous work item and a specific asynchronous operation that it's related to.

## -parameters
### -param traceLevel
The trace level.

### -param source
The trace source.

### -param platformId
Identifier for the operation type.

### -param operationId
The identifier for the asynchronous operation that's unique within the platform for the operation's lifetime.

### -param relation
The relationship between the synchronous work item and asynchronous operation identified by *operationId*.

## -remarks
Causality relations track ways that synchronous work items may interact with asynchronous operations.

## -examples

## -see-also
[CausalityRelation](causalityrelation.md), [CausalitySource](causalitysource.md), [CausalitySynchronousWork](causalitysynchronouswork.md), [CausalityTraceLevel](causalitytracelevel.md)