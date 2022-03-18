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

[Using JavaScript Object Notation (JSON)](/previous-versions/windows/apps/hh770289(v=win.10)), [JSON sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/Json)
