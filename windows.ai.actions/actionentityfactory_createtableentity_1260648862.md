---
-api-id: M:Windows.AI.Actions.ActionEntityFactory.CreateTableEntity(System.String[],System.UInt32)
-api-type: winrt method
---

# Windows.AI.Actions.ActionEntityFactory.CreateTableEntity(System.String[],System.UInt32)

<!--
public Windows.AI.Actions.TableActionEntity CreateTableEntity (string[] data, uint columnCount);
-->


## -description

Creates a new instance of [TableActionEntity](tableactionentity.md).

## -parameters

### -param data

A one-dimensional array of strings representing a two-dimensional string table.

### -param columnCount

The number of columns in the table. The system determines the number of rows by dividing the length of the *data* array by the *columnCount*, casting the row count to an integer. If the product of the column count and row count is not the same as the data length, an exception will be raised.

## -returns

A new **TableActionEntity**.

## -remarks

## -see-also

## -examples


