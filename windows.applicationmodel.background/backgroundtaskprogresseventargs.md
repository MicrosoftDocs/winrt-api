---
-api-id: T:Windows.ApplicationModel.Background.BackgroundTaskProgressEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class BackgroundTaskProgressEventArgs : Windows.ApplicationModel.Background.IBackgroundTaskProgressEventArgs
-->

# Windows.ApplicationModel.Background.BackgroundTaskProgressEventArgs

## -description
Represents progress information for a task at the time a progress update notification is sent.

## -remarks
The system generates this class and passes it as an argument to the application's [BackgroundTaskProgressEventHandler](backgroundtaskprogresseventhandler.md) handler.

## -examples
The following example shows how to use the BackgroundTaskProgressEventArgs class with a [BackgroundTaskProgressEventHandler](backgroundtaskprogresseventhandler.md) delegate to show background task progress while the app is in the foreground.

```csharp

private async void OnProgress(IBackgroundTaskRegistration task, BackgroundTaskProgressEventArgs args)
{
    //
    // UI element updates should be done asynchronously.
    //
    await Dispatcher.RunAsync(CoreDispatcherPriority.Normal,
    () =>
    {
        ExampleProgressElement.Text = "Progress is at " args.Progress + "%.";
    });
}
```



## -see-also
