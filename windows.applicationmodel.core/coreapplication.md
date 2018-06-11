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

```cpp
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

### Windows Phone 8

This API is supported in native apps only, except for the [Properties](coreapplication_properties.md) property, which is always available.

## -examples

## -see-also

[DirectX swap chain implementation sample](http://go.microsoft.com/fwlink/p/?linkid=258452), [CoreApplicationView](coreapplicationview.md), [Multiple views sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/MultipleViews)