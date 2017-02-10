---
-api-id: E:Windows.UI.Xaml.Controls.WebView.LongRunningScriptDetected
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler LongRunningScriptDetected<Windows.UI.Xaml.Controls.WebView,  Windows.UI.Xaml.Controls.WebViewLongRunningScriptDetectedEventArgs>
-->

# Windows.UI.Xaml.Controls.WebView.LongRunningScriptDetected

## -description
Occurs periodically while the [WebView](webview.md) executes JavaScript, letting you halt the script.

## -xaml-syntax
```xaml
<WebView LongRunningScriptDetected="eventhandler"/>

```


## -remarks
Your app might appear unresponsive while scripts are running. This event provides an opportunity to interrupt a long-running script. To determine how long the script has been running, check the [ExecutionTime](webviewlongrunningscriptdetectedeventargs_executiontime.md) property of the [WebViewLongRunningScriptDetectedEventArgs](webviewlongrunningscriptdetectedeventargs.md) object. To halt the script, set the event args [StopPageScriptExecution](webviewlongrunningscriptdetectedeventargs_stoppagescriptexecution.md) property to **true**. The halted script will not execute again unless it is reloaded during a subsequent [WebView](webview.md) navigation.



> [!NOTE]
> In some cases, the [WebView](webview.md) cannot detect a long-running script. For example, this event might not occur if the script is stuck in a loop that doesn’t perform any memory allocations.

## -examples

## -see-also
[WebViewLongRunningScriptDetectedEventArgs](webviewlongrunningscriptdetectedeventargs.md), [WebViewLongRunningScriptDetectedEventArgs.ExecutionTime](webviewlongrunningscriptdetectedeventargs_executiontime.md), [WebViewLongRunningScriptDetectedEventArgs.StopPageScriptExecution](webviewlongrunningscriptdetectedeventargs_stoppagescriptexecution.md)