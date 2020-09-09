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


<!-- confirmed -->
> [!NOTE]
> This class is not agile, which means that you need to consider its threading model and marshaling behavior. For more info, see [Threading and Marshaling (C++/CX)](/cpp/cppcx/threading-and-marshaling-c-cx)
<!--[jjacks - removed this link (https://go.microsoft.com/fwlink/p/?linkid=258277 404->http://msdn.microsoft.com/library/windows/apps/jj157115.aspx) because it doesn't work] and Using Windows Runtime objects in a multithreaded environment (.NET)-->
.

## -examples

## -see-also
[App lifecycle](/windows/uwp/launch-resume/app-lifecycle), [SuspendingOperation](suspendingoperation.md), [App activated, resume, and suspend using the WRL sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208%20app%20samples/%5BJavaScript%5D-Windows%208%20app%20samples/JavaScript/Windows%208%20app%20samples/App%20activated%2C%20resume%2C%20and%20suspend%20using%20the%20WRL%20%20sample%20(Windows%208)/JavaScript)
