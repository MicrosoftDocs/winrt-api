---
-api-id: P:Windows.Storage.FileProperties.BasicProperties.ItemDate
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.DateTime ItemDate { get; }
-->

# Windows.Storage.FileProperties.BasicProperties.ItemDate

## -description
Gets the most relevant date for the item.

## -property-value
The item's date.

The system determines the most relevant date based on the type of the item. For example, if the item is a photo the date in [System.Photo.DateTaken](XREF:TODO:properties.props_System_Photo_DateTaken) is returned. Or if the item is a song the date in [System.Media.DateReleased](XREF:TODO:properties.props_System_Media_DateReleased) is returned.

## -remarks
This property lets you get the most relevant date for an item without the need to access item-specific properties.

## -examples

## -see-also
