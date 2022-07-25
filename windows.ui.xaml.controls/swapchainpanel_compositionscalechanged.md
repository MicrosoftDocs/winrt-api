---
-api-id: E:Windows.UI.Xaml.Controls.SwapChainPanel.CompositionScaleChanged
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler CompositionScaleChanged<Windows.UI.Xaml.Controls.SwapChainPanel,  object>
-->

# Windows.UI.Xaml.Controls.SwapChainPanel.CompositionScaleChanged

## -description
Occurs when the composition scale factor of the [SwapChainPanel](swapchainpanel.md) has changed.



## -xaml-syntax
```xaml
<SwapChainPanel CompositionScaleChanged="eventhandler"/>
```


## -remarks
The supplier of the swap chain content might need to resize their content if a layout pass determines a new size for the panel or containers it's within, or if a [RenderTransform](../windows.ui.xaml/uielement_rendertransform.md) is applied on the [SwapChainPanel](swapchainpanel.md) or any of its ancestors. Changes of this nature aren't always originated by app logic that's easy to detect from other events (for example the user might change a device orientation or a view state that causes layout to rerun), so this event provides a notification specifically for the scenario of changing the swap chain content size, which would typically invert the scale factors applied.

Check [CompositionScaleX](swapchainpanel_compositionscalex.md) and [CompositionScaleY](swapchainpanel_compositionscaley.md) any time you are handling CompositionScaleChanged (CompositionScaleChanged doesn't have event data, but if it fires it means that one or both properties have changed values on this [SwapChainPanel](swapchainpanel.md)).

This event fires asynchronously versus the originating change. For example, dynamic animations or manipulations might affect the scale factor, and the event is raised when those dynamic changes are completed.

## -examples

## -see-also
