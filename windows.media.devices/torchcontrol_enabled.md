---
-api-id: P:Windows.Media.Devices.TorchControl.Enabled
-api-type: winrt property
---

<!-- Property syntax
public bool Enabled { get;  set; }
-->

# Windows.Media.Devices.TorchControl.Enabled

## -description
Gets or sets a value that enables and disables the torch LED on the device.

## -property-value
**true** if the torch LED is enabled; otherwise, **false**.

## -remarks
On some devices the torch will not emit light, even if **Enabled** is set to true, unless the device has a preview stream running and is actively capturing video. The recommended order of operations is to turn on the video preview, then turn on the torch by setting **Enabled** to true, and then initiate video capture. On some devices the torch will light up after the preview is started. On other devices, the torch may not light up until video capture is started.

## -examples

## -see-also
