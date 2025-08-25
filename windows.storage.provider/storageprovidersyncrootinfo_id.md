---
-api-id: P:Windows.Storage.Provider.StorageProviderSyncRootInfo.Id
-api-type: winrt property
---

<!-- Property syntax.
public string Id { get;  set; }
-->

# Windows.Storage.Provider.StorageProviderSyncRootInfo.Id

## -description

A unique identifier that distinguishes this sync root from other sync roots registered on the system. This identifier is used by the Windows storage provider framework to manage and track the sync root throughout its lifecycle.

## -property-value

An identifier in the form: [Storage Provider ID]![Windows SID]![Account ID]

## -remarks

An example of an ID might look something like: "OneDrive!S-1-1234!Personal".

Note that the maximum allowed length for an ID is 174 characters. Setting a longer ID can result in an error (ERROR_INSUFFICIENT_BUFFER).

## -see-also

## -examples
