---
-api-id: P:Windows.UI.Xaml.Controls.WebViewLongRunningScriptDetectedEventArgs.StopPageScriptExecution
-api-type: winrt property
---

<!-- Property syntax
public bool StopPageScriptExecution { get;  set; }
-->

# Windows.UI.Xaml.Controls.WebViewLongRunningScriptDetectedEventArgs.StopPageScriptExecution

## -description
Halts a long-running script executing in a [WebView](webview.md) control.

## -property-value
**true** to halt the script; otherwise, **false**.

## -remarks
The halted script will not resume for the lifetime of the [WebView](webview.md). If the script is still running after 5 seconds, the app will hang. To determine how long the script has been running, check the [ExecutionTime](webviewlongrunningscriptdetectedeventargs_executiontime.md) property.

## -examples

## -see-also
[WebView](webview.md), [LongRunningScriptDetected](webview_longrunningscriptdetected.md)