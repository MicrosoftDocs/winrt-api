---
-api-id: P:Windows.UI.Xaml.ResourceDictionary.MergedDictionaries
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVector<Windows.UI.Xaml.ResourceDictionary> MergedDictionaries { get; }
-->

# Windows.UI.Xaml.ResourceDictionary.MergedDictionaries

## -description
Gets a collection of the [ResourceDictionary](resourcedictionary.md) dictionaries that constitute the various resource dictionaries in the merged dictionaries.



## -xaml-syntax
```xaml
<ResourceDictionary>
  <ResourceDictionary.MergedDictionaries>
    oneOrMoreResourceDictionaryElements
  </ResourceDictionary.MergedDictionaries>
</ResourceDictionary>
```


## -xaml-values
<dl><dt>oneOrMoreResourceDictionaryElements</dt><dd>oneOrMoreResourceDictionaryElementsOne or more explicit ResourceDictionary object elements. Each such ResourceDictionary should specify a Source value as its only attribute, and should not attempt to specify any keyed child content itself. Also, do not specify the x:Key attribute on the ResourceDictionary object elements.</dd>
</dl>
## -property-value
A list collection of the [ResourceDictionary](resourcedictionary.md) dictionaries that constitute the various resource dictionaries in the merged dictionaries.

## -remarks
Setting a MergedDictionaries value enables you to share a [ResourceDictionary](resourcedictionary.md) XAML file amongst several pages, or also as a common file you might add to multiple app projects. This provides a useful factoring and reuse technique for resources from a development and design standpoint. You typically include the XAML file as a **Content** item as part of the project and app manifest.

The keyed resources in any MergedDictionaries XAML do not have to be unique versus the keys as found in the primary [ResourceDictionary](resourcedictionary.md) for [Application.Resources](application_resources.md) or [FrameworkElement.Resources](frameworkelement_resources.md), and the lookup order for keys will look in the primary dictionary first. This enables a technique whereby you can override any key value obtained from within MergedDictionaries XAML files, but you could also have the merged dictionaries available as a fallback or as a general set of non-customized resources.

You can include more than one [ResourceDictionary](resourcedictionary.md) in a MergedDictionaries set in order to provide a fallback sequence even within the MergedDictionaries set.

For more info on how to use MergedDictionaries and the resource lookup sequence, see [ResourceDictionary and XAML resource references](/windows/apps/design/style/xaml-resource-dictionary).

[ThemeDictionaries](resourcedictionary_themedictionaries.md) is a related property that also merges additional XAML [ResourceDictionary](resourcedictionary.md) sources into the overall keyed resource set, where the scenario is for providing theme-related resources for controls.

Changing the contents of the collection of [ResourceDictionary](resourcedictionary.md) items for MergedDictionaries is not a common scenario. Generally you establish the collection contents in XAML and don't change it at runtime. There aren't many scenarios where you would access the collection itself in run-time code. Usually you rely on the built-in resource lookup that happens at XAML load time, or you query the relevant [Application.Resources](application_resources.md) or [FrameworkElement.Resources](frameworkelement_resources.md) collections that can reference resources by key, including the merged resources.

## -examples
The starting Microsoft Visual Studio templates for a UWP app using C++, C#, or Visual Basic include a MergedDictionaries node in the app.xaml file. This references a separate XAML [ResourceDictionary](resourcedictionary.md) in the project that contains some basic control template definitions. You can modify the XAML within the [ResourceDictionary](resourcedictionary.md) in order to customize the appearance of your controls.

```xaml
<Application
    ....
>
    <Application.Resources>
        <ResourceDictionary>
            <ResourceDictionary.MergedDictionaries>
                <ResourceDictionary Source="Common/StandardStyles.xaml"/>
            </ResourceDictionary.MergedDictionaries>
        </ResourceDictionary>
    </Application.Resources>
</Application>
```



## -see-also
[ResourceDictionary and XAML resource references](/windows/apps/design/style/xaml-resource-dictionary)
