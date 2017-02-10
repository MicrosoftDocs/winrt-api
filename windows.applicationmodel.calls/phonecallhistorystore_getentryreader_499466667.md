---
-api-id: M:Windows.ApplicationModel.Calls.PhoneCallHistoryStore.GetEntryReader(Windows.ApplicationModel.Calls.PhoneCallHistoryEntryQueryOptions)
-api-type: winrt method
---

<!-- Method syntax
public Windows.ApplicationModel.Calls.PhoneCallHistoryEntryReader GetEntryReader(Windows.ApplicationModel.Calls.PhoneCallHistoryEntryQueryOptions queryOptions)
-->

# Windows.ApplicationModel.Calls.PhoneCallHistoryStore.GetEntryReader

## -description
Retrieves an entry reader based on provided filters.

## -parameters
### -param queryOptions
The options used to create a filtered entry reader.

## -returns
A reader that can be used to go through the phone call log entries.

## -remarks
Use *queryOptions* to create a reader that will only read the specified entries. If you want a reader that accesses all log entries, you can use [GetEntryReader](phonecallhistorystore_getentryreader_641155997.md).

## -examples

## -see-also
[GetEntryReader](phonecallhistorystore_getentryreader_641155997.md)

## -capabilities
phoneCallHistoryPublic