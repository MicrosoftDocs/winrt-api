---
-api-id: T:Windows.Foundation.IAsyncInfo
-api-type: winrt interface
---

<!-- Interface syntax.
public interface IAsyncInfo : 
-->

# Windows.Foundation.IAsyncInfo

## -description
Supports asynchronous actions and operations. [IAsyncInfo](iasyncinfo.md) is a base interface for [IAsyncAction](iasyncaction.md), [IAsyncActionWithProgress&lt;TProgress&gt;](iasyncactionwithprogress_1.md), [IAsyncOperation&lt;TResult&gt;](iasyncoperation_1.md) and [IAsyncOperationWithProgress&lt;TResult,TProgress&gt;](iasyncoperationwithprogress_2.md), each of which support combinations of return type and progress for an asynchronous method.

## -remarks
[IAsyncInfo](iasyncinfo.md) is an inherited interface for each of the 4 Windows Runtime interfaces that are used for asynchronous method support. These are:
+ [IAsyncAction](iasyncaction.md)
+ [IAsyncActionWithProgress&lt;TProgress&gt;](iasyncactionwithprogress_1.md)
+ [IAsyncOperation&lt;TResult&gt;](iasyncoperation_1.md)
+ [IAsyncOperationWithProgress&lt;TResult,TProgress&gt;](iasyncoperationwithprogress_2.md)


When you use asynchronous methods in your app code, you usually don't see any of these interfaces as the return value. That's because you almost always use the language-specific awaitable syntax, which handles the interfaces internally. For more info, see [Asynchronous programming](https://msdn.microsoft.com/library/23fe28f1-89c5-4a17-a732-a722648f9c5e), or one of the language-specific guides to Windows Runtime asynchronous programming ([Call asynchronous APIs in C# or Visual Basic](https://msdn.microsoft.com/library/066711e0-d5c4-467e-8683-3cc64edbcc83), [C++](https://msdn.microsoft.com/library/34c00f9f-2196-46a3-a32f-0067ab48291b), [JavaScript](https://msdn.microsoft.com/library/b1544667-77f5-4269-8d58-ad81d3ca5dcf)).

For most app code, it's uncommon to use [IAsyncInfo](iasyncinfo.md) as an API even if you don't use an awaitable syntax. Each of the languages has extension points that are generally easier to use than is the Windows Runtime[IAsyncInfo](iasyncinfo.md) interface. JavaScript has the **then/done** syntax. .NET has the [AsTask](https://msdn.microsoft.com/library/windows/apps/hh779207) extension method, and once the [IAsyncAction](iasyncaction.md) is converted to a [Task](https://msdn.microsoft.com/library/system.threading.tasks.task.aspx), it's easier to cancel, get notification on completion, and so on. For C++/CX, you can wrap the calls using the [Concurrency runtime](https://msdn.microsoft.com/library/f1d33ca2-679b-4442-b140-22a9d9df61d1). In other words, [IAsyncInfo](iasyncinfo.md) is runtime-level infrastructure, which each of the languages use as a framework to support awaitable syntax in their own way.

If you're implementing a custom action or custom operation (an advanced scenario) don't implement [IAsyncAction](iasyncaction.md) directly. Implement one of the 4 interfaces previously listed instead.

## -examples

## -see-also
[Asynchronous programming](https://msdn.microsoft.com/library/23fe28f1-89c5-4a17-a732-a722648f9c5e), [IAsyncAction](iasyncaction.md), [IAsyncOperation&lt;TResult&gt;](iasyncoperation_1.md)
