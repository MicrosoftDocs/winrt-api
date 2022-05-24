---
-api-id: T:Windows.UI.Xaml.Interop.TypeName
-api-type: winrt struct
---

<!-- Structure syntax.
public struct TypeName 
-->

# TypeName

## -description
Substitutes for **System.Type** such that type information reported by other APIs doesn't have a dependency on the common language runtime (CLR). This structure is used as a value by properties such as [UnderlyingType](../windows.ui.xaml.markup/ixamltype_underlyingtype.md) and [Type](../windows.ui.xaml.data/icustomproperty_type.md).

> **.NET**
> When programming with .NET, this type is hidden and you should use the [System.Type](/dotnet/api/system.type?view=dotnet-uwp-10.0&preserve-view=true) type. All Windows Runtime APIs that use a **TypeName** per the raw IDL signatures will instead use [System.Type](/dotnet/api/system.type?view=dotnet-uwp-10.0&preserve-view=true) values when you use the API with .NET code.

> **[C++/WinRT](/windows/uwp/cpp-and-winrt-apis/index)**
> You can use the **winrt::xaml_typename\<T\>()** helper function to create a **TypeName** object. See [winrt::xaml_typename function template](/uwp/cpp-ref-for-winrt/xaml-typename) for more details, and a code example.

## -struct-fields

### -field Name

The name of the type. Depending on the value of *Kind* (see below), *Name* can contain any of the following.

- If *Kind* is set to **TypeKind::Custom**, then the contents of *Name* is unspecified, and language-projection-dependent (in the case of C#, the value is a fully-qualified name).
- If *Kind* is set to **TypeKind::Metadata**, then *Name* contains the Windows Runtime class name, such as "Windows.UI.Xaml.Controls.Button".
- If *Kind* is set to **TypeKind::Primitive**, then *Name* contains a primitive name, such as "Int32".

### -field Kind

A [TypeKind](/uwp/api/windows.ui.xaml.interop.typekind) value containing basic guidance regarding the origin of the type.

## -remarks

### Projection and members of TypeName

If you are using Visual C++ component extensions (C++/CX), then **Name** and **Kind** are read-write properties, not fields. This definition of the structure is provided by platform.winmd, as part of the extension behavior.

If you are programming with C++ using the Windows Runtime Template Library (WRL), then **Name** and **Kind** are fields.

## -examples

## -see-also
[System.Type](/dotnet/api/system.type?view=dotnet-uwp-10.0&preserve-view=true), [IXamlType](../windows.ui.xaml.markup/ixamltype.md), [Type System (C++/CX)](/cpp/cppcx/type-system-c-cx)