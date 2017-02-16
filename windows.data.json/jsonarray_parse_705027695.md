---
-api-id: M:Windows.Data.Json.JsonArray.Parse(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Data.Json.JsonArray Parse(System.String input)
-->

# Windows.Data.Json.JsonArray.Parse

## -description
Parses the specified JSON string that represents a [JsonArray](jsonarray.md).

> [!NOTE]
> This method will throw an exception if the provided JSON string is not valid. Use of [JsonObject.TryParse](jsonobject_tryparse.md) is a recommended alternative. A [TryParse](jsonarray_tryparse.md) call will return a boolean value to indicate success or failure and, if successful, the resultant [JsonArray](jsonarray.md).

## -parameters
### -param input
The specified JSON string.

## -returns


## -remarks
This method may only be called when the [ValueType](ijsonvalue_valuetype.md) is **Null**. If the value contained in the specified JSON string is a String, a Number or a Boolean, the [ValueType](ijsonvalue_valuetype.md) will be updated and the actual value can then be accessed through the [GetString](ijsonvalue_getstring.md), [GetNumber](ijsonvalue_getnumber.md) or [GetBoolean](ijsonvalue_getboolean.md) methods. If [Parse](jsonvalue_parse.md) fails due to an invalid JSON string or resource allocation errors, the [ValueType](ijsonvalue_valuetype.md) will not be changed.

When implemented on the subclass [JsonObject](jsonobject_jsonobject.md), this method requires the specified input string to be a valid JSON object value. When implemented on the subclass [JsonArray](jsonarray_jsonarray.md), this method requires the specified input string to be a valid JSON array value. The original object state will be overwritten when [JsonObject](jsonobject_jsonobject.md).[Parse](jsonvalue_parse.md) or [JsonArray](jsonarray_jsonarray.md).[Parse](jsonvalue_parse.md) succeeds. If [Parse](jsonvalue_parse.md) fails, the object state remains intact.

## -examples

## -see-also
