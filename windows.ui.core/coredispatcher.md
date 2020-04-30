---
-api-id: T:Windows.UI.Core.CoreDispatcher
-api-type: winrt class
---

<!-- Class syntax.
public class CoreDispatcher : Windows.UI.Core.ICoreAcceleratorKeys, Windows.UI.Core.ICoreDispatcher, Windows.UI.Core.ICoreDispatcher2, Windows.UI.Core.ICoreDispatcherWithTaskPriority
-->

# Windows.UI.Core.CoreDispatcher

## -description
Provides the Windows Runtime core event message dispatcher. Instances of this type are responsible for processing the window messages and dispatching the events to the client.

## -remarks
Instances of this type can be obtained from the CoreWindow.Dispatcher property. The current [CoreWindow](corewindow.md) instance can be obtained by calling [CoreWindow.GetForCurrentThread](corewindow_getforcurrentthread_1771949562.md).

```cppwinrt
// App.cpp
...
// An implementation of IFrameworkView::Run.
void Run()
{
    CoreWindow window{ CoreWindow::GetForCurrentThread() };
    window.Activate();

    CoreDispatcher dispatcher{ window.Dispatcher() };
    dispatcher.ProcessEvents(CoreProcessEventsOption::ProcessUntilQuit);
}

// The CoreApplication::Run call indirectly calls the App::Run function above.
int __stdcall wWinMain(HINSTANCE, HINSTANCE, PWSTR, int)
{
    CoreApplication::Run(App());
}
```

```cppcx
void MyCoreWindowEvents::Run() // this is an implementation of IFrameworkView::Run() used to show context. It is called by CoreApplication::Run().
{
    CoreWindow::GetForCurrentThread()->Activate();

    //...

    CoreWindow::GetForCurrentThread()->Dispatcher->ProcessEvents(CoreProcessEventsOption::ProcessUntilQuit);
}
```

## -examples

## -see-also
