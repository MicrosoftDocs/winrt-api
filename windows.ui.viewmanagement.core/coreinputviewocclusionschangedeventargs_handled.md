---
-api-id: P:Windows.UI.ViewManagement.Core.CoreInputViewOcclusionsChangedEventArgs.Handled
-api-type: winrt property
---

<!-- Property syntax.
public bool Handled { get;  set; }
-->

# Windows.UI.ViewManagement.Core.CoreInputViewOcclusionsChangedEventArgs.Handled

## -description

Gets or sets a value that marks the event as handled. A **true** value for Handled prevents most handlers along the event route from handling the same event again.

## -property-value

**true** to mark the event handled. **false** to leave the event unhandled, which permits the event to potentially route further and be acted on by other handlers. The default is **false**.

## -remarks

Occluding events can be handled by your app first. If your app doesn't handle the events, they bubble up to any framework that needs to handle the events.

## -see-also

## -examples
