---
-api-id: P:Windows.Storage.KnownFolders.CameraRoll
-api-type: winrt property
---

<!-- Property syntax
public Windows.Storage.StorageFolder CameraRoll { get; }
-->

# Windows.Storage.KnownFolders.CameraRoll

## -description
Gets the Camera Roll folder.

## -property-value
The Camera Roll folder.

## -remarks
To access the Camera Roll folder, in the app manifest, specify the **Pictures Library** capability.

Windows Store app only. If the Camera Roll folder doesn't exist, reading the value of this property creates it. It does not raise an exception. The Camera Roll folder is typically a subfolder in the Pictures library that has the following path.

+ `%USERPROFILE%\Pictures\Camera Roll`


## -examples

## -see-also


## -capabilities
picturesLibrary