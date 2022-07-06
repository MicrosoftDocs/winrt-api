---
-api-id: M:Windows.UI.Xaml.Media.Animation.ColorKeyFrameCollection.SetAt(System.UInt32,Windows.UI.Xaml.Media.Animation.ColorKeyFrame)
-api-type: winrt method
---

<!-- Method syntax
public void SetAt(System.UInt32 index, Windows.UI.Xaml.Media.Animation.ColorKeyFrame value)
-->

# Windows.UI.Xaml.Media.Animation.ColorKeyFrameCollection.SetAt

## -description
Sets the value at the specified index to the [ColorKeyFrame](colorkeyframe.md) value specified.



## -parameters
### -param index
The index at which to set the value.

### -param value
The value to set.

## -remarks
[InsertAt](colorkeyframecollection_insertat_804551258.md) expands the collection and moves all subsequent index items by one.

In contrast, SetAt replaces the item at the index, and the collection count remains the same.

## -examples

## -see-also
