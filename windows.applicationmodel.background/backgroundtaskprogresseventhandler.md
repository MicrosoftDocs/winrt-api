---
-api-id: T:Windows.ApplicationModel.Background.BackgroundTaskProgressEventHandler
-api-type: winrt delegate
---
<!-- Delegate syntax.
public delegate void BackgroundTaskProgressEventHandler(Windows.ApplicationModel.Background.BackgroundTaskRegistration sender, Windows.ApplicationModel.Background.BackgroundTaskProgressEventArgs args)
-->
# Windows.ApplicationModel.Background.BackgroundTaskProgressEventHandler

## -description
Represents a method that handles progress update events for a background task.

## -parameters
### -param sender
The background task.

### -param args
Progress information for the task at the time the notification is sent.


## -remarks
Progress update events are delivered only while the application is in the foreground.

## -examples

## -see-also