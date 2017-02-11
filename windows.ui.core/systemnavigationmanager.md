---
-api-id: T:Windows.UI.Core.SystemNavigationManager
-api-type: winrt class
---

<!-- Class syntax.
public class SystemNavigationManager : Windows.UI.Core.ISystemNavigationManager, Windows.UI.Core.ISystemNavigationManager2
-->

# Windows.UI.Core.SystemNavigationManager

## -description
Provides a way for an app to respond to system provided back-navigation events.

## -remarks
The [SystemNavigationManager](systemnavigationmanager.md) lets you respond to user presses of the system provided back button such as a hardware button, or gestures and voice commands that activate the same event.

To enable your app to respond to the system back-navigation event, call [GetForCurrentView](systemnavigationmanager_getforcurrentview.md) to get the [SystemNavigationManager](systemnavigationmanager.md) object associated with the current view, then register an event handler for the [BackRequested](systemnavigationmanager_backrequested.md) event. Your app will receive the event only of it's the foreground app. If you handle the [BackRequested](systemnavigationmanager_backrequested.md) event, set the [BackRequestedEventArgs.Handled](backrequestedeventargs_handled.md) property to **true** to mark the event as handled. If you don't mark the event as handled, the system decides whether to navigate away from the app (on the Mobile device family) or ignore the event (on the Desktop device family).

If the device doesn't provide any back-navigation button, gesture, or command, the event is not raised.

## -examples

## -see-also
