---
-api-id: M:Windows.Data.Json.JsonObject.GetNamedArray(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Data.Json.JsonArray GetNamedArray(System.String name)
-->

# Windows.Data.Json.JsonObject.GetNamedArray

## -description
Gets the [JsonArray](jsonarray.md) value with the specified name.

## -parameters
### -param name
The name.

## -returns
The [JsonArray](jsonarray.md) with the specified *name*.

## -remarks
This method should always used with a try/catch block because it throws an exception if the name found is not a [JsonArray](jsonarray.md) type or the name is not found.

## -examples

## -see-also
[GetNamedArray(String, JsonArray)](jsonobject_getnamedarray_1738038789.md)