---
-api-id: P:Windows.UI.ViewManagement.InputPaneVisibilityEventArgs.EnsuredFocusedElementInView
-api-type: winrt property
---

<!-- Property syntax
public bool EnsuredFocusedElementInView { get;  set; }
-->

# Windows.UI.ViewManagement.InputPaneVisibilityEventArgs.EnsuredFocusedElementInView

## -description
Identifies whether the application has taken steps to ensure that the input pane doesn't cover the UI element that has focus.

## -property-value
True if the application has ensured that the input pane isn't covering the UI element that has focus; otherwise false.

## -remarks
If this property is false, Windows ensures that the input pane doesn't cover the focused element.

If you do the work to ensure that the focused element isn't covered, be sure to set this property to true to prevent Windows from trying to do the same work; otherwise, the results can be unpredictable.

## -examples

## -see-also
[Responding to the appearance of the on-screen keyboard sample](http://go.microsoft.com/fwlink/p/?linkid=231633)