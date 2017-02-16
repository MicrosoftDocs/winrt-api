---
-api-id: M:Windows.ApplicationModel.Resources.Management.ResourceIndexer.IndexFileContentsAsync(Windows.Foundation.Uri)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Foundation.Collections.IVectorView<Windows.ApplicationModel.Resources.Management.IndexedResourceCandidate>> IndexFileContentsAsync(Windows.Foundation.Uri file)
-->

# Windows.ApplicationModel.Resources.Management.ResourceIndexer.IndexFileContentsAsync

## -description
Indexes a ResW, ResJSON, PRI, or PRI XML dump file path for file and folder naming conventions, and applies the qualifiers to the resources found within the contents of the file.

## -parameters
### -param file
The file to be indexed (file:// URI). The path must be an absolute path with the drive letter specified. The [Uri](../windows.foundation/uri.md) can also provide an empty authority which is assumed to be the local file system. Long file paths are not supported.

## -returns
A list of [IndexedResourceCandidate](indexedresourcecandidate.md) objects found within *file*. This is an empty list if nothing is found.

## -remarks

## -examples

## -see-also
