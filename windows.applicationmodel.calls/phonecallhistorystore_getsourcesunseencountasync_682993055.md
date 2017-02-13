---
-api-id: M:Windows.ApplicationModel.Calls.PhoneCallHistoryStore.GetSourcesUnseenCountAsync(Windows.Foundation.Collections.IIterable{System.String})
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<uint> GetSourcesUnseenCountAsync(Windows.Foundation.Collections.IIterable<System.String> sourceIds)
-->

# Windows.ApplicationModel.Calls.PhoneCallHistoryStore.GetSourcesUnseenCountAsync

## -description
Gets the number of unseen log entries for the provided sources.

## -parameters
### -param sourceIds
The identifiers that need to match [PhoneCallHistoryEntry.SourceId](phonecallhistoryentry_sourceid.md) in order for that entry to be considered.

## -returns
The total number of unseen entries matching all of the identifiers provided by *sourceIds*.

## -remarks

## -examples

## -see-also


## -capabilities
phoneCallHistoryPublic