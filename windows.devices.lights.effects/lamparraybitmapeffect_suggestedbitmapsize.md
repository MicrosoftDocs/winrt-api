---
-api-id: P:Windows.Devices.Lights.Effects.LampArrayBitmapEffect.SuggestedBitmapSize
-api-type: winrt property
ms.custom: RS5
---

<!-- Property syntax.
public Size SuggestedBitmapSize { get; }
-->

# Windows.Devices.Lights.Effects.LampArrayBitmapEffect.SuggestedBitmapSize

## -description
Gets the most suitable image size for the caller selected lamp indexes that results in minimal scaling/distortion.
## -property-value
The image size.
## -remarks
Images supplied to [UpdateBitmap](lamparraybitmaprequestedeventargs_updatebitmap_191710798.md) that are not of the suggested size will incur a small performance penalty when resizing internally.

It is possible for this size to change between releases, as the algorithm is refined; even for the same LampArray.

Callers must NOT take a dependency that a certain size is returned for a particular LampArray.
## -see-also

## -examples

