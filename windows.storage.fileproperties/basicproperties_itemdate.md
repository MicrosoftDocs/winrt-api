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

The system determines the most relevant date based on the type of the item. For example, if the item is a photo the date in [System.Photo.DateTaken](https://msdn.microsoft.com/library/windows/desktop/bb760410.aspx) is returned. Or if the item is a song the date in [System.Media.DateReleased](https://msdn.microsoft.com/library/windows/desktop/bb787397.aspx) is returned.

## -remarks
This property lets you get the most relevant date for an item without the need to access item-specific properties.

## -examples

## -see-also
