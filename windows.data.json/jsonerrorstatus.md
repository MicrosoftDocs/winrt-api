---
-api-id: T:Windows.Data.Json.JsonErrorStatus
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Data.Json.JsonErrorStatus : int
-->

# JsonErrorStatus

## -description
Defines errors encountered while parsing JSON data.

## -enum-fields
### -field Unknown:0
An unknown error occurred.

### -field InvalidJsonString:1
The string is invalid. It is possible the expressed value type of the JSON encapsulated data type does not match what is defined by [JsonValueType](jsonvaluetype.md).

### -field InvalidJsonNumber:2
The number is invalid. It is possible the expressed value type of the JSON encapsulated data type does not match what is defined by [JsonValueType](jsonvaluetype.md).

### -field JsonValueNotFound:3
The specified [JsonValue](jsonvalue.md) cannot be found.

### -field ImplementationLimit:4
This operation exceeds the internal limit of 1024 nested JSON objects.


## -remarks

## -examples

## -see-also
[JsonError](jsonerror.md), [JsonValueType](jsonvaluetype.md)