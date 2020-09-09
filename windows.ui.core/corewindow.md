---
-api-id: T:Windows.UI.Core.CoreWindow
-api-type: winrt class
---

<!-- Class syntax.
public class CoreWindow : Windows.UI.Core.ICorePointerRedirector, Windows.UI.Core.ICoreWindow, Windows.UI.Core.ICoreWindow2, Windows.UI.Core.ICoreWindow3, Windows.UI.Core.ICoreWindow4
-->

# Windows.UI.Core.CoreWindow

## -description

Represents the UWP app with input events and basic user interface behaviors.

## -remarks

New instances of this class are obtained by calling [CoreApplication.CreateNewView](../windows.applicationmodel.core/coreapplication_createnewview_1643095864.md) and then inspecting the [CoreWindow](../windows.applicationmodel.core/coreapplicationview_corewindow.md) property on the returned [CoreApplicationView](../windows.applicationmodel.core/coreapplicationview.md) instance. Or you can obtain existing CoreWindow instances for a running app from the [CoreApplication.Views](../windows.applicationmodel.core/coreapplication_views.md) property, or by calling [CoreWindow.GetForCurrentThread](corewindow_getforcurrentthread_1771949562.md), as seen in the following example.

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
void MyCoreWindowEvents::Run() // this is an implementation of IFrameworkView::Run() used to show context
{
    CoreWindow::GetForCurrentThread()->Activate();

    /...

    CoreWindow::GetForCurrentThread()->Dispatcher->ProcessEvents(CoreProcessEventsOption::ProcessUntilQuit);
}
```

<!-- confirmed -->
> [!NOTE]
> This class is not agile, which means that you need to consider its threading model and marshaling behavior. For more info, see [Threading and Marshaling (C++/CX)](/cpp/cppcx/threading-and-marshaling-c-cx).

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1511 | 10586 | PointerRoutedAway |
| 1511 | 10586 | PointerRoutedReleased |
| 1511 | 10586 | PointerRoutedTo |
| 1607 | 14393 | ClosestInteractiveBoundsRequested |
| 1607 | 14393 | GetCurrentKeyEventDeviceId |
| 1703 | 15063 | ResizeCompleted |
| 1703 | 15063 | ResizeStarted |
| 1709 | 16299 | ActivationMode |
| 1709 | 16299 | DispatcherQueue |
| 1903 | 18362 | UIContext |

## -examples

## -see-also

[CoreApplicationView](../windows.applicationmodel.core/coreapplicationview.md), [CoreApplication.CreateNewView](../windows.applicationmodel.core/coreapplication_createnewview_1643095864.md), [CoreApplication.Views](../windows.applicationmodel.core/coreapplication_views.md), [Direct2D custom image effects sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/D2DCustomEffects)
