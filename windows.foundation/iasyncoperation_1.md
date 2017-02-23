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
[IAsyncOperation&lt;TResult&gt;](iasyncoperation_1.md) is the return type for many Windows Runtime asynchronous methods that have a result upon completion, but don't report progress. This constitutes over 650 different Windows Runtime APIs. APIs that do report progress (and have a result) use another interface, [IAsyncOperationWithProgress&lt;TResult,TProgress&gt;](iasyncoperationwithprogress_2.md).

When you use methods that return [IAsyncOperation&lt;TResult&gt;](iasyncoperation_1.md) (with a **TResult** specific constraint) in your app code, you usually don't access the [IAsyncOperation](iasyncoperation_1.md) return value directly. That's because you almost always use the language-specific awaitable syntax. In this case, the apparent return value of the method is the type provided as the **TResult** parameter. For more info, see [Asynchronous programming](http://msdn.microsoft.com/library/23fe28f1-89c5-4a17-a732-a722648f9c5e), or one of the language-specific guides to Windows Runtime asynchronous programming ([Call asynchronous APIs in C# or Visual Basic](http://msdn.microsoft.com/library/066711e0-d5c4-467e-8683-3cc64edbcc83), [C++](http://msdn.microsoft.com/library/34c00f9f-2196-46a3-a32f-0067ab48291b), [JavaScript](http://msdn.microsoft.com/library/b1544667-77f5-4269-8d58-ad81d3ca5dcf)).


<!--There do not appear to be utilities eg ThreadPool that use IAsyncOperation-->
It's not common to use [IAsyncOperation&lt;TResult&gt;](iasyncoperation_1.md) directly even if you don't use a language-specific awaitable syntax. Each of the languages has extension points that are generally easier to use than the Windows Runtime interface. JavaScript has [WinJS.Promise](http://msdn.microsoft.com/library/df6a1939-0c42-4079-a9d5-ab49488d0375), and the **then/done** syntax. .NET has the [AsTask](https://msdn.microsoft.com/library/windows/apps/hh779207) extension method, and once the [IAsyncOperation&lt;TResult&gt;](iasyncoperation_1.md) is converted to a [Task&lt;TResult&gt;](https://msdn.microsoft.com/library/system.threading.tasks.task.aspx), it's easier to get the result, cancel, get notification on completion, and so on. For C++/CX, you can wrap the calls using the [Concurrency runtime](http://msdn.microsoft.com/library/f1d33ca2-679b-4442-b140-22a9d9df61d1) (and use [create_task](http://msdn.microsoft.com/library/6e364052-c923-4006-9e03-8516bf041482)). In other words, [IAsyncOperation&lt;TResult&gt;](iasyncoperation_1.md) can be considered runtime-level infrastructure, which each of the languages use as a framework to support awaitable syntax or asynchronous programming models in their own way.

Instead of using [IAsyncOperation&lt;TResult&gt;](iasyncoperation_1.md), some Windows Runtime asynchronous methods use custom operation types. For example, [DataReaderLoadOperation](../windows.storage.streams/datareaderloadoperation.md) is a Windows Runtime type that implements [IAsyncOperation](iasyncoperation_1.md) using **uint** as the result type. The [DataReaderLoadOperation](../windows.storage.streams/datareaderloadoperation.md) type is then used as the custom operation/result type for the [DataReader.LoadAsync](../windows.storage.streams/datareader_loadasync.md) method.

### Interface inheritance

[IAsyncOperation&lt;TResult&gt;](iasyncoperation_1.md) inherits [IAsyncInfo](iasyncinfo.md). Types that implement [IAsyncOperation&lt;TResult&gt;](iasyncoperation_1.md) also implement the interface members of [IAsyncInfo](iasyncinfo.md): 
+ [Cancel](iasyncinfo_cancel.md) method
+ [Close](iasyncinfo_close.md) method
+ [ErrorCode](iasyncinfo_errorcode.md) property
+ [Id](iasyncinfo_id.md) property
+ [Status](iasyncinfo_status.md) property


### Notes to implementers

As with calling the existing methods, there are language-specific ways to define asynchronous methods that don't use [IAsyncOperation&lt;TResult&gt;](iasyncoperation_1.md) directly. If writing code using .NET, your method can return a [Task&lt;TResult&gt;](https://msdn.microsoft.com/library/system.threading.tasks.task.aspx). For C++/CX, you can use the [Concurrency runtime](http://msdn.microsoft.com/library/f1d33ca2-679b-4442-b140-22a9d9df61d1). However, if you're defining a [ component](http://msdn.microsoft.com/library/9a6b8f0a-7d5e-40a0-a9c5-a59b4908e133), you can use **Task**/**task** internally but you must return one of the Windows Runtime interfaces for your public methods. The language-specific asynchronous support types (and many other language-specific types you might conventionally use in code) can't be used for the public surface area of a Windows Runtime component.

## -examples

## -see-also
[IAsyncInfo](iasyncinfo.md), [IAsyncOperationWithProgress&lt;TResult,TProgress&gt;](iasyncoperationwithprogress_2.md), [IAsyncAction](iasyncaction.md), [Task&lt;TResult&gt; (.NET)](https://msdn.microsoft.com/library/system.threading.tasks.task.aspx), [Asynchronous programming](http://msdn.microsoft.com/library/23fe28f1-89c5-4a17-a732-a722648f9c5e)