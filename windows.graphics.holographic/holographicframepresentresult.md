---
-api-id: T:Windows.Graphics.Holographic.HolographicFramePresentResult
-api-type: winrt enum
-api-device-family-note: xbox
---

<!-- Enumeration syntax
public enum Windows.Graphics.Holographic.HolographicFramePresentResult : int
-->

# HolographicFramePresentResult

## -description
Indicates the outcome of a Present call on a holographic frame.

## -enum-fields
### -field Success:0
The frame was presented successfully.

### -field DeviceRemoved:1
The Direct3D 11 device was removed and a new device is required. To investigate the cause of device removed errors, call the ID3D11Device::GetDeviceRemovedReason method before releasing the Direct3D device. Set the new device by calling the HolographicSpace::SetDirect3D11Device method.


## -remarks

## -examples

## -see-also