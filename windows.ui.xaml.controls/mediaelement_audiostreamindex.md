---
-api-id: P:Windows.UI.Xaml.Controls.MediaElement.AudioStreamIndex
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.IReference<int> AudioStreamIndex { get;  set; }
-->

# Windows.UI.Xaml.Controls.MediaElement.AudioStreamIndex

## -description
Gets or sets the index of the audio stream that plays along with the video component. The collection of audio streams is composed at run time and represents all audio streams that are available in the media file.


## -xaml-syntax
```xaml
<MediaElement AudioStreamIndex="int"/>
```


## -property-value
The index in the media file of the audio component that plays along with the video component. The index can be unspecified, in which case the value is null. The default value is null.

<!--Projection dochack:-->
If you're programming using C#or Microsoft Visual Basic, the type of this property is projected as **int?**(a nullable integer).

## -remarks
Setting AudioStreamIndex to **null** selects the default audio track, which is defined by the content.




<!--<rem>See the <xref targtype="ovw" rid="m_media_mca.create_media_player">Quickstart: create a media player application</xref> and <xref targtype="howto-singlepage" rid="m_media_mca.select_audio_tracks">How to select audio tracks in different languages</xref> for examples of supporting multiple audio tracks.</rem>-->

## -examples

## -see-also
