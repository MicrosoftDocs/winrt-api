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

A background task must explicitly call the Web Workers [close](http://msdn.microsoft.com/en-us/library/hh673568(v=VS.85).aspx) method to terminate itself after the task has completed.

## -remarks

<!-- confirmed -->
> [!NOTE]
> This class is not agile, which means that you need to consider its threading model and marshaling behavior. For more info, see [Threading and Marshaling (C++/CX)](http://msdn.microsoft.com/en-us/library/windows/apps/hh771042.aspx).

## -examples

## -see-also

[Background task sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/BackgroundTask), [Background activation sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/BackgroundActivation)
