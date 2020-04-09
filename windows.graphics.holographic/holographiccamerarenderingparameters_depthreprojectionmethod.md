---
-api-id: P:Windows.Graphics.Holographic.HolographicCameraRenderingParameters.DepthReprojectionMethod
-api-type: winrt property
---

# Windows.Graphics.Holographic.HolographicCameraRenderingParameters.DepthReprojectionMethod

<!--
public Windows.Graphics.Holographic.HolographicDepthReprojectionMethod DepthReprojectionMethod { get; set; }
-->


## -description

Gets or sets the reprojection method used for the associated camera. The system will select a default reprojection mode based on the device and/or platform capabilities. 

## -property-value

The reprojection method used for the associated camera.

## -remarks

Apps that use a particular mode can use this property to select the mode on devices which support that mode. Check to see what modes are supported on a device by calling [HolographicViewConfiguration.SupportedDepthReprojectionMethods](holographicviewconfiguration_supporteddepthreprojectionmethods.md).

## -see-also

## -examples


