---
-api-id: M:Windows.UI.Xaml.Core.Direct.XamlDirect.InsertIntoCollectionAt(Windows.UI.Xaml.Core.Direct.IXamlDirectObject,System.UInt32,Windows.UI.Xaml.Core.Direct.IXamlDirectObject)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public void XamlDirect.InsertIntoCollectionAt(IXamlDirectObject xamlDirectObject, UInt32 index, IXamlDirectObject value)
-->

# Windows.UI.Xaml.Core.Direct.XamlDirect.InsertIntoCollectionAt

## -description
Inserts a value into the specified [IXamlDirectObject](ixamldirectobject.md) collection at the specified index.


## -parameters
### -param xamlDirectObject
Refers to the specific [IXamlDirectObject](ixamldirectobject.md) collection.

### -param index
Refers to the index in the collection where the specified value must be inserted.

### -param value
Refers to the [IXamlDirectObject](ixamldirectobject.md) value to add to the collection.

## -see-also

[XamlDirect.RemoveFromCollectionAt](xamldirect_removefromcollectionat_1250477505.md), [XamlDirect.AddToCollection](xamldirect_addtocollection_1437837191.md), [XamlDirect.RemoveFromCollection](xamldirect_removefromcollection_1992847812.md
), [XamlDirect.ClearCollection](xamldirect_clearcollection_1428253299.md)

## -examples
The following example shows how to insert a value into a collection at a specific index using [XamlDirect](xamldirect.md) APIs.

```csharp
XamlDirect xd = XamlDirect.GetDefault();

IXamlDirectObject relativePanel = xd.CreateInstance(XamlTypeIndex.RelativePanel);

IXamlDirectObject childrenCollection = xd.GetXamlDirectObjectProperty(relativePanel, XamlPropertyIndex.Panel_Children);

IXamlDirectObject button = xd.CreateInstance(XamlTypeIndex.Button);
xd.InsertIntoCollectionAt(childrenCollection, 0, button);
```

```cppcx
XamlDirect^ xd = XamlDirect::GetDefault();

IXamlDirectObject^ relativePanel = xd->CreateInstance(XamlTypeIndex::RelativePanel);

IXamlDirectObject^ childrenCollection = xd->GetXamlDirectObjectProperty(relativePanel, XamlPropertyIndex::Panel_Children);

IXamlDirectObject^ button = xd->CreateInstance(XamlTypeIndex::Button);
xd->InsertIntoCollectionAt(childrenCollection, 0, button);
```
