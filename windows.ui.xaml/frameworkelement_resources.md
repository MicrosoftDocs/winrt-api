---
-api-id: P:Windows.UI.Xaml.FrameworkElement.Resources
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.ResourceDictionary Resources { get;  set; }
-->

# Windows.UI.Xaml.FrameworkElement.Resources

## -description
Gets the locally defined resource dictionary. In XAML, you can establish resource items as child object elements of a `frameworkElement.Resources` property element, through XAML implicit collection syntax.


## -xaml-syntax
```xaml
<frameworkElement>
  <frameworkElement.Resources>
    oneOrMoreResourceElements
  </frameworkElement.Resources>
</frameworkElement>
```


## -xaml-values
<dl><dt>oneOrMoreResourceElements</dt><dd>oneOrMoreResourceElementsOne or more object elements, each of which creates and defines a resource. Each resource property element in a ResourceDictionary must have a unique key (typically x:Key attribute, specified as an attribute, with a string value ). The key is used when values are retrieved from the ResourceDictionary with a {StaticResource} markup extension XAML usage (or code).</dd>
</dl>
## -property-value
The current locally defined dictionary of resources, where each resource can be accessed by its key.

## -remarks
The primary purpose of the items in a Resources collection is to refer to them from other parts of your XAML, using a [{StaticResource} markup extension](/windows/uwp/xaml-platform/staticresource-markup-extension) reference (or the similar [{ThemeResource} markup extension](/windows/uwp/xaml-platform/themeresource-markup-extension) reference). If you want to access the Resources collection at run time, you can use the API of the relevant template to query, add, or remove items in the [ResourceDictionary](resourcedictionary.md).

For more info and examples, see [ResourceDictionary and XAML resource references](/windows/apps/design/style/xaml-resource-dictionary).

A [ResourceDictionary](resourcedictionary.md) is a keyed collection, which is based on an [IMap<K,V>](../windows.foundation.collections/imap_2.md) template if you are programming with Visual C++ component extensions (C++/CX), or an [IDictionary&lt;TKey,TValue&gt;](XREF:TODO:T:System.Collections.Generic.IDictionary`2) template if you are programming with C# or Microsoft Visual Basic. The API you use in code to work with the dictionary and its items are reflective of the underlying template and thus of the language you're using for your app.

[Application](application.md) also has a [Resources](application_resources.md) property, which can be used to store resources that should be accessible from more than one page in the app. Resources for custom controls can also be stored in a separate XAML file that is created by the default project template of a templated control.

The items that you see in a XAML [Resources](application_resources.md) collection are not necessarily the entirety of XAML-defined resources available at runtime. Other resources are available at runtime, due to the influence of the [MergedDictionaries](resourcedictionary_mergeddictionaries.md) property on a [ResourceDictionary](resourcedictionary.md). The [MergedDictionaries](resourcedictionary_mergeddictionaries.md) value can introduce other dictionaries such as the resources defined by the system, such as resources from the default XAML control templates. Runtime theme-specific resources are also available from the similar [ThemeDictionaries](resourcedictionary_themedictionaries.md) property. If you access a [Resources](application_resources.md) collection at runtime and query for a specific key using the [Item](/dotnet/api/system.windows.resourcedictionary.item) indexer or [Lookup](resourcedictionary_lookup_786690417.md) method, you can access and retrieve these resources. For more info, see [ResourceDictionary and XAML resource references](/windows/apps/design/style/xaml-resource-dictionary). Also, [Application.Resources](application_resources.md) can provide resources that are available for any XAML reference in the app and thus extend the resources in any given FrameworkElement.Resources dictionary.

## -examples
This example shows a XAML definition of a simple Resources dictionary that contains one item, a [DataTemplate](datatemplate.md).



[!code-xaml[3](../windows.ui.xaml.data/code/DataTemplates/csharp/Page.xaml#Snippet3)]

```xaml
<GridView ItemTemplate="{StaticResource CBTemplate}" .../>
```

Using XAML resource definitions and resource references is the typical way to use the Resources property. Most of the time XAML alone can handle common resource scenarios. But you also can use the property to access the collection API and thus retrieve resources with runtime code, if that's needed by your scenario. This example shows code access to the Resources property. In this example the Resources property references is inline and immediately followed by an indexer usage that retrieves a [ResourceDictionary](resourcedictionary.md) item with the string key `RainbowBrush`. Note the explicit cast; the return value for items from the [ResourceDictionary](resourcedictionary.md) is always a nontyped object.



[!code-cpp[ResourceProceduralGet](../windows.ui.xaml/code/PropertiesOvwSupport/cpp/loose.cpp#SnippetResourceProceduralGet)]

[!code-csharp[ResourceProceduralGet](../windows.ui.xaml/code/PropertiesOvwSupport/csharp/page3.xaml.cs#SnippetResourceProceduralGet)]

[!code-vb[ResourceProceduralGet](../windows.ui.xaml/code/PropertiesOvwSupport/vbnet/page3.xaml.vb#SnippetResourceProceduralGet)]

```xaml
<Page.Resources>
...
  <LinearGradientBrush x:Key="RainbowBrush">
    <GradientStop Color="Red" Offset="0.05" />
    <GradientStop Color="Orange" Offset="0.23" />
    <GradientStop Color="Yellow" Offset="0.41" />
    <GradientStop Color="Green" Offset="0.59" />
    <GradientStop Color="Blue" Offset="0.77" />
    <GradientStop Color="Purple" Offset="0.95" />
 </LinearGradientBrush>
</Page.Resources>
```



## -see-also
[ResourceDictionary](resourcedictionary.md), [x:Key attribute](/windows/uwp/xaml-platform/x-key-attribute), [ResourceDictionary and XAML resource references](/windows/apps/design/style/xaml-resource-dictionary), [{StaticResource} markup extension](/windows/uwp/xaml-platform/staticresource-markup-extension), [{ThemeResource} markup extension](/windows/uwp/xaml-platform/themeresource-markup-extension), [Application resources and localization sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/ApplicationResources), [XAML overview](/windows/uwp/xaml-platform/xaml-overview)
1b37-f1a8-44a4-bb8e-1d4de30e7823)
