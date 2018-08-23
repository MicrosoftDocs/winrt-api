---
-api-id: M:Windows.UI.Xaml.Controls.WebView.InvokeScript(System.String,System.String[])
-api-type: winrt method
---

<!-- Method syntax
public string InvokeScript(System.String scriptName, System.String[] arguments)
-->

# Windows.UI.Xaml.Controls.WebView.InvokeScript

## -description
> [!NOTE]
> [InvokeScript](webview_invokescript_1786819783.md) may be altered or unavailable for releases after Windows 8.1. Instead, use [InvokeScriptAsync](webview_invokescriptasync_1912773610.md).

Executes the specified script function from the currently loaded HTML, with specific arguments.

## -parameters
### -param scriptName
The name of the script function to invoke.

### -param arguments
A string array that packages arguments to the script function.

## -returns
The result of the script invocation.

## -remarks
The invoked script can return only string values.

## -examples

## -see-also
[InvokeScriptAsync](webview_invokescriptasync_1912773610.md)