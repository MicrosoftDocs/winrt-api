---
-api-id: P:Windows.Graphics.Holographic.HolographicQuadLayerUpdateParameters.CanAcquireWithHardwareProtection
-api-type: winrt property
---

<!-- Property syntax.
public bool CanAcquireWithHardwareProtection { get; }
-->

# Windows.Graphics.Holographic.HolographicQuadLayerUpdateParameters.CanAcquireWithHardwareProtection

## -description
Gets whether hardware content protection is supported for this quad layer.

## -property-value
Whether hardware content protection is supported.

## -remarks
To enable hardware content protection for a quad layer's buffer, call [AcquireBufferToUpdateContentWithHardwareProtection](holographicquadlayerupdateparameters_acquirebuffertoupdatecontentwithhardwareprotection_809854092.md) whenever you acquire new buffers for updates.

To enable hardware content protection for the primary layer's back buffer, set [IsHardwareContentProtectionEnabled](holographiccamera_ishardwarecontentprotectionenabled.md) to true.

## -see-also

## -examples

