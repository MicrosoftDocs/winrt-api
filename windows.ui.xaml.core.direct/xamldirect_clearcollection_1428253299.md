---
-api-id: M:Windows.UI.Xaml.Core.Direct.XamlDirect.ClearCollection(Windows.UI.Xaml.Core.Direct.IXamlDirectObject)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public void XamlDirect.ClearCollection(IXamlDirectObject xamlDirectObject)
-->

# Windows.UI.Xaml.Core.Direct.XamlDirect.ClearCollection

## -description
Removes all items from the specified [IXamlDirectObject](ixamldirectobject.md) collection.


## -parameters
### -param xamlDirectObject
Refers to the specific [IXamlDirectObject](ixamldirectobject.md) collection.

## -see-also

[XamlDirect.AddToCollection](xamldirect_addtocollection_1437837191.md), [XamlDirect.RemoveFromCollection](xamldirect_removefromcollection_1992847812.md)

## -examples
The following example shows how to add to use the ClearCollection method to clear a collection pointed to by the specified [IXamlDirectObject](ixamldirectobject.md).

```csharp
XamlDirect xd = XamlDirect.GetDefault();

IXamlDirectObject relativePanel = xd.CreateInstance(XamlTypeIndex.RelativePanel);

IXamlDirectObject childrenCollection = xd.GetXamlDirectObjectProperty(relativePanel, XamlPropertyIndex.Panel_Children);

IXamlDirectObject button = xd.CreateInstance(XamlTypeIndex.Button);
xd.AddToCollection(childrenCollection, button);

xd.ClearCollection(childrenCollection);
```

```cppcx
XamlDirect^ xd = XamlDirect::GetDefault();

IXamlDirectObject^ relativePanel = xd->CreateInstance(XamlTypeIndex::RelativePanel);

IXamlDirectObject^ childrenCollection = xd->GetXamlDirectObjectProperty(relativePanel, XamlPropertyIndex::Panel_Children);

IXamlDirectObject^ button = xd->CreateInstance(XamlTypeIndex::Button);
xd->AddToCollection(childrenCollection, button);

xd->ClearCollection(childrenCollection);
```
