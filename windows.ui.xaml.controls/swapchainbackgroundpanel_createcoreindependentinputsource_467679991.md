---
-api-id: M:Windows.UI.Xaml.Controls.SwapChainBackgroundPanel.CreateCoreIndependentInputSource(Windows.UI.Core.CoreInputDeviceTypes)
-api-type: winrt method
---

<!-- Method syntax
public Windows.UI.Core.CoreIndependentInputSource CreateCoreIndependentInputSource(Windows.UI.Core.CoreInputDeviceTypes deviceTypes)
-->

# Windows.UI.Xaml.Controls.SwapChainBackgroundPanel.CreateCoreIndependentInputSource

## -description
> [!NOTE]
> [SwapChainBackgroundPanel](swapchainbackgroundpanel.md) may be altered or unavailable for releases after Windows 8.1 Instead, use [SwapChainPanel](swapchainpanel.md).

Creates a core input object that handles the input types as specified by the *deviceTypes* parameter.

## -parameters
### -param deviceTypes
A combined value of the enumeration.

## -returns
An object that represents the input subsystem for interoperation purposes and can be used for input event connection points.

## -remarks
> [!IMPORTANT]
> You must call [CreateCoreIndependentInputSource](swapchainbackgroundpanel_createcoreindependentinputsource_467679991.md) from a non-UI thread, otherwise this method will fail.

## -examples

## -see-also
[CoreIndependentInputSource](../windows.ui.core/coreindependentinputsource.md)