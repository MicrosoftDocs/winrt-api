---
-api-id: T:Windows.Foundation.IAsyncOperation`1
-api-type: winrt interface
---

<!-- Interface syntax.
public interface IAsyncOperation<TResult> : Windows.Foundation.IAsyncInfo
-->

# Windows.Foundation.IAsyncOperation<TResult>

## -description

Represents an asynchronous operation, which returns a result upon completion. This is the return type for many Windows Runtime (WinRT) asynchronous methods that have results but don't report progress.

## -remarks

`IAsyncOperation<TResult>` is the return type for many WinRT asynchronous methods that have a result upon completion, but don't report progress. This constitutes over 650 different WinRT APIs. APIs that report progress and have a result use another interface, [IAsyncOperationWithProgress<TResult,TProgress>](iasyncoperationwithprogress_2.md).

When you use methods that return `IAsyncOperation<TResult>` (with a `TResult` specific constraint) in your app code, you usually don't access the `IAsyncOperation` return value directly. That's because you almost always use the language-specific awaitable syntax. In this case, the apparent return value of the method is the type provided as the `TResult` parameter. For more info, see [Asynchronous programming](/windows/uwp/threading-async/asynchronous-programming-universal-windows-platform-apps), or one of the language-specific guides to WinRT asynchronous programming ([Call asynchronous APIs in C# or Visual Basic](/windows/uwp/threading-async/call-asynchronous-apis-in-csharp-or-visual-basic), [C++](/windows/uwp/threading-async/asynchronous-programming-in-cpp-universal-windows-platform-apps), [JavaScript](/previous-versions/windows/apps/hh700330(v=win.10))).

It's not common to use `IAsyncOperation<TResult>` directly even if you don't use a language-specific awaitable syntax. Each of the languages has extension points that are generally easier to use than the WinRT interface. JavaScript has [WinJS.Promise](/previous-versions/windows/apps/br211867(v=win.10)), and the `then`/`done` syntax. .NET has the [AsTask](/dotnet/api/system.windowsruntimesystemextensions.astask?view=dotnet-uwp-10.0&preserve-view=true) extension method, and once the `IAsyncOperation<TResult>` is converted to a [Task&lt;TResult&gt;](/dotnet/api/system.threading.tasks.task?view=dotnet-uwp-10.0&preserve-view=true), it's easier to get the result, cancel, get notification on completion, and so on. For C++/CX, you can wrap the calls using the [Concurrency runtime](/cpp/parallel/concrt/reference/concurrency-namespace) (and use [create_task](/cpp/parallel/concrt/reference/concurrency-namespace-functions?view=vs-2017)). In other words, `IAsyncOperation<TResult>` can be considered runtime-level infrastructure, which each of the languages use as a framework to support awaitable syntax or asynchronous programming models in their own way.

Instead of using `IAsyncOperation<TResult>`, some WinRT asynchronous methods use custom operation types. For example, [DataReaderLoadOperation](../windows.storage.streams/datareaderloadoperation.md) is a WinRT type that implements `IAsyncOperation` using `uint` as the result type. The [DataReaderLoadOperation](../windows.storage.streams/datareaderloadoperation.md) type is then used as the custom operation/result type for the [DataReader.LoadAsync](../windows.storage.streams/datareader_loadasync_972718946.md) method.

If you have a method that returns a .NET `Task<T>` and need an `IAsyncOperation<TResult>` to pass to a WinRT API, you can use the [AsAsyncOperation](/dotnet/api/system.windowsruntimesystemextensions.asasyncoperation?view=dotnet-uwp-10.0&preserve-view=true) extension method.

### C++/WinRT extension functions

> [!NOTE]
> Extension functions exist on the C++/WinRT projection types for certain WinRT APIs. For example, `winrt::Windows::Foundation::IAsyncAction` is the C++/WinRT projection type for [IAsyncAction](/uwp/api/windows.foundation.iasyncaction). The extension functions aren't part of the application binary interface (ABI) surface of the actual WinRT types, so they're not listed as members of the WinRT APIs. But you can call them from within any C++/WinRT project. See [C++/WinRT functions that extend Windows Runtime APIs](/uwp/cpp-ref-for-winrt/winrt#cwinrt-functions-that-extend-windows-runtime-apis).

```cppwinrt
TResult get() const;
```

Waits synchronously for the operation to complete, and returns the completed value. Throws a corresponding exception if the operation is canceled, or enters an error state. You mustn't call it from a single-threaded apartment. For more info, and code examples showing how to call `get`, see [Write a coroutine](/windows/uwp/cpp-and-winrt-apis/concurrency#write-a-coroutine).

```cppwinrt
AsyncStatus wait_for(TimeSpan const& timeout) const;
```

Waits synchronously for the operation to complete, or for the specified timeout. Returns the state of the `IAsyncOperation`, or [AsyncStatus::Started](/uwp/api/windows.foundation.asyncstatus) if the timeout elapsed. If the action didn't time out, then call [GetResults](/uwp/api/windows.foundation.iasyncoperation-1.getresults) to obtain the results of the operation. For more info, and code examples showing how to call `wait_for`, see [Asynchronous timeouts made easy](/windows/uwp/cpp-and-winrt-apis/concurrency-2#asynchronous-timeouts-made-easy).

### Interface inheritance

`IAsyncOperation<TResult>` inherits [IAsyncInfo](iasyncinfo.md). Types that implement `IAsyncOperation<TResult>` also implement the interface members of [IAsyncInfo](iasyncinfo.md):

+ [Cancel](iasyncinfo_cancel_1985564044.md) method
+ [Close](iasyncinfo_close_811482585.md) method
+ [ErrorCode](iasyncinfo_errorcode.md) property
+ [Id](iasyncinfo_id.md) property
+ [Status](iasyncinfo_status.md) property

### Notes to implementers

As with calling the existing methods, there are language-specific ways to define asynchronous methods that don't use `IAsyncOperation<TResult>` directly. If writing code using .NET, your method can return a [Task&lt;TResult&gt;](/dotnet/api/system.threading.tasks.task?view=dotnet-uwp-10.0&preserve-view=true). For C++/CX, you can use the [Concurrency runtime](/cpp/parallel/concrt/reference/concurrency-namespace). However, if you're defining a [component](/previous-versions/windows/apps/hh441572(v=vs.140)), you can use `Task`/`task` internally but you must return one of the WinRT interfaces for your public methods. The language-specific asynchronous support types (and many other language-specific types you might conventionally use in code) can't be used for the public surface area of a WinRT component.

## -examples

## -see-also

[IAsyncInfo](iasyncinfo.md), [IAsyncOperationWithProgress &lt;TResult,TProgress&gt;](iasyncoperationwithprogress_2.md), [IAsyncAction](iasyncaction.md), [Task](/dotnet/api/system.threading.tasks.task?view=dotnet-uwp-10.0&preserve-view=true), [Asynchronous programming](/windows/uwp/threading-async/asynchronous-programming-universal-windows-platform-apps), [Using a Windows Runtime Component](/previous-versions/windows/apps/jj712233(v=win.10)#using-a-windows-runtime-component)
