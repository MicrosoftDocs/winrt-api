---
-api-id: T:Windows.UI.Xaml.Media.Brush
-api-type: winrt class
---

<!-- Class syntax.
public class Brush : Windows.UI.Xaml.DependencyObject, Windows.UI.Xaml.Media.IBrush
-->

# Windows.UI.Xaml.Media.Brush

## -description
Defines objects used to paint graphical objects. Classes that derive from [Brush](brush.md) describe how the area is painted.

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
For examples and further explanation of the UI drawing concepts represented by [Brush](brush.md), see [Use brushes](http://msdn.microsoft.com/library/02141f86-355e-4046-86ea-2a89d615b7db).

### Brushes as XAML resources

Each of the [Brush](brush.md) types that can be declared in XAML ([SolidColorBrush](solidcolorbrush.md), [LinearGradientBrush](lineargradientbrush.md), [ImageBrush](imagebrush.md)) is intended to be defined as a resource, so that you can reuse that brush as a resource throughout your app. The XAML syntax shown for [Brush](brush.md) types is appropriate for defining the brush as a resource. When you declare a brush as a resource, you also need an [x:Key attribute](http://msdn.microsoft.com/library/141fc5af-80ee-4401-8a1b-17cb22c2277a) that you'll later use to refer to that resource from other UI definitions. For more info on XAML resources and how to use [x:Key attribute](http://msdn.microsoft.com/library/141fc5af-80ee-4401-8a1b-17cb22c2277a), see [ResourceDictionary and XAML resource references](http://msdn.microsoft.com/library/e3cbfa3d-6af5-44e1-b9f9-c3d3ea8a25ce).

The advantage of declaring brushes as resources is that it reduces the number of runtime objects that are needed to construct a UI: the brush is now shared as a common resource that's providing values for multiple parts of the object graph.

If you look at the existing control template definitions for Windows Runtime XAML controls, you'll see that the templates use brush resources extensively. Many of these resources are system resources, and they use the [{ThemeResource} markup extension](http://msdn.microsoft.com/library/8a1c79d2-9566-44aa-b8e1-cc7adad1bcc5) for the resource reference rather than [{StaticResource} markup extension](http://msdn.microsoft.com/library/d50349b5-4588-4ebd-9458-75f629ccc395). For more info on how to use system resource brushes in your own control template XAML, see [XAML theme resources](http://msdn.microsoft.com/library/41b87dbf-e7a2-44e9-beba-af6eebabb81b).

### **Brush** derived classes

[Brush](brush.md) is the parent class for several derived classes that either implement practical brushes that paint UI regions, or are intermediate base classes for such brushes:

+ [GradientBrush](gradientbrush.md): Intermediate base class for [LinearGradientBrush](lineargradientbrush.md).
+ [SolidColorBrush](solidcolorbrush.md): This is by far the most commonly used [Brush](brush.md).
+ [TileBrush](tilebrush.md): Intermediate base class for [ImageBrush](imagebrush.md).


## -examples

## -see-also
[DependencyObject](../windows.ui.xaml/dependencyobject.md), [SolidColorBrush](solidcolorbrush.md), [Color](../windows.ui/color.md), [Colors](../windows.ui/colors.md), [Use brushes](http://msdn.microsoft.com/library/02141f86-355e-4046-86ea-2a89d615b7db), [Image and ImageBrush](http://msdn.microsoft.com/library/cea8780c-71a3-4168-a6e8-6361cdfb2faf), [ResourceDictionary and XAML resource references](http://msdn.microsoft.com/library/e3cbfa3d-6af5-44e1-b9f9-c3d3ea8a25ce)