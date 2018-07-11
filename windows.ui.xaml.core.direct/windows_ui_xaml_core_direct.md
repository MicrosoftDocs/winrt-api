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
* Create an instance of an internal Xaml object for a regular Xaml type, like [Button](../windows.ui.xaml.controls/button.md), using [XamlDirect.CreateInstance](xamldirect_createinstance.md). 
* Set property values using one of the appropriate variants of the XamlDirect.Set-Property method based on the type of the property. For example, use [XamlDirect.SetColorProperty](xamldirect_setcolorproperty.md) to the [SolidColorBrush.Color](../windows.ui.xaml.media/solidcolorbrush_color.md) property. Similarly use Get-Property methods to access specific properties.
* Add an item to a collection, like [Panel.Children](../windows.ui.xaml.controls/panel_children.md), using [XamlDirect.AddToCollection](xamldirect_addtocollection.md) and remove items from collections using [XamlDirect.RemoveFromCollection](xamldirect_removefromcollection.md). XamlDirect supports a variety of such collection operations including [GetCollectionCount](xamldirect_getcollectioncount.md), [ClearCollection](xamldirect_clearcollection.md), [InsertIntoCollectionAt](xamldirect_insertintocollectionat.md), [RemoveFromCollection](xamldirect_removefromcollection.md), [RemoveFromCollectionAt](xamldirect_removefromcollectionat.md) and [GetXamlDirectObjectFromCollectionAt](xamldirect_getxamldirectobjectfromcollectionat.md). 
* Add an event handler, like [Button.Click](../windows.ui.xaml.controls/button_click.md) using [XamlDirect.AddEventHandler](xamldirect_addeventhandler.md) and similarly remove event handlers using [XamlDirect.RemoveEventHandler](xamldirect_removeeventhandler.md).

All objects returned by [XamlDirect.CreateInstance](xamldirect_createinstnce.md) are of type [IXamlDirectObject](ixamldirectobject.md).  All other APIs, such as the Set*Property APIs, take an [IXamlDirectObject](ixamldirectobject.md) as its first parameter. 

To convert an [IXamlDirectObject](ixamldirectobject.md) to its full APINDEX, for example a [Button](../windows.ui.xaml.controls/button.md), use the [XamlDirect.GetObject](xamldirect_getobject.md) method. Similarly, you can use [XamlDirect.GetXamlDirectObject](xamldirect_getxamldirectobject.md) to convert from a full Object/DependencyObject to its XamlDirect equivalent instance. 

## -see-also
* [XamlDirect](xamldirect.md)
* [IXamlDirectObject](ixamldirectobject.md)
* [XamlTypeIndex](xamltypeindex.md)
* [XamlPropertyIndex](xamlpropertyindex.md)
* [XamlEventIndex](xamleventindex.md)
