---
-api-id: M:Windows.Graphics.Holographic.HolographicFrame.GetQuadLayerUpdateParameters(Windows.Graphics.Holographic.HolographicQuadLayer)
-api-type: winrt method
---

<!-- Method syntax.
public HolographicQuadLayerUpdateParameters HolographicFrame.GetQuadLayerUpdateParameters(HolographicQuadLayer layer)
-->

# Windows.Graphics.Holographic.HolographicFrame.GetQuadLayerUpdateParameters

## -description
Gets an update payload that lets an application configure a specific quad layer's parameters from this frame forward.

## -parameters
### -param layer
The quad layer to update.

## -returns
The update parameters.

## -remarks
To display quad layers, an application creates the necessary [HolographicQuadLayer](holographicquadlayer.md) instances and adds them to a [HolographicCamera](holographiccamera.md)'s mutable [QuadLayers](holographiccamera_quadlayers.md) list.  To synchronize a retained quad layer update with a given immediate-mode holographic frame, an application requests an [HolographicQuadLayerUpdateParameters](holographicquadlayerupdateparameters.md) instance from that frame by calling HolographicFrame.GetQuadLayerUpdateParameters.  Any updates requested on that **HolographicQuadLayerUpdateParameters** instance will apply starting in that frame.

> [!NOTE]
> The [AcquireBufferToUpdateContent](holographicquadlayerupdateparameters_acquirebuffertoupdatecontent_748006292.md) or [AcquireBufferToUpdateContentWithHardwareProtection](holographicquadlayerupdateparameters_acquirebuffertoupdatecontentwithhardwareprotection_809854092.md) method must be called when updating a **HolographicQuadLayer** object for the first time.

## -see-also

## -examples

