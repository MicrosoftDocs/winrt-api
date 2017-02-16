---
-api-id: P:Windows.UI.Xaml.Controls.WebViewLongRunningScriptDetectedEventArgs.ExecutionTime
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.TimeSpan ExecutionTime { get; }
-->

# Windows.UI.Xaml.Controls.WebViewLongRunningScriptDetectedEventArgs.ExecutionTime

## -description
Gets the number of milliseconds that the [WebView](webview.md) control has been executing a long-running script.

## -property-value
The number of milliseconds the script has been running.

## -remarks
If the script is still running after 5 seconds, the app will hang. To halt the script, set the [StopPageScriptExecution](webviewlongrunningscriptdetectedeventargs_stoppagescriptexecution.md) property to **true**. The halted script will not resume for the lifetime of the [WebView](webview.md).

## -examples

## -see-also
[WebView](webview.md), [LongRunningScriptDetected](webview_longrunningscriptdetected.md)