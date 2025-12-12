---
-api-id: P:Windows.Storage.StorageFile.ContentType
-api-type: winrt property
---

<!-- Property syntax
public string ContentType { get; }
-->

# Windows.Storage.StorageFile.ContentType

## -description

Gets the MIME type of the contents of the file.

## -property-value

The MIME type of the file contents.

For example, a music file might have the "audio/mpeg" MIME type.

## -remarks

The `ContentType` property provides an interpretation of the file extension to determine the MIME type. It does not inspect the actual contents of the file. For example, renaming a text file (`.txt`) to have a `.jpg` extension will result in the `ContentType` being reported as `image/jpeg`.

## -examples

## -see-also
