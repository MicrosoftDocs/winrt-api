---
-api-id: P:Windows.Graphics.Holographic.HolographicCamera.IsHardwareContentProtectionEnabled
-api-type: winrt property
ms.custom: RS5
---

<!-- Property syntax.
public bool IsHardwareContentProtectionEnabled { get;  set; }
-->

# Windows.Graphics.Holographic.HolographicCamera.IsHardwareContentProtectionEnabled

## -description
Gets or sets whether this [HolographicCamera](holographiccamera.md) will produce hardware-protected back buffers for the primary layer.

## -property-value
Whether hardware content protection is enabled.

## -remarks
If this property is successfully set to true, the [Direct3D11BackBuffer](holographiccamerarenderingparameters_direct3d11backbuffer.md) property will return hardware-protected back buffers for the primary layer.  Setting this property to true will fail unless [IsHardwareContentProtectionSupported](holographiccamera_ishardwarecontentprotectionsupported.md) returns true.

While content protection is enabled, rendered content will be visible only in the headset, disabling the Mixed Reality Portal's preview.

Changes to this property will take effect on future frames, unless [GetRenderingParameters](holographicframe_getrenderingparameters_2127053540.md) has not yet been called for a given frame.  To ensure that a particular back buffer is hardware-protected, you can check that its [D3D11_RESOURCE_MISC_HW_PROTECTED](/windows/desktop/api/d3d11/ne-d3d11-d3d11_resource_misc_flag) flag is set.

> [!NOTE]
> This property does not affect content protection for quad layers.  To enable hardware content protection for a quad layer's buffer, call [AcquireBufferToUpdateContentWithHardwareProtection](holographicquadlayerupdateparameters_acquirebuffertoupdatecontentwithhardwareprotection_809854092.md) whenever you acquire new buffers for updates.

## -see-also

## -examples

