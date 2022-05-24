---
-api-id: M:Windows.UI.Xaml.Core.Direct.XamlDirect.GetXamlDirectObjectFromCollectionAt(Windows.UI.Xaml.Core.Direct.IXamlDirectObject,System.UInt32)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public IXamlDirectObject XamlDirect.GetXamlDirectObjectFromCollectionAt(IXamlDirectObject xamlDirectObject, UInt32 index)
-->

# Windows.UI.Xaml.Core.Direct.XamlDirect.GetXamlDirectObjectFromCollectionAt

## -description
Returns the [IXamlDirectObject](ixamldirectobject.md) item at the specified index from the specified [IXamlDirectObject](ixamldirectobject.md) collection.


## -parameters
### -param xamlDirectObject
Refers to the specific [IXamlDirectObject](ixamldirectobject.md) collection.

### -param index
Refers to the index in the collection of the item to get.

## -returns
Returns the [IXamlDirectObject](ixamldirectobject.md) item at the specified index of the collection.

## -examples
The following example shows how to access an [IXamlDirectObject](ixamldirectobject.md) item at the specified index of a collection.

```csharp
XamlDirect xd = XamlDirect.GetDefault();

IXamlDirectObject relativePanel = xd.CreateInstance(XamlTypeIndex.RelativePanel);

IXamlDirectObject childrenCollection = xd.GetXamlDirectObjectProperty(relativePanel, XamlPropertyIndex.Panel_Children);

IXamlDirectObject first = xd.GetXamlDirectObjectFromCollectionAt(childrenCollection, 0);
```

```cppcx
XamlDirect^ xd = XamlDirect::GetDefault();

IXamlDirectObject^ relativePanel = xd->CreateInstance(XamlTypeIndex::RelativePanel);

IXamlDirectObject^ childrenCollection = xd->GetXamlDirectObjectProperty(relativePanel, XamlPropertyIndex::Panel_Children);

IXamlDirectObject^ first = xd->GetXamlDirectObjectFromCollectionAt(childrenCollection, 0);
```
