---
-api-id: P:Windows.Graphics.Holographic.HolographicCamera.IsHardwareContentProtectionSupported
-api-type: winrt property
ms.custom: RS5
---

<!-- Property syntax.
public bool IsHardwareContentProtectionSupported { get; }
-->

# Windows.Graphics.Holographic.HolographicCamera.IsHardwareContentProtectionSupported

## -description
Gets whether hardware content protection is supported for this [HolographicCamera](holographiccamera.md).

## -property-value
Whether hardware content protection is supported.

## -remarks
To enable hardware content protection for the primary layer's back buffer, set [IsHardwareContentProtectionEnabled](holographiccamera_ishardwarecontentprotectionenabled.md) to true.

To enable hardware content protection for a quad layer's buffer, call [AcquireBufferToUpdateContentWithHardwareProtection](holographicquadlayerupdateparameters_acquirebuffertoupdatecontentwithhardwareprotection_809854092.md) whenever you acquire new buffers for updates.

## -see-also

## -examples

