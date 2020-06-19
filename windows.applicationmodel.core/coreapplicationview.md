---
-api-id: T:Windows.ApplicationModel.Core.CoreApplicationView
-api-type: winrt class
---

<!-- Class syntax.
public class CoreApplicationView : Windows.ApplicationModel.Core.ICoreApplicationView, Windows.ApplicationModel.Core.ICoreApplicationView2, Windows.ApplicationModel.Core.ICoreApplicationView3, Windows.ApplicationModel.Core.ICoreApplicationView5
-->

# Windows.ApplicationModel.Core.CoreApplicationView

## -description
Represents an app window and its thread.

## -remarks

The following code snippet demonstrates the activation of the CoreApplicationView and the associated CoreWindow in a view provider implementation.

```cppwinrt
struct App : implements<App, IFrameworkViewSource, IFrameworkView>
{
...
    void Initialize(CoreApplicationView const& applicationView)
    {
        applicationView.Activated({this, &App::OnActivated });
    }

    void OnActivated(CoreApplicationView const& /* applicationView */, IActivatedEventArgs const& /* args */)
    {
        // Activate the application window, making it visible and enabling it to receive events.
        CoreWindow::GetForCurrentThread().Activate();
    }
}
```

```cppcx
ref class MyFrameworkView : public IFrameworkView
{
// ...
virtual void Initialize(
        _In_ CoreApplicationView^ applicationView
        )
    {
        applicationView->Activated +=
            ref new TypedEventHandler<CoreApplicationView^, IActivatedEventArgs^>(this, &MyFrameworkView::OnActivated);
    }

// ...

void OnActivated(
        _In_ CoreApplicationView^ applicationView,
        _In_ IActivatedEventArgs^ args
        )
    {
        // Activate the application window, making it visible and enabling it to receive events.
        CoreWindow::GetForCurrentThread()->Activate();
    }

// ...
}
```

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1703 | 15063 | Properties |
| 1709 | 16299 | DispatcherQueue |

## -examples

## -see-also
[DirectX swap chain implementation sample](https://github.com/microsoft/Win2D/tree/master/samples/CoreWindowExample), [CoreApplication.CreateNewView](/uwp/api/windows.applicationmodel.core.coreapplication.createnewview), [CoreApplication.GetCurrentView](coreapplication_getcurrentview_176591067.md)
