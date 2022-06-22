---
-api-id: M:Windows.UI.Xaml.Application.LoadComponent(System.Object,Windows.Foundation.Uri)
-api-type: winrt method
---

<!-- Method syntax
public void LoadComponent(System.Object component, Windows.Foundation.Uri resourceLocator)
-->

# Windows.UI.Xaml.Application.LoadComponent

## -description
Loads a XAML file that is located at the specified relative location, and converts it to an instance of the object that is specified by the root element of the XAML file.



## -parameters
### -param component
An object of the same type as the root element of the XAML content to be loaded.

### -param resourceLocator
An object describing the Uniform Resource Identifier (URI) path to the resource to load.

## -remarks
LoadComponent exists mainly for infrastructure. You can see LoadComponent as part of the generated **InitializeComponent** logic that integrates the partial classes of a XAML page and its code-behind.

LoadComponent sometimes is cited in a call stack for an exception that is ultimately because your app is trying to parse bad XAML. In this case there's nothing that app code can do to change how [LoadComponent](application_loadcomponent_91636756.md) is used, and the way to fix the problem is to check your XAML source in an XML editor and fix it. What might be helpful from the stack trace message is confirming which XAML file is not loading. In scenarios where you have merged resources or other multiple XAML sources being combined, it's not always the obvious page-level XAML that is failing to parse.

Most app scenarios that involve loading XAML content and producing an object tree should use [XamlReader.Load](../windows.ui.xaml.markup/xamlreader_load_1077941801.md) instead.

### Resource loading optimization in Windows 8.1

Starting with Windows 8.1, there's a resource loading optimization that's enabled by the app model and the Windows Runtime XAML parser. LoadComponent is involved in this scenario because it's invoked internally to actually load any resource dictionary that comes from a XAML file, including those for [MergedDictionaries](resourcedictionary_mergeddictionaries.md). For Windows 8, the XAML parser loaded resources from app.xaml and created each of them as objects as part of startup. That wasn't very efficient if there were big dictionaries there. Also, those resources included the items that were needed by all three themes, and two of the three themes wouldn't even be active. Starting with Windows 8.1, the XAML parser only creates the resources when they're specifically requested. The request might come from other resources or from app or page XAML as each is loaded. This parser behavior minimizes the time it takes to read the app-level dictionary at startup time, and enables the first app page to load faster in most cases. Resources needed by other currently inactive themes are only loaded if that theme is chosen to become the active theme by the user. At that time, any resource where the [{ThemeResource} markup extension](/windows/uwp/xaml-platform/themeresource-markup-extension) was used for the request is recalculated based on the newly active theme.


<!--The following remark is relevant for Windows 8 > 8.1 migration. See WBB 454546-->
### Windows 8 behavior

Windows 8 didn't have the optimizations described above. The [ResourceDictionary](resourcedictionary.md) for `Application.Resources` had to finish parsing before any page other than the splash screen could load into the app's [Window](window.md). Because of this you might see some differences in timing when you retarget your app for Windows 8.1. The app should be loading faster, however it may not be possible to isolate this improvement versus other changes you've made to your app code as part of retargeting. Some of the places where you might see evidence of timing changes due to optimized resource loading include when the constructors are called by the parser, for objects like [Application](application.md) objects, converters, or other custom classes. Apps that were compiled for Windows 8 but running on Windows 8.1 continue to use the Windows 8 behavior.

For more info on performance and XAML resource factoring, see [Optimize your XAML markup](/windows/uwp/debug-test-perf/optimize-xaml-loading).

## -examples

## -see-also
[LoadComponent(Object, Uri, ComponentResourceLocation)](application_loadcomponent_91636756.md)
