---
-api-id: T:Windows.UI.WebUI.WebUIBackgroundTaskInstanceRuntimeClass
-api-type: winrt class
---

<!-- Class syntax.
public class WebUIBackgroundTaskInstanceRuntimeClass : Windows.ApplicationModel.Background.IBackgroundTaskInstance, Windows.UI.WebUI.IWebUIBackgroundTaskInstance
-->

# Windows.UI.WebUI.WebUIBackgroundTaskInstanceRuntimeClass

## -description
Provides access to an instance of a background task.

> [!NOTE]
> A background task must explicitly call the Web Workers [close](/previous-versions/windows/internet-explorer/ie-developer/dev-guides/hh673568(v=vs.85)) method to terminate itself after the task has completed.

## -remarks
To retrieve this object, use the [WebUIBackgroundTaskInstance.current](webuibackgroundtaskinstance_current.md) property.

<!-- confirmed -->
> [!NOTE]
> This class is not agile, which means that you need to consider its threading model and marshaling behavior. For more info, see [Threading and Marshaling (C++/CX)](/cpp/cppcx/threading-and-marshaling-c-cx).

## -examples

## -see-also
