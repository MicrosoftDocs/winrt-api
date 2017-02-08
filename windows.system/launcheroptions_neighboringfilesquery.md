---
-api-id: P:Windows.System.LauncherOptions.NeighboringFilesQuery
-api-type: winrt property
---

<!-- Property syntax
public Windows.Storage.Search.StorageFileQueryResult NeighboringFilesQuery { get;  set; }
-->

# Windows.System.LauncherOptions.NeighboringFilesQuery

## -description
Enables an app to access files that are related to the file used to activate the app.

## -property-value
A query containing the list of related files.

## -remarks
Access to files is carefully controlled to protect users from malicious apps. This property gives an application that is activated for a particular file access to other files of the same type. For example, if a photo app is activated for a picture, this property returns the other pictures in the same folder. However, only file types that are declared in the capabilities section of the manifest file will be accessible. For example, only if an app declares the **Pictures Library** capability in the app manifest will it be possible to access picture files when the app is launched with **kind:pictures**.

## -examples

## -see-also
