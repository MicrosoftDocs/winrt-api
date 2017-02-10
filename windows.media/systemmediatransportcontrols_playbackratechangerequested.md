---
-api-id: E:Windows.Media.SystemMediaTransportControls.PlaybackRateChangeRequested
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler PlaybackRateChangeRequested<Windows.Media.SystemMediaTransportControls,  Windows.Media.PlaybackRateChangeRequestedEventArgs>
-->

# Windows.Media.SystemMediaTransportControls.PlaybackRateChangeRequested

## -description
Occurs when the user modifies the [SystemMediaTransportControls](systemmediatransportcontrols.md) playback rate.

## -remarks
Registering for this event causes an app to be notified when the **SystemMediaTransportControls** playback rate changes. An app can change its playback rate based on the request or ignore the request and update the **SystemMediaTransportControls** by setting the [PlaybackRate](systemmediatransportcontrols_playbackrate.md) property to a value that reflects the app's actual playback rate.

## -examples

## -see-also
