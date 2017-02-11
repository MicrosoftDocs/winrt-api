---
-api-id: P:Windows.Storage.StorageFile.Path
-api-type: winrt property
---

<!-- Property syntax
public string Path { get; }
-->

# Windows.Storage.StorageFile.Path

## -description
Gets the full file-system path of the current file, if the file has a path.

## -property-value
The full path of the file, if the file has a path in the user's file-system.

## -remarks
Do not rely on this property to access a file because some files may not have file-system paths. For example if the file is backed by a URI, or was picked using the file picker, the file is not guaranteed to have a file-system path.

## -examples

## -see-also
