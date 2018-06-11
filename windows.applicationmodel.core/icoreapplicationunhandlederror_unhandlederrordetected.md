---
-api-id: E:Windows.ApplicationModel.Core.ICoreApplicationUnhandledError.UnhandledErrorDetected
-api-type: winrt event
---

<!-- Event syntax
abstract public event Windows.Foundation.EventHandler UnhandledErrorDetected<Windows.ApplicationModel.Core.UnhandledErrorDetectedEventArgs>
-->

# Windows.ApplicationModel.Core.ICoreApplicationUnhandledError.UnhandledErrorDetected

## -description
Occurs when there is an error in an async completion or event handler that wasn't otherwise handled by system or app code.

## -remarks
This event is raised whenever there is an error in an async completion or event handler that reaches top of stack without being handled by system or app code. Your app can inspect the error and choose whether to mark the error as handled (using the [Handled](unhandlederror_handled.md) property in event data). If the error is marked [Handled](unhandlederror_handled.md), execution will continue. If the error is not marked [Handled](unhandlederror_handled.md), the process will be terminated.

```cpp
CoreApplication::UnhandledErrorDetected += ref new EventHandler<UnhandledErrorDetectedEventArgs^ >(
    [](Platform::Object^ sender, UnhandledErrorDetectedEventArgs^ ea) ->
{
    if (!ea->UnhandledError->Handled)
    {
        try
        {
            // Take the failure HRESULT and wrap it in a language specific exception
            ea->UnhandledError->Propagate();
        }
        catch (Platform::Exception^ e)
        {
            MyLogger::Log(e->Message);
            // Since UnhandledError.Propagate marks the error as Handled, rethrow in order to only Log and not Handle
            throw e;
        }
    }
});
```

## -examples

## -see-also
[UnhandledException](../windows.ui.xaml/application_unhandledexception.md)