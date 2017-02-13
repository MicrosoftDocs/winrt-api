---
-api-id: M:Windows.ApplicationModel.Resources.Management.ResourceIndexer.#ctor(Windows.Foundation.Uri)
-api-type: winrt method
---

<!-- Method syntax
public ResourceIndexer(Windows.Foundation.Uri projectRoot)
-->

# Windows.ApplicationModel.Resources.Management.ResourceIndexer.ResourceIndexer

## -description
Creates a new [ResourceIndexer](resourceindexer.md) specifying the root of the project files.

## -parameters
### -param projectRoot
The project root folder (file:// URI).



## -remarks
The parameter *projectRoot* represents the root of the project for the files to be produced. This is used to determine file paths relative to the package that will contain them.

The path must be an absolute path with the drive letter specified. Long file paths are not supported.



Example:

```csharp
var idxr = new Windows.ApplicationModel.Resources.Management.ResourceIndexer( 
    new Uri("file:///C:\MyApp\"));

```



## -examples

## -see-also
[ResourceIndexer(Uri, Uri)](resourceindexer_resourceindexer_950603582.md)