---
-api-id: P:Windows.UI.Xaml.Controls.MediaElement.PlayToPreferredSourceUri
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Uri PlayToPreferredSourceUri { get;  set; }
-->

# Windows.UI.Xaml.Controls.MediaElement.PlayToPreferredSourceUri

## -description
> [!NOTE]
> **PlayToPreferredSourceUri** is deprecated. Instead, call [**MediaElement.GetAsCastingSource**](/uwp/api/windows.ui.xaml.controls.mediaelement.getascastingsource) and, on the returned value, call [**CastingSource.PreferredSourceUri**](/uwp/api/windows.media.casting.castingsource.preferredsourceuri).

Gets or sets the path to the preferred media source which enables the Play To target device to stream the media content, which can be DRM protected, from a different location, such as a cloud media server.

## -xaml-syntax
```xaml
<MediaElement PlayToPreferredSourceUri="uri" />
```

## -property-value
The path to the preferred media source.

## -remarks
[PlayToSource.PreferredSourceUri](../windows.media.playto/playtosource_preferredsourceuri.md) enables Play To by reference. This allows streaming content on the Play To target device from a different location, such as a cloud media server. This enables web pages and UWP app to play Digital Rights Management (DRM) protected content. The app specifies a preferred Uniform Resource Identifier (URI) that will be sent to the Play To target device. This Uniform Resource Identifier (URI) can point to a cloud based media server. If the [PlayToSource.PreferredSourceUri](../windows.media.playto/playtosource_preferredsourceuri.md) value is present, the Play To target device can stream content directly from the cloud, which can be Digital Rights Management (DRM) protected, instead of streaming content from the Windows machine which must be unprotected content.

A forward slash ("/") is appended to the Uniform Resource Identifier (URI) string when it is sent over the network to a Play To device. This is done to conform to Uniform Resource Identifier (URI) standards.

## -examples
Here is some code that shows how to set up Play To by reference.

```xaml
<MediaElement Source="http://www.contoso.com/videos/video.mp4" 
   PlayToPreferredSourceUri="http://www.contoso.com/catalogid=1234">
</MediaElement>
```

```csharp
MediaElement video = new MediaElement();

video.Source = 
    new Uri("http://www.contoso.com/videos/video.mp4");

video.PlayToPreferredSourceUri = 
    new Uri("http://www.contoso.com/catalogid=1234"); 
```

```cppcx
auto video = ref new Windows::UI::Xaml::Controls::MediaElement();

video->Source = 
   ref new Windows::Foundation::Uri("http://www.contoso.com/videos/video.mp4");

video->PlayToPreferredSourceUri = 
   ref new Windows::Foundation::Uri("http://www.contoso.com/catalogid=1234");
```

## -see-also
