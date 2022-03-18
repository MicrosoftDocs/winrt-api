---
-api-id: T:Windows.AI.MachineLearning.TensorKind
-api-type: winrt enum
ms.custom: RS5
---

<!-- Enumeration syntax.
public enum TensorKind : int
-->

# Windows.AI.MachineLearning.TensorKind

## -description
Defines the list of supported tensor data types.

## -enum-fields
### -field Undefined:0
Invalid type.

### -field Float:1
The tensor type is 32-bit floating point.

### -field UInt8:2
The tensor type is 8-bit unsigned integer.

### -field Int8:3
The tensor type is 8-bit signed integer.

### -field UInt16:4
The tensor type is 16-bit unsigned integer.

### -field Int16:5
The tensor type is 16-bit signed integer.

### -field Int32:6
The tensor type is 32-bit signed integer.

### -field Int64:7
The tensor type is 64-bit signed integer.

### -field String:8
The tensor type is **String**.

### -field Boolean:9
The tensor type is **Boolean**.

### -field Float16:10
The tensor type is 16-bit floating point.

### -field Double:11
The tensor type is 64-bit floating point.

### -field UInt32:12
The tensor type is 32-bit unsigned integer.

### -field UInt64:13
The tensor type is 64-bit unsigned integer.

### -field Complex64:14
Invalid type.

### -field Complex128:15
Invalid type.

## -remarks
A tensor is a multi-dimensional array of values.

The layout of tensors is row-major, with tightly packed contiguous data representing each dimension. The total size of a tensor is the product of the size of each dimension.

### Windows Server
To use this API on Windows Server, you must use Windows Server 2019 with Desktop Experience.

### Thread safety
This API is thread-safe.

## -see-also
[Windows Machine Learning](/windows/ai/), [Windows ML samples (GitHub repo)](https://github.com/Microsoft/Windows-Machine-Learning)

## -examples
