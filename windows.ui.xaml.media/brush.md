---
-api-id: T:Windows.UI.Xaml.Media.Brush
-api-type: winrt class
---

<!-- Class syntax.
public class Brush : Windows.UI.Xaml.DependencyObject, Windows.UI.Xaml.Media.IBrush
-->

# Windows.UI.Xaml.Media.Brush

## -description
Defines objects used to paint graphical objects. Classes that derive from Brush describe how the area is painted.



## -xaml-syntax
```xaml
<object property="predefinedColorName"/>
- or -
<object property="#rgb"/>
- or -
<object property="#argb"/>
- or -
<object property="#rrggbb"/>
- or -
<object property="#aarrggbb"/>
- or -
<object property="sc#scR,scG,scB"/>
- or -
<object property="sc#scA,scR,scG,scB"/>
```


## -remarks
For examples and further explanation of the UI drawing concepts represented by Brush, see [Use brushes](/windows/uwp/graphics/using-brushes).

### Brushes as XAML resources

Each of the Brush types that can be declared in XAML ([SolidColorBrush](solidcolorbrush.md), [LinearGradientBrush](lineargradientbrush.md), [ImageBrush](imagebrush.md)) is intended to be defined as a resource, so that you can reuse that brush as a resource throughout your app. The XAML syntax shown for Brush types is appropriate for defining the brush as a resource. When you declare a brush as a resource, you also need an [x:Key attribute](/windows/uwp/xaml-platform/x-key-attribute) that you'll later use to refer to that resource from other UI definitions. For more info on XAML resources and how to use [x:Key attribute](/windows/uwp/xaml-platform/x-key-attribute), see [ResourceDictionary and XAML resource references](/windows/apps/design/style/xaml-resource-dictionary).

The advantage of declaring brushes as resources is that it reduces the number of runtime objects that are needed to construct a UI: the brush is now shared as a common resource that's providing values for multiple parts of the object graph.

If you look at the existing control template definitions for Windows Runtime XAML controls, you'll see that the templates use brush resources extensively. Many of these resources are system resources, and they use the [{ThemeResource} markup extension](/windows/uwp/xaml-platform/themeresource-markup-extension) for the resource reference rather than [{StaticResource} markup extension](/windows/uwp/xaml-platform/staticresource-markup-extension). For more info on how to use system resource brushes in your own control template XAML, see [XAML theme resources](/windows/apps/design/style/xaml-theme-resources).

### **Brush** derived classes

Brush is the parent class for several derived classes that either implement practical brushes that paint UI regions, or are intermediate base classes for such brushes:

+ [GradientBrush](gradientbrush.md): Intermediate base class for [LinearGradientBrush](lineargradientbrush.md).
+ [SolidColorBrush](solidcolorbrush.md): This is by far the most commonly used Brush.
+ [TileBrush](tilebrush.md): Intermediate base class for [ImageBrush](imagebrush.md).

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1809 | 17763 | PopulatePropertyInfo |
| 1809 | 17763 | PopulatePropertyInfoOverride |

## -examples

## -see-also
[DependencyObject](../windows.ui.xaml/dependencyobject.md), [SolidColorBrush](solidcolorbrush.md), [Color](../windows.ui/color.md), [Colors](../windows.ui/colors.md), [Use brushes](/windows/uwp/graphics/using-brushes), [Image and ImageBrush](/windows/uwp/controls-and-patterns/images-imagebrushes), [ResourceDictionary and XAML resource references](/windows/apps/design/style/xaml-resource-dictionary)
