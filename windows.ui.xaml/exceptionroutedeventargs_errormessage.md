---
-api-id: P:Windows.UI.Xaml.ExceptionRoutedEventArgs.ErrorMessage
-api-type: winrt property
---

<!-- Property syntax
public string ErrorMessage { get; }
-->

# Windows.UI.Xaml.ExceptionRoutedEventArgs.ErrorMessage

## -description
Gets the message component of the exception, as a string.



## -property-value
The message component of the exception.

## -remarks
Don't display ErrorMessage strings to end users. Instead, use substrings and codes within the string to positively identify the error condition, and have your app take appropriate action or display user-appropriate information in the app UI.

## -examples
This example shows use of [ExceptionRoutedEventArgs](exceptionroutedeventargs.md) in a handler in order to get the **HResult** and error message. This is code that might support debugging and testing during development but wouldn't be found as-is in production code. Production code might take this example further though. For example, once you've isolated the **HResult** from the ErrorMessage, your app code could branch on the **HResult** values and provide notification to users of what went wrong and possible actions to take to correct the problem.



[!code-csharp[MediaPlayer_MediaFailedHandlers](../windows.ui.xaml/code/MediaPlayerQuickStart/csharp/MainPage.xaml.cs#SnippetMediaPlayer_MediaFailedHandlers)]

## -see-also
[MediaFailedRoutedEventArgs](mediafailedroutedeventargs.md), [ImageFailed](../windows.ui.xaml.controls/image_imagefailed.md)
