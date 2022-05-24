---
-api-id: M:Windows.UI.Xaml.Core.Direct.XamlDirect.RemoveFromCollectionAt(Windows.UI.Xaml.Core.Direct.IXamlDirectObject,System.UInt32)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public void XamlDirect.RemoveFromCollectionAt(IXamlDirectObject xamlDirectObject, UInt32 index)
-->

# Windows.UI.Xaml.Core.Direct.XamlDirect.RemoveFromCollectionAt

## -description
Tries to remove a value from the [IXamlDirectObject](ixamldirectobject.md) collection at the specified index.


## -parameters
### -param xamlDirectObject
Refers to the specific [IXamlDirectObject](ixamldirectobject.md) collection.

### -param index
Refers to the index in the collection where the value must be removed.

## -see-also

[XamlDirect.InsertIntoCollectionAt](xamldirect_insertintocollectionat_679802579.md), [XamlDirect.AddToCollection](xamldirect_addtocollection_1437837191.md), [XamlDirect.RemoveFromCollection](xamldirect_removefromcollection_1992847812.md), [XamlDirect.ClearCollection](xamldirect_clearcollection_1428253299.md)

## -examples
The following example shows how to remove a value from a specific index using [XamlDirect](xamldirect.md) APIs.

```csharp
XamlDirect xd = XamlDirect.GetDefault();

IXamlDirectObject relativePanel = xd.CreateInstance(XamlTypeIndex.RelativePanel);

IXamlDirectObject childrenCollection = xd.GetXamlDirectObjectProperty(relativePanel, XamlPropertyIndex.Panel_Children);

xd.RemoveFromCollectionAt(childrenCollection, 0);
```

```cppcx
XamlDirect^ xd = XamlDirect::GetDefault();

IXamlDirectObject^ relativePanel = xd->CreateInstance(XamlTypeIndex::RelativePanel);

IXamlDirectObject^ childrenCollection = xd->GetXamlDirectObjectProperty(relativePanel, XamlPropertyIndex::Panel_Children);

xd->RemoveFromCollectionAt(childrenCollection, 0);
```
