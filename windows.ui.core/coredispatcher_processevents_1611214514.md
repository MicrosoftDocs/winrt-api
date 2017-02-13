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
The options for processing window events.

## -remarks
This method is called from the main app loop defined in the [IFrameworkView::Run](../windows.applicationmodel.core/iframeworkview.md) method you implemented on your view provider. Typically, you call it once on each iteration of the loop. If you are creating a Windows Store app using DirectX with C++, call this method with [CoreProcessEventsOption::ProcessAllIfPending](coreprocesseventsoption.md).

If you are using another app model, such as XAML or JavaScript, you do not need to call this method. To avoid reentrancy scenarios in your Windows Store app using C++, C#, or Visual Basic with XAML, use the types and methods in the provided XAML namespaces, which call this method in the appropriate context.

Also, this method fails if called recursively. When it fails, call [RoOriginateError](http://msdn.microsoft.com/library/ed647880-5a18-4f75-b7e5-3b9bf36229d3) to obtain the error and the message supplied to an attached debugger.

## -examples

## -see-also
