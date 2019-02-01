---
-api-id: M:Windows.Graphics.Imaging.BitmapProperties.SetPropertiesAsync(Windows.Foundation.Collections.IIterable{Windows.Foundation.Collections.IKeyValuePair{System.String,Windows.Graphics.Imaging.BitmapTypedValue}})
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction SetPropertiesAsync(Windows.Foundation.Collections.IIterable<Windows.Foundation.Collections.IKeyValuePair<System.String, Windows.Graphics.Imaging.BitmapTypedValue>> propertiesToSet)
-->

# Windows.Graphics.Imaging.BitmapProperties.SetPropertiesAsync

## -description
Asynchronously sets one or more bitmap properties.

## -parameters
### -param propertiesToSet
A collection of key-value pairs representing the bitmap properties to be set. Each key is a string containing the Windows property or metadata query, and the corresponding value is a [BitmapTypedValue](bitmaptypedvalue.md) with the data and the correct [PropertyType](../windows.foundation/propertytype.md).

## -returns
Object that manages the setting of the bitmap properties asynchronously.

## -remarks
Use a [BitmapPropertySet](bitmappropertyset.md) to store metadata items that you want to set on the encoder. Each metadata item is a key-value pair.

The key is a string that identifies the metadata item to set. [BitmapEncoder](bitmapencoder.md) accepts some Windows properties as well as queries constructed using the WIC metadata query language. For a list of supported Windows properties, see [Supported Windows Properties](https://msdn.microsoft.com/library/7532e58f-bbf2-4e36-9d81-c8e04b92cb7c). For a summary of supported WIC metadata queries, see the [WIC Native Image Format Metadata Queries](https://msdn.microsoft.com/library/a6ab1708-dd82-4960-b908-f1daef7374ef) topic.

The value is a [BitmapTypedValue](bitmaptypedvalue.md) which allows you to associate the actual metadata value with an explicit data type ([Windows.Foundation.PropertyType](../windows.foundation/propertytype.md)).

Each image format has specific requirements around the type of every bitmap property, and you must ensure that the [Type](bitmaptypedvalue_type.md) field of each [BitmapTypedValue](bitmaptypedvalue.md) is correctly set for the selected property. For example, the [System.Photo.Orientation](https://msdn.microsoft.com/library/windows/desktop/bb760505.aspx) Windows property is stored in the file as a UInt16, and therefore the [Type](bitmaptypedvalue_type.md) field must be set to UInt16. For more info about Windows property types, see [Photo Metadata Policies](https://msdn.microsoft.com/library/ac71889b-94e5-4135-abd4-5d96690e41ea). For more info about Windows Imaging Component metadata query types, see [Native Image Format Metadata Queries](https://msdn.microsoft.com/library/a6ab1708-dd82-4960-b908-f1daef7374ef).

## -examples

## -see-also
[BitmapPropertySet](bitmappropertyset.md)