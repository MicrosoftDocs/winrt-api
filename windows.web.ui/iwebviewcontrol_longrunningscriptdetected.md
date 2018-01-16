---
-api-id: E:Windows.Web.UI.IWebViewControl.LongRunningScriptDetected
-api-type: winrt event
---

<!-- Event syntax.
abstract public event TypedEventHandler LongRunningScriptDetected<IWebViewControl, WebViewControlLongRunningScriptDetectedEventArgs>
-->

# Windows.Web.UI.IWebViewControl.LongRunningScriptDetected

## -description
Occurs periodically while the IWebViewControl executes JavaScript, letting you halt the script.

## -remarks
Your app might appear unresponsive while scripts are running. This event provides an opportunity to interrupt a long-running script. To determine how long the script has been running, check the [ExecutionTime](webviewcontrollongrunningscriptdetectedeventargs_executiontime.md) property of the [WebViewLongRunningScriptDetectedEventArgs](webviewcontrollongrunningscriptdetectedeventargs.md) object. To halt the script, set the event args [StopPageScriptExecution](webviewcontrollongrunningscriptdetectedeventargs_stoppagescriptexecution.md) property to true. The halted script will not execute again unless it is reloaded during a subsequent IWebViewControl navigation.

> [!NOTE]
> In some cases, the IWebVieControl cannot detect a long-running script. For example, this event might not occur if the script is stuck in a loop that doesn’t perform any memory allocations.

## -see-also

## -examples

