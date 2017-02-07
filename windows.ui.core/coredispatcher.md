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
Instances of this type can be obtained from the [CoreWindow.Dispatcher](coredispatcher.md) property. The current [CoreWindow](corewindow.md) instance can be obtained by calling [CoreWindow.GetForCurrentThread](corewindow_getforcurrentthread.md).





```cpp
void MyCoreWindowEvents::Run() // this is an implementation of IFrameworkView::Run() used to show context. It is called by CoreApplication::Run().
{
    CoreWindow::GetForCurrentThread()->Activate();

    /...

    CoreWindow::GetForCurrentThread()->Dispatcher->ProcessEvents(CoreProcessEventsOption::ProcessUntilQuit);
}
```



## -examples

## -see-also