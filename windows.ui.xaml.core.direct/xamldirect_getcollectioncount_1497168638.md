---
-api-id: M:Windows.UI.Xaml.Core.Direct.XamlDirect.GetCollectionCount(Windows.UI.Xaml.Core.Direct.IXamlDirectObject)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public uint XamlDirect.GetCollectionCount(IXamlDirectObject xamlDirectObject)
-->

# Windows.UI.Xaml.Core.Direct.XamlDirect.GetCollectionCount

## -description
Returns the count of items in the specified [IXamlDirectObject](ixamldirectobject.md) collection.


## -parameters
### -param xamlDirectObject
Refers to the specific [IXamlDirectObject](ixamldirectobject.md) collection.

## -returns
Count of items.

## -examples
The following example shows how to get the count of [Panel.Children](../windows.ui.xaml.controls/panel_children.md) through the [IXamlDirectObject](ixamldirectobject.md)'s instance.

```csharp
XamlDirect xd = XamlDirect.GetDefault();

IXamlDirectObject relativePanel = xd.CreateInstance(XamlTypeIndex.RelativePanel);

IXamlDirectObject childrenCollection = xd.GetXamlDirectObjectProperty(relativePanel, XamlPropertyIndex.Panel_Children);

uint count = xd.GetCollectionCount(childrenCollection);
```

```cppcx
XamlDirect^ xd = XamlDirect::GetDefault();

IXamlDirectObject^ relativePanel = xd->CreateInstance(XamlTypeIndex::RelativePanel);

IXamlDirectObject^ childrenCollection = xd->GetXamlDirectObjectProperty(relativePanel, XamlPropertyIndex::Panel_Children);

UINT count = xd->GetCollectionCount(childrenCollection);
```
