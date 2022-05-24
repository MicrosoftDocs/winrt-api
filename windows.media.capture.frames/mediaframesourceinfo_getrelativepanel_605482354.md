---
-api-id: M:Windows.Media.Capture.Frames.MediaFrameSourceInfo.GetRelativePanel(Windows.UI.WindowManagement.DisplayRegion)
-api-type: winrt method
---

<!-- Method syntax.
public Panel MediaFrameSourceInfo.GetRelativePanel(DisplayRegion displayRegion)
-->

# Windows.Media.Capture.Frames.MediaFrameSourceInfo.GetRelativePanel

## -description

Gets the relative panel location of the provided [DisplayRegion](/uwp/api/windows.ui.windowmanagement.displayregion) when using the associated [MediaFrameSource](mediaframesource.md).

## -parameters

### -param displayRegion

The **DisplayRegion** for which the relative panel location is retrieved.

## -returns

A member of the [Panel](/uwp/api/windows.devices.enumeration.panel) enumeration indicating relative panel location of the provided **DisplayRegion**.

## -remarks

This API is useful for hinged devices where the relative location of a **DisplayRegion** can vary depending on the physical configuration of the device.  For more information, see [PanelBasedOptimizationControl Class](/uwp/api/windows.media.devices.panelbasedoptimizationcontrol)

## -see-also

[MediaFrameSource](mediaframesource.md),[DisplayRegion](/uwp/api/windows.ui.windowmanagement.displayregion),[PanelBasedOptimizationControl Class](/uwp/api/windows.media.devices.panelbasedoptimizationcontrol),[Panel](/uwp/api/windows.devices.enumeration.panel)

## -examples

