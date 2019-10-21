---
-api-id: T:Windows.Graphics.Holographic.HolographicQuadLayerUpdateParameters
-api-type: winrt class
ms.custom: RS5
---

<!-- Class syntax.
public class HolographicQuadLayerUpdateParameters 
-->

# Windows.Graphics.Holographic.HolographicQuadLayerUpdateParameters

## -description
Represents an update payload that lets an application configure a specific quad layer's parameters from a given frame forward.

## -remarks
To display quad layers, an application creates the necessary [HolographicQuadLayer](holographicquadlayer.md) instances and adds them to a [HolographicCamera](holographiccamera.md)'s mutable [QuadLayers](holographiccamera_quadlayers.md) list.  To synchronize a retained quad layer update with a given immediate-mode holographic frame, an application requests a HolographicQuadLayerUpdateParameters instance from that frame by calling [HolographicFrame.GetQuadLayerUpdateParameters](holographicframe_getquadlayerupdateparameters_1786338093.md).  Any updates requested on that **HolographicQuadLayerUpdateParameters** instance will apply starting in that frame.

> [!NOTE]
> The [AcquireBufferToUpdateContent](holographicquadlayerupdateparameters_acquirebuffertoupdatecontent_748006292.md) or [AcquireBufferToUpdateContentWithHardwareProtection](holographicquadlayerupdateparameters_acquirebuffertoupdatecontentwithhardwareprotection_809854092.md) method must be called when updating a **HolographicQuadLayer** object for the first time.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1809 | 17763 | AcquireBufferToUpdateContentWithHardwareProtection |
| 1809 | 17763 | CanAcquireWithHardwareProtection |

## -see-also

## -examples

