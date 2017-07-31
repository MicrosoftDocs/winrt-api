---
-api-id: N:Windows.Data.Json
-api-type: winrt namespace
---

# Windows.Data.Json

## -description
Provides support for JSON arrays, values, and objects.

## -remarks

## -examples
```csharp
string jsonString = await FileIO.ReadTextAsync(await StorageFile.GetFileFromApplicationUriAsync(new Uri("ms-appx:///Assets/MyData.json")));
var rootObject = JsonObject.Parse(jsonString);
System.Diagnostics.Debug.WriteLine(rootObject["myJsonProperty"]);
```

## -see-also
[Using JavaScript Object Notation (JSON)](http://msdn.microsoft.com/library/94875e43-4e0c-499f-b409-317bcd306d3e), [JSON sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=620556)
