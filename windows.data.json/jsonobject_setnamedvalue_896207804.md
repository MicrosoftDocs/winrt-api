---
-api-id: M:Windows.Data.Json.JsonObject.SetNamedValue(System.String,Windows.Data.Json.IJsonValue)
-api-type: winrt method
---

<!-- Method syntax
public void SetNamedValue(System.String name, Windows.Data.Json.IJsonValue value)
-->

# Windows.Data.Json.JsonObject.SetNamedValue

## -description
Sets the value of the first [JsonValue](jsonvalue.md) object with the specified name to the specified value. If no such object is found, a new name and [JsonValue](jsonvalue.md) pair is inserted into the JSON object.

## -parameters
### -param name
The specified name.

### -param value
The specified value.

## -remarks
If `value` is `null`, then any existing value with the specified name is removed.

## -examples

## -see-also
