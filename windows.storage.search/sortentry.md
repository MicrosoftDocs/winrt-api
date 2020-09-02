---
-api-id: T:Windows.Storage.Search.SortEntry
-api-type: winrt struct
---

<!-- Structure syntax.
public struct SortEntry 
-->

# SortEntry

## -description
An entry in the [SortOrder](queryoptions_sortorder.md) list the specifies a property and ordering that is used to sort query results.

## -struct-fields

### -field PropertyName
The name of the property to use for sorting, like [System.Author](/windows/desktop/properties/props-system-author). The property must be registered on the system.

For more information, see the [Windows Property System](/windows/desktop/properties/windows-properties-system).
    

### -field AscendingOrder
True to sort content in the query results in ascending order based on the property name, or false to sort content in descending order.
    

## -remarks

## -examples

## -see-also
[SortEntryVector](sortentryvector.md)