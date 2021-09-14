---
-api-id: M:Windows.UI.Xaml.Core.Direct.XamlDirect.RemoveFromCollection(Windows.UI.Xaml.Core.Direct.IXamlDirectObject,Windows.UI.Xaml.Core.Direct.IXamlDirectObject)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public bool XamlDirect.RemoveFromCollection(IXamlDirectObject xamlDirectObject, IXamlDirectObject value)
-->

# Windows.UI.Xaml.Core.Direct.XamlDirect.RemoveFromCollection

## -description
Tries to remove a value from the specified [IXamlDirectObject](ixamldirectobject.md) collection.


## -parameters
### -param xamlDirectObject
Refers to the specific [IXamlDirectObject](ixamldirectobject.md) collection.

### -param value
Refers to the [IXamlDirectObject](ixamldirectobject.md) value to remove from the collection.

## -returns
**true** if value was present.
**false** if value was not present.

## -see-also

[XamlDirect.AddToCollection](xamldirect_addtocollection_1437837191.md), [XamlDirect.InsertIntoCollectionAt](xamldirect_insertintocollectionat_679802579.md), [XamlDirect.RemoveFromCollectionAt](xamldirect_removefromcollectionat_1250477505.md), [XamlDirect.ClearCollection](xamldirect_clearcollection_1428253299.md)

## -examples
The following example shows how to remove a value from a collection using [XamlDirect](xamldirect.md) APIs.

```csharp
XamlDirect xd = XamlDirect.GetDefault();

IXamlDirectObject relativePanel = xd.CreateInstance(XamlTypeIndex.RelativePanel);

IXamlDirectObject childrenCollection = xd.GetXamlDirectObjectProperty(relativePanel, XamlPropertyIndex.Panel_Children);

IXamlDirectObject button = xd.CreateInstance(XamlTypeIndex.Button);
xd.AddToCollection(childrenCollection, button);

xd.RemoveFromCollection(childrenCollection, button); // Should return true
xd.RemoveFromCollection(childrenCollection, button); // Should return false
```

```cppcx
XamlDirect^ xd = XamlDirect::GetDefault();

IXamlDirectObject^ relativePanel = xd->CreateInstance(XamlTypeIndex::RelativePanel);

IXamlDirectObject^ childrenCollection = xd->GetXamlDirectObjectProperty(relativePanel, XamlPropertyIndex::Panel_Children);

IXamlDirectObject^ button = xd->CreateInstance(XamlTypeIndex::Button);
xd->AddToCollection(childrenCollection, button);

xd->RemoveFromCollection(childrenCollection, button); // Should return true
xd->RemoveFromCollection(childrenCollection, button); // Should return false
```

