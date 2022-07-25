---
-api-id: T:Windows.UI.Xaml.Markup.IXamlType
-api-type: winrt interface
---

<!-- Interface syntax.
public interface IXamlType : 
-->

# Windows.UI.Xaml.Markup.IXamlType

## -description
Provides the means to report XAML-type system specifics about XAML types. Using this interface contract, XAML parsers can load any custom types and members thereof that are defined in your app and are referenced in XAML files.



## -remarks
The Windows Runtime is a native Component Object Model (COM) based API. You can use several languages to write the app code, including Microsoft .NET languages and native C++. The Windows Runtime does not include reflection or a CLR-style type system. In absence of such a type system, the XAML framework for the Windows Runtime needs infrastructure and contracts to recognize and load any custom types that are defined in your app and are referenced in XAML files. The [IXamlMember](ixamlmember.md) and IXamlType interfaces are the contract. The infrastructure is partially visible as a generated code file XamlTypeInfo.* (remainder of file name varying depending on which language you use). This file contains a partial class that extends the [Application](../windows.ui.xaml/application.md) class and implements the [IXamlMetadataProvider](ixamlmetadataprovider.md) interface. The Windows Runtime XAML framework uses this interface to query for the details of types referenced in XAML files. Other generated files also use [IXamlMetadataProvider](ixamlmetadataprovider.md) for discovery.

> [!NOTE]
> XamlTypeInfo.* can be found in the obj folder along with other generated files . You may need to enable **Show all files** to see it. Also, if you want to step into the type definition code, disable the **Just my code** feature in the debugger options.

## -examples

## -see-also
[IXamlMetadataProvider](ixamlmetadataprovider.md), [IXamlMember](ixamlmember.md), [XAML overview](/windows/uwp/xaml-platform/xaml-overview)
