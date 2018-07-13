---
-api-id: M:Windows.UI.Xaml.Core.Direct.XamlDirect.AddToCollection(Windows.UI.Xaml.Core.Direct.IXamlDirectObject,Windows.UI.Xaml.Core.Direct.IXamlDirectObject)
-api-type: winrt method
---

<!-- Method syntax.
public void XamlDirect.AddToCollection(IXamlDirectObject xamlDirectObject, IXamlDirectObject value)
-->

# Windows.UI.Xaml.Core.Direct.XamlDirect.AddToCollection

## -description
Adds a value to the collection for the specified [IXamlDirectObject](ixamldirectobject.md)

## -parameters
### -param xamlDirectObject
Refers to the specific [IXamlDirectObject](ixamldirectobject.md)

### -param value
Refers to the [IXamlDirectObject](ixamldirectobject.md) value to add to the collection

## -remarks
[IXamlDirectObject](ixamldirectobject.md) is the minimal handle to Xaml's internal object instances. Hence, the base object, the collection and the value to add to the collection are all of type [IXamlDirectObject](ixamldirectobject.md)

## -examples
The following example shows how to add a value to a collection using [XamlDirect](xamldirect.md) APIs.

```C#
XamlDirect xd = XamlDirect.GetDefault();

IXamlDirectObject relativePanel = xd.CreateInstance(XamlTypeIndex.RelativePanel);

IXamlDirectObject childrenCollection = xd.GetXamlDirectObjectProperty(relativePanel, XamlPropertyIndex.Panel_Children);

IXamlDirectObject button = xd.CreateInstance(XamlTypeIndex.Button);
xd.AddToCollection(childrenCollection, button);
```

```CPP
XamlDirect^ xd = XamlDirect::GetDefault();

IXamlDirectObject^ relativePanel = xd->CreateInstance(XamlTypeIndex::RelativePanel);

IXamlDirectObject^ childrenCollection = xd->GetXamlDirectObjectProperty(relativePanel, XamlPropertyIndex::Panel_Children);

IXamlDirectObject^ button = xd->CreateInstance(XamlTypeIndex::Button);
xd->AddToCollection(childrenCollection, button);
```