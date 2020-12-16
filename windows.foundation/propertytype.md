---
-api-id: T:Windows.Foundation.PropertyType
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Foundation.PropertyType : int
-->

# PropertyType

## -description
Specifies property value types.

## -enum-fields
### -field Empty:0
No type is specified.

### -field UInt8:1
A byte.

### -field Int16:2
A signed 16-bit (2-byte) integer.

### -field UInt16:3
An unsigned 16-bit (2-byte) integer.

### -field Int32:4
A signed 32-bit (4-byte) integer.

### -field UInt32:5
An unsigned 32-bit (4-byte) integer.

### -field Int64:6
A signed 64-bit (8-byte) integer.

### -field UInt64:7
An unsigned 64-bit (8-byte) integer.

### -field Single:8
A signed 32-bit (4-byte) floating-point number.

### -field Double:9
A signed 64-bit (8-byte) floating-point number.

### -field Char16:10
An unsigned 16-bit (2-byte) code point.

### -field Boolean:11
A value that can be only true or false.

### -field String:12
A Windows Runtime  [HSTRING](/windows/desktop/WinRT/hstring).

### -field Inspectable:13
An object implementing the [IInspectable](/windows/desktop/api/inspectable/nn-inspectable-iinspectable) interface.

### -field DateTime:14
An instant in time, typically expressed as a date and time of day.

### -field TimeSpan:15
A time interval.

### -field Guid:16
A globally unique identifier.

### -field Point:17
An ordered pair of floating-point x- and y-coordinates that defines a point in a two-dimensional plane.

### -field Size:18
An ordered pair of float-point numbers that specify a height and width.

### -field Rect:19
A set of four floating-point numbers that represent the location and size of a rectangle.

### -field OtherType:20
A type not specified in this enumeration.

### -field UInt8Array:1025
An array of [Byte](/dotnet/api/system.byte?view=dotnet-uwp-10.0&preserve-view=true) values.

### -field Int16Array:1026
An array of [Int16](/dotnet/api/system.int16?view=dotnet-uwp-10.0&preserve-view=true) values.

### -field UInt16Array:1027
An array of [UInt16](/dotnet/api/system.uint16?view=dotnet-uwp-10.0&preserve-view=true) values.

### -field Int32Array:1028
An array of [Int32](/dotnet/api/system.int32?view=dotnet-uwp-10.0&preserve-view=true) values.

### -field UInt32Array:1029
An array of [UInt32](/dotnet/api/system.uint32?view=dotnet-uwp-10.0&preserve-view=true) values.

### -field Int64Array:1030
An array of [Int64](/dotnet/api/system.int64?view=dotnet-uwp-10.0&preserve-view=true) values.

### -field UInt64Array:1031
An array of [UInt64](/dotnet/api/system.uint64?view=dotnet-uwp-10.0&preserve-view=true) values.

### -field SingleArray:1032
An array of [Single](/dotnet/api/system.single?view=dotnet-uwp-10.0&preserve-view=true) values.

### -field DoubleArray:1033
An array of [Double](/dotnet/api/system.double?view=dotnet-uwp-10.0&preserve-view=true) values.

### -field Char16Array:1034
An array of [Char](/dotnet/api/system.char?view=dotnet-uwp-10.0&preserve-view=true) values.

### -field BooleanArray:1035
An array of [Boolean](/dotnet/api/system.boolean?view=dotnet-uwp-10.0&preserve-view=true) values.

### -field StringArray:1036
An array of [String](/dotnet/api/system.string?view=dotnet-uwp-10.0&preserve-view=true) values.

### -field InspectableArray:1037
An array of **Inspectable** values.

### -field DateTimeArray:1038
An array of [DateTime](datetime.md) values.

### -field TimeSpanArray:1039
An array of [TimeSpan](timespan.md) values.

### -field GuidArray:1040
An array of [Guid](/dotnet/api/system.guid?view=dotnet-uwp-10.0&preserve-view=true) values.

### -field PointArray:1041
An array of [Point](point.md) structures.

### -field SizeArray:1042
An array of [Size](size.md) structures.

### -field RectArray:1043
An array of [Rect](rect.md) structures.

### -field OtherTypeArray:1044
An array of an unspecified type.


## -remarks
This enumeration is used as a value by [IPropertyValue.Type](ipropertyvalue_type.md) and [BitmapTypedValue.Type](../windows.graphics.imaging/bitmaptypedvalue_type.md).

## -examples

## -see-also
[PropertySet](../windows.foundation.collections/propertyset.md), [IPropertyValue.Type](ipropertyvalue_type.md)