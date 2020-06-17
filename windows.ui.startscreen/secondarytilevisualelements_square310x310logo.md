---
-api-id: P:Windows.UI.StartScreen.SecondaryTileVisualElements.Square310x310Logo
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.Foundation.Uri Square310x310Logo { get;  set; }
-->

# Windows.UI.StartScreen.SecondaryTileVisualElements.Square310x310Logo

## -description
Gets or sets the large secondary tile image.

> The large tile size is not supported on Windows Phone 8.1.

## -property-value
The location of the image. This can be expressed as one of these schemes: <termdeflist><termdef><name>ms-appx:///</name>A path within the deployed app package. This path is resolved for languages and DPI plateau supported by the app.</termdef><termdef><name>ms-appdata:///local/</name>A file found in the per-user app storage.</termdef></termdeflist>

## -remarks
A [wide tile image](secondarytilevisualelements_wide310x150logo.md) must also be set for the large tile option to be presented to the user.

## -examples

## -see-also
[Square150x150Logo](secondarytilevisualelements_square150x150logo.md), [Square30x30Logo](secondarytilevisualelements_square30x30logo.md), [Square70x70Logo](secondarytilevisualelements_square70x70logo.md), [Wide310x150Logo](secondarytilevisualelements_wide310x150logo.md), [Secondary tiles sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Secondary%20tiles%20sample)
