---
-api-id: P:Windows.UI.StartScreen.SecondaryTileVisualElements.Square150x150Logo
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.Foundation.Uri Square150x150Logo { get;  set; }
-->

# Windows.UI.StartScreen.SecondaryTileVisualElements.Square150x150Logo

## -description
Gets or sets the medium secondary tile image.

## -property-value
The location of the image. This can be expressed as one of these schemes: <termdeflist><termdef><name>ms-appx:///</name>A path within the deployed app package. This path is resolved for languages and DPI plateau supported by the app.</termdef><termdef><name>ms-appdata:///local/</name>A file found in the per-user app storage.</termdef></termdeflist>

## -remarks
This image must be set before you call [SecondaryTile.RequestCreateAsync](secondarytile_requestcreateasync_1444672734.md).

## -examples

## -see-also
[Square30x30Logo](secondarytilevisualelements_square30x30logo.md), [Square310x310Logo](secondarytilevisualelements_square310x310logo.md), [Square70x70Logo](secondarytilevisualelements_square70x70logo.md), [Wide310x150Logo](secondarytilevisualelements_wide310x150logo.md), [Secondary tiles sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Secondary%20tiles%20sample)
