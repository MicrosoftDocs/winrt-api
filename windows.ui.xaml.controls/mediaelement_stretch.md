---
-api-id: P:Windows.UI.Xaml.Controls.MediaElement.Stretch
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Media.Stretch Stretch { get;  set; }
-->

# Windows.UI.Xaml.Controls.MediaElement.Stretch

## -description
Gets or sets a value that describes how an [MediaElement](mediaelement.md) should be stretched to fill the destination rectangle.


## -xaml-syntax
```xaml
<MediaElement Stretch="stretchMemberName" />
```


## -xaml-values
<dl><dt>stretchMemberName</dt><dd>stretchMemberNameA named constant of the Stretch enumeration, such as Fill.</dd>
</dl>
## -property-value
A value of the [Stretch](../windows.ui.xaml.media/stretch.md) enumeration that specifies how the source visual media is rendered. The default value is **Uniform**.

## -remarks
Here's what the [Stretch](../windows.ui.xaml.media/stretch.md) values represent for [MediaElement](mediaelement.md) content:
+ **None**: The original size of the content is preserved.
+ **Fill**: The content is resized to fill the destination dimensions. The aspect ratio of the video is not preserved.
+ **UniformToFill**: Uniformly stretches the [MediaElement](mediaelement.md) to fill the available layout space while preserving the aspect ratio of the content. If the aspect ratio of the destination rectangle differs from the source, the source content is clipped to fit the destination dimensions.
+ **Uniform**: Uniformly stretches the [MediaElement](mediaelement.md) to fill the layout space while preserve the aspect ratio of the image. This will ensure that the entire image is displayed, undistorted and not cropped. This may result in letterboxing or pillarboxing on the top or sides of the image, depending on the aspect ratio of the content.


## -examples
Here is some code that shows how to create a zoom effect, similar to [msZoom](XREF:TODO:wwa.HTMLVideoElement_msZoom) in Windows app using JavaScript. The [MediaElement](mediaelement.md) content will fill up the entire layout space while preserving the aspect ratio of the content. This could result in cropping if the aspect ratio of the content is not the same as the layout space.

```csharp
private void ToggleZoom(MediaElement media)
{
    if (media.Stretch != Stretch.UniformToFill)
    {
        // zoom
        media.Stretch = Stretch.UniformToFill;
    }
    else
    {
        // unzoom
        media.Stretch = Stretch.Uniform;
    }
}
```



## -see-also
[Stretch](../windows.ui.xaml.media/stretch.md), [NaturalVideoHeight](mediaelement_naturalvideoheight.md), [NaturalVideoWidth](mediaelement_naturalvideowidth.md)
