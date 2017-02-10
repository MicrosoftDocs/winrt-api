---
-api-id: M:Windows.ApplicationModel.Resources.Management.ResourceIndexer.IndexFilePath(Windows.Foundation.Uri)
-api-type: winrt method
---

<!-- Method syntax
public Windows.ApplicationModel.Resources.Management.IndexedResourceCandidate IndexFilePath(Windows.Foundation.Uri filePath)
-->

# Windows.ApplicationModel.Resources.Management.ResourceIndexer.IndexFilePath

## -description
Indexes a file path for file and folder naming conventions.

## -parameters
### -param filePath
The file to be indexed (file:// URI). The path must be an absolute path with the drive letter specified. The [Uri](../windows.foundation/uri.md) can also provide an empty authority which is assumed to be the local file system. Long file paths are not supported.

## -returns
An [IndexedResourceCandidate](indexedresourcecandidate.md) object that represents the indexed file resource.

## -remarks

## -examples

## -see-also
