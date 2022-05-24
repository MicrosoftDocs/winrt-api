---
-api-id: T:Windows.UI.Xaml.Media.RateChangedRoutedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class RateChangedRoutedEventArgs : Windows.UI.Xaml.RoutedEventArgs, Windows.UI.Xaml.Media.IRateChangedRoutedEventArgs
-->

# Windows.UI.Xaml.Media.RateChangedRoutedEventArgs

## -description
Provides event data for the [RateChanged](../windows.ui.xaml.controls/mediaelement_ratechanged.md) event.


## -remarks
[RateChanged](../windows.ui.xaml.controls/mediaelement_ratechanged.md) event fires when [PlaybackRate](../windows.ui.xaml.controls/mediaelement_playbackrate.md) or [DefaultPlaybackRate](../windows.ui.xaml.controls/mediaelement_defaultplaybackrate.md) change.

The new [PlaybackRate](../windows.ui.xaml.controls/mediaelement_playbackrate.md) or [DefaultPlaybackRate](../windows.ui.xaml.controls/mediaelement_defaultplaybackrate.md) value, whichever property has changed, is not provided in the event data. Applications should query [PlaybackRate](../windows.ui.xaml.controls/mediaelement_playbackrate.md) or [DefaultPlaybackRate](../windows.ui.xaml.controls/mediaelement_defaultplaybackrate.md) inside the [RateChangedRoutedEventHandler](ratechangedroutedeventhandler.md) to obtain the new rate.

## -examples

## -see-also
[RoutedEventArgs](../windows.ui.xaml/routedeventargs.md)
