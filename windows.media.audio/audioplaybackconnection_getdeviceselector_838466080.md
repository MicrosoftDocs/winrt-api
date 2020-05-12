---
-api-id: M:Windows.Media.Audio.AudioPlaybackConnection.GetDeviceSelector
-api-type: winrt method
---

## -description

Gets an Advanced Query Syntax (AQS) string for that can be used to find devices for which an [AudioPlaybackConnection](audioplaybackconnection.md) can be created. 

## -returns

An AQS string.

## -remarks

Pass the returned string to the [DeviceInformation.CreateWatcher](/uwp/api/windows.devices.enumeration.deviceinformation.createwatcher) method to create a [DeviceWatcher](/uwp/api/Windows.Devices.Enumeration.DeviceWatcher) that will notify your app when devices are added or removed.

## -see-also

[DeviceInformation.CreateWatcher](/uwp/api/windows.devices.enumeration.deviceinformation.createwatcher)

[DeviceWatcher](/uwp/api/Windows.Devices.Enumeration.DeviceWatcher)

## -examples

