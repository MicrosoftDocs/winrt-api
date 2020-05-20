---
-api-id: P:Windows.Media.Audio.AudioPlaybackConnection.DeviceId
-api-type: winrt property
---

## -description

Gets the unique device ID for the underlying device represented by the [AudioPlaybackConnection](audioplaybackconnection.md). 

## -property-value

The unique device ID for the underlying device represented by the **AudioPlaybackConnection**.

## -remarks

The returned ID is the same ID used to create the connection in the call to [TryCreateFromId](audioplaybackconnection_trycreatefromid_1104379169.md). If the connection was created from a transport that does not have a corresponding transport device, then this property’s value is an empty string. 

## -see-also

## -examples

