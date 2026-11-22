---
-api-id: T:Windows.Foundation.Metadata.RemoteAsyncAttribute
-api-type: winrt class
---

<!-- Class syntax.
public class RemoteAsyncAttribute : System.Attribute
-->

# Windows.Foundation.Metadata.RemoteAsyncAttribute

## -description
Indicates that an interface can be delivered using an asynchronous form of the Async pattern.

## -remarks

In IDL, this attribute is written as `[remote_async]`. Windows COM Async-Async supports methods that return [IAsyncAction](../windows.foundation/iasyncaction.md) or [IAsyncOperation&lt;TResult&gt;](../windows.foundation/iasyncoperation_1.md), allowing the initial cross-process call to return without waiting for the provider to return its asynchronous operation.

Methods that return [IAsyncActionWithProgress&lt;TProgress&gt;](../windows.foundation/iasyncactionwithprogress_1.md) or [IAsyncOperationWithProgress&lt;TResult, TProgress&gt;](../windows.foundation/iasyncoperationwithprogress_2.md) use synchronous initial dispatch even when annotated with `[remote_async]`. The initial call waits for the provider to return the asynchronous operation, not for the operation to complete. Progress reporting remains supported.

## -examples

## -see-also
[Attribute](/dotnet/api/system.attribute?view=dotnet-uwp-10.0&preserve-view=true)