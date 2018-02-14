---
-api-id: M:Windows.UI.Xaml.Input.FocusManager.FindNextElement(Windows.UI.Xaml.Input.FocusNavigationDirection,Windows.UI.Xaml.Input.FindNextElementOptions)
-api-type: winrt method
---

<!-- Method syntax.
public DependencyObject FocusManager.FindNextElement(FocusNavigationDirection focusNavigationDirection, FindNextElementOptions focusNavigationOptions)
-->

# Windows.UI.Xaml.Input.FocusManager.FindNextElement

## -description
Retrieves the element that will receive focus based on the specified navigation direction (cannot be used with tab navigation, see remarks).

## -parameters

### -param focusNavigationDirection
The direction that focus moves from element to element within the app UI.

### -param focusNavigationOptions
The options to help identify the next element to receive focus with keyboard/controller/remote navigation.

## -returns
The next object to receive focus.

## -remarks
We recommend using this method instead of [FindNextFocusableElement(FocusNavigationDirection, Rect)](focusmanager_findnextfocusableelement_153874287.md).

Tab navigation ([FocusNavigationDirection.Previous](focusnavigationdirection.md) and [FocusNavigationDirection.Next](focusnavigationdirection.md)) cannot be used with [FindNextElementOptions](findnextelementoptions.md). Only directional navigation ([FocusNavigationDirection.Up](focusnavigationdirection.md), [FocusNavigationDirection.Down](focusnavigationdirection.md), [FocusNavigationDirection.Left](focusnavigationdirection.md), or [FocusNavigationDirection.Right](focusnavigationdirection.md)) is valid.

## -see-also

## -examples

