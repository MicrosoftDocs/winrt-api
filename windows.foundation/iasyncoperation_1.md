---
-api-id: T:Windows.Foundation.IAsyncOperation`1
-api-type: winrt interface
---

<!-- Interface syntax.
public interface IAsyncOperation<TResult> : Windows.Foundation.IAsyncInfo
-->

# Windows.Foundation.IAsyncOperation<TResult>

## -description
Represents an asynchronous operation, which returns a result upon completion. This is the return type for many Windows Runtime asynchronous methods that have results but don't report progress.

## -remarks
IAsyncOperation&lt;TResult&gt; is the return type for many Windows Runtime asynchronous methods that have a result upon completion, but don't report progress. This constitutes over 650 different Windows Runtime APIs. APIs that do report progress (and have a result) use another interface, [IAsyncOperationWithProgress&lt;TResult,TProgress&gt;](iasyncoperationwithprogress_2.md).

When you use methods that return IAsyncOperation&lt;TResult&gt; (with a **TResult** specific constraint) in your app code, you usually don't access the IAsyncOperation return value directly. That's because you almost always use the language-specific awaitable syntax. In this case, the apparent return value of the method is the type provided as the **TResult** parameter. For more info, see [Asynchronous programming](https://docs.microsoft.com/windows/uwp/threading-async/asynchronous-programming-universal-windows-platform-apps), or one of the language-specific guides to Windows Runtime asynchronous programming ([Call asynchronous APIs in C# or Visual Basic](https://docs.microsoft.com/windows/uwp/threading-async/call-asynchronous-apis-in-csharp-or-visual-basic), [C++](https://docs.microsoft.com/windows/uwp/threading-async/asynchronous-programming-in-cpp-universal-windows-platform-apps), [JavaScript](https://docs.microsoft.com/previous-versions/windows/apps/hh700330(v=win.10))).


<!--There do not appear to be utilities eg ThreadPool that use IAsyncOperation-->
It's not common to use IAsyncOperation&lt;TResult&gt; directly even if you don't use a language-specific awaitable syntax. Each of the languages has extension points that are generally easier to use than the Windows Runtime interface. JavaScript has [WinJS.Promise](https://docs.microsoft.com/previous-versions/windows/apps/br211867(v=win.10)), and the **then/done** syntax. .NET has the [AsTask](https://docs.microsoft.com/en-us/dotnet/api/system.threading.tasks.valuetask-1.astask?view=netcore-2.2) extension method, and once the IAsyncOperation&lt;TResult&gt; is converted to a [Task&lt;TResult&gt;](https://docs.microsoft.com/dotnet/api/system.threading.tasks.task?redirectedfrom=MSDN), it's easier to get the result, cancel, get notification on completion, and so on. For C++/CX, you can wrap the calls using the [Concurrency runtime](https://docs.microsoft.com/cpp/parallel/concrt/reference/concurrency-namespace) (and use [create_task](https://docs.microsoft.com/cpp/parallel/concrt/reference/concurrency-namespace-functions?view=vs-2017)). In other words, IAsyncOperation&lt;TResult&gt; can be considered runtime-level infrastructure, which each of the languages use as a framework to support awaitable syntax or asynchronous programming models in their own way.

Instead of using IAsyncOperation&lt;TResult&gt;, some Windows Runtime asynchronous methods use custom operation types. For example, [DataReaderLoadOperation](../windows.storage.streams/datareaderloadoperation.md) is a Windows Runtime type that implements IAsyncOperation using **uint** as the result type. The [DataReaderLoadOperation](../windows.storage.streams/datareaderloadoperation.md) type is then used as the custom operation/result type for the [DataReader.LoadAsync](../windows.storage.streams/datareader_loadasync_972718946.md) method.

### Interface inheritance

IAsyncOperation&lt;TResult&gt; inherits [IAsyncInfo](iasyncinfo.md). Types that implement IAsyncOperation&lt;TResult&gt; also implement the interface members of [IAsyncInfo](iasyncinfo.md): 
+ [Cancel](iasyncinfo_cancel_1985564044.md) method
+ [Close](iasyncinfo_close_811482585.md) method
+ [ErrorCode](iasyncinfo_errorcode.md) property
+ [Id](iasyncinfo_id.md) property
+ [Status](iasyncinfo_status.md) property


### Notes to implementers

As with calling the existing methods, there are language-specific ways to define asynchronous methods that don't use IAsyncOperation&lt;TResult&gt; directly. If writing code using .NET, your method can return a [Task&lt;TResult&gt;](https://docs.microsoft.com/dotnet/api/system.threading.tasks.task?redirectedfrom=MSDN). For C++/CX, you can use the [Concurrency runtime](https://docs.microsoft.com/cpp/parallel/concrt/reference/concurrency-namespace). However, if you're defining a [ component](https://docs.microsoft.com/previous-versions/windows/apps/hh441572(v=vs.140)), you can use **Task**/**task** internally but you must return one of the Windows Runtime interfaces for your public methods. The language-specific asynchronous support types (and many other language-specific types you might conventionally use in code) can't be used for the public surface area of a Windows Runtime component.

## -examples

## -see-also
[IAsyncInfo](iasyncinfo.md), [IAsyncOperationWithProgress &lt;TResult,TProgress&gt;](iasyncoperationwithprogress_2.md), [IAsyncAction](iasyncaction.md), [Task](https://docs.microsoft.com/dotnet/api/system.threading.tasks.task?redirectedfrom=MSDN), [Asynchronous programming](https://docs.microsoft.com/windows/uwp/threading-async/asynchronous-programming-universal-windows-platform-apps), [Using a Windows Runtime Component](https://docs.microsoft.com/previous-versions/windows/apps/jj712233(v=win.10)#using-a-windows-runtime-component)
