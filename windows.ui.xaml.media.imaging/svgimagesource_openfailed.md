---
-api-id: E:Windows.UI.Xaml.Media.Imaging.SvgImageSource.OpenFailed
-api-type: winrt event
---

<!-- Event syntax.
public event TypedEventHandler OpenFailed<SvgImageSource, SvgImageSourceFailedEventArgs>
-->

# Windows.UI.Xaml.Media.Imaging.SvgImageSource.OpenFailed

## -description
Occurs when there is an error associated with SVG retrieval or format.



## -xaml-syntax
```xaml
<SvgImageSource OpenFailed="eventhandler"/>
```

## -remarks
You can use the OpenFailed event to determine why the SVG didn't load correctly by checking the [SvgImageSourceFailedEventArgs](svgimagesourcefailedeventargs.md), which contain error information in the [Status](svgimagesourcefailedeventargs_status.md) property.
One scenario for handling OpenFailed is to set the [UriSource](svgimagesource_urisource.md) to a different local SVG source file that can serve as a fallback value. For example, if you are trying to display an external image where it's possible that either the source is no longer there, the user has no Internet connection,
or the SVG source is not in the correct format, you could set the [UriSource](svgimagesource_urisource.md) to reference a local fallback or placeholder SVG that's part of your app package and is always guaranteed to be available.

```csharp
private void SvgImageSource_OpenFailed(SvgImageSource sender, SvgImageSourceFailedEventArgs args) {
    if(args.Status != SvgImageSourceLoadStatus.Success) {
        sender.UriSource = new Uri("ms-appx:///Assets/fallback.svg");
    }
}

```


