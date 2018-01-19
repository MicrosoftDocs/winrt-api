---
-api-id: P:Windows.Web.UI.WebViewControlLongRunningScriptDetectedEventArgs.StopPageScriptExecution
-api-type: winrt property
---

<!-- Property syntax.
public bool StopPageScriptExecution { get;  set; }
-->

# Windows.Web.UI.WebViewControlLongRunningScriptDetectedEventArgs.StopPageScriptExecution

## -description
Halts a long-running script executing in a [IWebViewControl](iwebviewcontrol.md).

## -property-value
**true** to halt the script; otherwise, **false**.

## -remarks
The halted script will not resume for the lifetime of the [IWebViewControl](iwebviewcontrol.md) unless it is reloaded during a subsequent [IWebViewControl](iwebviewcontrol.md) navigation. If the script is still running after 5 seconds, the app will hang. To determine how long the script has been running, check the [ExecutionTime](webviewcontrollongrunningscriptdetectedeventargs_executiontime.md) property.

## -see-also

## -examples

