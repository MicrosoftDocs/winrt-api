---
-api-id: P:Windows.Storage.ApplicationData.RoamingFolder
-api-type: winrt property
---

<!-- Property syntax
public Windows.Storage.StorageFolder RoamingFolder { get; }
-->

# Windows.Storage.ApplicationData.RoamingFolder

## -description
Gets the root folder in the roaming app data store.

## -property-value
The file system folder that contains the files.

## -remarks
The sync engine has restrictions on the file name conventions that you must follow to ensure the items in the roaming folder can roam. Be sure that your file and folder names do not contain leading whitespace. The sync engine may limit the total size of settings and files that can roam.

You can access files in the roaming app data store using the "ms-appdata:///roaming/" protocol. For example:

`<img src="ms-appdata:///roaming/myFile.png" alt="" />`

## -examples

## -see-also
[Quickstart: Roaming application data (JavaScript)](https://msdn.microsoft.com/library/60f40214-c201-4afe-a2f5-0ef3a7de0076), [Store and retrieve settings and other app data](https://msdn.microsoft.com/library/41676a02-325a-455e-8565-c9ec0bc3a8fe), [Store and retrieve settings and other app data](https://msdn.microsoft.com/library/41676a02-325a-455e-8565-c9ec0bc3a8fe)
