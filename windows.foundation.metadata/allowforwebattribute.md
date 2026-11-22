---
-api-id: T:Windows.Foundation.Metadata.AllowForWebAttribute
-api-type: winrt class
---

<!-- Class syntax.
public class AllowForWebAttribute : System.Attribute
-->

# Windows.Foundation.Metadata.AllowForWebAttribute

## -description
Enables developers to expose a native Windows Runtime object as a global parameter in the context of the top-level document inside of a [WebView](../windows.ui.xaml.controls/webview.md). For a Windows Runtime object to be projected, it must implement [IAgileObject](/windows/desktop/api/objidl/nn-objidl-iagileobject) and be decorated with the AllowForWebAttribute attribute.

## -remarks

In MIDL 3.0, this attribute is written as `[allowforweb]`. For details, see [Predefined attributes (MIDL 3.0)](https://learn.microsoft.com/uwp/midl-3/predefined-attributes#the-allowforweb-attribute).

## -examples

## -see-also
[Attribute](/dotnet/api/system.attribute?view=dotnet-uwp-10.0&preserve-view=true)
