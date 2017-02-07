---
-api-id: T:Windows.Storage.Search.FolderDepth
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Storage.Search.FolderDepth : int
-->

# FolderDepth

## -description
Indicates whether all files and subfolders of the folder being queried will be enumerated or if only the top-level files and subfolders will be enumerated.

## -enum-fields
### -field Shallow:0
Perform a shallow enumeration of the folder being queried. Only the top-level, child files and folders of the folder being queried will be returned. This is similar to the view that Windows Explorer would provide for the folder being queried.

### -field Deep:1
Perform a deep enumeration of the folder contents. Windows traverses through subfolders to discover content and presents the results in a single list that combines all discovered content.


## -remarks

## -examples

## -see-also
[QueryOptions.FolderDepth](queryoptions_folderdepth.md)