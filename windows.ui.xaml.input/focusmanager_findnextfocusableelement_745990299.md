---
-api-id: M:Windows.UI.Xaml.Input.FocusManager.FindNextFocusableElement(Windows.UI.Xaml.Input.FocusNavigationDirection)
-api-type: winrt method
---

<!-- Method syntax
public Windows.UI.Xaml.UIElement FindNextFocusableElement(Windows.UI.Xaml.Input.FocusNavigationDirection focusNavigationDirection)
-->

# Windows.UI.Xaml.Input.FocusManager.FindNextFocusableElement

## -description

Retrieves the element that should receive focus based on the specified navigation direction.



## -parameters

### -param focusNavigationDirection

The direction that focus moves from element to element within the application UI.

## -returns

**null** if focus cannot be set in the specified direction.

## -remarks

You can also use either the [FindNextElement(FocusNavigationDirection, FindNextElementOptions)](focusmanager_findnextelement_918683319.md) method or the [FindNextElement(FocusNavigationDirection)](focusmanager_findnextelement_1379272417.md) method to programmatically move focus. These methods retrieve the element (as a [DependencyObject](../windows.ui.xaml/dependencyobject.md)) that will receive focus based on the specified navigation direction (directional navigation only, cannot be used to emulate tab navigation).

> [!NOTE]
> We recommend using the FindNextElement method instead of FindNextFocusableElement because FindNextFocusableElement retrieves a UIElement, which returns null if the next focusable element is not a UIElement (such as a [Hyperlink](../windows.ui.xaml.documents/hyperlink.md) object).

## -examples

## -see-also

[FindNextFocusableElement(FocusNavigationDirection, Rect)](focusmanager_findnextfocusableelement_153874287.md), [Keyboard interactions](/windows/uwp/design/input/keyboard-interactions), [Focus navigation for keyboard, gamepad, remote control, and accessibility tools](/windows/uwp/design/input/focus-navigation), [Programmatic focus navigation](/windows/uwp/design/input/focus-navigation-programmatic)
