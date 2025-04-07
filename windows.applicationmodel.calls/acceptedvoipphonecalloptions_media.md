---
-api-id: P:Windows.ApplicationModel.Calls.AcceptedVoipPhoneCallOptions.Media
-api-type: winrt property
---

# Windows.ApplicationModel.Calls.AcceptedVoipPhoneCallOptions.Media

<!--
public Windows.ApplicationModel.Calls.VoipPhoneCallMedia Media { get; set; }
-->


## -description

Gets or sets the media types of the new incoming call (either audio and video or audio only).

## -property-value

The media types of the new incoming call (either audio and video or audio only). Use **Audio|Video** if the user should have the option of answering the call with outgoing video. That assumes that the user's device has a camera available for the app to use at the time the call arrives. If that's not the case, or the user should only use audio, then use **Audio**.

## -remarks

## -see-also

## -examples

## -capabilities
voipCall
