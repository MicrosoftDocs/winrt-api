---
-api-id: E:Windows.Storage.Provider.CachedFileUpdaterUI.UIRequested
-api-type: winrt event
-api-device-family-note: xbox
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler UIRequested<Windows.Storage.Provider.CachedFileUpdaterUI,  object>
-->

# Windows.Storage.Provider.CachedFileUpdaterUI.UIRequested

## -description
Fires when the calling app needs to display the file picker letterbox UI that is represented by the [CachedFileUpdaterUI](cachedfileupdaterui.md) object.

A server may defer its UI initialization until it receives this event.

## -remarks
The app can register to be notified when this event fires by adding an event listener to the [CachedFileUpdaterUI](cachedfileupdaterui.md) object and declaring a handler function. If the app has registered an event handler for this event, it must respond when the event fires by initializing its UI.

## -examples

## -see-also
