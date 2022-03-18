---
-api-id: E:Windows.UI.ViewManagement.InputPane.Showing
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler Showing<Windows.UI.ViewManagement.InputPane,  Windows.UI.ViewManagement.InputPaneVisibilityEventArgs>
-->

# Windows.UI.ViewManagement.InputPane.Showing

## -description
Occurs when the input pane starts sliding into view.

## -remarks
The system associates the input pane with the application window that was visible when you called the [GetForCurrentView](inputpane_getforcurrentview_1363600702.md) method. This implies that you must create a new input pane object and register for the Showing event each time you create a new window.

When the system calls your event handler, the input pane has not started to slide into view. After your event handler returns, the input pane starts to slide into view. If your event handler doesn't respond quickly enough (within 200 milliseconds), the input pane starts to slide into view without waiting for your event handler to return.

You can use the Showing event to create a custom user experience when the input pane is displayed. For example, in an instant messenger app, you might want to resize the chat window and input box to fit above the input pane so that the user never has to scroll to see new messages. If you do create a custom user experience, make sure to set the [EnsuredFocusedElementInView](inputpanevisibilityeventargs_ensuredfocusedelementinview.md) property on the event arguments to notify the app framework that you have handled the input pane event and it should not try to do so for you.

You should minimize the amount of work you do while the input pane is being shown because multiple animations and content resizes may be happening simultaneously. The more work you do during this period affects the overall system performance, causing a poor user experience.

## -examples

## -see-also
[InputPaneVisibilityEventArgs](inputpanevisibilityeventargs.md), [TryShow](inputpane_tryshow_1077566544.md)
