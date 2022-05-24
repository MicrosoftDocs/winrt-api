---
-api-id: M:Windows.UI.Xaml.Core.Direct.XamlDirect.AddToCollection(Windows.UI.Xaml.Core.Direct.IXamlDirectObject,Windows.UI.Xaml.Core.Direct.IXamlDirectObject)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public void XamlDirect.AddToCollection(IXamlDirectObject xamlDirectObject, IXamlDirectObject value)
-->

# Windows.UI.Xaml.Core.Direct.XamlDirect.AddToCollection

## -description
Adds a value to the specified [IXamlDirectObject](ixamldirectobject.md) collection.


## -parameters
### -param xamlDirectObject
Refers to the specific [IXamlDirectObject](ixamldirectobject.md) collection.

### -param value
Refers to the [IXamlDirectObject](ixamldirectobject.md) value to add to the collection.

## -remarks
[IXamlDirectObject](ixamldirectobject.md) is the minimal handle to Xaml's internal object instances. Hence the collection and the value to add to the collection are both of type [IXamlDirectObject](ixamldirectobject.md).

## -see-also

[XamlDirect.RemoveFromCollection](xamldirect_removefromcollection_1992847812.md), [XamlDirect.InsertIntoCollectionAt](xamldirect_insertintocollectionat_679802579.md), [XamlDirect.RemoveFromCollectionAt](xamldirect_removefromcollectionat_1250477505.md), [XamlDirect.ClearCollection](xamldirect_clearcollection_1428253299.md)

## -examples
The following example shows how to add a value to a collection using [XamlDirect](xamldirect.md) APIs.

```csharp
XamlDirect xd = XamlDirect.GetDefault();

IXamlDirectObject relativePanel = xd.CreateInstance(XamlTypeIndex.RelativePanel);

IXamlDirectObject childrenCollection = xd.GetXamlDirectObjectProperty(relativePanel, XamlPropertyIndex.Panel_Children);

IXamlDirectObject button = xd.CreateInstance(XamlTypeIndex.Button);
xd.AddToCollection(childrenCollection, button);
```

```cppcx
XamlDirect^ xd = XamlDirect::GetDefault();

IXamlDirectObject^ relativePanel = xd->CreateInstance(XamlTypeIndex::RelativePanel);

IXamlDirectObject^ childrenCollection = xd->GetXamlDirectObjectProperty(relativePanel, XamlPropertyIndex::Panel_Children);

IXamlDirectObject^ button = xd->CreateInstance(XamlTypeIndex::Button);
xd->AddToCollection(childrenCollection, button);
```
