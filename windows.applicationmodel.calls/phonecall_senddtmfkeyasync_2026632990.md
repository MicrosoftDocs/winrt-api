---
-api-id: M:Windows.ApplicationModel.Calls.PhoneCall.SendDtmfKeyAsync(Windows.ApplicationModel.Calls.DtmfKey,Windows.ApplicationModel.Calls.DtmfToneAudioPlayback)
-api-type: winrt method
---

# Windows.ApplicationModel.Calls.PhoneCall.SendDtmfKeyAsync(Windows.ApplicationModel.Calls.DtmfKey,Windows.ApplicationModel.Calls.DtmfToneAudioPlayback)

<!--
public Windows.Foundation.IAsyncOperation<Windows.ApplicationModel.Calls.PhoneCallOperationStatus> SendDtmfKeyAsync (Windows.ApplicationModel.Calls.DtmfKey key, Windows.ApplicationModel.Calls.DtmfToneAudioPlayback dtmfToneAudioPlayback);
-->

## -description

Asynchronously sends the specified dual tone multi-frequency (DTMF) character to the phone call. Only short tones (burst) are supported.

## -parameters

### -param key

A [DtmfKey](dtmfkey.md) object representing the DTMF character to send.

### -param dtmfToneAudioPlayback

A [DtmfToneAudioPlayback](dtmftoneaudioplayback.md) object specifying whether or not the audio for the DTMF tones should be played back on the local device.

## -returns

An asynchronous operation object which, when it completes, contains a [PhoneCallOperationStatus](phonecalloperationstatus.md) object representing the status of the phone call.

## -remarks

## -see-also

## -examples

## -capabilities
phoneCall
