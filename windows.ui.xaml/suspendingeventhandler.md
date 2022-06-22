---
-api-id: T:Windows.UI.Xaml.SuspendingEventHandler
-api-type: winrt delegate
---
<!-- Delegate syntax.
public delegate void SuspendingEventHandler(System.Object sender, Windows.ApplicationModel.SuspendingEventArgs e)
-->
# Windows.UI.Xaml.SuspendingEventHandler

## -description
Represents the method that will handle the [Suspending](application_suspending.md) event.



## -parameters
### -param sender
The object where the handler is attached.

### -param e
Event data.


## -remarks
The system suspends your app whenever the user switches to another app or to the desktop, and resumes your app whenever the user switches back to it. However, the system can also terminate your app while it is suspended in order to free up resources. Therefore, you should handle the [Suspending](application_suspending.md) event to perform the following operations:


+ Preserve user session state.
+ Release any exclusive locks on resources.
+ Reduce memory usage if possible. For example, serialize any data that is easy to reconstruct in object form upon reactivation.
+ Save app state.
The [Suspending](application_suspending.md) event is the only indication your app will receive prior to termination (if it happens). Because of this, you should store enough session state (such as the current article being read or the current movie playback position) to recreate the exact same experience during activation. The guidance for content creation apps is to save a user’s work early and often but also commit one final save during [Suspending](application_suspending.md). Saving data prior to suspension is useful because the [Suspending](application_suspending.md) event handler has only 5 seconds to complete its operation.

If your app is terminated, you can restore the app state in an [OnLaunched](application_onlaunched_859642554.md) method override. If your app resumes before it is terminated, the system restores the app state automatically. You should handle the [Resuming](application_resuming.md) event only if you need to refresh any displayed content that might have changed while the app is suspended, such as news feeds or the user's location.

## -examples
This code example demonstrates a typical usage pattern for this event. This code is used by many of the XAML samples, for example the [Input sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Input%20XAML%20user%20input%20events%20sample), as part of the code-behind for the app.xaml file. If you browse the XAML samples, you can find the source code for the `SuspensionManager` class API as referenced in this code.

```csharp
async protected void OnSuspending(object sender, SuspendingEventArgs args)
{
    SuspendingDeferral deferral = args.SuspendingOperation.GetDeferral();
    await SuspensionManager.SaveAsync();
    deferral.Complete();
}
```

```vb
Private Async Sub OnSuspending(sender As Object, args As SuspendingEventArgs) 
    Dim deferral As SuspendingDeferral = args.SuspendingOperation.GetDeferral 
    Await SuspensionManager.SaveAsync 
    deferral.Complete() 
End Sub 
```



## -see-also
