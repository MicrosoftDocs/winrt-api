---
-api-id: P:Windows.Storage.KnownFolders.HomeGroup
-api-type: winrt property
---

<!-- Property syntax
public Windows.Storage.StorageFolder HomeGroup { get; }
-->

# Windows.Storage.KnownFolders.HomeGroup

## -description
Gets the HomeGroup folder.

## -property-value
The HomeGroup folder.

## -remarks
### Prerequisites

Before you can access the HomeGroup folder, the user's computer must belong to an existing HomeGroup.

To access the HomeGroup folder, in the app manifest, specify at least one of the following capabilities: **Pictures Library**, **Music Library**, or **Videos Library**.

### More info

In the HomeGroup folder, the app sees only the libraries that correspond to the capabilities specified in the app's manifest. For example, an app that specifies only the **Pictures Library** capability sees only the Pictures libraries in the HomeGroup folder.

## -examples

## -see-also
[HomeGroup app sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/HomeGroup%20app%20sample), [HomeGroup sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=620549)
