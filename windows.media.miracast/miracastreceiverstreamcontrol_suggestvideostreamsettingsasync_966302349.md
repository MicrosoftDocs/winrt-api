---
-api-id: M:Windows.Media.Miracast.MiracastReceiverStreamControl.SuggestVideoStreamSettingsAsync(Windows.Media.Miracast.MiracastReceiverVideoStreamSettings)
-api-type: winrt method
---

## -description

Asynchronously suggests an appropriate width, height and bitrate to the Miracast Transmitter.

## -parameters

### -param settings

A [MiracastReceiverVideoStreamSettings](miracastreceivervideostreamsettings.md) object representing the suggested settings.

## -returns

An asynchronous task.

## -remarks

An app can call this API when the [MediaPlayerElement](/uwp/api/Windows.UI.Xaml.Controls.MediaPlayerElement) associated with the Miracast content changes. By default, Miracast tries to use a 1920x1080 resolution, or a 4k resolution if supported by the hardware. By asking the transmitter to use a lower resolution, it might be possible to reduce the network bandwidth used. 

The settings passed into the method are suggestions that the transmitter may or may not adopt. To find out the actual values chosen by the receiver, call [GetVideoStreamSettingsAsync](miracastreceiverstreamcontrol_getvideostreamsettingsasync_709470693.md).


This function accesses member variables without locking, so it should be invoked on the UI thread in a call to [CoreDispatcher.RunAsync](/uwp/api/windows.ui.core.coredispatcher.runasync)


## -see-also

## -examples

