---
-api-id: T:Windows.Storage.NameCollisionOption
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Storage.NameCollisionOption : int
-->

# NameCollisionOption

## -description
Specifies what to do if a file or folder with the specified name already exists in the current folder when you copy, move, or rename a file or folder.

## -enum-fields
### -field GenerateUniqueName:0
Automatically append a number to the base of the specified name if the file or folder already exists.

For example, if `MyFile.txt` already exists, then the new file is named `MyFile (2).txt`. If `MyFolder` already exists, then the new folder is named `MyFolder (2)`.

### -field ReplaceExisting:1
Replace the existing item if the file or folder already exists.

### -field FailIfExists:2
Raise an exception of type **System.Exception** if the file or folder already exists.

Methods that don't explicitly pass a value from the [NameCollisionOption](namecollisionoption.md) enumeration use the **FailIfExists** value as the default when you try to create, rename, copy, or move a file or folder.


## -remarks

## -examples

## -see-also