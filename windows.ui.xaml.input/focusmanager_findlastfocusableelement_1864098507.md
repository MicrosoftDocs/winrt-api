---
-api-id: M:Windows.UI.Xaml.Input.FocusManager.FindLastFocusableElement(Windows.UI.Xaml.DependencyObject)
-api-type: winrt method
---

<!-- Method syntax.
public DependencyObject FocusManager.FindLastFocusableElement(DependencyObject searchScope)
-->

# Windows.UI.Xaml.Input.FocusManager.FindLastFocusableElement

## -description

Retrieves the last element that can receive focus based on the specified scope.

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.Input.FocusManager.FindLastFocusableElement](/windows/winui/api/microsoft.ui.xaml.input.focusmanager.findlastfocusableelement) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -parameters

### -param searchScope

The root object from which to search. If **null**, the search scope is the current window.

## -returns

The last focusable object.

## -remarks

## -see-also

[FindFirstFocusableElement(DependencyObject searchScope)](focusmanager_findfirstfocusableelement_2071666361.md), [Keyboard interactions](/windows/uwp/design/input/keyboard-interactions), [Focus navigation for keyboard, gamepad, remote control, and accessibility tools](/windows/uwp/design/input/focus-navigation), [Programmatic focus navigation](/windows/uwp/design/input/focus-navigation-programmatic)

## -examples

