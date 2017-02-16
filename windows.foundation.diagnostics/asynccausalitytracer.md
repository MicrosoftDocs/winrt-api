---
-api-id: T:Windows.Foundation.Diagnostics.AsyncCausalityTracer
-api-type: winrt class
---

<!-- Class syntax.
public class AsyncCausalityTracer 
-->

# Windows.Foundation.Diagnostics.AsyncCausalityTracer

## -description
Enables tracing control flow across asynchronous operations.

## -remarks
The [AsyncCausalityTracer](asynccausalitytracer.md) class provides methods that enable creating, propagating, and tracking causality as control flows across asynchronous operations. The causality is an abstraction for tracking both asynchronous and synchronous activities. You can use the collected data to develop causality graphs that are useful for debugging. Causality tracing uses event tracing for Windows (ETW) for logging.

## -examples

## -see-also
[CausalityRelation](causalityrelation.md), [CausalitySource](causalitysource.md), [CausalitySynchronousWork](causalitysynchronouswork.md), [CausalityTraceLevel](causalitytracelevel.md)