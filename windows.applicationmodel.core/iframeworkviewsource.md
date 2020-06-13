---
-api-id: T:Windows.ApplicationModel.Core.IFrameworkViewSource
-api-type: winrt interface
---

<!-- Interface syntax.
public interface IFrameworkViewSource : 
-->

# Windows.ApplicationModel.Core.IFrameworkViewSource

## -description
Defines a factory for view provider objects.

## -remarks
Instances of objects that implement this class are provided to the app object's [CoreApplication.Run](coreapplication_run_1480028297.md) method when the app starts, which uses it to create the views used by the app.

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

If you're using C++/CX, then a view provider must be attributed as **MTAThread.**

```cppcx
ref class MyFrameworkViewSource : IFrameworkViewSource
{
public:
    virtual IFrameworkView^ CreateView()
    {
        return ref new MyFrameworkView(); // See IFrameworkView for implementation specifics.
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

## -examples

## -see-also
[DirectX swap chain implementation sample](https://github.com/microsoft/Win2D/tree/master/samples/CoreWindowExample), [IFrameworkView](iframeworkview.md)
