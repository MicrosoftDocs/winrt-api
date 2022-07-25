---
-api-id: M:Windows.UI.Xaml.Markup.IXamlMetadataProvider.GetXamlType(Windows.UI.Xaml.Interop.TypeName)
-api-type: winrt method
---

<!-- Method syntax
public Windows.UI.Xaml.Markup.IXamlType GetXamlType(Windows.UI.Xaml.Interop.TypeName type)
-->

# Windows.UI.Xaml.Markup.IXamlMetadataProvider.GetXamlType

## -description
Implements XAML schema context access to underlying type mapping, based on providing a helper value that describes a type.



## -parameters
### -param type
The type as represented by the relevant type system or interoperation support type.

## -returns
The schema context's implementation of the [IXamlType](ixamltype.md) concept.

## -remarks
> [!NOTE]
> 

If you are programming using a Microsoft .NET language (C# or Microsoft Visual Basic), the [TypeName](../windows.ui.xaml.interop/typename.md) type projects as [System.Type](/dotnet/api/system.type?view=dotnet-uwp-10.0&preserve-view=true).

For more info on [IXamlMetadataProvider](ixamlmetadataprovider.md), [IXamlType](ixamltype.md) and [IXamlMember](ixamlmember.md) and how these are used for XAML custom types, see "Remarks" section of [IXamlType](ixamltype.md).

## -examples

## -see-also
[GetXamlType(String)](ixamlmetadataprovider_getxamltype_366630699.md)
