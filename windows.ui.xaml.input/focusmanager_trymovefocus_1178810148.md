---
-api-id: M:Windows.UI.Xaml.Input.FocusManager.TryMoveFocus(Windows.UI.Xaml.Input.FocusNavigationDirection,Windows.UI.Xaml.Input.FindNextElementOptions)
-api-type: winrt method
---

<!-- Method syntax.
public bool FocusManager.TryMoveFocus(FocusNavigationDirection focusNavigationDirection, FindNextElementOptions focusNavigationOptions)
-->

# Windows.UI.Xaml.Input.FocusManager.TryMoveFocus

## -description

Attempts to change focus from the element with focus to the next focusable element in the specified direction, using the specified navigation options.



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

You can also use either the [FindNextElement(FocusNavigationDirection, FindNextElementOptions)](focusmanager_findnextelement_918683319.md) method or the [FindNextElement(FocusNavigationDirection)](focusmanager_findnextelement_1379272417.md) method to programmatically move focus. These methods retrieve the element (as a [DependencyObject](../windows.ui.xaml/dependencyobject.md)) that will receive focus based on the specified navigation direction (directional navigation only, cannot be used to emulate tab navigation).

> [!NOTE]
> We recommend using the FindNextElement method instead of FindNextFocusableElement because FindNextFocusableElement retrieves a UIElement, which returns null if the next focusable element is not a UIElement (such as a [Hyperlink](../windows.ui.xaml.documents/hyperlink.md) object).

## -see-also

[TryMoveFocus(Windows.UI.Xaml.Input.FocusNavigationDirection focusNavigationDirection)](focusmanager_trymovefocus_582274934.md), [Keyboard interactions](/windows/uwp/design/input/keyboard-interactions), [Focus navigation for keyboard, gamepad, remote control, and accessibility tools](/windows/uwp/design/input/focus-navigation), [Programmatic focus navigation](/windows/uwp/design/input/focus-navigation-programmatic)

## -examples
