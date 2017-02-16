---
-api-id: P:Windows.Media.Effects.IBasicVideoEffect.IsReadOnly
-api-type: winrt property
---

<!-- Property syntax
public bool IsReadOnly { get; }
-->

# Windows.Media.Effects.IBasicVideoEffect.IsReadOnly

## -description
Gets a value indicating whether the video effect will modify the contents of the input frame.

## -property-value
True, if the effect will not modify the input frame; otherwise, false.

## -remarks
When [IBasicVideoEffect.IsReadOnly](ibasicvideoeffect_isreadonly.md) is set to true, the system automatically copies the frame data directly from the input frame to the output frame before [ProcessFrame](ibasicvideoeffect_processframe.md) is called. This allows an effect that analyzes the input data, but does not modify it, to skip the creation of the output frame data.

## -examples

## -see-also
