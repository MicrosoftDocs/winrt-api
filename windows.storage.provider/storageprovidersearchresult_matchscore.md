---
-api-id: P:Windows.Storage.Provider.StorageProviderSearchResult.MatchScore
-api-type: winrt property
---

# Windows.Storage.Provider.StorageProviderSearchResult.MatchScore

<!--
public double MatchScore { get; set; }
-->

## -description

Gets or sets the match score for the search result. This indicates how well the search result matches the search query.

## -property-value

The match score for the search result as a `double` value.

## -remarks

This property allows for merging and sorting of results with local results provided by system indexer.

The range of values is `0` to `1`. A value of `1.0` is a perfect match.

## -see-also

## -examples
