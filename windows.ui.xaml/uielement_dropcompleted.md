---
-api-id: E:Windows.UI.Xaml.UIElement.DropCompleted
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler DropCompleted<Windows.UI.Xaml.UIElement,  Windows.UI.Xaml.DropCompletedEventArgs>
-->

# Windows.UI.Xaml.UIElement.DropCompleted

## -description

Occurs when a drag-and-drop operation is ended.

## -xaml-syntax

```xaml
<uiElement DropCompleted="eventhandler"/>
```

## -remarks

[DropCompleted](uielement_drop.md) is a routed event. An element must have [AllowDrop](uielement_allowdrop.md) be **true** to be a [DropCompleted](uielement_drop.md) event source. If the event is permitted to bubble up to parent elements because it goes unhandled, then it is possible to handle the event on a parent element if [AllowDrop](uielement_allowdrop.md) is **true** on the parent element. Intermediate elements in the route that aren't either the handler object or the drop target don't need [AllowDrop](uielement_allowdrop.md) to be **true**. For more info on the routed event concept, see [Events and routed events overview](https://docs.microsoft.com/windows/uwp/xaml-platform/events-and-routed-events-overview).

## -examples

## -see-also

[DropCompletedEventArgs](dropcompletedeventargs.md)