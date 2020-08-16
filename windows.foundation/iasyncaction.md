---
-api-id: T:Windows.Foundation.IAsyncAction
-api-type: winrt interface
---

<!-- Interface syntax.
public interface IAsyncAction : Windows.Foundation.IAsyncInfo
-->

# Windows.Foundation.IAsyncAction

## -description
Represents an asynchronous action. This is the return type for many Windows Runtime asynchronous methods that don't have a result object, and don't report ongoing progress.

## -remarks
IAsyncAction is the return type for all Windows Runtime asynchronous methods that don't communicate a result object, or ongoing progress. This constitutes over 300 different Windows Runtime APIs. APIs that do report progress (but don't have a result) use another interface, [IAsyncActionWithProgress&lt;TProgress&gt;](iasyncactionwithprogress_1.md).

When you use methods that return IAsyncAction in your app code, you usually don't access the IAsyncAction return value directly. That's because you almost always use the language-specific awaitable syntax. In this case, the apparent return value of the method is **void**. For more info, see [Asynchronous programming](https://docs.microsoft.com/windows/uwp/threading-async/asynchronous-programming-universal-windows-platform-apps), or one of the language-specific guides to Windows Runtime asynchronous programming ([Call asynchronous APIs in C# or Visual Basic](https://docs.microsoft.com/windows/uwp/threading-async/call-asynchronous-apis-in-csharp-or-visual-basic), [C++](https://docs.microsoft.com/windows/uwp/threading-async/asynchronous-programming-in-cpp-universal-windows-platform-apps), [JavaScript](https://docs.microsoft.com/previous-versions/windows/apps/hh700330(v=win.10))).

IAsyncAction is also an input type for some advanced-scenario utility APIs such as [CoreDispatcher.RunAsync](../windows.ui.core/coredispatcher_runasync_447339746.md) and [ThreadPool.RunAsync](../windows.system.threading/threadpool_runasync_514988780.md).

It's not common to use IAsyncAction directly even if you don't use a language-specific awaitable syntax. Each of the languages has extension points that are generally easier to use than the Windows Runtime interface. JavaScript has [WinJS.Promise](https://docs.microsoft.com/previous-versions/windows/apps/br211867(v=win.10)), and the **then/done** syntax. .NET has the [AsTask](https://docs.microsoft.com/dotnet/api/system?redirectedfrom=MSDN) extension method, and once the IAsyncAction is converted to a [Task](https://docs.microsoft.com/dotnet/api/system.threading.tasks.task?redirectedfrom=MSDN), it's easier to cancel, get notification on completion, and so on. For C++/CX, you can wrap the calls using the [Concurrency runtime](https://docs.microsoft.com/cpp/parallel/concrt/reference/concurrency-namespace) (and use [create_task](https://docs.microsoft.com/cpp/parallel/concrt/reference/concurrency-namespace-functions?view=vs-2017)). In other words, IAsyncAction can be considered runtime-level infrastructure, which each of the languages use as a framework to support awaitable syntax or asynchronous programming models in their own way.

Instead of using IAsyncAction, some Windows Runtime asynchronous methods use custom action types (which might have "Operation" rather than "Action" in their name). For example, [SignOutUserOperation](../windows.security.authentication.onlineid/signoutuseroperation.md) is a Windows Runtime type that implements IAsyncAction. The [SignOutUserOperation](../windows.security.authentication.onlineid/signoutuseroperation.md) type is then used as the custom action return type for the [SignOutUserAsync](../windows.security.authentication.onlineid/onlineidauthenticator_signoutuserasync_658229157.md) method.

> [!NOTE]
> The **get** function exists on the C++/WinRT projection type **winrt::Windows::Foundation::IAsyncAction**, so you can call the function from within any C++/WinRT project. You will not find the function listed as a member of the **IAsyncAction** interface, because **get** is not part of the application binary interface (ABI) surface of the actual Windows Runtime type **IAsyncAction**. For more info, and code examples showing how to call **get**, see [Write a coroutine](/windows/uwp/cpp-and-winrt-apis/concurrency#write-a-coroutine).
>
> Like **get**, the **wait_for** function exists only on the C++/WinRT projection. For more info, and code examples showing how to call **wait_for**, see [Asynchronous timeouts made easy](/windows/uwp/cpp-and-winrt-apis/concurrency-2#asynchronous-timeouts-made-easy).

### Interface inheritance

IAsyncAction inherits [IAsyncInfo](iasyncinfo.md). Types that implement IAsyncAction also implement the interface members of [IAsyncInfo](iasyncinfo.md):
+ [Cancel](iasyncinfo_cancel_1985564044.md) method
+ [Close](iasyncinfo_close_811482585.md) method
+ [ErrorCode](iasyncinfo_errorcode.md) property
+ [Id](iasyncinfo_id.md) property
+ [Status](iasyncinfo_status.md) property


### Notes to implementers

As with calling the existing methods, there are language-specific ways to define asynchronous methods that don't use [IAsyncInfo](iasyncinfo.md) directly. If writing code using .NET, your method can return a [Task](https://docs.microsoft.com/dotnet/api/system.threading.tasks.task?redirectedfrom=MSDN). For C++/CX, you can use the [Concurrency runtime](https://docs.microsoft.com/cpp/parallel/concrt/reference/concurrency-namespace). However, if you're defining a [ component](https://docs.microsoft.com/previous-versions/windows/apps/hh441572(v=vs.140)), you can use **Task**/**task** internally but you must return one of the Windows Runtime interfaces for your public methods. The language-specific asynchronous support types (and many other language-specific types you might conventionally use in code) can't be used for the public surface area of a Windows Runtime component.

## -examples

## -see-also
[IAsyncInfo](iasyncinfo.md), [IAsyncActionWithProgress&lt;TProgress&gt;](iasyncactionwithprogress_1.md), [Asynchronous programming](https://docs.microsoft.com/windows/uwp/threading-async/asynchronous-programming-universal-windows-platform-apps)
