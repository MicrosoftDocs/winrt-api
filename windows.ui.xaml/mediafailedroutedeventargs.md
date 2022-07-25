---
-api-id: T:Windows.UI.Xaml.MediaFailedRoutedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class MediaFailedRoutedEventArgs : Windows.UI.Xaml.ExceptionRoutedEventArgs, Windows.UI.Xaml.IMediaFailedRoutedEventArgs
-->

# Windows.UI.Xaml.MediaFailedRoutedEventArgs

## -description
Provides event data for media failed events.



## -remarks
MediaFailedRoutedEventArgs is the event data for the [MediaFailed](../windows.ui.xaml.controls/mediaelement_mediafailed.md) event. MediaFailedRoutedEventArgs extends [ExceptionRoutedEventArgs](exceptionroutedeventargs.md) by adding the [ErrorTrace](mediafailedroutedeventargs_errortrace.md) property. In a handler for [MediaFailed](../windows.ui.xaml.controls/mediaelement_mediafailed.md), cast the [ExceptionRoutedEventArgs](exceptionroutedeventargs.md) data as MediaFailedRoutedEventArgs so that you can use the [ErrorTrace](mediafailedroutedeventargs_errortrace.md) information. Otherwise, if you're only interested in the message, you can access [ErrorMessage](exceptionroutedeventargs_errormessage.md) without casting.

## -examples

## -see-also
[ExceptionRoutedEventArgs](exceptionroutedeventargs.md), [MediaFailed](../windows.ui.xaml.controls/mediaelement_mediafailed.md)
