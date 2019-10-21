---
-api-id: M:Windows.Data.Json.JsonValue.Parse(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Data.Json.JsonValue Parse(System.String input)
-->

# Windows.Data.Json.JsonValue.Parse

## -description
Parses the specified JSON string into a [JsonValue](jsonvalue.md).

> [!NOTE]
> This method will throw an exception if the provided JSON string is not valid. Use of [JsonObject.TryParse](jsonobject_tryparse_1919547471.md) is a recommended alternative. A [TryParse](jsonvalue_tryparse_1449496227.md) call will return a boolean value to indicate success or failure and, if successful, the resultant [JsonValue](jsonvalue.md).

## -parameters
### -param input
The specified JSON string.

## -returns


## -remarks
This method may only be called when the [ValueType](ijsonvalue_valuetype.md) is **Null**. If the value contained in the specified JSON string is a String, a Number or a Boolean, the [ValueType](ijsonvalue_valuetype.md) will be updated and the actual value can then be accessed through the [GetString](ijsonvalue_getstring_1001279800.md), [GetNumber](ijsonvalue_getnumber_1143516409.md) or [GetBoolean](ijsonvalue_getboolean_1304335680.md) methods. If Parse fails due to an invalid JSON string or resource allocation errors, the [ValueType](ijsonvalue_valuetype.md) will not be changed.

When implemented on the subclass [JsonObject](jsonobject_jsonobject_1221375020.md), this method requires the specified input string to be a valid JSON object value. When implemented on the subclass [JsonArray](jsonarray_jsonarray_1221375020.md), this method requires the specified input string to be a valid JSON array value. The original object state will be overwritten when JsonObject(jsonobject_jsonobject_1221375020.md).Parse or JsonArray(jsonarray_jsonarray_1221375020.md).Parse succeeds. If Parse fails, the object state remains intact.

## -examples

## -see-also
[TryParse](jsonvalue_tryparse_1449496227.md)
