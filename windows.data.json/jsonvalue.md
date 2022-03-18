---
-api-id: T:Windows.Data.Json.JsonValue
-api-type: winrt class
---

<!-- Class syntax.
public class JsonValue : Windows.Data.Json.IJsonValue, Windows.Foundation.IStringable
-->

# Windows.Data.Json.JsonValue

## -description

Implements the [IJsonValue](ijsonvalue.md) interface which represents a JSON value.

A JsonValue object can represent the three primitive JSON value types of Boolean, Number and String, and can also represent the complex value types of Array and Object by providing ways to access them.

## -remarks

A JsonValue object has overloaded constructors to instantiate a new object from a JSON String, Number or Boolean value and a default constructor that instantiates a JsonValue object with a [ValueType](ijsonvalue_valuetype.md) of **NULL**.

For an example of how these class methods are used to parse a number or string from a JSON string and convert it into a JsonValue object, see [Using JavaScript Object Notation (JSON)](/previous-versions/windows/apps/hh770289(v=win.10)).

## -examples

## -see-also

[Using JavaScript Object Notation (JSON)](/previous-versions/windows/apps/hh770289(v=win.10)), [ValueType](ijsonvalue_valuetype.md), [JSON sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/Json)
