---
-api-id: T:Windows.UI.Xaml.Markup.IXamlMetadataProvider
-api-type: winrt interface
---

<!-- Interface syntax.
public interface IXamlMetadataProvider : 
-->

# Windows.UI.Xaml.Markup.IXamlMetadataProvider

## -description
Implements XAML type resolution and provides the mapping between types used in markup and the corresponding classes implemented in an application or component.



## -remarks
The XAML compiler generates implementations of the interface within each component (application, library, or WinRT component) that uses XAML. In applications, the implementation is generated on the application object itself. For libraries and WinRT components, the implementation is generated on an anonymous class created by the XAML compiler. Each IXamlMetadataProvider implementation provides type information for the controls defined in the component it's generated in.

For more info on IXamlMetadataProvider, [IXamlType](ixamltype.md) and [IXamlMember](ixamlmember.md) and how these are used for XAML custom types, see "Remarks" section of [IXamlType](ixamltype.md).

## -examples

## -see-also
[IXamlType](ixamltype.md), [XAML overview](/windows/uwp/xaml-platform/xaml-overview)
