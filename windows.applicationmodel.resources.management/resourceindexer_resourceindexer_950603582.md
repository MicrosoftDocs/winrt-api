---
-api-id: M:Windows.ApplicationModel.Resources.Management.ResourceIndexer.#ctor(Windows.Foundation.Uri,Windows.Foundation.Uri)
-api-type: winrt method
---

<!-- Method syntax
public ResourceIndexer(Windows.Foundation.Uri projectRoot, Windows.Foundation.Uri extensionDllPath)
-->

# Windows.ApplicationModel.Resources.Management.ResourceIndexer.ResourceIndexer

## -description
Creates a new [ResourceIndexer](resourceindexer.md) specifying the root of the project files and an extension DLL.

## -parameters
### -param projectRoot
The project root folder (file:// URI).

### -param extensionDllPath
The extension DLL path (file:// URI).

## -remarks
The parameter *projectRoot* represents the root of the project for the files to be produced. This is used to determine file paths relative to the package that will contain them.

The parameter *extensionDllPath* represents a full path to an extension DLL that is Microsoft-signed and implements the ext-ms-win-mrmcorer-environment-l1 API set. This determines the file path from where the MRT environment extension DLL will be loaded.

The paths must be absolute paths with the drive letter specified. Long file paths are not supported.



This example shows the constructor used to index source assets intended for a Windows Phone project:

```csharp
var idxr = new Windows.ApplicationModel.Resources.Management.ResourceIndexer( 
    new Uri("file:///C:\MyApp\"), 
    new Uri("file:///C:\WPSDKPATH\bin\MrmEnvironmentExtDl.dll"));

```



## -examples

## -see-also
[ResourceIndexer(Uri)](resourceindexer_resourceindexer_843413386.md)