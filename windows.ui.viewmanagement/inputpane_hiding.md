---
-api-id: E:Windows.UI.ViewManagement.InputPane.Hiding
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler Hiding<Windows.UI.ViewManagement.InputPane,  Windows.UI.ViewManagement.InputPaneVisibilityEventArgs>
-->

# Windows.UI.ViewManagement.InputPane.Hiding

## -description
Occurs when the input pane starts sliding out of view.

## -remarks
The system associates the input pane with the application window that was visible when you called the [GetForCurrentView](inputpane_getforcurrentview_1363600702.md) method. This implies that you must create a new input pane object and register for the [Showing](inputpane_showing.md) event each time you create a new window. You can use the Hiding event to undo changes you may have made to your app's layout during the [Showing](inputpane_showing.md) event.

When the system calls your event handler, the input pane has not started to slide out of view. After your event handler returns, the input pane starts to slide out of view. If your event handler doesn't respond quickly enough (within 200 milliseconds), the input pane starts to slide out of view without waiting for your event handler to return.

If you create a custom user experience for the input pane, make sure to set the [EnsuredFocusedElementInView](inputpanevisibilityeventargs_ensuredfocusedelementinview.md) property on the event arguments to notify the app framework that you have handled the input pane event and it should not try to do so for you.

You should minimize the amount of work you do while the input pane is being hidden because multiple animations and content resizes may be happening simultaneously. The more work you do during this period affects the overall system performance, causing a poor user experience.

## -examples

## -see-also
[InputPaneVisibilityEventArgs](inputpanevisibilityeventargs.md), [TryHide](inputpane_tryhide_42550069.md)
