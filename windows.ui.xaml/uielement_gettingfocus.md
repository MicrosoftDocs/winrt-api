---
-api-id: E:Windows.UI.Xaml.UIElement.GettingFocus
-api-type: winrt event
---

<!-- Event syntax.
public event TypedEventHandler GettingFocus<UIElement, GettingFocusEventArgs>
-->

# Windows.UI.Xaml.UIElement.GettingFocus

## -description
Occurs before a [UIElement](uielement.md) receives focus.

## -xaml-syntax

```xaml
<uiElement GettingFocus="eventhandler"/>
```

## -remarks
[FocusNavigationDirection.Previous](focusnavigationdirection.md) and [FocusNavigationDirection.Next](focusnavigationdirection.md) cannot be used with [FindNextElementOptions](findnextelementoptions.md). Only [FocusNavigationDirection.Up](focusnavigationdirection.md), [FocusNavigationDirection.Down](focusnavigationdirection.md), [FocusNavigationDirection.Left](focusnavigationdirection.md), or [FocusNavigationDirection.Right](focusnavigationdirection.md) are valid.

## -see-also
[GettingFocusEventArgs](..\windows.ui.xaml.input\gettingfocuseventargs.md), [GotFocus](uielement_gotfocus.md)

## -examples

