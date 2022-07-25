---
-api-id: E:Windows.UI.Xaml.Controls.SplitView.PaneClosing
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler PaneClosing<Windows.UI.Xaml.Controls.SplitView,  Windows.UI.Xaml.Controls.SplitViewPaneClosingEventArgs>
-->

# Windows.UI.Xaml.Controls.SplitView.PaneClosing

## -description
Occurs when the [SplitView](splitview.md) pane is closing.



## -xaml-syntax
```xaml

      <SplitView PaneClosing="eventhandler"/>
    
```


## -remarks
Set the [SplitViewPaneClosingEventArgs.Cancel](splitviewpaneclosingeventargs_cancel.md) property to **true** in a handler for this event in order to cancel a [SplitView](splitview.md) pane closing action.

## -examples

## -see-also
[PaneClosed](splitview_paneclosed.md)
