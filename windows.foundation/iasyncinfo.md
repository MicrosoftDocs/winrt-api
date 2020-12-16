---
-api-id: T:Windows.Foundation.IAsyncInfo
-api-type: winrt interface
---

<!-- Interface syntax.
public interface IAsyncInfo : 
-->

# Windows.Foundation.IAsyncInfo

## -description
Supports asynchronous actions and operations. IAsyncInfo is a base interface for [IAsyncAction](iasyncaction.md), [IAsyncActionWithProgress<TProgress>](iasyncactionwithprogress_1.md), [IAsyncOperation<TResult>](iasyncoperation_1.md) and [IAsyncOperationWithProgress<TResult,TProgress>](iasyncoperationwithprogress_2.md), each of which support combinations of return type and progress for an asynchronous method.

## -remarks
IAsyncInfo is an inherited interface for each of the 4 Windows Runtime interfaces that are used for asynchronous method support. These are:
+ [IAsyncAction](iasyncaction.md)
+ [IAsyncActionWithProgress<TProgress>](iasyncactionwithprogress_1.md)
+ [IAsyncOperation<TResult>](iasyncoperation_1.md)
+ [IAsyncOperationWithProgress<TResult,TProgress>](iasyncoperationwithprogress_2.md)


When you use asynchronous methods in your app code, you usually don't see any of these interfaces as the return value. That's because you almost always use the language-specific awaitable syntax, which handles the interfaces internally. For more info, see [Asynchronous programming](/windows/uwp/threading-async/asynchronous-programming-universal-windows-platform-apps), or one of the language-specific guides to Windows Runtime asynchronous programming ([Call asynchronous APIs in C# or Visual Basic](/windows/uwp/threading-async/call-asynchronous-apis-in-csharp-or-visual-basic), [C++](/windows/uwp/threading-async/asynchronous-programming-in-cpp-universal-windows-platform-apps), [JavaScript](/previous-versions/windows/apps/hh700330(v=win.10))).

For most app code, it's uncommon to use IAsyncInfo as an API even if you don't use an awaitable syntax. Each of the languages has extension points that are generally easier to use than is the Windows RuntimeIAsyncInfo interface. JavaScript has the **then/done** syntax. .NET has the [AsTask](/dotnet/api/system.windowsruntimesystemextensions.astask?view=dotnet-uwp-10.0&preserve-view=true) extension method, and once the [IAsyncAction](iasyncaction.md) is converted to a [Task](/dotnet/api/system.threading.tasks.task?view=dotnet-uwp-10.0&preserve-view=true), it's easier to cancel, get notification on completion, and so on. For C++/CX, you can wrap the calls using the [Concurrency runtime](/cpp/parallel/concrt/reference/concurrency-namespace). In other words, IAsyncInfo is runtime-level infrastructure, which each of the languages use as a framework to support awaitable syntax in their own way.

If you're implementing a custom action or custom operation (an advanced scenario) don't implement [IAsyncAction](iasyncaction.md) directly. Implement one of the 4 interfaces previously listed instead.

## -examples

## -see-also
[Asynchronous programming](/windows/uwp/threading-async/asynchronous-programming-universal-windows-platform-apps), [IAsyncAction](iasyncaction.md), [IAsyncOperation&lt;TResult&gt;](iasyncoperation_1.md)
