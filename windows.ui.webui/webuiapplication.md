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

<!-- confirmed -->
> [!NOTE]
> This class is not agile, which means that you need to consider its threading model and marshaling behavior. For more info, see [Threading and Marshaling (C++/CX)](/cpp/cppcx/threading-and-marshaling-c-cx).

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
[App lifecycle](/windows/uwp/launch-resume/app-lifecycle), [App lifecycle](/windows/uwp/launch-resume/app-lifecycle), [App lifecycle](/windows/uwp/launch-resume/app-lifecycle), [App activated, resume, and suspend using the WRL sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208%20app%20samples/%5BJavaScript%5D-Windows%208%20app%20samples/JavaScript/Windows%208%20app%20samples/App%20activated%2C%20resume%2C%20and%20suspend%20using%20the%20WRL%20%20sample%20(Windows%208)/JavaScript)
