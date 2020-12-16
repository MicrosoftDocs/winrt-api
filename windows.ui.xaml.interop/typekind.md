---
-api-id: T:Windows.UI.Xaml.Interop.TypeKind
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Xaml.Interop.TypeKind : int
-->

# TypeKind

## -description
Provides basic guidance about the origin of a type. Used as a value by [TypeName](typename.md).

## -enum-fields
### -field Primitive:0
The type is a language-level primitive.

### -field Metadata:1
The type is declared through WinMD (Windows Runtime metadata).

### -field Custom:2
The type is a custom type declared by means other than WinMD.


## -remarks
This enumeration is not relevant to type system information as reported to .NET code. Any value that reports type information from a Windows Runtime  API being called by C# or Microsoft Visual Basic code is projected to [System.Type](/dotnet/api/system.type?view=dotnet-uwp-10.0&preserve-view=true).

## -examples

## -see-also
[System.Type](/dotnet/api/system.type?view=dotnet-uwp-10.0&preserve-view=true), [Type system (C++/CX)](/cpp/cppcx/type-system-c-cx)