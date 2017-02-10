---
-api-id: P:Windows.Storage.StorageFolder.DateCreated
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.DateTime DateCreated { get; }
-->

# Windows.Storage.StorageFolder.DateCreated

## -description
Gets the date and time that the current folder was created.

## -property-value
The date and time that the current folder was created as type [DateTime](../windows.foundation/datetime.md).

For example: Fri Sep 16 13:47:08 PDT 2011.

## -remarks
If the date property isn't set, this value defaults to 0 which can be translated into misleading dates in different programming languages. In JavaScript, for example, 0 translates to December 16, 1600. You should always check that this property is a real value and not 0.

## -examples

## -see-also
