---
-api-id: M:Windows.Media.Miracast.MiracastReceiverStreamControl.SuggestVideoStreamSettings(Windows.Media.Miracast.MiracastReceiverVideoStreamSettings)
-api-type: winrt method
ms.custom: 19H1
---

<!-- Method syntax.
public void MiracastReceiverStreamControl.SuggestVideoStreamSettings(MiracastReceiverVideoStreamSettings settings)
-->

# Windows.Media.Miracast.MiracastReceiverStreamControl.SuggestVideoStreamSettings

## -description

Suggests the specified video stream settings to the Miracast Transmitter.

## -parameters
### -param settings

The suggested video stream settings.

## -remarks

Because this method may block for a noticeable period of time, you should not call it from the UI thread or from a single-threaded apartment. Instead, use the asyncronous method [SuggestVideoStreamSettingsAsync](miracastreceiverstreamcontrol_suggestvideostreamsettingsasync_966302349.md).

Not all Miracast Transmitters support changing the settings of the video stream, and the Miracast Transmitter may ignore the suggested settings, or choose different values.

## -see-also

[MiracastReceiverVideoStreamSettings](miracastreceivervideostreamsettings.md),
[SuggestVideoStreamSettingsAsync](miracastreceiverstreamcontrol_suggestvideostreamsettingsasync_966302349.md)

## -examples

