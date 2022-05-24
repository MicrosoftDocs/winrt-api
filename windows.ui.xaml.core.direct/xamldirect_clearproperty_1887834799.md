---
-api-id: M:Windows.UI.Xaml.Core.Direct.XamlDirect.ClearProperty(Windows.UI.Xaml.Core.Direct.IXamlDirectObject,Windows.UI.Xaml.Core.Direct.XamlPropertyIndex)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public void XamlDirect.ClearProperty(IXamlDirectObject xamlDirectObject, XamlPropertyIndex propertyIndex)
-->

# Windows.UI.Xaml.Core.Direct.XamlDirect.ClearProperty

## -description
Clears the value of the specified property on a given [IXamlDirectObject](ixamldirectobject.md).


## -parameters
### -param xamlDirectObject
A reference to the specific [IXamlDirectObject](ixamldirectobject.md).

### -param propertyIndex
A reference to the property to be cleared from the list of supported properties in [XamlPropertyIndex](xamlpropertyindex.md) enum.

## -examples
The following example shows how to clear the value of a [Border](../windows.ui.xaml.controls/border.md) element's [MinHeight](../windows.ui.xaml/frameworkelement_minheight.md) property through [XamlDirect](xamldirect.md) APIs.

```csharp
XamlDirect xd = XamlDirect.GetDefault();
IXamlDirectObject border = xd.CreateInstance(XamlTypeIndex.Border);
xd.ClearProperty(border, XamlPropertyIndex.FrameworkElement_MinHeight);
```

```cppcx
XamlDirect^ xd = XamlDirect::GetDefault();
IXamlDirectObject^ border = xd->CreateInstance(XamlTypeIndex::Border);
xd->ClearProperty(border, XamlPropertyIndex::FrameworkElement_MinHeight);
```

