---
-api-id: P:Windows.UI.Xaml.ResourceDictionary.ThemeDictionaries
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IMap<object, object> ThemeDictionaries { get; }
-->

# Windows.UI.Xaml.ResourceDictionary.ThemeDictionaries

## -description
Gets a collection of merged resource dictionaries that are specifically keyed and composed to address theme scenarios, for example supplying theme values for "HighContrast".



## -xaml-syntax
```xaml
<ResourceDictionary>
  <ResourceDictionary.ThemeDictionaries>
    oneOrMoreThemeDictionaries
  </ResourceDictionary.ThemeDictionaries>
</ResourceDictionary>
```


## -xaml-values
<dl><dt>oneOrMoreThemeDictionaries</dt><dd>oneOrMoreThemeDictionariesOne or more ResourceDictionary object elements. Each such ResourceDictionary must have an x:Key attribute. The value of x:Key must be unique within the resource scope (within the ResourceDictionary and the page it exists in). Each key directly on a ResourceDictionary tag should reference a known theme name. Each resource dictionary and the contents thereof should supply theme-specific resources that are referenced by {ThemeResource} markup extensions. Inside each theme-specific resource dictionary, keys for individual resources are not unique, which is intentional so that the theme resources are defined in parallel for each theme.</dd>
</dl>
## -property-value
A dictionary of [ResourceDictionary](resourcedictionary.md) theme dictionaries. Each must be keyed with **x:Key**.

## -remarks
Theme dictionaries have two primary scenarios: resources for your own app, and resources that the system provides for you on a per-theme basis. You'll only need to set values for the ThemeDictionaries resource set if you're defining your own app resources in app.xaml. Otherwise, the [{ThemeResource} markup extension](/windows/uwp/xaml-platform/themeresource-markup-extension) usages you'll be using in XAML control templates and elsewhere are typically referring to the system ThemeDictionaries resources, which can be viewed for design purposes within the generic.xaml design file.

Brush resources are often theme-specific. Default Windows Runtime XAML control UI defines many brush resources that are used for the various default XAML controls. You can see these resource definitions as part of the generic.xaml design file. The system ThemeDictionaries definitions are located early in the file, so that they are lexically forward of the [{ThemeResource} markup extension](/windows/uwp/xaml-platform/themeresource-markup-extension)s that reference them from within the default control templates. Your own page definitions and custom control definitions can make [{ThemeResource} markup extension](/windows/uwp/xaml-platform/themeresource-markup-extension) references to the system-supplied theme resources. In fact that's a recommended practice if you are writing controls that are intended to be in the same UI as the default controls. The default controls are using the theme resources extensively, and using the theme resources in your own controls can help prevent visual mismatches if the user changes the theme at runtime, or if the app is running under a theme that you hadn't specifically designed for.

There are also non-brush resources in the system theme resources in generic.xaml, such as default measures and font properties.

Theme dictionaries that you specify for individual apps aren't intended to supply the resource definition of an entire app theme. Instead, you should factor your page UI and custom control definitions to use system theme resources whenever possible, and to use app-specific theme resources for just a few cases where you want to override the system default values. For page-level app UI you typically only need new theme resources for certain non-brush resources used in composition such as glyphs or path-based graphics. The resources in ThemeDictionaries that you define yourself are intended for scenarios like accessibility. In particular, different resources might be needed for high contrast themes. For more info on the high contrast scenario, see [High-contrast themes](/windows/uwp/accessibility/high-contrast-themes). For more info on system-supplied themes, see [RequestedTheme](application_requestedtheme.md) or [XAML requested theme sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/XAML%20requested%20theme%20sample).

The expected keys for the basic themes are "Light" and "Dark".

For custom controls, you should also have a "HighContrast" keyed theme dictionary whenever you have theme dictionaries for "Light" and "Dark". There are other named high contrast themes, but the "HighContrast" theme key is the fallback the system uses for finding the high contrast theme if no other theme resources for high contrast are available.

For custom controls, if you don't support "Light" and "Dark" themes and only support one theme as well as at least one "HighContrast" theme, you can change your main dictionary's [x:Key attribute](/windows/uwp/xaml-platform/x-key-attribute) to "Default". "Default" is the [ResourceDictionary](resourcedictionary.md) that will be used if a [ResourceDictionary](resourcedictionary.md) in the specified theme (such as "Dark") cannot be found.

For high contrast themes and custom control scenarios, in addition to system brush resources, there are also system color resources such as "SystemColorButtonFaceColor" that you can assign to be the [Color](../windows.ui.xaml.media/solidcolorbrush_color.md) value of [SolidColorBrush](../windows.ui.xaml.media/solidcolorbrush.md) resources. You can use these as values for your "HighContrast" theme dictionary and also "Default". If the resource exists for each of the themes your control supports, the XAML templates will load the appropriate resource for the theme that's active.

## -examples
This example shows a ThemeDictionaries dictionary that defines brush styles for a "Default" theme, two existing "HighContrast*" themes that map to user theme choices for high contrast, and a custom high contrast theme. The dictionary is used by a control template for a custom control. This is part of the [High contrast sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/XAML%20high%20contrast%20style%20sample).

```xaml
<ResourceDictionary>
  <ResourceDictionary.ThemeDictionaries> 
    <ResourceDictionary x:Key="Default"> 
      <SolidColorBrush x:Key="TargetBackground" Color="Red"/> 
      <SolidColorBrush x:Key="TargetBorderBrush" Color="Black"/> 
      <SolidColorBrush x:Key="Circle4Fill" Color="Blue"/> 
      <SolidColorBrush x:Key="Circle3Fill" Color="Green"/> 
      <SolidColorBrush x:Key="Circle2Fill" Color="Yellow"/> 
      <SolidColorBrush x:Key="Circle1Fill" Color="White"/> 
      <SolidColorBrush x:Key="CircleStroke" Color="Black"/> 
    </ResourceDictionary> 
    <ResourceDictionary x:Key="HighContrastBlack"> 
       <SolidColorBrush x:Key="TargetBackground" Color="Black"/> 
       <SolidColorBrush x:Key="TargetBorderBrush" Color="White"/> 
       <SolidColorBrush x:Key="Circle4Fill" Color="Black"/> 
       <SolidColorBrush x:Key="Circle3Fill" Color="Black"/> 
       <SolidColorBrush x:Key="Circle2Fill" Color="Black"/> 
       <SolidColorBrush x:Key="Circle1Fill" Color="Black"/> 
       <SolidColorBrush x:Key="CircleStroke" Color="White"/> 
     </ResourceDictionary> 
     <ResourceDictionary x:Key="HighContrastWhite"> 
       <SolidColorBrush x:Key="TargetBackground" Color="White"/> 
       <SolidColorBrush x:Key="TargetBorderBrush" Color="Black"/> 
       <SolidColorBrush x:Key="Circle4Fill" Color="White"/> 
       <SolidColorBrush x:Key="Circle3Fill" Color="White"/> 
       <SolidColorBrush x:Key="Circle2Fill" Color="White"/> 
       <SolidColorBrush x:Key="Circle1Fill" Color="White"/> 
       <SolidColorBrush x:Key="CircleStroke" Color="Black"/> 
    </ResourceDictionary> 
    <ResourceDictionary x:Key="HighContrastCustom"> 
      <SolidColorBrush x:Key="TargetBackground" Color="{StaticResource SystemColorButtonFaceColor}"/> 
      <SolidColorBrush x:Key="TargetBorderBrush" Color="{StaticResource SystemColorButtonTextColor}"/> 
      <SolidColorBrush x:Key="Circle4Fill" Color="{StaticResource SystemColorHotlightColor}"/> 
      <SolidColorBrush x:Key="Circle3Fill" Color="{StaticResource SystemColorHotlightColor}"/> 
      <SolidColorBrush x:Key="Circle2Fill" Color="{StaticResource SystemColorHotlightColor}"/> 
      <SolidColorBrush x:Key="Circle1Fill" Color="{StaticResource SystemColorHotlightColor}"/> 
      <SolidColorBrush x:Key="CircleStroke" Color="{StaticResource SystemColorHighlightTextColor}"/> 
    </ResourceDictionary> 
  </ResourceDictionary.ThemeDictionaries>
</ResourceDictionary> 

```

The starting Microsoft Visual Studio templates for a UWP app using C++, C#, or Visual Basic include a ThemeDictionaries node in the XAML file that is the starting [MergedDictionaries](resourcedictionary_mergeddictionaries.md) value for an app.xaml file. All the built-in Windows Runtime controls already have high-contrast themes defined elsewhere (the native equivalent of generic.xaml) or use system theme resources so they can respond to themes, so the starting content of an app-specific ThemeDictionaries resource set is minimal. It's only once you start defining custom controls or app-specific theme styles that you'll see more resource definitions here.

```xaml
<ResourceDictionary
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml">

    <!-- Non-brush values that vary across themes -->
    
    <ResourceDictionary.ThemeDictionaries>
        <ResourceDictionary x:Key="Default">
            <x:String x:Key="BackButtonGlyph">&#xE071;</x:String>
            <x:String x:Key="BackButtonSnappedGlyph">&#xE0BA;</x:String>
        </ResourceDictionary>

        <ResourceDictionary x:Key="HighContrast">
            <x:String x:Key="BackButtonGlyph">&#xE0A6;</x:String>
            <x:String x:Key="BackButtonSnappedGlyph">&#xE0C4;</x:String>
        </ResourceDictionary>
    </ResourceDictionary.ThemeDictionaries>
...
</ResourceDictionary>
```



## -see-also
[MergedDictionaries](resourcedictionary_mergeddictionaries.md), [AccessibilitySettings](../windows.ui.viewmanagement/accessibilitysettings.md), [XAML theme resources](/windows/apps/design/style/xaml-theme-resources), [ResourceDictionary and XAML resource references](/windows/apps/design/style/xaml-resource-dictionary), [UI contrast and settings sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208%20app%20samples/%5BC%23%5D-Windows%208%20app%20samples/C%23/Windows%208%20app%20samples/UI%20contrast%20and%20settings%20sample%20(Windows%208)/C%23), [High contrast sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/XAML%20high%20contrast%20style%20sample), [XAML requested theme sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/XAML%20requested%20theme%20sample), [Control and app styling in XAML sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/XAML%20control%20and%20app%20styling%20sample), [High-contrast themes](/windows/uwp/accessibility/high-contrast-themes)
