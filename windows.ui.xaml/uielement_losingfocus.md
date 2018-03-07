---
-api-id: E:Windows.UI.Xaml.UIElement.LosingFocus
-api-type: winrt event
---

<!-- Event syntax.
public event TypedEventHandler LosingFocus<UIElement, LosingFocusEventArgs>
-->

# Windows.UI.Xaml.UIElement.LosingFocus

## -description
Occurs before a [UIElement](uielement.md) loses focus.

## -xaml-syntax

```xaml
<uiElement LosingFocus="eventhandler"/>
```

## -remarks
[FocusNavigationDirection.Previous](focusnavigationdirection.md) and [FocusNavigationDirection.Next](focusnavigationdirection.md) cannot be used with [FindNextElementOptions](findnextelementoptions.md). Only [FocusNavigationDirection.Up](focusnavigationdirection.md), [FocusNavigationDirection.Down](focusnavigationdirection.md), [FocusNavigationDirection.Left](focusnavigationdirection.md), or [FocusNavigationDirection.Right](focusnavigationdirection.md) are valid.

## -see-also
[LosingFocusEventArgs](..\windows.ui.xaml.input\losingfocuseventargs.md), [LostFocus](uielement_lostfocus.md)

## -examples

