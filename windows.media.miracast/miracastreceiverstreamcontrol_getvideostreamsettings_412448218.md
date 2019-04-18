---
-api-id: M:Windows.Media.Miracast.MiracastReceiverStreamControl.GetVideoStreamSettings
-api-type: winrt method
ms.custom: 19H1
---

<!-- Method syntax.
public MiracastReceiverVideoStreamSettings MiracastReceiverStreamControl.GetVideoStreamSettings()
-->

# Windows.Media.Miracast.MiracastReceiverStreamControl.GetVideoStreamSettings

## -description

Returns an object representing the current settings for the video stream.

## -returns

The current settings for the video stream.

## -remarks

Because this method may block for a noticeable period of time, you should not call it from the UI thread or from a single-threaded apartment. Instead, use the asyncronous method [GetVideoStreamSettingsAsync](miracastreceiverstreamcontrol_getvideostreamsettingsasync_709470693.md).

## -see-also

[GetVideoStreamSettingsAsync](miracastreceiverstreamcontrol_getvideostreamsettingsasync_709470693.md),
[MiracastReceiverVideoStreamSettings](miracastreceivervideostreamsettings.md)

## -examples

