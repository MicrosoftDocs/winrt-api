---
-api-id: M:Windows.UI.Xaml.Core.Direct.XamlDirect.GetXamlDirectObjectFromCollectionAt(Windows.UI.Xaml.Core.Direct.IXamlDirectObject,System.UInt32)
-api-type: winrt method
---

<!-- Method syntax.
public IXamlDirectObject XamlDirect.GetXamlDirectObjectFromCollectionAt(IXamlDirectObject xamlDirectObject, UInt32 index)
-->

# Windows.UI.Xaml.Core.Direct.XamlDirect.GetXamlDirectObjectFromCollectionAt

## -description
Returns the [IXamlDirectObject](ixamldirectobject.md) item at the specified index from the collection for the specified [IXamlDirectObject](ixamldirectobject.md).

## -parameters
### -param xamlDirectObject
Refers to the specific [IXamlDirectObject](ixamldirectobject.md)

### -param index
Refers to the index in the collection where the specified item must be accessed

## -returns
Returns the [IXamlDirectObject](ixamldirectobject.md) item at the specified index of the collection

## -examples
The following example shows how to access an [IXamlDirectObject](ixamldirectobject.md) item at the specified index of a collection.

```C#
XamlDirect xd = XamlDirect.GetDefault();

IXamlDirectObject relativePanel = xd.CreateInstance(XamlTypeIndex.RelativePanel);

IXamlDirectObject childrenCollection = xd.GetXamlDirectObjectProperty(relativePanel, XamlPropertyIndex.Panel_Children);

IXamlDirectObject first = xd.GetXamlDirectObjectFromCollectionAt(childrenCollection, 0);
```

```CPP
XamlDirect^ xd = XamlDirect::GetDefault();

IXamlDirectObject^ relativePanel = xd->CreateInstance(XamlTypeIndex::RelativePanel);

IXamlDirectObject^ childrenCollection = xd->GetXamlDirectObjectProperty(relativePanel, XamlPropertyIndex::Panel_Children);

IXamlDirectObject^ first = xd->GetXamlDirectObjectFromCollectionAt(childrenCollection, 0);
```