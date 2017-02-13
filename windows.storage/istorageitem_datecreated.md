---
-api-id: P:Windows.Storage.IStorageItem.DateCreated
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.DateTime DateCreated { get; }
-->

# Windows.Storage.IStorageItem.DateCreated

## -description
Gets the date and time when the current item was created.

## -property-value
The date and time when the current item was created.

For example, in string format the [DateTime](../windows.foundation/datetime.md) that an item was created might be "Fri Sep 16 13:47:08 PDT 2011".

## -remarks
If the date property isn't set, this value defaults to 0 which can be translated into misleading dates in different programming languages. In JavaScript, for example, 0 translates to December 16, 1600. You should always check that this property is a real value and not 0.

## -examples

## -see-also
