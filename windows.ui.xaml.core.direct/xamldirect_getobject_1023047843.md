---
-api-id: M:Windows.UI.Xaml.Core.Direct.XamlDirect.GetObject(Windows.UI.Xaml.Core.Direct.IXamlDirectObject)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public object XamlDirect.GetObject(IXamlDirectObject xamlDirectObject)
-->

# Windows.UI.Xaml.Core.Direct.XamlDirect.GetObject

## -description
Gets (and creates if necessary) the instance as its full XAML type of the specified [IXamlDirectObject](ixamldirectobject.md). 


## -parameters
### -param xamlDirectObject
Refers to the specific [IXamlDirectObject](ixamldirectobject.md).

## -returns
Returns the instance of the full XAML type (typically, but not always, a [DependencyObject](../windows.ui.xaml/dependencyobject.md)).

## -remarks
Use this method to convert from a [XamlDirect](xamldirect.md) instance to its full XAML type. This results in the creation of a full object and hence the performance benefits of staying within the [XamlDirect](xamldirect.md) APIs will be lost for that specific [IXamlDirectObject](ixamldirectobject.md) instance.

## -see-also
[XamlDirect.GetXamlDirectObject](xamldirect_getxamldirectobject_197339041.md)

## -examples
The following example shows how to convert an [IXamlDirectObject](ixamldirectobject.md) instance pointing to a [Border](../windows.ui.xaml.controls/border.md) element to its full XAML type.

```csharp
XamlDirect xd = XamlDirect.GetDefault();

IXamlDirectObject border = xd.CreateInstance(XamlTypeIndex.Border);
Border borderDO = (Border)xd.GetObject(border);
```

```cppcx
XamlDirect^ xd = XamlDirect::GetDefault();

IXamlDirectObject^ border = xd->CreateInstance(XamlTypeIndex::Border);
Border^ borderDO = dynamic_cast<Border^>(xd->GetObject(border));
```

