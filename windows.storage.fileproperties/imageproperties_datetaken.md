---
-api-id: P:Windows.Storage.FileProperties.ImageProperties.DateTaken
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.DateTime DateTaken { get;  set; }
-->

# Windows.Storage.FileProperties.ImageProperties.DateTaken

## -description
Gets or sets the date when the image was taken.

## -property-value
The date when the image was taken.

## -remarks
If the date property isn't set, this value defaults to 0 which can be translated into misleading dates in different programming languages. In JavaScript, for example, 0 translates to December 16, 1600. You should always check that this property is a real value and not 0.

## -examples

## -see-also
