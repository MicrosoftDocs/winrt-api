---
-api-id: M:Windows.Media.Audio.AudioPlaybackConnection.TryCreateFromId(System.String)
-api-type: winrt method
---

<!-- Method syntax.
public AudioPlaybackConnection AudioPlaybackConnection.TryCreateFromId(String id)
-->

# Windows.Media.Audio.AudioPlaybackConnection.TryCreateFromId

## -description

Attempts to create an [AudioPlaybackConnection](audioplaybackconnection.md) from the specified device ID.

## -parameters

### -param id

The identifier for the device for which the connection should be created.

## -returns

If successful, returns an [AudioPlaybackConnection](audioplaybackconnection.md). If the specified device does not have support for audio streaming, the return value is null.

## -remarks

Get a device ID by creating a [DeviceWatcher](/uwp/api/Windows.Devices.Enumeration.DeviceWatcher) by calling [DeviceInformation.CreateWatcher](/uwp/api/windows.devices.enumeration.deviceinformation.createwatcher) and passing in the string returned by [GetDeviceSelector](audioplaybackconnection_getdeviceselector_838466080.md).

## -see-also

[AudioPlaybackConnection](audioplaybackconnection.md)

## -examples

