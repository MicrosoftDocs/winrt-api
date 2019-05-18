---
-api-id: T:Windows.UI.Xaml.Markup.IComponentConnector2
-api-type: winrt interface
---

<!-- Interface syntax.
public interface IComponentConnector2 : 
-->

# Windows.UI.Xaml.Markup.IComponentConnector2

## -description
Provides infrastructure support for event wiring and build actions.

## -remarks
IComponentConnector2 is used by the XAML compiler in generated code files. For more info, see the Remarks for [IComponentConnector](icomponentconnector.md).

Apps compiled by the XAML compiler for Windows 10 implement IComponentConnector2. Apps will fall back to [IComponentConnector](icomponentconnector.md) for compatibility if necessary. 
<!--<xref targtype="interface_winrt" rid="w_ui_xaml_mark.icomponentconnector2">IComponentConnector2</xref> includes the <xref targtype="method_winrt" rid="w_ui_xaml_mark.icomponentconnector2_getbindingconnector">GetBindingConnector</xref> method, and an additional parameter on the <xref targtype="method_winrt" rid="w_ui_xaml_mark.icomponentconnector2_connect">Connect</xref>method. These additions support compiled bindings and deferred loading of templates.-->

## -examples

## -see-also
[IComponentConnector](icomponentconnector.md)
