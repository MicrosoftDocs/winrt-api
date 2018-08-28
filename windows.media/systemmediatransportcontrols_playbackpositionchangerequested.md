---
-api-id: E:Windows.Media.SystemMediaTransportControls.PlaybackPositionChangeRequested
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler PlaybackPositionChangeRequested<Windows.Media.SystemMediaTransportControls,  Windows.Media.PlaybackPositionChangeRequestedEventArgs>
-->

# Windows.Media.SystemMediaTransportControls.PlaybackPositionChangeRequested

## -description
Occurs when the user modifies the playback position of the [SystemMediaTransportControls](systemmediatransportcontrols.md).

## -remarks
Registering for this event causes an app to be notified when the **SystemMediaTransportControls** playback position changes. An app can change its auto-repeat behavior based on the request or ignore the request and update the **SystemMediaTransportControls** by populating a [SystemMediaTransportControlsTimelineProperties](systemmediatransportcontrolstimelineproperties.md) object with values indicating the actual playback position and calling [SystemMediaTransportControls.UpdateTimelineProperties](systemmediatransportcontrols_updatetimelineproperties_1933562266.md).

## -examples

## -see-also
