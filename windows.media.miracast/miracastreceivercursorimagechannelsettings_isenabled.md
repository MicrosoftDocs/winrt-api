---
-api-id: P:Windows.Media.Miracast.MiracastReceiverCursorImageChannelSettings.IsEnabled
-api-type: winrt property
ms.custom: 19H1
---

<!-- Property syntax.
public bool IsEnabled { get;  set; }
-->

# Windows.Media.Miracast.MiracastReceiverCursorImageChannelSettings.IsEnabled

## -description

Gets or sets the enabled status of the use of the separate channel for mouse cursor images.

## -property-value

True if the Miracast Cursor Image Channel is enabled.

## -remarks

When set to true, the Miracast Transmitter may transmit the mouse cursor image as a PNG bitmap, separate from the normal Miracast video stream.
Not all Miracast Transmitters support this feature, in which case the mouse cursor image, if any, will remain included in the video stream even if the property is set to True.

## -see-also

## -examples

