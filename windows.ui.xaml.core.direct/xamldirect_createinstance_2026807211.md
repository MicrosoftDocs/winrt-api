---
-api-id: M:Windows.UI.Xaml.Core.Direct.XamlDirect.CreateInstance(Windows.UI.Xaml.Core.Direct.XamlTypeIndex)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public IXamlDirectObject XamlDirect.CreateInstance(XamlTypeIndex typeIndex)
-->

# Windows.UI.Xaml.Core.Direct.XamlDirect.CreateInstance

## -description
Creates an [IXamlDirectObject](ixamldirectobject.md) instance of the type specified by the [XamlTypeIndex](xamltypeindex.md) parameter.


## -parameters
### -param typeIndex
Refers to the specific XAML type from the set of supported types listed in the [XamlTypeIndex](xamltypeindex.md) enum.

## -returns
Returns the [IXamlDirectObject](ixamldirectobject.md) instance.

## -see-also
[XamlDirect](xamldirect.md), [XamlDirect.GetDefault](xamldirect_getdefault_846721868.md)

## -examples
The following example shows how to create an [IXamlDirectObject](ixamldirectobject.md) instance for a [Border](../windows.ui.xaml.controls/border.md) element. 

```csharp
XamlDirect xd = XamlDirect.GetDefault();
IXamlDirectObject border = xd.CreateInstance(XamlTypeIndex.Border);
```

```cppcx
XamlDirect^ xd = XamlDirect::GetDefault();
IXamlDirectObject^ border = xd->CreateInstance(XamlTypeIndex::Border);
```
