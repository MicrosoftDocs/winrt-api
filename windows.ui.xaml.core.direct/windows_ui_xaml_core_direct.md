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

[XamlDirect](xamldirect.md) is **purpose built for middleware** that predominantly use imperative APIs to create UI instead of markup-based UI creation. With [XamlDirect](xamldirect.md) APIs, you can achieve performance parity with the XAML parser even when creating UI imperatively in code. 

[XamlDirect](xamldirect.md) APIs can be used side-by-side with traditional APIs and take advantage of the pay for play performance improvements.  

Not all Xaml APIs are available with [XamlDirect](xamldirect.md). The [XamlTypeIndex enum](xamltypeindex.md) lists all supported types, the [XamlPropertyIndex enum](xamlpropertyindex.md) lists all supported properties, and the [XamlEventIndex enum](xamleventindex.md) lists all supported events. 

### Supported functions

You can perform the following functions using XamlDirect APIs:
* Create an instance of an internal Xaml object for a regular Xaml type, like [Button](../windows.ui.xaml.controls/button.md), using [XamlDirect.CreateInstance](xamldirect_createinstance_2026807211.md). 
* Set property values using one of the appropriate variants of the XamlDirect.Set-Property method based on the type of the property. For example, use [XamlDirect.SetColorProperty](xamldirect_setcolorproperty_902589183.md) to the [SolidColorBrush.Color](../windows.ui.xaml.media/solidcolorbrush_color.md) property. Similarly use Get-Property methods to access specific properties.
* Add an item to a collection, like [Panel.Children](../windows.ui.xaml.controls/panel_children.md), using [XamlDirect.AddToCollection](xamldirect_addtocollection_1437837191.md) and remove items from collections using [XamlDirect.RemoveFromCollection](xamldirect_removefromcollection_1992847812.md). XamlDirect supports a variety of such collection operations including [GetCollectionCount](xamldirect_getcollectioncount_1497168638.md), [ClearCollection](xamldirect_clearcollection_1428253299.md), [InsertIntoCollectionAt](xamldirect_insertintocollectionat_679802579.md), [RemoveFromCollectionAt](xamldirect_removefromcollectionat_1250477505.md) and [GetXamlDirectObjectFromCollectionAt](xamldirect_getxamldirectobjectfromcollectionat_960712420.md). 
* Add an event handler, like [Button.Click](../windows.ui.xaml.controls/button_click.md) using [XamlDirect.AddEventHandler](xamldirect_addeventhandler_1323041406.md) and similarly remove event handlers using [XamlDirect.RemoveEventHandler](xamldirect_removeeventhandler_2027037099.md).

All objects returned by [XamlDirect.CreateInstance](xamldirect_createinstance_2026807211.md) are of type [IXamlDirectObject](ixamldirectobject.md).  All other APIs, such as the Set*Property APIs, take an [IXamlDirectObject](ixamldirectobject.md) as its first parameter. 

To convert an [IXamlDirectObject](ixamldirectobject.md) to its full APINDEX, for example a [Button](../windows.ui.xaml.controls/button.md), use the [XamlDirect.GetObject](xamldirect_getobject_1023047843.md) method. Similarly, you can use [XamlDirect.GetXamlDirectObject](xamldirect_getxamldirectobject_197339041.md) to convert from a full Object/DependencyObject to its XamlDirect equivalent instance. 

## -see-also
* [XamlDirect](xamldirect.md)
* [IXamlDirectObject](ixamldirectobject.md)
* [XamlTypeIndex](xamltypeindex.md)
* [XamlPropertyIndex](xamlpropertyindex.md)
* [XamlEventIndex](xamleventindex.md)
