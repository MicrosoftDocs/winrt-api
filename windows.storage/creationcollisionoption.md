---
-api-id: T:Windows.Storage.CreationCollisionOption
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Storage.CreationCollisionOption : int
-->

# CreationCollisionOption

## -description
Specifies what to do if a file or folder with the specified name already exists in the current folder when you create a new file or folder.

## -enum-fields
### -field GenerateUniqueName:0
Automatically append a number to the base of the specified name if the file or folder already exists.

For example, if `MyFile.txt` already exists, then the new file is named `MyFile (2).txt`. If `MyFolder` already exists, then the new folder is named `MyFolder (2)`.

### -field ReplaceExisting:1
Replace the existing item if the file or folder already exists.

### -field FailIfExists:2
Raise an exception of type **System.Exception** if the file or folder already exists.

Methods that don't explicitly pass a value from the [CreationCollisionOption](creationcollisionoption.md) enumeration use the **FailIfExists** value as the default when you try to create, rename, copy, or move a file or folder.

### -field OpenIfExists:3
Return the existing item if the file or folder already exists.


## -remarks
Methods that don't explicitly pass a value from the [CreationCollisionOption](creationcollisionoption.md) enumeration use the **FailIfExists** value as the default when you create a file or folder.

For example, the [CreateFileAsync](downloadsfolder_createfileasync_1058061470.md) method has one overload, [CreateFileAsync (String, .CreationCollisionOption)](downloadsfolder_createfileasync_1058061470.md), that explicitly passes a value from the [CreationCollisionOption](creationcollisionoption.md) enumeration. If you call the other overload, [CreateFileAsync (String)](downloadsfolder_createfileasync_644130808.md), the method uses the **FailIfExists** option as the default.

## -examples

## -see-also