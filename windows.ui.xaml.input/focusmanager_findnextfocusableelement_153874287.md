---
-api-id: M:Windows.UI.Xaml.Input.FocusManager.FindNextFocusableElement(Windows.UI.Xaml.Input.FocusNavigationDirection,Windows.Foundation.Rect)
-api-type: winrt method
---

<!-- Method syntax
public Windows.UI.Xaml.UIElement FindNextFocusableElement(Windows.UI.Xaml.Input.FocusNavigationDirection focusNavigationDirection, Windows.Foundation.Rect hintRect)
-->

# Windows.UI.Xaml.Input.FocusManager.FindNextFocusableElement

## -description
Retrieves the element that will receive focus based on the specified navigation direction and hint rectangle.

## -parameters
### -param focusNavigationDirection
The direction that focus moves from element to element within the app UI.

### -param hintRect
A bounding rectangle used to influence which element is most likely to be considered the next to receive focus. Examples where this can be useful include:
+ When no element currently has focus, specifying a small rectangle at a screen location of (-1, -1) starts focus from the upper left corner of the display.
+ In a program guide where you want to ensure programs at the current time receive focus. (The focus algorithm might favor shows at a later time based on a number of factors.)


## -returns
**null** if focus cannot be set in the specified direction.

## -remarks

## -examples

## -see-also
[FindNextFocusableElement(FocusNavigationDirection)](focusmanager_findnextfocusableelement_745990299.md)