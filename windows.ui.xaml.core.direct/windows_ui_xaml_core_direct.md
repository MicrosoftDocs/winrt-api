---
-api-id: N:Windows.UI.Xaml.Core.Direct
-api-type: winrt namespace
---

<!-- Namespace syntax.
namespace Windows.UI.Xaml.Core.Direct 
-->

# Windows.UI.Xaml.Core.Direct

## -description
Provides [XamlDirect](xamldirect.md) APIs that allow middleware to access most of Xaml at a more primitive level, achieving better CPU and working set performance.

## -remarks

[XamlDirect](xamldirect.md) is **purpose built for middleware** that predominantly use imperative APIs to create UI instead of markup. With [XamlDirect](xamldirect.md) APIs, you can achieve performance parity with the XAML parser even when creating UI imperatively in code. 

[XamlDirect](xamldirect.md) APIs can be used side-by-side with traditional APIs and take advantage of the pay for play performance improvements.  

Not all Xaml APIs are available with [XamlDirect](xamldirect.md). The [XamlTypeIndex enum](xamltypeindex.md) lists all supported types, the [XamlPropertyIndex enum](xamlpropertyindex.md) lists all supported properties, and the [XamlEventIndex enum](xamleventindex.md) lists all supported events. 

### Supported functions

You can perform the following functions using XamlDirect APIs:
* Create an instance of an internal Xaml object for a regular Xaml type, like [Button](../windows.ui.xaml.controls/button.md), using [XamlDirect.CreateInstance](xamldirect_createinstance_2026807211.md). 
* Set property values using one of the appropriate variants of the XamlDirect.Set-Property method based on the type of the property. For example, use [XamlDirect.SetColorProperty](xamldirect_setcolorproperty_902589183.md) to the [SolidColorBrush.Color](../windows.ui.xaml.media/solidcolorbrush_color.md) property. Similarly use Get-Property methods to access specific properties.
* Add an item to a collection, like [Panel.Children](../windows.ui.xaml.controls/panel_children.md), using [XamlDirect.AddToCollection](xamldirect_addtocollection_1437837191.md) and remove items from collections using [XamlDirect.RemoveFromCollection](xamldirect_removefromcollection_1992847812.md). XamlDirect supports a variety of such collection operations including [GetCollectionCount](xamldirect_getcollectioncount_1497168638.md), [ClearCollection](xamldirect_clearcollection_1428253299.md), [InsertIntoCollectionAt](xamldirect_insertintocollectionat_679802579.md), [RemoveFromCollectionAt](xamldirect_removefromcollectionat_1250477505.md) and [GetXamlDirectObjectFromCollectionAt](xamldirect_getxamldirectobjectfromcollectionat_960712420.md). 
* Add an event handler, like [Button.Click](../windows.ui.xaml.controls.primitives/buttonbase_click.md) using [XamlDirect.AddEventHandler](xamldirect_addeventhandler_1323041406.md) and similarly remove event handlers using [XamlDirect.RemoveEventHandler](xamldirect_removeeventhandler_2027037099.md).

All objects returned by [XamlDirect.CreateInstance](xamldirect_createinstance_2026807211.md) are of type [IXamlDirectObject](ixamldirectobject.md). All other APIs, such as the Set*Property APIs, take an [IXamlDirectObject](ixamldirectobject.md) as their first parameter. 

To convert an [IXamlDirectObject](ixamldirectobject.md) to its full APINDEX, for example a [Button](../windows.ui.xaml.controls/button.md), use the [XamlDirect.GetObject](xamldirect_getobject_1023047843.md) method. Similarly, you can use [XamlDirect.GetXamlDirectObject](xamldirect_getxamldirectobject_197339041.md) to convert from a full Object/DependencyObject to its XamlDirect equivalent instance. 

## -examples
This example demonstrates how to create objects, set properties, and interface with standard UIElements in 3 ways: using XAML markup, using regular XAML types in C# and the new way using **XamlDirect** APIs. 

In this example, we create a [Border](../windows.ui.xaml.controls/border.md) element and a [Rectangle](../windows.ui.xaml.shapes/rectangle.md) element and set a few properties on each. Then we add them to the tree of UI elements.

1. Using XAML markup:
```xaml
<Grid x:Name="RootGrid">
    <Border BorderBrush="Black" BorderThickness="5">
        <Rectangle Height="100" Width="100" Fill="Red" />
    </Border>
</Grid>
```

2. Using regular imperative code, with full XAML types:

```csharp
Border border = new Border();
border.BorderBrush = new SolidColorBrush(Colors.Black);
border.BorderThickness = new Thickness(5);

Rectangle rectangle = new Rectangle();
rectangle.Height = 100;
rectangle.Width = 100;
SolidColorBrush rectBrush = new SolidColorBrush(Colors.Red);
rectangle.Fill = rectBrush;

border.Child = rectangle;

RootGrid.Children.Add(border);
```

3. Using **XamlDirect** code:

The following code will have higher performance than using full XAML types since all operations like instantiation and setting of properties on various elements are accomplished through [IXamlDirectObjects](ixamldirectobject.md) instead of the full XAML types.

```csharp
XamlDirect xamlDirect = XamlDirect.GetDefault();

IXamlDirectObject border = XamlDirect.CreateInstance(XamlTypeIndex.Border);
xamlDirect.SetThicknessProperty(border, XamlPropertyIndex.Border_BorderThickness, new Thickness(5));

IXamlDirectObject borderBrush = XamlDirect.CreateInstance(XamlTypeIndex.SolidColorBrush);
xamlDirect.SetColorProperty(borderBrush, XamlPropertyIndex.SolidColorBrush_Color, Colors.Black);
xamlDirect.SetXamlDirectObjectProperty(border, XamlPropertyIndex.Border_BorderBrush, borderBrush);

IXamlDirectObject rectangle = XamlDirect.CreateInstance(XamlTypeIndex.Rectangle);
xamlDirect.SetDoubleProperty(rectangle, XamlPropertyIndex.FrameworkElement_Width, 100);
xamlDirect.SetDoubleProperty(rectangle, XamlPropertyIndex.FrameworkElement_Height, 100);

IXamlDirectObject rectBrush = XamlDirect.CreateInstance(XamlTypeIndex.SolidColorBrush);
xamlDirect.SetColorProperty(rectBrush, XamlPropertyIndex.SolidColorBrush_Color, Colors.Red);
xamlDirect.SetXamlDirectObjectProperty(rectangle, XamlPropertyIndex.Shape_Fill, rectangleBrush);

xamlDirect.SetXamlDirectObjectProperty(border, XamlPropertyIndex.Border_Child, rectangle);

RootGrid.Children.Add((UIElement) XamlDirect.GetObject(border));
```

## -see-also

[XamlDirect](xamldirect.md), [IXamlDirectObject](ixamldirectobject.md), [XamlTypeIndex](xamltypeindex.md), [XamlPropertyIndex](xamlpropertyindex.md), [XamlEventIndex](xamleventindex.md)
