---
-api-id: M:Windows.Data.Json.JsonObject.GetNamedValue(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Data.Json.JsonValue GetNamedValue(System.String name)
-->

# Windows.Data.Json.JsonObject.GetNamedValue

## -description
Gets the [JsonValue](jsonvalue.md) value with the specified name.

## -parameters
### -param name
The name.

## -returns
The [JsonValue](jsonvalue.md) value with the specified name.

## -remarks
This method should always used with a try/catch block because it throws an exception if the name found is not a [JsonValue](jsonvalue.md) type or the name is not found.

## -examples

## -see-also
[GetNamedValue(String, JsonValue)](jsonobject_getnamedvalue_1852490180.md)