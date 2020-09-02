---
-api-id: P:Windows.Storage.Search.QueryOptions.SortOrder
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVector<Windows.Storage.Search.SortEntry> SortOrder { get; }
-->

# Windows.Storage.Search.QueryOptions.SortOrder

## -description
Gets the list of [SortEntry](sortentry.md) structures that specify how to sort content (like files and subfolders) in query results. Use this list to customize how query results are sorted.

## -property-value
A [SortEntryVector](sortentryvector.md) that contains [SortEntry](sortentry.md) structures. These structures specify how to sort query results.

## -remarks
If the folder being queried is not in a library or in the HomeGroup folder, SortOrder only supports entries based on the [System.ItemNameDisplay](/windows/desktop/properties/props-system-itemnamedisplay) (**PKEY_ItemNameDisplay**), [System.Search.Rank](/windows/desktop/properties/props-system-search-rank) (**PKEY_Search_Rank**), or [System.DateModified](/windows/desktop/properties/props-system-datemodified) (**PKEY_DateModified**) properties; SortOrder entries based on any other properties will return **E_INVALIDARG**.

## -examples

## -see-also
[queryOptions class](queryoptions.md), [sortEntryVector class](sortentryvector.md)
