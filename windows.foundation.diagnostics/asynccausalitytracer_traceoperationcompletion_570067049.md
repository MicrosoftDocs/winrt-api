---
-api-id: M:Windows.Foundation.Diagnostics.AsyncCausalityTracer.TraceOperationCompletion(Windows.Foundation.Diagnostics.CausalityTraceLevel,Windows.Foundation.Diagnostics.CausalitySource,System.Guid,System.UInt64,Windows.Foundation.AsyncStatus)
-api-type: winrt method
---

<!-- Method syntax
public void TraceOperationCompletion(Windows.Foundation.Diagnostics.CausalityTraceLevel traceLevel, Windows.Foundation.Diagnostics.CausalitySource source, System.Guid platformId, System.UInt64 operationId, Windows.Foundation.AsyncStatus status)
-->

# Windows.Foundation.Diagnostics.AsyncCausalityTracer.TraceOperationCompletion

## -description
Indicates that a previously created asynchronous operation has completed all of its asynchronous work.

## -parameters
### -param traceLevel
The trace level.

### -param source
The trace source.

### -param platformId
Identifier for the operation type.

### -param operationId
The identifier for the asynchronous operation that's unique within the platform for the operation's lifetime.

### -param status
The completion status of the asynchronous operation.

## -remarks
This function is used to indicate that a previously created asynchronous operation has completed all of its asynchronous work. The only work that the operation may schedule after logging completion is its completion continuation. The *operationId* and *platformId* parameters must match an asynchronous operation that was previously logged by a call to the [TraceOperationCreation](asynccausalitytracer_traceoperationcreation_1939304732.md) method.

## -examples

## -see-also
[CausalityRelation](causalityrelation.md), [CausalitySource](causalitysource.md), [CausalitySynchronousWork](causalitysynchronouswork.md), [CausalityTraceLevel](causalitytracelevel.md), [TraceOperationCreation](asynccausalitytracer_traceoperationcreation_1939304732.md)