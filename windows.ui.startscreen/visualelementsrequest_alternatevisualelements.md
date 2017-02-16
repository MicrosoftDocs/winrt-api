---
-api-id: P:Windows.UI.StartScreen.VisualElementsRequest.AlternateVisualElements
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVectorView<Windows.UI.StartScreen.SecondaryTileVisualElements> AlternateVisualElements { get; }
-->

# Windows.UI.StartScreen.VisualElementsRequest.AlternateVisualElements

## -description
Gets a set of objects that provide alternate logo images, background and foreground colors, and display name. These alternates are shown to the user in the **Pin to Start**  flyout.

> On Windows Phone 8.1, the secondary tile is created without showing the user a flyout, prompting them for confirmation, or allowing them to choose an alternate version of the tile.

## -property-value
An array of [SecondaryTileVisualElements](secondarytilevisualelements.md) objects, each of which provides the information for an alternate presentation of the secondary tile.

## -remarks
For each [SecondaryTileVisualElements](secondarytilevisualelements.md) object in the array, any property left undeclared is given the default value. App name display properties should be specified for each alternate set because their default is **false**.

## -examples

## -see-also
