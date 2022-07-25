---
-api-id: E:Windows.UI.Xaml.Controls.ScrollViewer.ViewChanged
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.EventHandler ViewChanged<Windows.UI.Xaml.Controls.ScrollViewerViewChangedEventArgs>
-->

# Windows.UI.Xaml.Controls.ScrollViewer.ViewChanged

## -description
Occurs when manipulations such as scrolling and zooming have caused the view to change.



## -xaml-syntax
```xaml
<ScrollViewer ViewChanged="eventhandler"/>
```


## -remarks
[ViewChanging](scrollviewer_viewchanging.md) fires before ViewChanged.

In your event handler, use a parameter of type [ScrollViewerViewChangedEventArgs](scrollviewerviewchangedeventargs.md) for the second parameter of your handler method. [ScrollViewerViewChangedEventArgs](scrollviewerviewchangedeventargs.md) includes the [IsIntermediate](scrollviewerviewchangedeventargs_isintermediate.md) property, which reports whether the manipulation that fired the event is completed or still ongoing.

Not every underlying manipulation will necessarily fire this event. The class logic delays and consolidates intermediate events into a single occurrence in some cases.

## -examples

## -see-also
[ScrollViewerViewChangedEventArgs](scrollviewerviewchangedeventargs.md), [ViewChanging](scrollviewer_viewchanging.md)
