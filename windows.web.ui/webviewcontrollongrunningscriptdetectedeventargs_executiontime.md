---
-api-id: P:Windows.Web.UI.WebViewControlLongRunningScriptDetectedEventArgs.ExecutionTime
-api-type: winrt property
---

<!-- Property syntax.
public TimeSpan ExecutionTime { get; }
-->

# Windows.Web.UI.WebViewControlLongRunningScriptDetectedEventArgs.ExecutionTime

## -description
Gets the number of milliseconds that the [IWebViewControl](iwebviewcontrol.md) has been executing a long-running script.

## -property-value
The number of milliseconds the script has been running.

## -remarks
If the script is still running after 5 seconds, the app will hang. To halt the script, set the [StopPageScriptExecution](webviewcontrollongrunningscriptdetectedeventargs_stoppagescriptexecution.md) property to true. The halted script will not resume for the lifetime of the [IWebViewControl](iwebviewcontrol.md) unless it is reloaded during a subsequent [IWebViewControl](iwebviewcontrol.md) navigation.

## -see-also

## -examples

