---
-api-id: T:Windows.ApplicationModel.Core.CoreApplication
-api-type: winrt class
---

<!-- Class syntax.
public class CoreApplication 
-->

# Windows.ApplicationModel.Core.CoreApplication

## -description

Enables apps to handle state changes, manage windows, and integrate with a variety of UI frameworks.

## -remarks

The system creates this object as a singleton when it runs the app. It is run as an Application Single-Threaded Apartment (ASTA). Threads created from the app singleton, such as the view provider (seen in the sample below), should be attributed as Multi-Threaded Apartment (MTAThread). 

This API is supported in Universal Windows Platform apps only, except for the [Properties](coreapplication_properties.md) property, which is always available.

```cppwinrt
struct App : implements<App, IFrameworkViewSource, IFrameworkView>
{
public:
    IFrameworkView CreateView()
    {
        return *this;
    }
};

...

int __stdcall wWinMain(HINSTANCE, HINSTANCE, PWSTR, int)
{
    Windows::ApplicationModel::Core::CoreApplication::Run(App());
}
```

```cppcx
ref class MyFrameworkViewSource : IFrameworkViewSource
{
public:
    virtual IFrameworkView^ CreateView()
    {
        return ref new MyFrameworkView();
    }
};

// ...

[Platform::MTAThread]
int main(Platform::Array<Platform::String^>^)
{
    auto frameworkViewSource = ref new MyFrameworkViewSource();
    Windows::ApplicationModel::Core::CoreApplication::Run(frameworkViewSource);
    return 0;
}
```

```csharp
internal class ApplicationSource : IFrameworkViewSource
{
	public virtual IFrameworkView CreateView()
	{
		return new CoreApp();
	}
}

...

[MTAThread]
public static int Main()
{
	var appSource = new ApplicationSource();
	CoreApplication.Run(appSource);
	return 0;
}
```

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | BackgroundActivated |
| 1607 | 14393 | EnablePrelaunch |
| 1607 | 14393 | EnteredBackground |
| 1607 | 14393 | LeavingBackground |
| 1709 | 16299 | RequestRestartAsync |
| 1709 | 16299 | RequestRestartForUserAsync |

## -examples

## -see-also

[COM Processes, Threads, and Apartments](/windows/desktop/com/processes--threads--and-apartments), [DirectX swap chain implementation sample](https://github.com/microsoft/Win2D/tree/master/samples/CoreWindowExample), [CoreApplicationView](coreapplicationview.md), [Multiple views sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/MultipleViews), [MTAThreadAttribute](/dotnet/api/system.mtathreadattribute?view=dotnet-uwp-10.0&preserve-view=true)
