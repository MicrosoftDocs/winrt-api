---
-api-id: T:Windows.Graphics.Holographic.HolographicQuadLayerUpdateParameters
-api-type: winrt class
---

<!-- Class syntax.
public class HolographicQuadLayerUpdateParameters 
-->

# Windows.Graphics.Holographic.HolographicQuadLayerUpdateParameters

## -description
Represents an update payload that lets an app configure a specific quad layer's parameters from a given frame forward.

## -remarks
To display quad layers, an app creates the necessary [HolographicQuadLayer](holographicquadlayer.md) instances and adds them to a HolographicCamera's mutable [QuadLayers](holographiccamera_quadlayers.md) list.  To synchronize a retained quad layer update with a given immediate-mode holographic frame, an app requests an [HolographicQuadLayerUpdateParameters](holographicquadlayerupdateparameters.md) instance from that frame by calling [HolographicFrame.GetQuadLayerUpdateParameters](holographicframe_getquadlayerupdateparameters_1786338093.md).  Any updates requested on that HolographicQuadLayerUpdateParameters instance will apply starting in that frame.

**Note:** The AcquireBufferToUpdateContent method must be called when updating a HolographicQuadLayer object for the first time.

## -see-also

## -examples

