---
-api-id: E:Windows.UI.Xaml.Window.SizeChanged
-api-type: winrt event
---

<!-- Event syntax
public event Windows.UI.Xaml.WindowSizeChangedEventHandler SizeChanged
-->

# Windows.UI.Xaml.Window.SizeChanged

## -description
Occurs when the app window has first rendered or has changed its rendering size.



## -remarks
This event occurs whenever there are changes in the [Bounds](window_bounds.md) values for the app window. This might be because the user resizes your app or changes the display orientation. Another trigger is if the user moves your app to a new display that has a different resolution and the app window expands to fill it.

Window.SizeChanged is the event to handle in order to detect that the user has deliberately resized your app or rotated the display on a PC that detects orientation. You may want to detect that the app window has changed from landscape to portrait orientation or vice versa. The app window orientation might influence how you want the individual controls within the app window to appear. For example, you might want to display data lists in a [ListView](../windows.ui.xaml.controls/listview.md) for portrait orientation, but in a [GridView](../windows.ui.xaml.controls/gridview.md) for landscape orientation. Typically you would compare the ratio of `Window.Current.Bounds.Width` to `Window.Current.Bounds.Height` in order to determine the orientation based on the [Bounds](window_bounds.md), and you'd do this whenever Window.SizeChanged fires. Exactly how you interpret width/height ratios is up to you.

If you're attaching handlers for Window.SizeChanged at the [Page](../windows.ui.xaml.controls/page.md) level within a handler for the [FrameworkElement.Loaded](frameworkelement_loaded.md) event, you should detach those handlers in a [FrameworkElement.Unloaded](frameworkelement_unloaded.md) event handler from that [Page](../windows.ui.xaml.controls/page.md). The [Window.Current](window_current.md) instance remains active between page navigations and should only have a handler active for the most current page code.


<!--Do we need further justification? Not sure it is an outright leak so don't want to state that.-->
A Window.SizeChanged handler is not how you enforce the minimum size that your app can be resized to. That's controlled by the app manifest. However, your logic for changing the visual states should be able to load a state that's designed for the minimum width you intended, and you'd typically use the [Bounds](window_bounds.md) values and Window.SizeChanged handling to detect when the app window is using minimum width.

For more info on how to use Window.SizeChanged to detect changes in the app window environment and load the appropriate visual states for your app, see [Quickstart: Designing apps for different window sizes](/previous-versions/windows/apps/dn297195(v=win.10)).


<!--Are there any VS templates that add default Window.SizeChanged anymore? This was in the old layoutawarepage but not the new one. And yet it seems like pretty important basic app functionality, just as important as the nav and suspension support-->

<!--Does SizeChanged fire on suspension/close? It appears it does but want to verify-->
There's another event named [SizeChanged](frameworkelement_sizechanged.md) that exists on [FrameworkElement](frameworkelement.md) derived types ([Window](window.md) is not a [FrameworkElement](frameworkelement.md) type). [FrameworkElement.SizeChanged](frameworkelement_sizechanged.md) events might fire in many of the same circumstances that cause Window.SizeChanged to fire. An app window size change can cause the root visual element (typically a [Page](../windows.ui.xaml.controls/page.md) or panel) to change its size. This sets off a cascade of layout invalidations for any the subelements that are using adaptive layout to fill available space. Each element that has new dimensions because of a layout pass will fire its own [FrameworkElement.SizeChanged](frameworkelement_sizechanged.md) event.


<!--More work to do here. How does FE.SizeChanged relate? For device orientation change, should be pointing to DisplayInformation.OrientationChanged? It may be that a mix of all three events is what's really needed to account for all resize scenarios.-->

<!--The data in WindowSizeChangedEventArgs seems pretty useless for most scenarios especially if you use Window.Current.Bounds instead of WindowSizeChangedEventArgs.Size. And when would you set to Handled, what does that even do?-->

## -examples

## -see-also
[Window.Bounds](window_bounds.md), [Window.Content](window_content.md), [FrameworkElement.SizeChanged](frameworkelement_sizechanged.md), [Quickstart: Designing apps for different window sizes](/previous-versions/windows/apps/dn297195(v=win.10)), [WindowSizeChangedEventArgs](../windows.ui.core/windowsizechangedeventargs.md)
