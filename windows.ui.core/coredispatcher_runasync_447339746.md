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
If you are on a worker thread and want to schedule work on the UI thread, use [CoreDispatcher.RunAsync](coredispatcher_runasync_447339746.md). Always set the priority to [CoreDispatcherPriority.Normal](coredispatcherpriority.md) or [CoreDispatcherPriority.Low](coredispatcherpriority.md), and ensure that any chained callbacks also use [CoreDispatcherPriority.Normal](coredispatcherpriority.md) or [CoreDispatcherPriority.Low](coredispatcherpriority.md).

> [!NOTE]
> Callbacks scheduled with [CoreDispatcherPriority.Low](coredispatcherpriority.md) priority are called when there are no pending input events. Use the [CoreDispatcherPriority.Low](coredispatcherpriority.md) priority to make your app UI more responsive. To schedule background tasks, use [CoreDispatcher.RunIdleAsync](coredispatcher_runidleasync_1309054974.md).

To spin off a worker thread from the UI thread, do not use this method ([CoreDispatcher.RunAsync](coredispatcher_runasync_447339746.md)). Instead, use one of the [Windows.System.Threading.ThreadPool.RunAsync](../windows.system.threading/threadpool_runasync_514988780.md) method overloads.

This method completes successfully when the CoreDispatcher starts to shut down, but does not run the specified callback on the UI thread. Use [CoreDispatcher.TryRunAsync](CoreDispatcher.TryRunAsync) if you need to detect this case.

### Await a UI task sent from a background thread

When you update your UI from a background thread by calling [RunAsync](coredispatcher_runasync_447339746.md), it schedules the work on the UI thread and returns control to the caller immediately. If you need to wait for async work to complete before returning, for example, waiting for user input in a dialog box, do not use [RunAsync](coredispatcher_runasync_447339746.md) alone. [RunAsync](coredispatcher_runasync_447339746.md) also does not provide a way for the task to return a result to the caller.

In this example, [RunAsync](coredispatcher_runasync_447339746.md) returns without waiting for the user input from the dialog box. ([RunAsync](coredispatcher_runasync_447339746.md) returns as soon as the code in the [lambda expression](https://msdn.microsoft.com/library/bb397687.aspx) begins executing.)

```csharp
//DO NOT USE THIS CODE.

await dispatcher.RunAsync(CoreDispatcherPriority.Normal, async () =>
{
   await signInDialog.ShowAsync(); 
});
// Execution continues here before the call to ShowAsync completes.
```

In this case, you need to use a [TaskCompletionSource](https://msdn.microsoft.com/library/dd449174.aspx) in combination with [RunAsync](coredispatcher_runasync_447339746.md) to return a Task that you can await from your background thread, thereby pausing execution until the UI task completes. We recommend that you use the [RunTaskAsync extension method](https://github.com/Microsoft/Windows-task-snippets/blob/master/tasks/UI-thread-task-await-from-background-thread.md) from our task snippet library for this. It provides a robust solution that enables code running on a background thread to await a task that must run on the UI thread. See the [Await a UI task sent from a background thread](https://github.com/Microsoft/Windows-task-snippets/blob/master/tasks/UI-thread-task-await-from-background-thread.md) page for the code and example usage.

### Porting from .NET

If you are porting from .NET code and using **Dispatcher.BeginInvoke** and **Dispatcher.Invoke** methods, note that [CoreDispatcher.RunAsync](coredispatcher_runasync_447339746.md) is asynchronous. There is no synchronous version. After you change **Dispatcher.Invoke** to [CoreDispatcher.RunAsync](coredispatcher_runasync_447339746.md), your code must support the Windows Runtime**async** pattern and use the specific lambda syntax for your chosen language.

## -examples
The following examples demonstrate the use of [CoreDispatcher.RunAsync](coredispatcher_runasync_447339746.md) to schedule work on the main UI thread using the [CoreWindow](corewindow.md) 's event dispatcher.

```csharp
await dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
{
   rootPage.NotifyUser("The toast encountered an error", NotifyType.ErrorMessage);
});

var ignored = dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
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

```cpp
// 
_dispatcher->RunAsync(Windows::UI::Core::CoreDispatcherPriority::Normal, 
                     ref new Windows::UI::Core::DispatchedHandler([this]()
{
  _count++;
  TimerTextBlock->Text = "Total Running Time: " + _count.ToString() + " Seconds";
}));

// using CallbackContext::Any
void Playback::DisplayStatus(Platform::String^ text)
{
  _dispatcher->RunAsync(Windows::UI::Core::CoreDispatcherPriority::Normal, 
                        ref new Windows::UI::Core::DispatchedHandler([=]()
  {
    _OutputStatus->Text += text + "\n";
  }, CallbackContext::Any)); 
}
```

## -see-also
[Asynchronous programming](https://msdn.microsoft.com/library/23fe28f1-89c5-4a17-a732-a722648f9c5e)
