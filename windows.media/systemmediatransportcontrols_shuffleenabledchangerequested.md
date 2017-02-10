---
-api-id: E:Windows.Media.SystemMediaTransportControls.ShuffleEnabledChangeRequested
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler ShuffleEnabledChangeRequested<Windows.Media.SystemMediaTransportControls,  Windows.Media.ShuffleEnabledChangeRequestedEventArgs>
-->

# Windows.Media.SystemMediaTransportControls.ShuffleEnabledChangeRequested

## -description
Occurs when the user modifies the [SystemMediaTransportControls](systemmediatransportcontrols.md) shuffle state.

## -remarks
Registering for this event causes an app to be notified when the **SystemMediaTransportControls** shuffle state changes. An app can change its shuffle state based on the request or ignore the request and update the **SystemMediaTransportControls** by setting the [ShuffleEnabled](systemmediatransportcontrols_shuffleenabled.md) property to a value that reflects the app's actual shuffle state.

## -examples

## -see-also
