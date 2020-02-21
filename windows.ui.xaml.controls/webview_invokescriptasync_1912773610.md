---
-api-id: M:Windows.UI.Xaml.Controls.WebView.InvokeScriptAsync(System.String,Windows.Foundation.Collections.IIterable{System.String})
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<string> WebView.InvokeScriptAsync(String scriptName, IIterable<String> arguments)
-->

# Windows.UI.Xaml.Controls.WebView.InvokeScriptAsync


## -description

Executes the specified script function from the currently loaded HTML, with specific arguments, as an asynchronous action.

## -parameters

### -param scriptName

The name of the script function to invoke.

### -param arguments

A string array that packages arguments to the script function.

## -returns

When this method returns, the string result of the script invocation.

## -remarks

To prevent malicious code from exploiting your app, be sure to call this method to invoke only scripts that you trust.

The invoked script can return only string values. 

Your app might appear unresponsive while scripts are running. Handle the [LongRunningScriptDetected](webview_longrunningscriptdetected.md) event to interrupt a long-running script.

## -see-also

## -examples

