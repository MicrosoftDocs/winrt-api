---
-api-id: M:Windows.Web.UI.IWebViewControl.InvokeScriptAsync(System.String,Windows.Foundation.Collections.IIterable{System.String})
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<string> IWebViewControl.InvokeScriptAsync(String scriptName, IIterable<String> arguments)
-->

# Windows.Web.UI.IWebViewControl.InvokeScriptAsync

## -description
Executes the specified script function from the currently loaded HTML, with specific arguments, as an asynchronous action.

## -parameters
### -param scriptName
The name of the script function to invoke.

### -param arguments
A string array that packages arguments to the script function.

## -returns
An asynchronous operation object from which, on successful completion, you can retrieve the string result of the script invocation.

## -remarks
o prevent malicious code from exploiting your app, be sure to call this method to invoke only scripts that you trust.

The invoked script can return only string values.

Your app might appear unresponsive while scripts are running. Handle the [LongRunningScriptDetected](iwebviewcontrol_longrunningscriptdetected.md) event to interrupt a long-running script.

## -see-also

## -examples

