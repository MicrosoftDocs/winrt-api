---
-api-id: M:Windows.UI.Core.CoreDispatcher.RunAsync(Windows.UI.Core.CoreDispatcherPriority,Windows.UI.Core.DispatchedHandler)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction RunAsync(Windows.UI.Core.CoreDispatcherPriority priority, Windows.UI.Core.DispatchedHandler agileCallback)
-->

# Windows.UI.Core.CoreDispatcher.RunAsync

## -description
Schedules the provided callback on the UI thread from a worker thread, and returns the results asynchronously.

## -parameters
### -param priority
Specifies the priority for event dispatch. Set this to [CoreDispatcherPriority.Normal](coredispatcherpriority.md).

### -param agileCallback
The callback on which the dispatcher returns when the event is dispatched.

## -returns
The object that provides handlers for the completed async event dispatch.

## -remarks
If you're on a worker thread, and you want to schedule work on the UI thread, use **CoreDispatcher.RunAsync**. Always set the priority to [CoreDispatcherPriority.Normal](coredispatcherpriority.md) or [CoreDispatcherPriority.Low](coredispatcherpriority.md), and ensure that any chained callbacks also use [CoreDispatcherPriority.Normal](coredispatcherpriority.md) or [CoreDispatcherPriority.Low](coredispatcherpriority.md).

> [!NOTE]
> Callbacks scheduled with [CoreDispatcherPriority.Low](coredispatcherpriority.md) priority are called when there are no pending input events. Use the [CoreDispatcherPriority.Low](coredispatcherpriority.md) priority to make your app UI more responsive. To schedule background tasks, use [CoreDispatcher.RunIdleAsync](coredispatcher_runidleasync_1309054974.md).

To spin off a worker thread from the UI thread, do not use this method (CoreDispatcher.RunAsync). Instead, use one of the [Windows.System.Threading.ThreadPool.RunAsync](../windows.system.threading/threadpool_runasync_514988780.md) method overloads.

This method completes successfully when the CoreDispatcher starts to shut down, but does not run the specified callback on the UI thread. Use [CoreDispatcher.TryRunAsync](coredispatcher_tryrunasync_1355560768.md) if you need to detect this case.

**C++/WinRT**. An alternative to **CoreDispatcher.RunAsync** is [**winrt::resume_foreground**](/uwp/cpp-ref-for-winrt/resume-foreground).

### Await a UI task sent from a background thread

When you update your UI from a background thread by calling **RunAsync**, it schedules the work on the UI thread, and returns control to the caller immediately. If you need to wait for async work to complete before returning, for example, waiting for user input in a dialog box, do not use **RunAsync** alone. **RunAsync** also doesn't provide a way for the task to return a result to the caller.

In this C# example, **RunAsync** returns without waiting for the user input from the dialog box. (**RunAsync** returns as soon as the code in the [lambda expression](/dotnet/articles/csharp/programming-guide/statements-expressions-operators/lambda-expressions) begins executing.)

```csharp
//DO NOT USE THIS CODE.

await Dispatcher.RunAsync(CoreDispatcherPriority.Normal, async () =>
{
   await signInDialog.ShowAsync(); 
});
// Execution continues here before the call to ShowAsync completes.
```

In this case, for C#, you need to use a [**TaskCompletionSource**](/dotnet/api/system.threading.tasks.taskcompletionsource-1) in combination with RunAsync to return a Task that you can await from your background thread, thereby pausing execution until the UI task completes. 

```csharp
public async Task<ContentDialogResult> SignInAsync()
{
    TaskCompletionSource<ContentDialogResult> taskCompletionSource = 
        new TaskCompletionSource<ContentDialogResult>();

    await Dispatcher.RunAsync(CoreDispatcherPriority.Normal, async () =>
    {
        try
        {
            taskCompletionSource.SetResult(await signInDialog.ShowAsync());
        }
        catch (Exception ex)
        {
            taskCompletionSource.SetException(ex);
        }
    });

    return await taskCompletionSource.Task;
}
```

> [!TIP]
> We recommend that you use the [RunTaskAsync extension method](https://github.com/Microsoft/Windows-task-snippets/blob/master/tasks/UI-thread-task-await-from-background-thread.md) from our task snippet library for this. It provides a robust solution that enables code running on a background thread to await a task that must run on the UI thread. See the [Await a UI task sent from a background thread](https://github.com/Microsoft/Windows-task-snippets/blob/master/tasks/UI-thread-task-await-from-background-thread.md) page for the code and example usage.

**C++/WinRT**. [**TaskCompletionSource**](/dotnet/api/system.threading.tasks.taskcompletionsource-1) is not available to C++/WinRT. For alternative options, see [A completion source sample](/windows/uwp/cpp-and-winrt-apis/concurrency-3).

### Porting from .NET

If you're porting from .NET code, and using **Dispatcher.BeginInvoke** and **Dispatcher.Invoke** methods, note that **CoreDispatcher.RunAsync** is asynchronous. There is no synchronous version. After you change **Dispatcher.Invoke** to **CoreDispatcher.RunAsync**, your code must support the Windows Runtime **async** pattern, and use the specific lambda syntax for your chosen language.

## -examples
The following examples demonstrate the use of Dispatcher.RunAsync to schedule work on the main UI thread using the [CoreWindow](corewindow.md)'s event dispatcher.

```csharp
await Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
{
   rootPage.NotifyUser("The toast encountered an error", NotifyType.ErrorMessage);
});

var ignored = Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
{
   Scenario3OutputText.Text += outputText;
});
```

```cppwinrt
TimerTextBlock().Dispatcher().RunAsync(Windows::UI::Core::CoreDispatcherPriority::Normal, [=]()
{
    ++m_count;
    std::wstringstream wstringstream;
    wstringstream << L"Total count: " << m_count;
    TimerTextBlock().Text(wstringstream.str().c_str());
});
```

```cppcx
// 
_Dispatcher->RunAsync(Windows::UI::Core::CoreDispatcherPriority::Normal, 
                     ref new Windows::UI::Core::DispatchedHandler([this]()
{
  _count++;
  TimerTextBlock->Text = "Total Running Time: " + _count.ToString() + " Seconds";
}));

// using CallbackContext::Any
void Playback::DisplayStatus(Platform::String^ text)
{
  _Dispatcher->RunAsync(Windows::UI::Core::CoreDispatcherPriority::Normal, 
                        ref new Windows::UI::Core::DispatchedHandler([=]()
  {
    _OutputStatus->Text += text + "\n";
  }, CallbackContext::Any)); 
}
```

## -see-also
[Asynchronous programming](/windows/uwp/threading-async/asynchronous-programming-universal-windows-platform-apps)
