---
-api-id: T:Windows.UI.Core.CoreIndependentInputSource
-api-type: winrt class
---

<!-- Class syntax.
public class CoreIndependentInputSource : Windows.UI.Core.ICoreInputSourceBase, Windows.UI.Core.ICorePointerInputSource
-->

# Windows.UI.Core.CoreIndependentInputSource

## -description

Surfaces core input APIs for interoperation scenarios.

## -remarks

Create an instance of this class by calling [SwapChainBackgroundPanel.CreateCoreIndependentInputSource](../windows.ui.xaml.controls/swapchainbackgroundpanel_createcoreindependentinputsource_467679991.md) or [SwapChainPanel.CreateCoreIndependentInputSource](../windows.ui.xaml.controls/swapchainpanel_createcoreindependentinputsource_467679991.md).

The CoreIndependentInputSource class enables an app to handle input and rendering independent of the XAML UI thread, because you're intentionally providing the input processing logic on a background thread. You must call [CreateCoreIndependentInputSource](../windows.ui.xaml.controls/swapchainpanel_createcoreindependentinputsource_467679991.md) from a non-UI thread, otherwise the [CreateCoreIndependentInputSource](../windows.ui.xaml.controls/swapchainpanel_createcoreindependentinputsource_467679991.md) method call will fail.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1803 | 17134 | DispatcherQueue |

## -examples

Initializing independent input.

```cppwinrt
// MainPage.cpp
#include "pch.h"
#include "MainPage.h"
#include <winrt/Windows.System.Threading.h>
#include <winrt/Windows.UI.Core.h>
#include <winrt/Windows.UI.Xaml.Controls.h>

using namespace winrt;
using namespace Windows::UI::Xaml;
using namespace Windows::UI::Xaml::Controls;

Windows::Foundation::IAsyncAction m_inputLoopWorker;
...
    // Create a task to register for independent input and begin processing input messages.
    Windows::System::Threading::WorkItemHandler workItemHandler([this](Windows::Foundation::IAsyncAction const& /* action */)
    {
        // The CoreIndependentInputSource will raise pointer events for the specified device types on whichever thread it's created on.
        Windows::UI::Core::CoreIndependentInputSource coreInput{
            MySwapChainPanel().CreateCoreIndependentInputSource(
                Windows::UI::Core::CoreInputDeviceTypes::Mouse |
                Windows::UI::Core::CoreInputDeviceTypes::Touch |
                Windows::UI::Core::CoreInputDeviceTypes::Pen)
        };

        // Register for pointer events, which will be raised on the background thread.
        coreInput.PointerPressed({ this, &MainPage::SCP_OnPointerPressed });
        coreInput.PointerMoved({ this, &MainPage::SCP_OnPointerMoved });
        coreInput.PointerReleased({ this, &MainPage::SCP_OnPointerReleased });

        // Begin processing input messages as they're delivered.
        coreInput.Dispatcher().ProcessEvents(Windows::UI::Core::CoreProcessEventsOption::ProcessUntilQuit);
    });

    // Run task on a dedicated high priority background thread.
    m_inputLoopWorker = Windows::System::Threading::ThreadPool::RunAsync(
        workItemHandler, Windows::System::Threading::WorkItemPriority::High,
        Windows::System::Threading::WorkItemOptions::TimeSliced);
...
void MainPage::SCP_OnPointerPressed(Windows::Foundation::IInspectable const& /* sender */,
    Windows::UI::Core::PointerEventArgs const& /* args */) {}
void MainPage::SCP_OnPointerMoved(Windows::Foundation::IInspectable const& /* sender */,
    Windows::UI::Core::PointerEventArgs const& /* args */) {}
void MainPage::SCP_OnPointerReleased(Windows::Foundation::IInspectable const& /* sender */,
    Windows::UI::Core::PointerEventArgs const& /* args */) {}
```

```cppcx
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

For more example code of how to use [CreateCoreIndependentInputSource](../windows.ui.xaml.controls/swapchainpanel_createcoreindependentinputsource_467679991.md) and CoreIndependentInputSource, see the `DrawingPanel` class definition that is part of the [XAML SwapChainPanel DirectX interop sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/XAML%20SwapChainPanel%20DirectX%20interop%20sample).

## -see-also

[ICoreInputSourceBase](icoreinputsourcebase.md), [ICorePointerInputSource](icorepointerinputsource.md), [SwapChainPanel](../windows.ui.xaml.controls/swapchainpanel.md), [Threading and async programming](/windows/uwp/threading-async/index)
