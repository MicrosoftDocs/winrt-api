---
-api-id: P:Windows.Storage.Search.QueryOptions.GroupPropertyName
-api-type: winrt property
---

<!-- Property syntax
public string GroupPropertyName { get; }
-->

# Windows.Storage.Search.QueryOptions.GroupPropertyName

## -description
Gets the name of the property used to group query results if the [QueryOptions](queryoptions.md) object was created using a [CommonFolderQuery](commonfolderquery.md). For example, if [CommonFolderQuery.GroupByYear](commonfolderquery.md) is used to create a [QueryOptions](queryoptions.md) object, the value of this property is [System.ItemDate](/windows/desktop/properties/props-system-itemdate).

## -property-value
The property that is being used to group files and that is specified by the [CommonFolderQuery](commonfolderquery.md) enumeration.

## -remarks

## -examples

## -see-also
[queryOptions class](queryoptions.md), [CommonFolderQuery enumeration](commonfolderquery.md)