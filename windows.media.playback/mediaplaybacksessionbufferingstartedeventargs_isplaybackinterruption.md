---
-api-id: P:Windows.Media.Playback.MediaPlaybackSessionBufferingStartedEventArgs.IsPlaybackInterruption
-api-type: winrt property
---

<!-- Property syntax.
public bool IsPlaybackInterruption { get; }
-->

# Windows.Media.Playback.MediaPlaybackSessionBufferingStartedEventArgs.IsPlaybackInterruption

## -description
Gets a value indicating whether the buffering that triggered the event was expected by the system, such as when a new item begins playing or after the user seeks to a new position in the media item, or if it was an unexpected interruption, such as when buffering is caused by degradation of the network connection.

## -property-value
True if the buffering represents an unexpected playback interruption. False if the buffering was an expected result of normal playback operations.

## -remarks
Media playback apps that implement a custom UI typically update their UI when buffering occurs to inform the user. Checking the value of this property allows you to choose to only display buffering UI for unexpected buffering interruptions.

To maintain backwards compatibility, the **BufferingStarted** delegate signature receives the event args as a generic object. To get an instance of this class, use the [as](/dotnet/articles/csharp/language-reference/keywords/as) operator keyword (C#) or [dynamic_cast](/cpp/cpp/dynamic-cast-operator) (C++) to cast the *args* parameter to a **MediaPlaybackSessionBufferingStartedEventArgs**.

## -see-also

## -examples

