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
Instances of objects that implement this class are provided to the app object's [CoreApplication.Run](coreapplication_run.md) method when the app starts, which uses it to create the views used by the app. View providers must be attributed as **MTAThread.**





```cpp

ref class MyFrameworkViewSource : IFrameworkViewSource
{
public:
    virtual IFrameworkView^ CreateView()
    {
        return ref new MyFrameworkView(); // see IFrameworkView for implementation specifics
    }
};

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
[DirectX swap chain implementation sample](http://go.microsoft.com/fwlink/p/?linkid=258452), [IFrameworkView](iframeworkview.md)