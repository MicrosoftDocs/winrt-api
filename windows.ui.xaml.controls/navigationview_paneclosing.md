---
-api-id: E:Windows.UI.Xaml.Controls.NavigationView.PaneClosing
-api-type: winrt event
---

<!-- Event syntax.
public event TypedEventHandler PaneClosing<NavigationView, NavigationViewPaneClosingEventArgs>
-->

# Windows.UI.Xaml.Controls.NavigationView.PaneClosing

## -description

Occurs when the [NavigationView](navigationview.md) pane is closing.

## -xaml-syntax

```xaml
<navigationView PaneClosing="eventhandler"/>
```

## -remarks

Set the [NavigationViewPaneClosingEventArgs.Cancel](navigationviewpaneclosingeventargs_cancel.md) property to **true** in a handler for this event in order to cancel a [navigationView](navigationview.md) pane closing action.

## -examples

## -see-also

[PaneClosed](navigationview_paneclosed.md)
