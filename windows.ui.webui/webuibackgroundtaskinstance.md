---
-api-id: T:Windows.UI.WebUI.WebUIBackgroundTaskInstance
-api-type: winrt class
---

<!-- Class syntax.
public class WebUIBackgroundTaskInstance 
-->

# Windows.UI.WebUI.WebUIBackgroundTaskInstance

## -description

Represents an instance of a background task that has been triggered to run.

A background task must explicitly call the Web Workers [close](https://go.microsoft.com/fwlink/p/?linkid=237467) method to terminate itself after the task has completed.

## -remarks

> [!NOTE]
> : This class is not agile, which means that you need to consider its threading model and marshaling behavior. For more info, see [Threading and Marshaling (C++/CX)](https://go.microsoft.com/fwlink/p/?linkid=258275)
<!--[jjacks - removed this link (https://go.microsoft.com/fwlink/p/?linkid=258277 404->http://msdn.microsoft.com/library/windows/apps/jj157115.aspx) because it doesn't work] and Using Windows Runtime objects in a multithreaded environment (.NET)-->
.

## -examples

## -see-also

[Background task sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=618666), [Background activation sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/BackgroundActivation)
