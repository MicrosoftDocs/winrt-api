---
-api-id: P:Windows.UI.Xaml.Application.Resources
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.ResourceDictionary Resources { get;  set; }
-->

# Windows.UI.Xaml.Application.Resources

## -description
Gets a collection of application-scoped resources, such as styles, templates, and brushes.



## -xaml-syntax
```xaml
<Application>
  <Application.Resources>
    oneOrMoreResourceElements
  </Application.Resources>
</Application>
 
```


## -xaml-values
<dl><dt>oneOrMoreResourceElements</dt><dd>oneOrMoreResourceElementsOne or more object elements, each of which creates and defines a resource. Each resource property element within each ResourceDictionary must have a unique value for the x:Key, which serves as the unique key when values are retrieved from the ResourceDictionary.</dd>
</dl>
## -property-value
A [ResourceDictionary](resourcedictionary.md) object that contains zero or more application-scoped resources.

## -remarks
The resource dictionary model in the Windows Runtime supports many of the XAML resource concepts you may be familiar with if you have created applications using Windows Presentation Foundation (WPF) or Microsoft Silverlight. For more info, see [ResourceDictionary and XAML resource references](/windows/apps/design/style/xaml-resource-dictionary).

The resources you define in the [ResourceDictionary](resourcedictionary.md) that fills the `Application.Resources` property element are available for retrieval from any page of your app. This is advantageous if many of your app's pages are all using the same resource. For example, if you have a [SolidColorBrush](../windows.ui.xaml.media/solidcolorbrush.md) resource that you're using for color schemes in your app's UI, and that color is used on most of your pages, it makes sense to declare that [SolidColorBrush](../windows.ui.xaml.media/solidcolorbrush.md) in the `Application.Resources` used for `Application.Resources`.

When you add resources to `Application.Resources`, add them either before or after any existing `ResourceDictionary.MergedResources`. The rules of XAML don't allow you to put content on both sides of a property element tag. For more info, see [XAML syntax guide](/windows/uwp/xaml-platform/xaml-syntax-guide).

### Notes for previous versions

#### Resource loading optimization in Windows 8.1

Starting with Windows 8.1, there's a resource loading optimization that's enabled by the app model and the Windows Runtime XAML parser. For Windows 8, the XAML parser loaded resources from app.xaml and created each of them as objects as part of startup. That wasn't very efficient if there were big dictionaries there. Also, those resources included the items that were needed by all three themes, and two of the three themes wouldn't even be active. Starting with Windows 8.1, the XAML parser only creates the resources when they're specifically requested. The request might come from other resources or from app or page XAML as each is loaded. This parser behavior minimizes the time it takes to read the app-level dictionary at startup time, and enables the first app page to load faster in most cases. Resources needed by other currently inactive themes are only loaded if that theme is chosen to become the active theme by the user. At that time, any resource where the [{ThemeResource} markup extension](/windows/uwp/xaml-platform/themeresource-markup-extension) was used for the request is recalculated based on the newly active theme.

<!--The following remark is relevant for Windows 8 > 8.1 migration. See WBB 454546-->
#### Windows 8 behavior

Windows 8 didn't have the optimizations described above. The [ResourceDictionary](resourcedictionary.md) for `Application.Resources` had to finish parsing before any page other than the splash screen could load into the app's [Window](window.md). Because of this you might see some differences in timing when you retarget your app for Windows 8.1. The app should be loading faster, however it may not be possible to isolate this improvement versus other changes you've made to your app code as part of retargeting. Some of the places where you might see evidence of timing changes due to optimized resource loading include when the constructors are called by the parser, for objects like [Application](application.md) objects, converters, or other custom classes. Apps that were compiled for Windows 8 but running on Windows 8.1 continue to use the Windows 8 behavior.

For more info on performance and XAML resource factoring, see [Optimize your XAML markup](/windows/uwp/debug-test-perf/optimize-xaml-loading).

## -examples
This example shows how to declare an app-specific resource (this one creates a common converter class instance that comes from starting templates). Then it adds an [Application.MergedDictionaries](resourcedictionary_mergeddictionaries.md) property element with [ResourceDictionary](resourcedictionary.md) elements within, each referencing a XAML file by **URI** as the [Source](resourcedictionary_source.md).

```xaml
<Application.Resources>
    <ResourceDictionary>
      <common:BooleanToVisibilityConverter x:Key="BooleanToVisibilityConverter"/> 
      <ResourceDictionary.MergedDictionaries>
        <ResourceDictionary Source="rd1.xaml" />
        <ResourceDictionary Source="rd2.xaml" />
      </ResourceDictionary.MergedDictionaries>
    </ResourceDictionary>
  </Application.Resources>
```



## -see-also
[x:Key attribute](/windows/uwp/xaml-platform/x-key-attribute), [ResourceDictionary and XAML resource references](/windows/apps/design/style/xaml-resource-dictionary), [{StaticResource} markup extension](/windows/uwp/xaml-platform/staticresource-markup-extension), [Application resources and localization sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/ApplicationResources)
