---
-api-id: P:Windows.Storage.StorageFolder.DisplayType
-api-type: winrt property
---

<!-- Property syntax
public string DisplayType { get; }
-->

# Windows.Storage.StorageFolder.DisplayType

## -description
Gets the user-friendly description of the type of the folder; for example, `JPEG image`.

## -property-value
The user-friendly description of the type of the folder; for example, `JPEG image`.

## -remarks
For an ordinary folder in the file system, the [DisplayType](storagefolder_displaytype.md) property returns `File folder`.

Here are some examples of the value of the [DisplayType](storagefolder_displaytype.md) property when you use a [CommonFolderQuery](../windows.storage.search/commonfolderquery.md) value other than **DefaultQuery**.

+ If you specify **GroupByType**, the value of [DisplayType](storagefolder_displaytype.md) may be `JPEG image` or `PNG image`. The folders have the same name as the display type.
+ If you specify **GroupByMonth**, the value of [DisplayType](storagefolder_displaytype.md) is `Stack`. The folders have names like `October 2014` or `November 2014`.


## -examples

## -see-also
