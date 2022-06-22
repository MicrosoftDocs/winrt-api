---
-api-id: M:Windows.UI.Xaml.Input.FocusManager.FindNextFocusableElement(Windows.UI.Xaml.Input.FocusNavigationDirection,Windows.Foundation.Rect)
-api-type: winrt method
---

<!-- Method syntax
public Windows.UI.Xaml.UIElement FindNextFocusableElement(Windows.UI.Xaml.Input.FocusNavigationDirection focusNavigationDirection, Windows.Foundation.Rect hintRect)
-->

# Windows.UI.Xaml.Input.FocusManager.FindNextFocusableElement

## -description

Retrieves the element that should receive focus based on the specified navigation direction and hint rectangle.



## -parameters

### -param focusNavigationDirection

The direction that focus moves from element to element within the app UI.

### -param hintRect

A bounding rectangle used to influence which element is most likely to be considered the next to receive focus. Examples where this can be useful include:

- When no element currently has focus, specifying a small rectangle at a screen location of (-1, -1) starts focus from the upper left corner of the display.
- In a program guide where you want to ensure programs at the current time receive focus. (The focus algorithm might favor shows at a later time based on a number of factors.)

## -returns

**null** if focus cannot be set in the specified direction.

## -remarks

You can also use either the [FindNextElement(FocusNavigationDirection, FindNextElementOptions)](focusmanager_findnextelement_918683319.md) method or the [FindNextElement(FocusNavigationDirection)](focusmanager_findnextelement_1379272417.md) method to programmatically move focus. These methods retrieve the element (as a [DependencyObject](../windows.ui.xaml/dependencyobject.md)) that will receive focus based on the specified navigation direction (directional navigation only, cannot be used to emulate tab navigation).

> [!NOTE]
> We recommend using the FindNextElement method instead of FindNextFocusableElement because FindNextFocusableElement retrieves a UIElement, which returns null if the next focusable element is not a UIElement (such as a [Hyperlink](../windows.ui.xaml.documents/hyperlink.md) object).

## -examples

## -see-also

[FindNextFocusableElement(FocusNavigationDirection)](focusmanager_findnextfocusableelement_745990299.md), [Keyboard interactions](/windows/uwp/design/input/keyboard-interactions), [Focus navigation for keyboard, gamepad, remote control, and accessibility tools](/windows/uwp/design/input/focus-navigation), [Programmatic focus navigation](/windows/uwp/design/input/focus-navigation-programmatic)
