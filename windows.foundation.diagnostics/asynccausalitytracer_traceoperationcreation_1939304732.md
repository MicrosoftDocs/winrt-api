---
-api-id: M:Windows.Foundation.Diagnostics.AsyncCausalityTracer.TraceOperationCreation(Windows.Foundation.Diagnostics.CausalityTraceLevel,Windows.Foundation.Diagnostics.CausalitySource,System.Guid,System.UInt64,System.String,System.UInt64)
-api-type: winrt method
---

<!-- Method syntax
public void TraceOperationCreation(Windows.Foundation.Diagnostics.CausalityTraceLevel traceLevel, Windows.Foundation.Diagnostics.CausalitySource source, System.Guid platformId, System.UInt64 operationId, System.String operationName, System.UInt64 relatedContext)
-->

# Windows.Foundation.Diagnostics.AsyncCausalityTracer.TraceOperationCreation

## -description
Logs the creation of an asynchronous operation.

## -parameters
### -param traceLevel
The trace level.

### -param source
The trace source.

### -param platformId
Identifier for the operation type.

### -param operationId
An identifier for the asynchronous operation that's unique within the platform for the operation's lifetime.

### -param operationName
A human-readable description of the asynchronous work.

### -param relatedContext
Additional information related to this operation.

## -remarks
Use the [TraceOperationCreation](asynccausalitytracer_traceoperationcreation_1939304732.md) method to log the creation of an asynchronous operation. An asynchronous operation represents a group of zero or more related synchronous work items that may be scheduled in an asynchronous way. Each asynchronous operation has a 128-bit GUID that identifies the operation type, like BCL task and WinJS Promise, and a **UInt64** operation identifier that must be unique within the platform for the lifetime of the asynchronous operation. Good choices for *operationId* include a native pointer to an underlying object, or an integer that's incremented for each new operation. The *operationName* should be a human readable description of the asynchronous work. The *relatedContext* associates any additional information related to this operation.

## -examples

## -see-also
[CausalityRelation](causalityrelation.md), [CausalitySource](causalitysource.md), [CausalitySynchronousWork](causalitysynchronouswork.md), [CausalityTraceLevel](causalitytracelevel.md)