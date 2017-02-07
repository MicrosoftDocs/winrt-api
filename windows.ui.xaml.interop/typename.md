---
-api-id: T:Windows.UI.Xaml.Interop.TypeName
-api-type: winrt struct
---

<!-- Structure syntax.
public struct TypeName 
-->

# TypeName

## -description
Substitutes for **System.Type** such that type information reported by other API does not have a dependency on the common language runtime (CLR). This structure is used as a value by properties such as [UnderlyingType](../windows.ui.xaml.markup/ixamltype_underlyingtype.md) and [Type](../windows.ui.xaml.data/icustomproperty_type.md).



> **.NET**
> This type appears as [System.Type](https://msdn.microsoft.com/library/system.type.aspx).

## -struct-fields

### -field Name
Name of the type.
    

### -field Kind
Basic guidance regarding the origin of the type.
    

## -remarks
When programming with .NET, this type is hidden and developers should use the [System.Type](https://msdn.microsoft.com/library/system.type.aspx) type. All Windows Runtime APIs that use a [TypeName](typename.md) per the raw IDL signatures will instead use [System.Type](https://msdn.microsoft.com/library/system.type.aspx) values when you use the API with .NET code.

### Projection and members of TypeName

If you are using Visual C++ component extensions (C++/CX), then [Name](typename_name.md) and [Kind](typename_kind.md) are read-write properties, not fields. This definition of the structure is provided by platform.winmd, as part of the extension behavior.

If you are programming with C++ using the Windows Runtime Template Library (WRL), then **Name** and **Kind** are fields.

## -examples

## -see-also
[System.Type](https://msdn.microsoft.com/library/system.type.aspx), [IXamlType](../windows.ui.xaml.markup/ixamltype.md), [Type System (C++/CX)](XREF:TODO:b67bee8a-b526-4872-969e-ef22724e88fe)