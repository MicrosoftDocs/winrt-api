---
-api-id: P:Windows.UI.Xaml.Input.GettingFocusEventArgs.Handled
-api-type: winrt property
---

<!-- Property syntax.
public bool Handled { get;  set; }
-->

# Windows.UI.Xaml.Input.GettingFocusEventArgs.Handled

## -description

Gets or sets a value that marks the routed event as handled. A **true** value for **Handled** prevents most handlers along the event route from handling the same event again.



## -property-value

**true** to mark the routed event handled. **false** to leave the routed event unhandled, which permits the event to potentially route further and be acted on by other handlers. The default is **false**.

## -remarks

## -see-also

[Keyboard interactions](/windows/uwp/design/input/keyboard-interactions), [Focus navigation for keyboard, gamepad, remote control, and accessibility tools](/windows/uwp/design/input/focus-navigation), [Programmatic focus navigation](/windows/uwp/design/input/focus-navigation-programmatic)

## -examples

