---
-api-id: T:Windows.UI.WebUI.SuspendingEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class SuspendingEventArgs : Windows.ApplicationModel.ISuspendingEventArgs
-->

# Windows.UI.WebUI.SuspendingEventArgs

## -description
Provides data for an app suspension event.

## -remarks
This object is accessed when you implement [WebUIApplication.SuspendingEventHandler](suspendingeventhandler.md) to respond to [WebUIApplication.suspending](webuiapplication_suspending.md) events.



> [!NOTE]
> : This class is not agile, which means that you need to consider its threading model and marshaling behavior. For more info, see [Threading and Marshaling (C++/CX)](http://go.microsoft.com/fwlink/p/?linkid=258275)
<!--[jjacks - removed this link (http://go.microsoft.com/fwlink/p/?linkid=258277 404->http://msdn.microsoft.com/library/windows/apps/jj157115.aspx) because it doesn't work] and Using Windows Runtime objects in a multithreaded environment (.NET)-->
.

## -examples

## -see-also
[App lifecycle](http://msdn.microsoft.com/library/6c469e77-f1e3-4859-a27b-c326f9616d10), [SuspendingOperation](suspendingoperation.md), [App activated, resume, and suspend using the WRL sample](http://go.microsoft.com/fwlink/p/?linkid=226722)