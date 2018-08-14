---
-api-id: P:Windows.UI.Xaml.Controls.UIElementCollection.Size
-api-type: winrt property
---

<!-- Property syntax
public uint Size { get; }
-->

# Windows.UI.Xaml.Controls.UIElementCollection.Size

## -description
Gets the size (count) of the collection.

## -property-value
The count of items in the collection.

## -remarks
The [Size](uielementcollection_size.md) value returns the true number of items. API that use the index, such as [GetAt](uielementcollection_getat_496709656.md), use a zero-based index, so you would subtract one from [Size](uielementcollection_size.md) in order to specify that you want the last item in the collection.

If you are programming using C# or Microsoft Visual Basic, see [Count](uielementcollection_count.md).

## -examples

## -see-also
