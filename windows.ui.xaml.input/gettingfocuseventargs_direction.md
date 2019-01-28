---
-api-id: P:Windows.UI.Xaml.Input.GettingFocusEventArgs.Direction
-api-type: winrt property
---

<!-- Property syntax.
public FocusNavigationDirection Direction { get; }
-->

# Windows.UI.Xaml.Input.GettingFocusEventArgs.Direction

## -description

Gets the direction that focus moved from element to element within the app UI.

## -property-value

The direction of focus movement.

## -remarks

[FocusNavigationDirection.Previous](focusnavigationdirection.md) and [FocusNavigationDirection.Next](focusnavigationdirection.md) cannot be used with [FindNextElementOptions](findnextelementoptions.md). Only [FocusNavigationDirection.Up](focusnavigationdirection.md), [FocusNavigationDirection.Down](focusnavigationdirection.md), [FocusNavigationDirection.Left](focusnavigationdirection.md), or [FocusNavigationDirection.Right](focusnavigationdirection.md) are valid.

## -see-also

[Keyboard interactions](https://docs.microsoft.com/windows/uwp/design/input/keyboard-interactions), [Focus navigation for keyboard, gamepad, remote control, and accessibility tools](https://docs.microsoft.com/windows/uwp/design/input/focus-navigation), [Programmatic focus navigation](https://docs.microsoft.com/windows/uwp/design/input/focus-navigation-programmatic)

## -examples

