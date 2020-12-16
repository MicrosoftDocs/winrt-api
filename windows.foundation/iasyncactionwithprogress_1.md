---
-api-id: T:Windows.Foundation.IAsyncActionWithProgress`1
-api-type: winrt interface
---

<!-- Interface syntax.
public interface IAsyncActionWithProgress<TProgress> : Windows.Foundation.IAsyncInfo
-->

# Windows.Foundation.IAsyncActionWithProgress<TProgress>

## -description
Represents an asynchronous action that can report progress updates to callers. This is the return type for all Windows Runtime asynchronous methods that don't have a result object, but do report progress to callback listeners.

## -remarks
IAsyncActionWithProgress&lt;TProgress&gt; is the return type for all Windows Runtime asynchronous methods that don't communicate a result object, but do enable an app to check the progress of the action. There aren't nearly as many of these as there are methods that use [IAsyncAction](iasyncaction.md). [IAsyncAction](iasyncaction.md) APIs don't report progress and don't have a result.

When you use methods that return IAsyncActionWithProgress&lt;TProgress&gt; in your app code, you usually don't access the [IAsyncAction](iasyncaction.md) return value directly. That's because you almost always use the language-specific awaitable syntax. In this case, the apparent return value of the method is **void**. For more info, see [Asynchronous programming](/windows/uwp/threading-async/asynchronous-programming-universal-windows-platform-apps), or one of the language-specific guides to Windows Runtime asynchronous programming ([Call asynchronous APIs in C# or Visual Basic](/windows/uwp/threading-async/call-asynchronous-apis-in-csharp-or-visual-basic), [C++](/windows/uwp/threading-async/asynchronous-programming-in-cpp-universal-windows-platform-apps), [JavaScript](/previous-versions/windows/apps/hh700330(v=win.10))).

It's not common to use IAsyncActionWithProgress&lt;TProgress&gt; directly even if you don't use a language-specific awaitable syntax. Each of the languages has extension points that are generally easier to use than the Windows Runtime interface. JavaScript has [WinJS.Promise](/previous-versions/windows/apps/br211867(v=win.10)), and the **then/done** with **onProgress** syntax. .NET has the [AsTask](/dotnet/api/system.windowsruntimesystemextensions.astask?view=dotnet-uwp-10.0&preserve-view=true) extension methods, and once the IAsyncActionWithProgress&lt;TProgress&gt; is converted to a [Task](/dotnet/api/system.threading.tasks.task?view=dotnet-uwp-10.0&preserve-view=true), it's easier to cancel, get notification on completion, use [IProgress&lt;T&gt;](/dotnet/api/system.iprogress-1?view=dotnet-uwp-10.0&preserve-view=true), and so on. For C++/CX, you can wrap the calls using the [Concurrency runtime](/cpp/parallel/concrt/reference/concurrency-namespace) (and use [create_task](/cpp/parallel/concrt/reference/concurrency-namespace-functions?view=vs-2017)). In other words, IAsyncActionWithProgress&lt;TProgress&gt; can be considered runtime-level infrastructure, which each of the languages use as a framework to support awaitable syntax or asynchronous programming models in their own way.

Specifically, if you want to handle progress in .NET code, use the **AsTask** signature that in an extension usage has a single [IProgress](/dotnet/api/system.iprogress-1?view=dotnet-uwp-10.0&preserve-view=true) reference parameter. (In this usage, the progress unit is already constrained and matches the IAsyncActionWithProgress method you're using.) Provide an object that implements [IProgress](/dotnet/api/system.iprogress-1?view=dotnet-uwp-10.0&preserve-view=true), and your [Report](/dotnet/api/system.iprogress-1.report?view=dotnet-uwp-10.0&preserve-view=true) method implementation is invoked each time the Windows Runtime method reports a progress notification.

To monitor the progress of the action (if not using the language-specific techniques described above), set the [Progress](iasyncactionwithprogress_1_progress.md) property, providing it the name of a method that implements the [AsyncActionProgressHandler<TProgress>](asyncactionprogresshandler_1.md) delegate.

### Interface inheritance

IAsyncActionWithProgress&lt;TProgress&gt; inherits [IAsyncInfo](iasyncinfo.md).Types that implement IAsyncActionWithProgress&lt;TProgress&gt; also implement the interface members of [IAsyncInfo](iasyncinfo.md):
+ [Cancel](iasyncinfo_cancel_1985564044.md) method
+ [Close](iasyncinfo_close_811482585.md) method
+ [ErrorCode](iasyncinfo_errorcode.md) property
+ [Id](iasyncinfo_id.md) property
+ [Status](iasyncinfo_status.md) property


### Notes to implementers

As with calling the existing methods, there are language-specific ways to define asynchronous methods that don't use IAsyncActionWithProgress&lt;TProgress&gt; directly. If writing code using .NET, your method can return a [Task](/dotnet/api/system.threading.tasks.task?view=dotnet-uwp-10.0&preserve-view=true). For C++/CX, you can use the [Concurrency runtime](/cpp/parallel/concrt/reference/concurrency-namespace). However, if you're defining a [ component](/previous-versions/windows/apps/hh441572(v=vs.140)), you can use **Task**/**task** internally but you must return one of the Windows Runtime interfaces for your public methods. The language-specific asynchronous support types (and many other language-specific types you might conventionally use in code) can't be used for the public surface area of a Windows Runtime component.

## -examples
For example [C++/WinRT](/windows/uwp/cpp-and-winrt-apis/) code illustrating how to handle the **Progress** event, see [Delegate types for asynchronous actions and operations](/windows/uwp/cpp-and-winrt-apis/handle-events#delegate-types-for-asynchronous-actions-and-operations).

## -see-also
[IAsyncInfo](iasyncinfo.md), [IAsyncAction](iasyncaction.md)
