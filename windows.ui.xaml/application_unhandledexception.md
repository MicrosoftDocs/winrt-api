---
-api-id: E:Windows.UI.Xaml.Application.UnhandledException
-api-type: winrt event
---

<!-- Event syntax
public event Windows.UI.Xaml.UnhandledExceptionEventHandler UnhandledException
-->

# Windows.UI.Xaml.Application.UnhandledException

## -description
Occurs when an exception can be handled by app code, as forwarded from a native-level Windows Runtime error. Apps can mark the occurrence as handled in event data.



## -remarks
The UnhandledException event is used to notify the app about exceptions encountered by the XAML framework or by the Windows Runtime in general that have not been handled by app code.

For example, if the Windows Runtime invokes app code like an event handler, and the app code throws an exception and does not catch it, the exception will propagate back to the Windows Runtime. The Windows Runtime will then fire the UnhandledException event to notify the app of this exception.

Handling exceptions in an UnhandledException is just one of many techniques that can be used both for debugging and for run-time exception handling and possible recovery. For more info about the full set of techniques you might use for debugging and error handling, see [Exception handling for    in C# or Visual Basic](/previous-versions/windows/apps/dn532194(v=win.10)).

Note that this event will only fire when there is no longer any possibility that app code can catch an exception. For example, imagine that an app event handler calls a Windows Runtime  API that in turn invokes a callback. If the inner app code throws an exception and does not catch it, the exception will propagate through the Windows Runtime back to the outer layer of app code, which is given a chance to catch it. The UnhandledException event is fired only when there are no more opportunities for app code to catch an exception through normal propagation.

It’s also possible for an exception to be thrown and never have any chance to be caught by app code. For example, if the XAML framework is performing layout and an exception is thrown, this exception won’t propagate through any app code. In this case, the UnhandledException event fires, and this will be the first time any app code is notified about the exception.

Normally after the UnhandledException event is fired, the Windows Runtime terminates the app because the exception was unhandled. The app code has some control over this: if the UnhandledException event handler sets the [Handled](unhandledexceptioneventargs_handled.md) property of the event arguments to **true**, then in most cases the app will not be terminated. However, doing so routinely is not recommended for several reasons: 
+ Typically the UnhandledException event handler doesn’t have enough information to know whether continuing on after an exception is safe. Parts of the application code or the Windows Runtime may be in an inconsistent state, which could result in subsequent failures if the app continues running its code.
+ The Windows Runtime considers exceptions encountered during certain operations as nonrecoverable, because the Windows Runtime itself will be in an inconsistent state following these exceptions. For such exceptions, even if the UnhandledException event handler sets [Handled](unhandledexceptioneventargs_handled.md) to **true**, the app will still be terminated.
+ Errors that happen during navigation could cause a state where there's nothing loaded as content and nothing to indicate to the user that the app is still running.
+ For more info on these points see [Exception handling for    in C# or Visual Basic](/previous-versions/windows/apps/dn532194(v=win.10)).



<!--THIS FIXED in 8.1 with unified exception model<p  xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">It’s important to be aware of several limitations of the <xref targtype="event_winrt" rid="w_ui_xaml.application_unhandledexception">UnhandledException</xref> event. This event is only used with exceptions encountered by the XAML framework or the core <tla rid="winrt"/>. Exceptions encountered by other <tla rid="winrt"/> components or parts of the app that are not using  the XAML framework will not result in this event being raised. For example, if a different <tla rid="windows"/> component calls into app  code and an exception is thrown and not caught, the <xref targtype="event_winrt" rid="w_ui_xaml.application_unhandledexception">UnhandledException</xref> event won’t fire, and the app won't have a chance to handle that. There's also an affinity to the UI thread. If app  code creates a worker thread, and then raises an exception on the worker thread, the <xref targtype="event_winrt" rid="w_ui_xaml.application_unhandledexception">UnhandledException</xref> event doesn't fire.</p>-->
A notable limitation is that the UnhandledException event arguments don’t contain as much detail as the original exception as propagated from app code. Whenever possible, if the app requires specific processing of a certain exception, it’s always better to catch the exception as it propagates, because more detail will be available then. The UnhandledException event arguments expose an exception object through the [Exception](unhandledexceptioneventargs_exception.md) property. However, the type, message, and stack trace of this exception object are not guaranteed to match those of the original exception that was raised. The event arguments do expose a [Message](unhandledexceptioneventargs_message.md) property. In most cases, this will contain the message of the originally raised exception.

You can't wire handlers for UnhandledException in XAML (on the [Application](application.md) element in App.xaml). You must attach handlers for UnhandledException on the [Application](application.md) object in code, either in the constructor or in activation logic.

For Windows 8.1 apps, exceptions from async method calls can propagate as an UnhandledException event. This includes your own async method implementations (activation handlers and so on).

## -examples

## -see-also
[UnhandledExceptionEventArgs](unhandledexceptioneventargs.md), [App lifecycle](/windows/uwp/launch-resume/app-lifecycle), [Exception handling for    in C# or Visual Basic](/previous-versions/windows/apps/dn532194(v=win.10)), [Cross-reference: Standard exceptions and error codes](/previous-versions/windows/apps/dn535792(v=win.10)), [Call asynchronous APIs in C# or Visual Basic](/windows/uwp/threading-async/call-asynchronous-apis-in-csharp-or-visual-basic), [Suspending](application_suspending.md), [Resuming](application_resuming.md)
