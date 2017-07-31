---
-api-id: T:Windows.Storage.Streams.FileOpenDisposition
-api-type: winrt enum
---

<!-- Enumeration syntax.
public enum FileOpenDisposition : int 
-->

# Windows.Storage.Streams.FileOpenDisposition

## -description
Enumeration values for actions to take on a file.

## -enum-fields
### -field OpenExisting:0
Opens a file only if it exists.

### -field OpenAlways:1
Opens a file. If the file does not exist, a new file will be created and opened.

### -field CreateNew:2
Creates a new file if one does not exist. If the file does exist, this will fail.

### -field CreateAlways:3
Opens a file and truncates it so that its size is zero bytes. If the file does not exist, a new file will be created and opened.

### -field TruncateExisting:4
Opens a file and truncates it so that its size is zero bytes. If the file does not exist, this will fail.

## -remarks
The results of the FileOpenDisposition values depend on whether the file exists or not.

## -see-also

## -examples

