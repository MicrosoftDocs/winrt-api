---
-api-id: P:Windows.UI.Xaml.Controls.MediaPlayerPresenter.Stretch
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Media.Stretch Stretch { get;  set; }
-->

# Windows.UI.Xaml.Controls.MediaPlayerPresenter.Stretch

## -description
Gets or sets a value that describes how an [MediaPlayerPresenter](mediaplayerpresenter.md) should be stretched to fill the destination rectangle.


## -xaml-syntax
```xaml
<MediaPlayerPresenter Stretch="stretchMemberName" />
```


## -xaml-values
<dl><dt>stretchMemberName</dt><dd>stretchMemberNameA named constant of the Stretch enumeration, such as Fill.</dd>
</dl>
## -property-value
A value of the [Stretch](../windows.ui.xaml.media/stretch.md) enumeration that specifies how the source visual media is rendered. The default value is **Uniform**.

## -remarks
Here's what the [Stretch](../windows.ui.xaml.media/stretch.md) values represent for [MediaPlayerPresenter](mediaplayerpresenter.md) content:
+ **None**: The original size of the content is preserved.
+ **Fill**: The content is resized to fill the destination dimensions. The aspect ratio of the video is not preserved.
+ **UniformToFill**: Uniformly stretches the [MediaPlayerPresenter](mediaplayerpresenter.md) to fill the available layout space while preserving the aspect ratio of the content. If the aspect ratio of the destination rectangle differs from the source, the source content is clipped to fit the destination dimensions.
+ **Uniform**: Uniformly stretches the [MediaPlayerPresenter](mediaplayerpresenter.md) to fill the layout space while preserve the aspect ratio of the image. This will ensure that the entire image is displayed, undistorted and not cropped. This may result in letterboxing or pillarboxing on the top or sides of the image, depending on the aspect ratio of the content.


## -examples

## -see-also
