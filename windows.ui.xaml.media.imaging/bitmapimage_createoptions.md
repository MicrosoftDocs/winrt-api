---
-api-id: P:Windows.UI.Xaml.Media.Imaging.BitmapImage.CreateOptions
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Media.Imaging.BitmapCreateOptions CreateOptions { get;  set; }
-->

# Windows.UI.Xaml.Media.Imaging.BitmapImage.CreateOptions

## -description
Gets or sets the [BitmapCreateOptions](bitmapcreateoptions.md) for a [BitmapImage](bitmapimage.md).



## -xaml-syntax
```xaml
<BitmapImage CreateOptions="bitmapCreateOptionsMemberName"/>
```


## -property-value
The [BitmapCreateOptions](bitmapcreateoptions.md) used for this [BitmapImage](bitmapimage.md). The default is **None**. With this default, a [BitmapImage](bitmapimage.md) uses cached content when it is available. For a [BitmapImage](bitmapimage.md) that is created by referencing an image source file by Uniform Resource Identifier (URI), the Uniform Resource Identifier (URI) controls the internal caching scheme.

## -remarks
The other possible value for CreateOptions is [BitmapCreateOptions.IgnoreImageCache](bitmapcreateoptions.md). You should only use [BitmapCreateOptions.IgnoreImageCache](bitmapcreateoptions.md) in cases where you know that the source image file as retrieved by Uniform Resource Identifier (URI) has the potential to change over time. Otherwise, setting CreateOptions to use [BitmapCreateOptions.IgnoreImageCache](bitmapcreateoptions.md) causes all newly retrieved image sources to be decoded again, which can negatively impact performance. [BitmapCreateOptions.IgnoreImageCache](bitmapcreateoptions.md) is typically only used by design tools that directly manipulate an image in a file location and need to enforce that any URI-determined content is always reloaded from the location, not from the cache.

## -examples

## -see-also
