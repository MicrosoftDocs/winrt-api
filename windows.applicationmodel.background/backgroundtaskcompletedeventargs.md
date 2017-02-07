---
-api-id: T:Windows.ApplicationModel.Background.BackgroundTaskCompletedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class BackgroundTaskCompletedEventArgs : Windows.ApplicationModel.Background.IBackgroundTaskCompletedEventArgs
-->

# Windows.ApplicationModel.Background.BackgroundTaskCompletedEventArgs

## -description
Represents completion information for a task at the time a completion notification is sent.

## -remarks
The system generates this class and passes it as an argument to the application's [BackgroundTaskCompletedEventHandler](backgroundtaskcompletedeventhandler.md) handler.

## -examples
The following example shows how to use the BackgroundTaskCompletedEventArgs class with a [BackgroundTaskCompletedEventHandler](backgroundtaskcompletedeventhandler.md) delegate to monitor background task completion while the app is in the foreground. Note that this depends on the background task to report status via [LocalSettings](../windows.storage/applicationdata_localsettings.md).

```csharp
private async void OnCompleted(IBackgroundTaskRegistration task,
                               BackgroundTaskCompletedEventArgs args)
{
    var settings = ApplicationData.Current.LocalSettings;
    var key = task.TaskId.ToString();
    string status = settings.Values[key].ToString();

    //
    // UI element updates should be done asynchronously.
    //
    await Dispatcher.RunAsync(CoreDispatcherPriority.Normal,
    () =>
    {
        ExampleProgressElement.Text = "Task completed with status: " + status;
    });
}
```



## -see-also