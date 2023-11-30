---
-api-id: T:Windows.UI.Xaml.ResourceDictionary
-api-type: winrt class
---

<!-- Class syntax.
public class ResourceDictionary : Windows.UI.Xaml.DependencyObject, Windows.Foundation.Collections.IIterable<Windows.Foundation.Collections.IKeyValuePair<System.Object, System.Object>>, Windows.Foundation.Collections.IMap<System.Object, System.Object>, Windows.UI.Xaml.IResourceDictionary
-->

# Windows.UI.Xaml.ResourceDictionary

## -description
Defines a repository for XAML resources, such as styles, that your app uses. You define the resources in XAML and can then retrieve them in XAML using the [{StaticResource} markup extension](/windows/uwp/xaml-platform/staticresource-markup-extension) and [{ThemeResource} markup extension](/windows/uwp/xaml-platform/themeresource-markup-extension) s. You can also access resources with code, but that is less common.



## -xaml-syntax
```xaml
<ResourceDictionary>
  oneOrMoreResources
</ResourceDictionary>
- or -
<frameworkElement>
  <frameworkElement.Resources>
    oneOrMoreResources
  </frameworkElement.Resources>
</frameworkElement>
```


## -remarks
A resource dictionary is a repository for XAML resources, such as styles, that your app uses. You define the resources in XAML and can then retrieve them in XAML using the [{StaticResource} markup extension](/windows/uwp/xaml-platform/staticresource-markup-extension) and [{ThemeResource} markup extension](/windows/uwp/xaml-platform/themeresource-markup-extension) s. You can also access resources with code, but that is less common. You can use resources to enforce that certain values such as brush colors or pixel measurements are used consistently throughout your app. For more info on using resource dictionaries effectively, see [ResourceDictionary and XAML resource references](/windows/apps/design/style/xaml-resource-dictionary).

### Uses of **ResourceDictionary** elements

The ResourceDictionary type is used as the value of two properties, [FrameworkElement.Resources](frameworkelement_resources.md) and [Application.Resources](application_resources.md), that are important to the overall structure of a UWP app. XAML files that you get from a starting project template for an app will start with initial values for [FrameworkElement.Resources](frameworkelement_resources.md), and the app.xaml file might start with initial values for [Application.Resources](application_resources.md). Exactly what resources are defined there depends on which project starting template you're using.

This XAML shows the use of a [FrameworkElement.Resources](frameworkelement_resources.md) property. In this case the [FrameworkElement](frameworkelement.md) is a [Page](../windows.ui.xaml.controls/page.md). There is no ResourceDictionary element subordinate to the Page.Resources property element, but its presence is implied; for more info see the "Notes on XAML syntax" section below. The XAML places a [Style](style.md) into the ResourceDictionary with an [x:Key attribute](/windows/uwp/xaml-platform/x-key-attribute) value of "TextBlockStyle1". Further down in the XAML, the [{StaticResource} markup extension](/windows/uwp/xaml-platform/staticresource-markup-extension) references the [Style](style.md) in the resource dictionary to provide a value for the [Style](frameworkelement_style.md) property of the [TextBlock](../windows.ui.xaml.controls/textblock.md) element.

The [Style](frameworkelement_style.md) as shown does not actually apply any styling to the [TextBlock](../windows.ui.xaml.controls/textblock.md), but you can add [Style](frameworkelement_style.md) properties in Microsoft Visual Studio. You can then use the [Style](frameworkelement_style.md) resource as often as you like on the page to enforce uniformity.

You can use Microsoft Visual Studio to create resource dictionaries. This example was created with these steps: put a [TextBlock](../windows.ui.xaml.controls/textblock.md) on the design surface, right click, choose **Edit Style / Create Empty**, then **"This document"** to define the new resource in Page.Resources.

```xaml
<Page
    x:Class="ResourceDictionary_example.MainPage"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    xmlns:local="using:ResourceDictionary_example"
    xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
    xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
    mc:Ignorable="d">
    <Page.Resources>
        <Style x:Key="TextBlockStyle1" TargetType="TextBlock"/>
    </Page.Resources>

    <Grid Background="{ThemeResource ApplicationPageBackgroundThemeBrush}">
        <TextBlock Style="{StaticResource TextBlockStyle1}" Text="TextBlock"/>
    </Grid>
</Page>

```

This XAML, from the AppPage.xaml file of the [AtomPub sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/AtomPub%20sample), shows the use of an [Application.Resources](application_resources.md) property. The XAML places two [Style](style.md) elements into the resource dictionary, making them available throughout the application.

```xaml
<Application xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml" 
    x:Class="AtomPub.App"
    RequestedTheme="Light" >
    <Application.Resources>
        <ResourceDictionary>
            <Style x:Key="TitleStyle" TargetType="TextBlock">
                <Setter Property="Foreground" Value="#707070"/>
                <Setter Property="FontFamily" Value="Segoe UI Light"/>
                <Setter Property="FontSize" Value="16"/>
            </Style>
            <Style x:Key="H1Style" TargetType="TextBlock">
                <Setter Property="Foreground" Value="#212121"/>
                <Setter Property="FontFamily" Value="Segoe UI Semilight"/>
                <Setter Property="FontSize" Value="26.667"/>
                <Setter Property="Margin" Value="0,0,0,25"/>
            </Style>
            ...
        </ResourceDictionary>
    </Application.Resources>
</Application> 

```

This XAML from file MainPage.xaml uses the [{StaticResource} markup extension](/windows/uwp/xaml-platform/staticresource-markup-extension) to access the **TitleStyle** and **H1Style** styles:

```xaml

    ...
    <!-- Header -->
    <StackPanel x:Name="Header" Grid.Row="0">
        <StackPanel Orientation="Horizontal">
            ...
            <TextBlock Text="Windows SDK Samples" VerticalAlignment="Bottom" Style="{StaticResource TitleStyle}" TextWrapping="Wrap"/>
        </StackPanel>
        <TextBlock x:Name="FeatureName" Text="Add Feature Name" Style="{StaticResource H1Style}" TextWrapping="Wrap"/>
    </StackPanel>
     ...

```

You can factor resources into their own XAML file by using ResourceDictionary as the root element of the file. You can then include those resources in a [FrameworkElement.Resources](frameworkelement_resources.md) or [Application.Resources](application_resources.md) resource dictionary. To do this you use the [ResourceDictionary.MergedDictionaries](resourcedictionary_mergeddictionaries.md) property or the [ResourceDictionary.ThemeDictionaries](resourcedictionary_themedictionaries.md) property of the ResourceDictionary element.

This file, Common/Styles1.xaml, defines [Style](style.md) resources using ResourceDictionary as the root element:

```xaml
<ResourceDictionary
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation" 
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml">

    <Style x:Key="TitleTextStyle" TargetType="TextBlock">
        <Setter Property="FontFamily" Value="Segoe UI Light"/>
        <Setter Property="FontSize" Value="16"/>
    </Style>
    <Style x:Key="HeaderTextStyle" TargetType="TextBlock">
        <Setter Property="FontFamily" Value="Segoe UI Semilight"/>
        <Setter Property="FontSize" Value="26.667"/>
        <Setter Property="Margin" Value="0,0,0,25"/>
    </Style>
    ...
</ResourceDictionary>
```

Now suppose there is another file, Common/Styles2.xaml that similarly defines [Style](style.md) resources. This XAML shows how to merge the resources in those two files using the [ResourceDictionary.MergedDictionaries](resourcedictionary_mergeddictionaries.md) property to create an [Application.Resources](application_resources.md) resource dictionary. The XAML also defines two further [Style](style.md) resources and merges them with the resources from the two files.

```xaml
<Application
    .... >
    <Application.Resources>
        <ResourceDictionary>
            <Style x:Key="ErrorStyle" TargetType="TextBlock">
                <Setter Property="Foreground" Value="DarkRed"/>
                <Setter Property="FontFamily" Value="Segoe UI Semilight"/>
                <Setter Property="FontSize" Value="15"/>
            </Style>
            <Style x:Key="StatusStyle" TargetType="TextBlock">
                <Setter Property="Foreground" Value="Black"/>
                <Setter Property="FontFamily" Value="Segoe UI Semilight"/>
                <Setter Property="FontSize" Value="15"/>
            </Style>
            <ResourceDictionary.MergedDictionaries>
                <!-- 
                    Styles that define common aspects of the platform look and feel
                 -->
                <ResourceDictionary Source="Common/Styles1.xaml"/>
                <ResourceDictionary Source="Common/Styles2.xaml"/>
            </ResourceDictionary.MergedDictionaries>
        </ResourceDictionary>
    </Application.Resources>
</Application>
```

For info on how merged dictionary resources are resolved, see the "Merged resource dictionaries" section of [ResourceDictionary and XAML resource references](/windows/apps/design/style/xaml-resource-dictionary).

### The x:Key property

In XAML, the keys for ResourceDictionaryitems are declared by setting the [x:Key attribute](/windows/uwp/xaml-platform/x-key-attribute)on elements that represent the XAML resources. Typically, if you try to put a child element that does not have a key value into a ResourceDictionary, this throws a XAML parse exception or a Windows Runtimeexception. The exception condition might also be noted as a warning by XAML design surfaces. However, there are three notable cases where a ResourceDictionarychild element won't require an [x:Key attribute](/windows/uwp/xaml-platform/x-key-attribute)value:
+ A [Style](style.md) resource can use its [TargetType](style_targettype.md) value as the implicit resource key. For more info on how implicit keys for styles and control templates work, see [Styling controls](/windows/uwp/controls-and-patterns/styling-controls).
+ The ResourceDictionary elements with [Source](resourcedictionary_source.md) values that represent [ResourceDictionary.MergedDictionaries](resourcedictionary_mergeddictionaries.md) values can't have an [x:Key attribute](/windows/uwp/xaml-platform/x-key-attribute) on ResourceDictionary. Within each merged dictionary file, (the one referenced by URI as its [Source](resourcedictionary_source.md)) you do need keys for each resource.
+ The [x:Name attribute](/windows/uwp/xaml-platform/x-name-attribute) can be used instead of [x:Key attribute](/windows/uwp/xaml-platform/x-key-attribute), for legacy reasons. However, [x:Name attribute](/windows/uwp/xaml-platform/x-name-attribute) by itself doesn't enable XAML resource lookup of that item. The [x:Name attribute](/windows/uwp/xaml-platform/x-name-attribute) identifying convention is used for certain scenarios such as defining storyboarded animations. For more info, see [x:Name attribute](/windows/uwp/xaml-platform/x-name-attribute).


### Iterating through a **ResourceDictionary**

You can iterate through a ResourceDictionary in C# or Microsoft Visual Basic. In many cases, such as using **foreach** syntax, the compiler does this casting for you and you won't need to cast to `IEnumerable` explicitly. If you do need to cast explicitly, for example if you want to call [GetEnumerator](/dotnet/api/system.collections.ienumerable.getenumerator?view=dotnet-uwp-10.0&preserve-view=true), cast to [IEnumerable&lt;T&gt;](/dotnet/api/system.collections.generic.ienumerable-1?view=dotnet-uwp-10.0&preserve-view=true) with a **KeyValuePair&lt;Object,Object&gt;** constraint.

### **ResourceDictionary** and Microsoft Visual Studio

Microsoft Visual Studio provides an **Add New Item** page choice for a resource dictionary. Use this option whenever you want to define a new loose XAML resource dictionary, for example to serve as the source for a merged dictionary. Microsoft Visual Studio also adds a loose XAML resource dictionary to the project whenever you use **Add New Item** to create a templated control. This resource dictionary provides the default theme templates. Microsoft Visual Studio might create a new ResourceDictionary for you in your XAML if you are editing copies of styles or templates and a ResourceDictionary for your chosen resource location (app, page, or standalone) doesn't exist yet.

### Notes on XAML syntax

Notice that the XAML implicit collection syntax for ResourceDictionary does not include an object element for the ResourceDictionary. This is an example of XAML implicit collection syntax; a tag representing the collection element can be omitted. The elements that are added as items to the collection are specified as child elements of a property element of a property whose underlying type supports a dictionary / map **Add** method.

For a merged resource dictionary, you do need to explicitly declare a ResourceDictionary object element, so that you can also declare the [ResourceDictionary.MergedDictionaries](resourcedictionary_mergeddictionaries.md) property element and [Source](resourcedictionary_source.md). Thus there are a minimum of two ResourceDictionary object elements involved, and you use this syntax.

```xaml
<ResourceDictionary>
  <ResourceDictionary.MergedDictionaries>
    <ResourceDictionary Source="uri"/>
    ...
  </ResourceDictionary.MergedDictionaries>
...
</ResourceDictionary>
```

In this syntax the outer ResourceDictionary is the primary ResourceDictionary. The inner ResourceDictionary is the ResourceDictionary being merged.

For the implicit collection usage, the placeholder as appropriate for the property [FrameworkElement.Resources](frameworkelement_resources.md) is shown. You could also use this implicit collection usage for the [Application.Resources](application_resources.md) property, or potentially for a custom property that uses ResourceDictionary as its property type.

### Shareable types and UIElement types

A resource dictionary is a technique for defining shareable types and values of these types in XAML. Not all types or values are suitable for usage from a ResourceDictionary. Examples of types where sharing is supported include [Style](style.md), any [FrameworkTemplate](frameworktemplate.md) subclass, the [XAML intrinsic data types](/windows/uwp/xaml-platform/xaml-intrinsic-data-types), brushes, colors, and transforms. For more info on which types are considered shareable, see [ResourceDictionary and XAML resource references](/windows/apps/design/style/xaml-resource-dictionary). Generally, [UIElement](uielement.md)-derived types are not shareable unless they come from templates and application of a template on a specific control instance. Excluding the template case, a [UIElement](uielement.md) is expected to exist in only one place in an object tree after it is instantiated, and having a [UIElement](uielement.md) be shareable would potentially violate this principle.


In practice, the vast majority of the resources defined in a ResourceDictionary will be one of these:
+ Control templates for a control, including its visual states.
+ Supporting styles for parts of controls
+ Styles for elements that are part of typical app UI but aren't controls, like [TextBlock](../windows.ui.xaml.controls/textblock.md)
+ Data templates for controls and panels that use data binding
+ Specific [Brush](../windows.ui.xaml.media/brush.md) values, mostly [SolidColorBrush](../windows.ui.xaml.media/solidcolorbrush.md)
+ Strings or other constants that never need to be localized (strings and constants that do need to be localized shouldn't be in a ResourceDictionary; for more info see [Quickstart: Translating UI resources](/previous-versions/windows/apps/hh965329(v=win.10)))


### Accessing a ResourceDictionary object in code

The API that your code uses to access the resources in a ResourceDictionary depends on which programming language you use:
+ For C# or Microsoft Visual Basic you use API that implement 
[IDictionary&lt;TKey,TValue&gt;](/dotnet/api/system.collections.generic.idictionary-2?view=dotnet-uwp-10.0&preserve-view=true) and 
[IEnumerable&lt;T&gt;](/dotnet/api/system.collections.generic.ienumerable-1?view=dotnet-uwp-10.0&preserve-view=true). For example, [TryGetValue](/dotnet/api/system.collections.generic.idictionary-2.trygetvalue?view=dotnet-uwp-10.0&preserve-view=true) or the [Item](/dotnet/api/system.collections.generic.idictionary-2.item?view=dotnet-uwp-10.0&preserve-view=true) indexer.
+ For Visual C++ component extensions (C++/CX) you use API that implement [IMap<K,V>](../windows.foundation.collections/imap_2.md) and [IIterable&lt;T&gt;](../windows.foundation.collections/iiterable_1.md). For example, [Lookup](resourcedictionary_lookup_786690417.md).
+ API that aren't part of collection support, like [Source](resourcedictionary_source.md), are the same in all languages.


For more info on how to use ResourceDictionary in code, see "Using a ResourceDictionary from code" section of [ResourceDictionary and XAML resource references](/windows/apps/design/style/xaml-resource-dictionary).

### System resources

Some theme resources reference system resource values as an underlying sub-value. A system resource is a special resource value that isn't found in any XAML resource dictionary. These values rely on behavior in Windows Runtime XAML support to forward values from the system itself, and represent them in a form that a XAML resource can reference. 
<!--For a list of these values, see ...-->

### Notes for previous versions

#### Resource loading optimization in Windows 8.1

Starting with Windows 8.1, there's a resource loading optimization that's enabled by the app model and the Windows Runtime XAML parser. For Windows 8, the XAML parser loaded resources from app.xaml and created each of them as objects as part of startup. That wasn't very efficient if there were big dictionaries there. Also, those resources included the items that were needed by all three themes, and two of the three themes wouldn't even be active. Starting with Windows 8.1, the XAML parser only creates the resources when they're specifically requested. The request might come from other resources or from app or page XAML as each is loaded. This parser behavior minimizes the time it takes to read the app-level dictionary at startup time, and enables the first app page to load faster in most cases. Resources needed by other currently inactive themes are only loaded if that theme is chosen to become the active theme by the user. At that time, any resource where the [{ThemeResource} markup extension](/windows/uwp/xaml-platform/themeresource-markup-extension) was used for the request is recalculated based on the newly active theme.

<!--The following remark is relevant for Windows 8 > 8.1 migration. See WBB 454546-->
#### Windows 8 behavior

Windows 8 didn't have the optimizations described above. The ResourceDictionary for `Application.Resources` had to finish parsing before any page other than the splash screen could load into the app's [Window](window.md). Because of this you might see some differences in timing when you retarget your app for Windows 8.1. The app should be loading faster, however it may not be possible to isolate this improvement versus other changes you've made to your app code as part of retargeting. Some of the places where you might see evidence of timing changes due to optimized resource loading include when the constructors are called by the parser, for objects like [Application](application.md) objects, converters, or other custom classes. Apps that were compiled for Windows 8 but running on Windows 8.1 continue to use the Windows 8 behavior.

For more info on performance and XAML resource factoring, see [Optimize your XAML markup](/windows/uwp/debug-test-perf/optimize-xaml-loading).

## -examples

## -see-also
[ResourceDictionary and XAML resource references](/windows/apps/design/style/xaml-resource-dictionary), [Application resources and localization sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/ApplicationResources), [{ThemeResource} markup extension](/windows/uwp/xaml-platform/themeresource-markup-extension), [{StaticResource} markup extension](/windows/uwp/xaml-platform/staticresource-markup-extension), [x:Key attribute](/windows/uwp/xaml-platform/x-key-attribute)
