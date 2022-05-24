---
-api-id: P:Windows.UI.Xaml.Controls.MediaElement.CurrentState
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Media.MediaElementState CurrentState { get; }
-->

# Windows.UI.Xaml.Controls.MediaElement.CurrentState

## -description
Gets the status of this [MediaElement](mediaelement.md).


## -property-value
The current state of this [MediaElement](mediaelement.md). The state can be one of the following (as defined in the [MediaElementState](../windows.ui.xaml.media/mediaelementstate.md) enumeration): **Buffering**, **Closed**, **Opening**, **Paused**, **Playing**, or **Stopped**. The default value is **Closed**.

## -remarks

## -examples
The following example demonstrates one way to display the CurrentState of a [MediaElement](mediaelement.md). It creates a [MediaElement](mediaelement.md) and several buttons for controlling media playback. To display the current state of the [MediaElement](mediaelement.md), the example registers for the [CurrentStateChanged](mediaelement_currentstatechanged.md) event and uses an event handler to update a [TextBlock](textblock.md).



[!code-xaml[media_ovw_controlling_media_with_currentstate](../windows.ui.xaml.controls/code/media_ovw_controlling_media_with_currentstate/csharp/Page.xaml#Snippetmedia_ovw_controlling_media_with_currentstate)]


[!code-csharp[media_ovw_controlling_media_with_currentstate_code](../windows.ui.xaml.controls/code/media_ovw_controlling_media_with_currentstate/csharp/Page.xaml.cs#Snippetmedia_ovw_controlling_media_with_currentstate_code)]

[!code-vb[media_ovw_controlling_media_with_currentstate_code](../windows.ui.xaml.controls/code/media_ovw_controlling_media_with_currentstate/vbnet/Page.xaml.vb#Snippetmedia_ovw_controlling_media_with_currentstate_code)]

## -see-also
