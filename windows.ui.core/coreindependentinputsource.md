---
-api-id: T:Windows.UI.Core.CoreIndependentInputSource
-api-type: winrt class
---

<!-- Class syntax.
public class CoreIndependentInputSource : Windows.UI.Core.ICoreInputSourceBase, Windows.UI.Core.ICorePointerInputSource
-->

# Windows.UI.Core.CoreIndependentInputSource

## -description
Surfaces core input API for interoperation scenarios.

## -remarks
Create an instance of this class by calling [SwapChainBackgroundPanel::CreateCoreIndependentInputSource](../windows.ui.xaml.controls/swapchainbackgroundpanel_createcoreindependentinputsource.md) or [SwapChainPanel::CreateCoreIndependentInputSource](../windows.ui.xaml.controls/swapchainpanel_createcoreindependentinputsource.md).

The [CoreIndependentInputSource](coreindependentinputsource.md) class enables an app to handle input and rendering independent of the XAML UI thread, because you're deliberately providing the input processing logic on a background thread. You must call [CreateCoreIndependentInputSource](../windows.ui.xaml.controls/swapchainpanel_createcoreindependentinputsource.md) from a non-UI thread, otherwise the [CreateCoreIndependentInputSource](../windows.ui.xaml.controls/swapchainpanel_createcoreindependentinputsource.md) method call will fail.



Initializing independent input

```cpp
// Create a task to register for independent input and begin processing input messages.
auto workItemHandler = ref new WorkItemHandler([this] (IAsyncAction ^)
{
   // The CoreIndependentInputSource will raise pointer events for the specified device types on whichever thread it's created on.
   CoreIndependentInputSource^ coreInput = CreateCoreIndependentInputSource(
      Windows::UI::Core::CoreInputDeviceTypes::Mouse |
      Windows::UI::Core::CoreInputDeviceTypes::Touch |
      Windows::UI::Core::CoreInputDeviceTypes::Pen
   );

   // Register for pointer events, which will be raised on the background thread.
   coreInput->PointerPressed += ref new TypedEventHandler<Object^, PointerEventArgs^>(this, &MyClass::OnPointerPressed);
   coreInput->PointerMoved += ref new TypedEventHandler<Object^, PointerEventArgs^>(this, &MyClass::OnPointerMoved);
   coreInput->PointerReleased += ref new TypedEventHandler<Object^, PointerEventArgs^>(this, &MyClass::OnPointerReleased);

   // Begin processing input messages as they're delivered.
   coreInput->Dispatcher->ProcessEvents(CoreProcessEventsOption::ProcessUntilQuit);
});

// Run task on a dedicated high priority background thread.
m_inputLoopWorker = ThreadPool::RunAsync(workItemHandler, WorkItemPriority::High, WorkItemOptions::TimeSliced);

```

For more example code of how to use [CreateCoreIndependentInputSource](../windows.ui.xaml.controls/swapchainpanel_createcoreindependentinputsource.md) and [CoreIndependentInputSource](coreindependentinputsource.md), see the `DrawingPanel` class definition that is part of the [XAML SwapChainPanel DirectX interop sample](http://go.microsoft.com/fwlink/p/?LinkID=309155).

## -examples

## -see-also
[ICoreInputSourceBase](icoreinputsourcebase.md), [ICorePointerInputSource](icorepointerinputsource.md), [SwapChainPanel](../windows.ui.xaml.controls/swapchainpanel.md), [Threading and async programming](http://msdn.microsoft.com/library/beac6333-655a-4bcf-9caf-bba15f715ea5)