---
-api-id: T:Windows.Data.Json.JsonObject
-api-type: winrt class
---

<!-- Class syntax.
public class JsonObject : Windows.Data.Json.IJsonObject, Windows.Data.Json.IJsonObjectWithDefaultValues, Windows.Data.Json.IJsonValue, Windows.Foundation.Collections.IIterable<Windows.Foundation.Collections.IKeyValuePair<System.String, Windows.Data.Json.IJsonValue>>, Windows.Foundation.Collections.IMap<System.String, Windows.Data.Json.IJsonValue>, Windows.Foundation.IStringable
-->

# Windows.Data.Json.JsonObject

## -description

Represents a JSON object containing a collection of name and [JsonValue](jsonvalue.md) pairs.

JsonObject is an activatable class that implements [JsonValue](jsonvalue.md) and the [IMap<String,IJsonValue>](../windows.foundation.collections/imap_2.md) interface such that its name/value pairs can be manipulated like a dictionary. When there are values with duplicated names, the last name/value pair will be stored.

## -remarks

For an example of how these class methods are used to parse an object from a JSON string and convert it into a JsonObject object, update the name/value pairs the object contains, and then serialize the updated JsonObject object as a JSON string, see [Using JavaScript Object Notation (JSON)](/previous-versions/windows/apps/hh770289(v=win.10)).

## -examples

## -see-also

[Using JavaScript Object Notation (JSON)](/previous-versions/windows/apps/hh770289(v=win.10)), [JSON sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/Json)
