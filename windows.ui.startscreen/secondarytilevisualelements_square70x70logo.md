---
-api-id: P:Windows.UI.StartScreen.SecondaryTileVisualElements.Square70x70Logo
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.Foundation.Uri Square70x70Logo { get;  set; }
-->

# Windows.UI.StartScreen.SecondaryTileVisualElements.Square70x70Logo

## -description
Gets or sets the small secondary tile image.

> The Square70x70 tile size is not supported on Windows Phone 8.1. Instead, call [Square71x71Logo](secondarytilevisualelements_square71x71logo.md).

## -property-value
The location of the image. This can be expressed as one of these schemes: <termdeflist><termdef><name>ms-appx:///</name>A path within the deployed app package. This path is resolved for languages and DPI plateau supported by the app.</termdef><termdef><name>ms-appdata:///local/</name>A file found in the per-user app storage.</termdef></termdeflist>

## -remarks
If this image is not specified, the [Square150x150Logo](secondarytilevisualelements_square150x150logo.md) image is scaled down for use in its place.

## -examples

## -see-also
[Square150x150Logo](secondarytilevisualelements_square150x150logo.md), [Square30x30Logo](secondarytilevisualelements_square30x30logo.md), [Square310x310Logo](secondarytilevisualelements_square310x310logo.md), [Wide310x150Logo](secondarytilevisualelements_wide310x150logo.md), [Secondary tiles sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Secondary%20tiles%20sample)
