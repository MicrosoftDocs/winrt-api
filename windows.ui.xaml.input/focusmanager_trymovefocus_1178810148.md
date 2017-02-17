---
-api-id: M:Windows.UI.Xaml.Input.FocusManager.TryMoveFocus(Windows.UI.Xaml.Input.FocusNavigationDirection,Windows.UI.Xaml.Input.FindNextElementOptions)
-api-type: winrt method
---

<!-- Method syntax.
public bool FocusManager.TryMoveFocus(FocusNavigationDirection focusNavigationDirection, FindNextElementOptions focusNavigationOptions)
-->

# Windows.UI.Xaml.Input.FocusManager.TryMoveFocus

## -description
Attempts to change focus from the element with focus to the next focusable element in both the specified direction and using the specified navigation options.

## -parameters

### -param focusNavigationDirection
The direction to traverse (in tab order).

### -param focusNavigationOptions
The options to help identify the next element to receive focus with keyboard/controller/remote navigation.

## -returns
**true** if focus moved; otherwise, **false**.

## -remarks
The tab order is the order in which a user moves from one control to another by pressing the Tab key (forward) or Shift+Tab (backward).

This method uses tab order sequence and behavior to traverse all focusable elements in the UI.

If the focus is on the first element in the tab order and [FocusNavigationDirection.Previous](focusnavigationdirection.md) is specified, focus moves to the last element.

If the focus is on the last element in the tab order and [FocusNavigationDirection.Next](focusnavigationdirection.md) is specified, focus moves to the first element.


## -see-also
- [TryMoveFocus(Windows.UI.Xaml.Input.FocusNavigationDirection focusNavigationDirection)](focusmanager_trymovefocus_582274934.md)

## -examples

