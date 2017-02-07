---
-api-id: T:Windows.ApplicationModel.Background.BackgroundTaskCompletedEventHandler
-api-type: winrt delegate
---
<!-- Delegate syntax.
public delegate void BackgroundTaskCompletedEventHandler(Windows.ApplicationModel.Background.BackgroundTaskRegistration sender, Windows.ApplicationModel.Background.BackgroundTaskCompletedEventArgs args)
-->
# Windows.ApplicationModel.Background.BackgroundTaskCompletedEventHandler

## -description
Represents a method that handles completion events for a background task.

## -parameters
### -param sender
The background task.

### -param args
Completion information for the task at the time the notification is sent.


## -remarks
Completion events are delivered only if the task completed while the application is in the foreground. If the application is suspended and then terminated, completion status is not delivered. If the application is suspended and then resumed, it is guaranteed to receive the completion notification.

## -examples

## -see-also