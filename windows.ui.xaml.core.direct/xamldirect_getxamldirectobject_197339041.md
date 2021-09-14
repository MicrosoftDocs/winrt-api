---
-api-id: M:Windows.UI.Xaml.Core.Direct.XamlDirect.GetXamlDirectObject(System.Object)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public IXamlDirectObject XamlDirect.GetXamlDirectObject(Object object)
-->

# Windows.UI.Xaml.Core.Direct.XamlDirect.GetXamlDirectObject

## -description
Gets the instance as an [IXamlDirectObject](ixamldirectobject.md) for a given XAML type. 


## -parameters
### -param object
Refers to the specific XAML type (typically, but not always, a [DependencyObject](../windows.ui.xaml/dependencyobject.md)).

## -returns
Returns the [IXamlDirectObject](ixamldirectobject.md) instance.

## -remarks
Use this method to convert from a full XAML type to its [XamlDirect](xamldirect.md) instance and then get the performance benefits of [XamlDirect](xamldirect.md) through property management, collection management and event handling functionalities exposed through the [XamlDirect](xamldirect.md) APIs.

## -see-also
[XamlDirect.GetObject](xamldirect_getobject_1023047843.md)

## -examples
The following example shows how to get the [IXamlDirectObject](ixamldirectobject.md) instance from a full XAML type.

```csharp
XamlDirect xd = XamlDirect.GetDefault();

Border border = new Border();
IXamlDirectObject borderXDO = xd.GetXamlDirectObject(border);
```

```cppcx
XamlDirect^ xd = XamlDirect::GetDefault();

Border^ border = ref new Border();
IXamlDirectObject^ borderXDO = xd->GetXamlDirectObject(border);
```

