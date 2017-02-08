---
-api-id: P:Windows.UI.StartScreen.VisualElementsRequest.VisualElements
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.StartScreen.SecondaryTileVisualElements VisualElements { get; }
-->

# Windows.UI.StartScreen.VisualElementsRequest.VisualElements

## -description
Gets a copy
<!-- @WRITER erictill 5/28/2013 : Does the original get set to the copy eventually, assuming it doesn't time out? -->
of the parent secondary tile's [SecondaryTileVisualElements](secondarytilevisualelements.md)object. The visual elements properties can be set or read through this object. When [deferral](visualelementsrequest_getdeferral.md) is complete (or the handler returns without a deferral), the properties in this object are verified and then reflected in the **Pin to Start**  flyout.

## -property-value
The object through which you'll access the visual element properties.

## -remarks

## -examples

## -see-also
