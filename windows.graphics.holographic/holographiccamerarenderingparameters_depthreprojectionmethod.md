---
-api-id: P:Windows.Graphics.Holographic.HolographicCameraRenderingParameters.DepthReprojectionMethod
-api-type: winrt property
---

# Windows.Graphics.Holographic.HolographicCameraRenderingParameters.DepthReprojectionMethod

<!--
public Windows.Graphics.Holographic.HolographicDepthReprojectionMethod DepthReprojectionMethod { get; set; }
-->


## -description

Gets or sets the reprojection method used for the associated [HolographicCamera](holographiccamera.md) for a given [HolographicFrame](holographicframe.md). The system will select a default reprojection method based on the device and/or platform capabilities.



## -property-value

The reprojection method to be used for the associated camera for a given [HolographicFrame](holographicframe.md).

## -remarks

Apps that use a particular mode can use this property to select the mode on devices which support that mode. Check to see what modes are supported on a device by calling [HolographicViewConfiguration.SupportedDepthReprojectionMethods](holographicviewconfiguration_supporteddepthreprojectionmethods.md).


## -see-also

## -examples

Starting with [TBD SDK version], apps should use the **HolographicCameraRenderingParameters.DepthReprojectionMethod** property to select **AutoPlanar** mode in order to enable auto-planar depth LSR. The following example demonstrates how set the depth reprojection method. This should be done on every [HolographicFrame](holographicframe.md) where the app needs to enable the auto-planar depth LSR mode:

```cppwinrt
renderingParameters.DepthReprojectionMethod(HolographicDepthReprojectionMethod::AutoPlanar);
```

Prior to [TBD SDK version], apps were instead required to call [SetFocusPoint](holographiccamerarenderingparameters_setfocuspoint_184506220.md) with a point value of {0,0,0} in order to enable auto-planar depth LSR on HoloLens 2. Apps that are compiled on the [TBD SDK version] SDK or later should be updated to set the **DepthReprojectionMethod** property instead.

```cppwinrt
renderingParameters.SetFocusPoint(m_stationaryReferenceFrame.CoordinateSystem(), { 0,0,0 });
```


