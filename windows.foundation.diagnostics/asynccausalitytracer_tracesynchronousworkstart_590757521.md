---
-api-id: M:Windows.Foundation.Diagnostics.AsyncCausalityTracer.TraceSynchronousWorkStart(Windows.Foundation.Diagnostics.CausalityTraceLevel,Windows.Foundation.Diagnostics.CausalitySource,System.Guid,System.UInt64,Windows.Foundation.Diagnostics.CausalitySynchronousWork)
-api-type: winrt method
---

<!-- Method syntax
public void TraceSynchronousWorkStart(Windows.Foundation.Diagnostics.CausalityTraceLevel traceLevel, Windows.Foundation.Diagnostics.CausalitySource source, System.Guid platformId, System.UInt64 operationId, Windows.Foundation.Diagnostics.CausalitySynchronousWork work)
-->

# Windows.Foundation.Diagnostics.AsyncCausalityTracer.TraceSynchronousWorkStart

## -description
Indicates that the specified asynchronous operation is scheduling synchronous work on the thread that the [TraceSynchronousWorkStart](asynccausalitytracer_tracesynchronousworkstart_590757521.md) method is called on.

## -parameters
### -param traceLevel
The trace level.

### -param source
The trace source.

### -param platformId
Identifier for the operation type.

### -param operationId
The identifier for the asynchronous operation that's unique within the platform for the operation's lifetime.

### -param work
The relationship between the work item and the asynchronous operation.

## -remarks

## -examples

## -see-also
[CausalityRelation](causalityrelation.md), [CausalitySource](causalitysource.md), [CausalitySynchronousWork](causalitysynchronouswork.md), [CausalityTraceLevel](causalitytracelevel.md)