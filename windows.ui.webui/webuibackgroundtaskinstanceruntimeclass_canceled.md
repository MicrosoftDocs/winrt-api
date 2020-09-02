---
-api-id: E:Windows.UI.WebUI.WebUIBackgroundTaskInstanceRuntimeClass.Canceled
-api-type: winrt event
---

<!-- Event syntax
public event Windows.ApplicationModel.Background.BackgroundTaskCanceledEventHandler Canceled
-->

# Windows.UI.WebUI.WebUIBackgroundTaskInstanceRuntimeClass.Canceled

## -description
Attaches a cancellation event handler to the background task instance.

## -remarks
In most cases, JavaScript background tasks continue to run until the Web Workers [close](/previous-versions/windows/internet-explorer/ie-developer/dev-guides/hh673568(v=vs.85)) method is called. The system shuts down a background task only when all apps are being closed, for example user log off or system shut down. In that case, Windows fires the canceled event, enabling the background task to complete any final activity before it is closed.

## -examples

## -see-also
