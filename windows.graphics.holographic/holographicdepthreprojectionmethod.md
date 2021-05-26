---
-api-id: T:Windows.Graphics.Holographic.HolographicDepthReprojectionMethod
-api-type: winrt enum
---

# Windows.Graphics.Holographic.HolographicDepthReprojectionMethod

<!--
public enum HolographicDepthReprojectionMethod
-->


## -description

Specifies the reprojection method used to process the depth buffer submitted for image stabilization for a particular holographic camera when a given [HolographicFrame](holographicframe.md) is presented.

## -enum-fields



### -field AutoPlanar

A best-fit plane will be constructed using the depth data, and the best-fit plane will be used for planar reprojection. The best-fit plane is optimized using temporal smoothing and fronto-parallel bias.



### -field DepthReprojection

Each pixel will be reprojected using a smoothed and filtered depth value, which is derived from depth information local to that pixel.

## -remarks

Use this value when setting the [DepthReprojectionMethod](holographiccamerarenderingparameters_depthreprojectionmethod.md) property on the [HolographicCameraRenderingParameters](holographiccamerarenderingparameters.md) for each frame that it should be applied to. 

This value is only applicable when the app has also submitted a depth buffer for the same **HolographicFrame**.

## -see-also

## -examples


