---
-api-id: T:Windows.Storage.Provider.StorageProviderInSyncPolicy
-api-type: winrt enum
---

<!-- Enumeration syntax.
public enum StorageProviderInSyncPolicy : uint 
-->

# Windows.Storage.Provider.StorageProviderInSyncPolicy

## -description
Contains the file and directory attributes supported by the sync root.

## -enum-fields
### -field Default:0
The default sync policy value.

### -field FileCreationTime:1
The file creation time.

### -field FileReadOnlyAttribute:2
Read-only attribute of a file.

### -field FileHiddenAttribute:4
Hidden attribute of a file.

### -field FileSystemAttribute:8
System attribute of a file.

### -field DirectoryCreationTime:16
The directory creation time.

### -field DirectoryReadOnlyAttribute:32
Read-only attribute of a directory.

### -field DirectoryHiddenAttribute:64
Hidden attribute of a directory.

### -field DirectorySystemAttribute:128
System attribute of a file.

### -field FileLastWriteTime:256
The last write time on a file.

### -field DirectoryLastWriteTime:512
The last write time on a directory.

### -field PreserveInsyncForSyncEngine:2147483648
Value reserved for the sync engine.

## -remarks

## -see-also
[FileAttributes Enumeration](/dotnet/api/system.io.fileattributes?view=dotnet-uwp-10.0&preserve-view=true)

