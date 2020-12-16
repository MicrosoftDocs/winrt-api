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

In C# and other languages that use .NET language projection, use the [ContainsKey](/dotnet/api/system.collections.generic.idictionary-2.containskey?view=dotnet-uwp-10.0&preserve-view=true) method instead of the **HasKey** method. The [JsonObject](jsonobject.md) class inherits **HasKey** from the [IMap<String,IJsonValue>](../windows.foundation.collections/imap_2.md) interface. However, this interface appears to .NET code as [IDictionary&lt;TKey,TValue&gt;](/dotnet/api/system.collections.generic.idictionary-2?view=dotnet-uwp-10.0&preserve-view=true) due to .NET language projection. Therefore, .NET code must use the **ContainsKey** method of the **IDictionary<TKey,TValue>** interface instead of the **HasKey** method of the **IMap<String,IJsonValue>** interface.

## -examples

## -see-also
