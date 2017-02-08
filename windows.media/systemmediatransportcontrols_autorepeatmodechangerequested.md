---
-api-id: E:Windows.Media.SystemMediaTransportControls.AutoRepeatModeChangeRequested
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler AutoRepeatModeChangeRequested<Windows.Media.SystemMediaTransportControls,  Windows.Media.AutoRepeatModeChangeRequestedEventArgs>
-->

# Windows.Media.SystemMediaTransportControls.AutoRepeatModeChangeRequested

## -description
Occurs when the user modifies the [SystemMediaTransportControls](systemmediatransportcontrols.md) auto-repeat mode.

## -remarks
Registering for this event causes an app to be notified when the **SystemMediaTransportControls** auto-repeat mode changes. An app can change its auto-repeat behavior based on the request or ignore the request and update the **SystemMediaTransportControls** by setting the [AutoRepeatMode](mediaplaybackautorepeatmode.md) property to a value that reflects the app's actual auto-repeat state.

## -examples

## -see-also
