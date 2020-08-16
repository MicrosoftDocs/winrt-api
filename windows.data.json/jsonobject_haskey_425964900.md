---
-api-id: M:Windows.Data.Json.JsonObject.HasKey(System.String)
-api-type: winrt method
---

<!-- Method syntax
public bool HasKey(System.String key)
-->

# Windows.Data.Json.JsonObject.HasKey

## -description
Indicates whether the [JsonObject](jsonobject.md) has an entry with the requested key.

## -parameters
### -param key
The requested key.

## -returns
true if the [JsonObject](jsonobject.md) has an entry with the requested key; otherwise, false.

## -remarks

In C# and other languages that use .NET language projection, use the [ContainsKey](https://docs.microsoft.com/dotnet/api/system.collections.generic.idictionary-2.containskey) method instead of the **HasKey** method. The [JsonObject](jsonobject.md) class inherits **HasKey** from the [IMap&lt;String,IJsonValue&gt;](../windows.foundation.collections/imap_2.md) interface. However, this interface appears to .NET code as [IDictionary&lt;TKey,TValue&gt;](https://docs.microsoft.com/dotnet/api/system.collections.generic.idictionary-2) due to .NET language projection. Therefore, .NET code must use the **ContainsKey** method of the **IDictionary<TKey,TValue>** interface instead of the **HasKey** method of the **IMap<String,IJsonValue>** interface.

## -examples

## -see-also
