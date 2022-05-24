---
-api-id: E:Windows.UI.Xaml.Controls.MediaElement.PartialMediaFailureDetected
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler PartialMediaFailureDetected<Windows.UI.Xaml.Controls.MediaElement,  Windows.UI.Xaml.Media.PartialMediaFailureDetectedEventArgs>
-->

# Windows.UI.Xaml.Controls.MediaElement.PartialMediaFailureDetected

## -description
Occurs when one or more streams fails to decode in content containing multiple streams.


## -remarks
If at least one stream in the content is successfully decoded, the decoded media is played and this event is raised. If the stream that fails to decode is the only stream contained in the content, playback fails and the [MediaFailed](mediaelement_mediafailed.md) event is raised.

## -examples

## -see-also
