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
[IAsyncAction](iasyncaction.md) is the return type for all Windows Runtime asynchronous methods that don't communicate a result object, or ongoing progress. This constitutes over 300 different Windows Runtime APIs. APIs that do report progress (but don't have a result) use another interface, [IAsyncActionWithProgress&lt;TProgress&gt;](iasyncactionwithprogress_1.md).

When you use methods that return [IAsyncAction](iasyncaction.md) in your app code, you usually don't access the [IAsyncAction](iasyncaction.md) return value directly. That's because you almost always use the language-specific awaitable syntax. In this case, the apparent return value of the method is **void**. For more info, see [Asynchronous programming](http://msdn.microsoft.com/library/23fe28f1-89c5-4a17-a732-a722648f9c5e), or one of the language-specific guides to Windows Runtime asynchronous programming ([Call asynchronous APIs in C# or Visual Basic](http://msdn.microsoft.com/library/066711e0-d5c4-467e-8683-3cc64edbcc83), [C++](http://msdn.microsoft.com/library/34c00f9f-2196-46a3-a32f-0067ab48291b), [JavaScript](http://msdn.microsoft.com/library/b1544667-77f5-4269-8d58-ad81d3ca5dcf)).

[IAsyncAction](iasyncaction.md) is also an input type for some advanced-scenario utility APIs such as [CoreDispatcher.RunAsync](../windows.ui.core/coredispatcher_runasync.md) and [ThreadPool.RunAsync](../windows.system.threading/threadpool_runasync.md).

It's not common to use [IAsyncAction](iasyncaction.md) directly even if you don't use a language-specific awaitable syntax. Each of the languages has extension points that are generally easier to use than the Windows Runtime interface. JavaScript has [WinJS.Promise](http://msdn.microsoft.com/library/df6a1939-0c42-4079-a9d5-ab49488d0375), and the **then/done** syntax. .NET has the [AsTask](https://msdn.microsoft.com/library/hh779334) extension method, and once the [IAsyncAction](iasyncaction.md) is converted to a [Task](https://msdn.microsoft.com/library/system.threading.tasks.task.aspx), it's easier to cancel, get notification on completion, and so on. For C++/CX, you can wrap the calls using the [Concurrency runtime](http://msdn.microsoft.com/library/f1d33ca2-679b-4442-b140-22a9d9df61d1) (and use [create_task](http://msdn.microsoft.com/library/6e364052-c923-4006-9e03-8516bf041482)). In other words, [IAsyncAction](iasyncaction.md) can be considered runtime-level infrastructure, which each of the languages use as a framework to support awaitable syntax or asynchronous programming models in their own way.

Instead of using [IAsyncAction](iasyncaction.md), some Windows Runtime asynchronous methods use custom action types (which might have "Operation" rather than "Action" in their name). For example, [SignOutUserOperation](../windows.security.authentication.onlineid/signoutuseroperation.md) is a Windows Runtime type that implements [IAsyncAction](iasyncaction.md). The [SignOutUserOperation](../windows.security.authentication.onlineid/signoutuseroperation.md) type is then used as the custom action return type for the [SignOutUserAsync](../windows.security.authentication.onlineid/onlineidauthenticator_signoutuserasync.md) method.

### Interface inheritance

[IAsyncAction](iasyncaction.md) inherits [IAsyncInfo](iasyncinfo.md). Types that implement [IAsyncAction](iasyncaction.md) also implement the interface members of [IAsyncInfo](iasyncinfo.md):
+ [Cancel](iasyncinfo_cancel.md) method
+ [Close](iasyncinfo_close.md) method
+ [ErrorCode](iasyncinfo_errorcode.md) property
+ [Id](iasyncinfo_id.md) property
+ [Status](iasyncinfo_status.md) property


### Notes to implementers

As with calling the existing methods, there are language-specific ways to define asynchronous methods that don't use [IAsyncInfo](iasyncinfo.md) directly. If writing code using .NET, your method can return a [Task](https://msdn.microsoft.com/library/system.threading.tasks.task.aspx). For C++/CX, you can use the [Concurrency runtime](http://msdn.microsoft.com/library/f1d33ca2-679b-4442-b140-22a9d9df61d1). However, if you're defining a [ component](http://msdn.microsoft.com/library/9a6b8f0a-7d5e-40a0-a9c5-a59b4908e133), you can use **Task**/**task** internally but you must return one of the Windows Runtime interfaces for your public methods. The language-specific asynchronous support types (and many other language-specific types you might conventionally use in code) can't be used for the public surface area of a Windows Runtime component.

## -examples

## -see-also
[IAsyncInfo](iasyncinfo.md), [IAsyncActionWithProgress&lt;TProgress&gt;](iasyncactionwithprogress_1.md), [Asynchronous programming](http://msdn.microsoft.com/library/23fe28f1-89c5-4a17-a732-a722648f9c5e)