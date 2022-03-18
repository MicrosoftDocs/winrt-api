---
-api-id: M:Windows.UI.Core.CoreDispatcher.ProcessEvents(Windows.UI.Core.CoreProcessEventsOption)
-api-type: winrt method
---

<!-- Method syntax
public void ProcessEvents(Windows.UI.Core.CoreProcessEventsOption options)
-->

# Windows.UI.Core.CoreDispatcher.ProcessEvents

## -description
Starts the dispatcher processing the input event queue for this instance of [CoreWindow](corewindow.md).

## -parameters
### -param options
Determines how many events to process, and if this method should block.

## -remarks
### - UWP app using DirectX with C++
Call this method to dispatch events from your view provider's main app loop defined in the [IFrameworkView.Run](../windows.applicationmodel.core/iframeworkview.md) method.  If your window is visible, call it with [CoreProcessEventsOption.ProcessAllIfPresent](coreprocesseventsoption.md) to dispatch current events and continue.  If your window is not visible, use [CoreProcessEventsOption.ProcessOneAndAllPending](coreprocesseventsoption.md) to block until the next event and prevent busy waiting.

### - Other App Models
If you are using another app model, such as XAML or JavaScript, you do not need to call this method. To avoid reentrancy scenarios in your UWP app using C++, C#, or Visual Basic with XAML, use the types and methods in the provided XAML namespaces, which call this method in the appropriate context.
 
## -warning
This method fails if called recursively. When it fails, call [RoOriginateError](/windows/desktop/api/roerrorapi/nf-roerrorapi-rooriginateerror) to obtain the error and the message supplied to an attached debugger.

## -examples

## -see-also
