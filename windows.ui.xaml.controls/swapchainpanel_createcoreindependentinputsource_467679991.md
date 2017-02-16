---
-api-id: M:Windows.UI.Xaml.Controls.SwapChainPanel.CreateCoreIndependentInputSource(Windows.UI.Core.CoreInputDeviceTypes)
-api-type: winrt method
---

<!-- Method syntax
public Windows.UI.Core.CoreIndependentInputSource CreateCoreIndependentInputSource(Windows.UI.Core.CoreInputDeviceTypes deviceTypes)
-->

# Windows.UI.Xaml.Controls.SwapChainPanel.CreateCoreIndependentInputSource

## -description
Creates a core input object that handles the input types as specified by the *deviceTypes* parameter. This core input object can process input events on a background thread.

## -parameters
### -param deviceTypes
A combined value of the enumeration.

## -returns
An object that represents the input subsystem for interoperation purposes and can be used for input event connection points.

## -remarks
This method enables an app that includes a [SwapChainPanel](swapchainpanel.md) to handle input and rendering independent of the XAML UI thread, because you're deliberately providing the input processing logic on a background thread. You must call [CreateCoreIndependentInputSource](swapchainpanel_createcoreindependentinputsource.md) from a non-UI thread, otherwise this method will fail.

Use the [CreateCoreIndependentInputSource](swapchainbackgroundpanel_createcoreindependentinputsource.md) method to create a core input object and associate it with your [SwapChainPanel](swapchainpanel.md). Upon successful creation, user input of the specified device types that accesses [SwapChainPanel](swapchainpanel.md) contents will be redirected to the thread that [CreateCoreIndependentInputSource](swapchainpanel_createcoreindependentinputsource.md) was called from. Your app can handle this input by registering for input events and processing those events on a background thread. In order to receive input messages through the [CoreIndependentInputSource](../windows.ui.core/coreindependentinputsource.md) object, the app code must set a swap chain on the [SwapChainPanel](swapchainpanel.md), and render (at a Microsoft DirectX level) from this swap chain at least once. That provides the rendering that makes hit testing possible.

You typically use [CoreDispatcher::ProcessEvents](../windows.ui.core/coredispatcher_processevents.md) as part of the event handling. Get a [CoreDispatcher](../windows.ui.core/coredispatcher.md) reference from [CoreIndependentInputSource::Dispatcher](../windows.ui.core/coreindependentinputsource_dispatcher.md). For more info on how to use background threads, see [ThreadPool](../windows.system.threading/threadpool.md) or [Threading and async programming](http://msdn.microsoft.com/library/beac6333-655a-4bcf-9caf-bba15f715ea5).

You can call [CreateCoreIndependentInputSource](swapchainpanel_createcoreindependentinputsource.md) multiple times. Each time [CreateCoreIndependentInputSource](swapchainpanel_createcoreindependentinputsource.md) is called, the previous [CoreIndependentInputSource](../windows.ui.core/coreindependentinputsource.md) object is disassociated with the [SwapChainPanel](swapchainpanel_swapchainpanel.md). In other words, only one [CoreIndependentInputSource](../windows.ui.core/coreindependentinputsource.md) object can get events at a time.

For example code of how to use [CreateCoreIndependentInputSource](swapchainpanel_createcoreindependentinputsource.md), see the `DrawingPanel` class definition that is part of the [XAML SwapChainPanel DirectX interop sample](http://go.microsoft.com/fwlink/p/?LinkID=309155).

[CreateCoreIndependentInputSource](swapchainpanel_createcoreindependentinputsource.md) d can return **null** if *deviceTypes* was passed as [CoreInputDeviceTypes.None](../windows.ui.core/coreinputdevicetypes.md) (that's not a typical way to call [CreateCoreIndependentInputSource](swapchainpanel_createcoreindependentinputsource.md) though).


<!--Implementation detail? Or is there a scenario for that usage?-->

## -examples

## -see-also
[CoreIndependentInputSource](../windows.ui.core/coreindependentinputsource.md), [ThreadPool](../windows.system.threading/threadpool.md), [Threading and async programming](http://msdn.microsoft.com/library/beac6333-655a-4bcf-9caf-bba15f715ea5), [DirectX and XAML interop](http://msdn.microsoft.com/library/17987eea-6771-423c-9b68-6b9aeadc7b7f), [XAML SwapChainPanel DirectX interop sample](http://go.microsoft.com/fwlink/p/?LinkID=309155), [Low latency input sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=620566)