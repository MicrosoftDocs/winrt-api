---
-api-id: T:Windows.UI.Xaml.Controls.WebViewExecutionMode
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Xaml.Controls.WebViewExecutionMode : int
-->

# WebViewExecutionMode

## -description
Defines constants that specify whether [WebView](webview.md) hosts HTML content on the UI thread or on a non-UI thread.

## -enum-fields
### -field SameThread:0
Content is hosted on the UI thread.

### -field SeparateThread:1
Content is hosted on a background thread.


### -field SeparateProcess:2

Content is hosted on a separate process off the app process. All of an app's WebView instances share the same separate process, there is not a separate process per WebView instance.


## -remarks

## -examples

## -see-also
