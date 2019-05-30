---
-api-id: T:Windows.UI.WebUI.WebUIApplication
-api-type: winrt class
---

<!-- Class syntax.
public class WebUIApplication 
-->

# Windows.UI.WebUI.WebUIApplication

## -description
Enables an app to receive notifications related to the lifetime of the app.

## -remarks
The system creates this object when it runs the app.

> [!NOTE]
> : This class is not agile, which means that you need to consider its threading model and marshaling behavior. For more info, see [Threading and Marshaling (C++/CX)](https://go.microsoft.com/fwlink/p/?linkid=258275)
<!--[jjacks - removed this link (https://go.microsoft.com/fwlink/p/?linkid=258277 404->http://msdn.microsoft.com/library/windows/apps/jj157115.aspx) because it doesn't work] and Using Windows Runtime objects in a multithreaded environment (.NET)-->
.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | EnablePrelaunch |
| 1607 | 14393 | EnteredBackground |
| 1607 | 14393 | LeavingBackground |
| 1709 | 16299 | RequestRestartAsync |
| 1709 | 16299 | RequestRestartForUserAsync |
| 1809 | 17763 | BackgroundActivated |
| 1809 | 17763 | NewWebUIViewCreated |

## -examples

## -see-also
[App lifecycle](https://docs.microsoft.com/windows/uwp/launch-resume/app-lifecycle), [App lifecycle](https://docs.microsoft.com/windows/uwp/launch-resume/app-lifecycle), [App lifecycle](https://docs.microsoft.com/windows/uwp/launch-resume/app-lifecycle), [App activated, resume, and suspend using the WRL sample](https://go.microsoft.com/fwlink/p/?linkid=226722)
