---
-api-id: M:Windows.ApplicationModel.Calls.PhoneVoicemail.DialVoicemailAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction DialVoicemailAsync()
-->

# Windows.ApplicationModel.Calls.PhoneVoicemail.DialVoicemailAsync

## -description
Dials a call to the voice mail access number.

## -returns
An asynchronous dial operation.

## -remarks
In order to use this method, the calling application needs to be in the foreground. In addition, the [PhoneLine](phoneline.md) instance needs to support outbound calls. Use [CanDial](phoneline_candial.md) to verify whether or not that is supported.

## -examples

## -see-also
