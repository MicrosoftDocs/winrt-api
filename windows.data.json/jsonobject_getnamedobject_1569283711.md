---
-api-id: M:Windows.Data.Json.JsonObject.GetNamedObject(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Data.Json.JsonObject GetNamedObject(System.String name)
-->

# Windows.Data.Json.JsonObject.GetNamedObject

## -description
Gets the [JsonObject](jsonobject.md) value with the specified name.

## -parameters
### -param name
The name.

## -returns
The [JsonObject](jsonobject.md) value with the specified name.

## -remarks
This method should always used with a try/catch block because it throws an exception if the name found is not a [JsonObject](jsonobject.md) type or the name is not found.

## -examples

## -see-also
[GetNamedObject(String, JsonObject)](jsonobject_getnamedobject_1279840399.md)