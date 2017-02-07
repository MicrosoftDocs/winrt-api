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

[JsonObject](jsonobject.md) is an activatable class that implements [JsonValue](jsonvalue.md) and the [IMap(String, IJsonValue)](../windows.foundation.collections/imap_2.md) interface such that its name/value pairs can be manipulated like a dictionary. When there are values with duplicated names, the last name/value pair will be stored.

## -remarks
For an example of how these class methods are used to parse an object from a JSON string and convert it into a [JsonObject](jsonobject.md) object, update the name/value pairs the object contains, and then serialize the updated [JsonObject](jsonobject.md) object as a JSON string, see [Using JavaScript Object Notation (JSON)](http://msdn.microsoft.com/library/94875e43-4e0c-499f-b409-317bcd306d3e).

## -examples

## -see-also
[Using JavaScript Object Notation (JSON)](http://msdn.microsoft.com/library/94875e43-4e0c-499f-b409-317bcd306d3e), [JSON sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=620556)