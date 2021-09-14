---
-api-id: T:Windows.UI.Xaml.Media.Imaging.RenderTargetBitmap
-api-type: winrt class
---

<!-- Class syntax.
public class RenderTargetBitmap : Windows.UI.Xaml.Media.ImageSource, Windows.UI.Xaml.Media.Imaging.IRenderTargetBitmap
-->

# Windows.UI.Xaml.Media.Imaging.RenderTargetBitmap

## -description
Represents an image source that can be populated with the combined contents of a XAML visual tree. See  for some notable limitations on which XAML visuals can be captured in a RenderTargetBitmap.


## -remarks
Using a RenderTargetBitmap, you can accomplish scenarios such as applying image effects to a visual that originally came from a XAML UI composition, generating thumbnail images of child pages for a navigation system, or enabling the user to save parts of the UI as an image source and then share that image with other apps.

Because RenderTargetBitmap is a subclass of [ImageSource](../windows.ui.xaml.media/imagesource.md), it can be used as the image source for [Image](../windows.ui.xaml.controls/image.md) elements or an [ImageBrush](../windows.ui.xaml.media/imagebrush.md) brush.

Calling [RenderAsync](rendertargetbitmap_renderasync_1804035726.md) provides a useful image source but the full buffer representation of rendering content is not copied out of video memory until the app calls [GetPixelsAsync](rendertargetbitmap_getpixelsasync_1480284075.md). It is faster to call [RenderAsync](rendertargetbitmap_renderasync_1804035726.md) only (without calling [GetPixelsAsync](rendertargetbitmap_getpixelsasync_1480284075.md)) and use the RenderTargetBitmap as an [Image](../windows.ui.xaml.controls/image.md) or [ImageBrush](../windows.ui.xaml.media/imagebrush.md) source if the app only intends to display the rendered content and does not need the pixel data. You probably do need the pixel data if you intend to capture the image for a [DataTransferManager](../windows.applicationmodel.datatransfer/datatransfermanager.md) operation such as a Share contract exchange, or if you want to apply effects to the image or transcode it using the [Windows.Graphics.Imaging](../windows.graphics.imaging/windows_graphics_imaging.md)API.

The RenderTargetBitmap  API you'll use the most often is [RenderAsync](rendertargetbitmap_renderasync_1804035726.md). There are two overloads of this method: [RenderAsync(UIElement)](rendertargetbitmap_renderasync_1804035726.md) and [another overload](rendertargetbitmap_renderasync_806843678.md) where you can specify the desired dimensions of the image source to be different than the natural size of the source visual tree. [RenderAsync](rendertargetbitmap_renderasync_1804035726.md) is an async method by design, so there's no guarantee of exact frame synchronization with the UI source, but it's close enough timing-wise for most scenarios.

<!--If you want your image to be larger or smaller than the XAML source, you should use this second overload to do your sizing rather than applying a <xref targtype="class_winrt" rid="w_ui_xaml_med.scaletransform"  xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">ScaleTransform</xref> or altering the <xref targtype="class_winrt" rid="w_ui_xaml_ctrl.image">Image</xref> or <xref targtype="class_winrt" rid="w_ui_xaml_med_img.bitmapimage">BitmapImage</xref> width/height versus the natural size. The <xref targtype="method_winrt" rid="w_ui_xaml_med_img.rendertargetbitmap_renderasync_806843678">RenderAsync</xref> call has access to lower-level info about the visual content that will generate a better-quality snapshot at your desired sizing than could be achieved by other sizing techniques.-->

A RenderTargetBitmap object isn't typically declared in a XAML UI, because you need to call [RenderAsync](rendertargetbitmap_renderasync_1804035726.md) in code before you have a useful, image-populated instance of RenderTargetBitmap for UI display purposes.

For more code examples of using RenderTargetBitmap, see [XAML render to bitmap sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/XAML%20render%20to%20bitmap%20sample).

The contents of a RenderTargetBitmap can be lost in rare cases because of interaction with other lower-level systems, for example if the video driver is reset as part of a recovery (see [Timeout Detection and Recovery (TDR)](XREF:TODO:display.timeout_detection_and_recovery)). If that happens, the [CompositionTarget.SurfaceContentsLost](../windows.ui.xaml.media/compositiontarget_surfacecontentslost.md) event will fire. To account for this case and similar info-loss cases, apps should listen for the [CompositionTarget.SurfaceContentsLost](../windows.ui.xaml.media/compositiontarget_surfacecontentslost.md) event and re-render the contents of a RenderTargetBitmap by calling [RenderAsync](rendertargetbitmap_renderasync_1804035726.md) again.

The rendered bitmap contents of a RenderTargetBitmap do not automatically scale when the current DPI setting changes. Apps should re-render the contents of a RenderTargetBitmap when the current view's DPI setting changes in order to ensure that the rendered vector content remains crisp. For example, a resize can occur if the user moves an app between two monitors running at a different DPI setting. Consider listening for the [DisplayInformation.DpiChanged](../windows.graphics.display/displayinformation_dpichanged.md) event to detect these cases.

The maximum rendered size of a XAML visual tree is restricted by the maximum dimensions of a Microsoft DirectX texture; for more info see [Resource Limits (Direct3D 11)](/windows/desktop/direct3d11/overviews-direct3d-11-resources-limits). This limit can vary depending on the hardware where the app runs. Very large content that exceeds this limit might be scaled to fit. If scaling limits are applied in this way, the rendered size after scaling can be queried using the [PixelWidth](rendertargetbitmap_pixelwidth.md) and [PixelHeight](rendertargetbitmap_pixelheight.md) properties. For example, a 10000 by 10000 pixel XAML visual tree might be scaled to 4096 by 4096 pixels, an example of a particular limit as forced by the hardware where the app runs.

### XAML visuals and **RenderTargetBitmap** capture capabilities

There are a few scenarios for XAML-composed visual content that you can't capture to a RenderTargetBitmap:
+ Content that's in the tree but with its [Visibility](../windows.ui.xaml/uielement_visibility.md) set to **Collapsed** won't be captured.
+ Content that's not directly connected to the XAML visual tree and the content of the main window won't be captured. This includes [Popup](../windows.ui.xaml.controls.primitives/popup.md) content, which is considered to be like a sub-window.
+ Content that can't be captured will appear as blank in the captured image, but other content in the same visual tree can still be captured and will render (the presence of content that can't be captured won't invalidate the entire capture of that XAML composition).
+ Content that's in the XAML visual tree but offscreen can be captured, so long as it's not [Visibility](../windows.ui.xaml/uielement_visibility.md) = **Collapsed**.

## -examples
This basic code outline is adapted from the first scenario XAML and code of the [XAML render to bitmap sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/XAML%20render%20to%20bitmap%20sample). Note how all the code, even the constructor, is within an **async** method. Here it's an event handler for a button that a user clicks to initiate the rendering request.

```xaml
<StackPanel> 
  <Button Content="Save as image source" Click="SaveImageSource_Click"/> 
...
  <Grid x:Name="RenderedGrid" Height="500"/>
  <!--user adds child-item content to this Grid using other code, not shown-->
...
  <Image x:Name="RenderedImage" Stretch="None"/>
  <!-- this Image has no Source yet, will be set by a RenderTargetBitmap.RenderAsync call --> 
</StackPanel> 

```

```csharp
private async void SaveImageSource_Click(object sender, RoutedEventArgs e) 
{                        
...
    RenderTargetBitmap renderTargetBitmap = new RenderTargetBitmap(); 
    await renderTargetBitmap.RenderAsync(RenderedGrid, width, height); 
    RenderedImage.Source = renderTargetBitmap; 
}
```



## -see-also
[ImageSource](../windows.ui.xaml.media/imagesource.md), [XAML render to bitmap sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/XAML%20render%20to%20bitmap%20sample), [Image and ImageBrush](/windows/uwp/controls-and-patterns/images-imagebrushes), [RenderAsync(UIElement)](rendertargetbitmap_renderasync_1804035726.md)
