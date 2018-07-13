---
-api-id: M:Windows.UI.Xaml.Core.Direct.XamlDirect.InsertIntoCollectionAt(Windows.UI.Xaml.Core.Direct.IXamlDirectObject,System.UInt32,Windows.UI.Xaml.Core.Direct.IXamlDirectObject)
-api-type: winrt method
---

<!-- Method syntax.
public void XamlDirect.InsertIntoCollectionAt(IXamlDirectObject xamlDirectObject, UInt32 index, IXamlDirectObject value)
-->

# Windows.UI.Xaml.Core.Direct.XamlDirect.InsertIntoCollectionAt

## -description
Inserts a value into the collection for the specified [IXamlDirectObject](ixamldirectobject.md) at the specified index.

## -parameters
### -param xamlDirectObject
Refers to the specific [IXamlDirectObject](ixamldirectobject.md)

### -param index
Refers to the index in the collection where the specified value must be inserted 

### -param value
Refers to the [IXamlDirectObject](ixamldirectobject.md) value to add to the collection

## -see-also
[XamlDirect.AddToCollection](xamldirect_addtocollection_1437837191.md)

## -examples
The following example shows how to insert a value into a collection at a specific index using [XamlDirect](xamldirect.md) APIs.

```C#
XamlDirect xd = XamlDirect.GetDefault();

IXamlDirectObject relativePanel = xd.CreateInstance(XamlTypeIndex.RelativePanel);

IXamlDirectObject childrenCollection = xd.GetXamlDirectObjectProperty(relativePanel, XamlPropertyIndex.Panel_Children);

IXamlDirectObject button = xd.CreateInstance(XamlTypeIndex.Button);
xd.InsertIntoCollectionAt(childrenCollection, 0, button);
```

```CPP
XamlDirect^ xd = XamlDirect::GetDefault();

IXamlDirectObject^ relativePanel = xd->CreateInstance(XamlTypeIndex::RelativePanel);

IXamlDirectObject^ childrenCollection = xd->GetXamlDirectObjectProperty(relativePanel, XamlPropertyIndex::Panel_Children);

IXamlDirectObject^ button = xd->CreateInstance(XamlTypeIndex::Button);
xd->InsertIntoCollectionAt(childrenCollection, 0, button);
```
