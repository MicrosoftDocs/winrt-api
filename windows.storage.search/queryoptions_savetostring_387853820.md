---
-api-id: M:Windows.Storage.Search.QueryOptions.SaveToString
-api-type: winrt method
---

<!-- Method syntax
public string SaveToString()
-->

# Windows.Storage.Search.QueryOptions.SaveToString

## -description
Converts the values of a [QueryOptions](queryoptions.md) object to a string that can be used to initialize the values of a [QueryOptions](queryoptions.md) object by calling [LoadFromString](queryoptions_loadfromstring_1308493691.md).

## -returns
A string representing the serialized settings of a [QueryOptions](queryoptions.md) instance.

## -remarks
Use this method if you want to save the query options for later use. For example if you generate query options dynamically based on user input and you want to preserve these options when your app is suspended. In this case, you should also use the [FutureAccessList](../windows.storage.accesscache/storageapplicationpermissions_futureaccesslist.md) to persist access to the folder(s) where the query was created.

## -examples

## -see-also
[LoadFromString](queryoptions_loadfromstring_1308493691.md)