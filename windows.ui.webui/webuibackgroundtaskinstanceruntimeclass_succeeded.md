---
-api-id: P:Windows.UI.WebUI.WebUIBackgroundTaskInstanceRuntimeClass.Succeeded
-api-type: winrt property
---

<!-- Property syntax
public bool Succeeded { get;  set; }
-->

# Windows.UI.WebUI.WebUIBackgroundTaskInstanceRuntimeClass.Succeeded

## -description
Gets or sets the success value for the background task. The success value is what is returned to the foreground instance of your app in the [completed](../windows.applicationmodel.background/backgroundtaskregistration_completed.md) event.

## -property-value
An app can set this property to **false** to indicate that the background task has failed. Otherwise this property is always **true.**

> [!NOTE]
> Once the background task sets this property and has therefore completed its work, the task must explicitly call the Web Workers [close](/previous-versions/windows/internet-explorer/ie-developer/dev-guides/hh673568(v=vs.85)) method to terminate itself.

## -remarks

## -examples

## -see-also
