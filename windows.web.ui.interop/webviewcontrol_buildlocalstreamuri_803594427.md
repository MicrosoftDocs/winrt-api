---
-api-id: M:Windows.Web.UI.Interop.WebViewControl.BuildLocalStreamUri(System.String,System.String)
-api-type: winrt method
---

<!-- Method syntax.
public Uri WebViewControl.BuildLocalStreamUri(String contentIdentifier, String relativePath)
-->

# Windows.Web.UI.Interop.WebViewControl.BuildLocalStreamUri

## -description

Creates a URI that you can pass to [NavigateToLocalStreamUri](../windows.web.ui/iwebviewcontrol_navigatetolocalstreamuri_1538250901.md)

For more info, see [Windows.Web.UI.IWebViewControl](../windows.web.ui/iwebviewcontrol.md)

## -parameters

### -param contentIdentifier

A unique identifier for the content the URI is referencing. This defines the root of the URI.

### -param relativePath

The path to the resource, relative to the root.

## -returns

The URI created by combining and normalizing the contentIdentifier and relativePath.

## -remarks

## -see-also

## -examples

