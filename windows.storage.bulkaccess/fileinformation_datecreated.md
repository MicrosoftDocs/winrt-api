---
-api-id: P:Windows.Storage.BulkAccess.FileInformation.DateCreated
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.DateTime DateCreated { get; }
-->

# Windows.Storage.BulkAccess.FileInformation.DateCreated

## -description
Gets the date that the file was created.

## -property-value
The file creation date.

## -remarks
If the date property isn't set, this value defaults to 0 which can be translated into misleading dates in different programming languages. In JavaScript, for example, 0 translates to December 16, 1600. You should always check that this property is a real value and not 0.

## -examples

## -see-also
