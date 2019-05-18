---
-api-id: T:Windows.Storage.Search.DateStackOption
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Storage.Search.DateStackOption : int
-->

# DateStackOption

## -description
Indicates the unit of time used to group files into folders if a [CommonFolderQuery](commonfolderquery.md) based on date is used to create a [QueryOptions](queryoptions.md) object.

## -enum-fields
### -field None:0
The query options are not based on the date.

### -field Year:1
The content is grouped by year.

### -field Month:2
The content is grouped by month.


## -remarks
For example, if you create a [QueryOptions](queryoptions.md) object using [CommonFolderQuery.GroupByYear](commonfolderquery.md) the [DateStackOption](queryoptions_datestackoption.md) property will contain the DateStackOption.Year value.

## -examples

## -see-also
