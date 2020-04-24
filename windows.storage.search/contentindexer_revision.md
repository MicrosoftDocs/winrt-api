---
-api-id: P:Windows.Storage.Search.ContentIndexer.Revision
-api-type: winrt property
---

<!-- Property syntax
public ulong Revision { get; }
-->

# Windows.Storage.Search.ContentIndexer.Revision

## -description
Gets the version of the [ContentIndexer](contentindexer.md).

## -property-value
The revision number.

## -remarks
Use the Revision property to track updates to the index.

For example, it's possible that your app may have terminated prior to the index being committed. In many cases the app can resubmit all of its content, but for more sophisticated apps, like mail, where there's a large amount of content, the app can create its own checkpoints and re-index only the missing content. The app can track how much content has been indexed by tracking the revision number. The Revision property is a number that increments based on the indexing operations that the app has initiated.

If the index is reset (which can be caused by either the index getting corrupted or a user manually clearing it out), the revision number will be "0". In this case, the app should re-push all of its data.

## -examples

## -see-also
[Content indexer sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/ContentIndexer)
