---
-api-id: T:Windows.UI.Xaml.Resources.CustomXamlResourceLoader
-api-type: winrt class
---

<!-- Class syntax.
public class CustomXamlResourceLoader : Windows.UI.Xaml.Resources.ICustomXamlResourceLoader, Windows.UI.Xaml.Resources.ICustomXamlResourceLoaderOverrides
-->

# Windows.UI.Xaml.Resources.CustomXamlResourceLoader

## -description
Enables loading of custom resource dictionaries as sources. Override [GetResource](customxamlresourceloader_getresource_689752583.md) to provide the logic that a XAML parser can use to look up the necessary resources at load time.



## -remarks
CustomXamlResourceLoader supports a markup extension usage `{CustomResource}`. This markup extension is unique to the Windows Runtime XAML framework (it did not exist in precursor XAML technologies such as Windows Presentation Foundation (WPF) and Microsoft Silverlight.)

A `{CustomResource}` usage doesn't work by default (the base implementation of [GetResource](customxamlresourceloader_getresource_689752583.md) is incomplete). To make a valid `{CustomResource}` reference, you must perform each of these steps:
1. Derive a custom class from CustomXamlResourceLoader and override [GetResource](customxamlresourceloader_getresource_689752583.md) method. Do not call base in the implementation.
1. Set [CustomXamlResourceLoader.Current](customxamlresourceloader_current.md) to reference your class in initialization logic. This must happen before any page-level XAML that includes the `{CustomResource}` extension usage is loaded. One place to set [CustomXamlResourceLoader.Current](customxamlresourceloader_current.md) is in the Application subclass constructor that's generated for you in the App.xaml code-behind templates.
1. Now you can use `{CustomResource}` extensions in the XAML that your app loads as pages, or from within XAML resource dictionaries.


[{CustomResource} markup extension](/windows/uwp/xaml-platform/customresource-markup-extension) can be used from XAML in a similar way to [{StaticResource} markup extension](/windows/uwp/xaml-platform/staticresource-markup-extension), which performs built-in resource lookup from various [ResourceDictionary](../windows.ui.xaml/resourcedictionary.md) locations. The difference is that the app itself implements the resource lookup logic for a [{CustomResource} markup extension](/windows/uwp/xaml-platform/customresource-markup-extension) usage by supplying a custom resource loader. To implement the custom resource loader, the application must provide a class that derives from CustomXamlResourceLoader and override the [GetResource](customxamlresourceloader_getresource_689752583.md) method. The app must register its custom resource loader by setting the static property [CustomXamlResourceLoader.Current](customxamlresourceloader_current.md) to an instance of its custom resource loader class. This registration must be done on a XAML UI thread before any parsing of XAML that uses [{CustomResource} markup extension](/windows/uwp/xaml-platform/customresource-markup-extension). If the application uses multiple UI threads, a separate registration must be done on each.

The way in which the CustomXamlResourceLoader stores its resources is probably not related to [ResourceDictionary](../windows.ui.xaml/resourcedictionary.md) at all. Typically, in addition to the required overrides, your CustomXamlResourceLoader class would provide internal or public methods that enable storing, keying and otherwise working with the resource items in an underlying collection.

## -examples

## -see-also
[{StaticResource} markup extension](/windows/uwp/xaml-platform/staticresource-markup-extension), [ResourceDictionary and XAML resource references](/windows/apps/design/style/xaml-resource-dictionary)
