---
-api-id: P:Windows.UI.Xaml.Controls.Maps.MapControl.StyleSheet
-api-type: winrt property
---

<!-- Property syntax.
public MapStyleSheet StyleSheet { get;  set; }
-->

# Windows.UI.Xaml.Controls.Maps.MapControl.StyleSheet

## -description
Gets or sets an object that defines the style of the map control.

## -property-value
An object that defines the style of the map control.

## -remarks

## -see-also

## -examples
The following example sets the [StyleSheet](mapcontrol_stylesheet.md) property by using one of the provided styles through the static [MapStyleSheet.RoadDark](mapstylesheet_roaddark_376470101.md) method.

```csharp
  myMap.StyleSheet = MapStyleSheet.RoadDark();
```

Custom map styles can be defined in JSON and loaded through the [MapStyleSheet.ParseFromJson](mapstylesheet_parsefromjson_1626148147.md) method.  They can optionally combined with a provided style.

A scalable way to do this is to create a file named MyStyle.json in the Assets folder of a UWP application.  Make sure that its Build Action property is set to Content.

```json
{
    "version": "1.*",
    "elements":{
        "water":{
            "fillColor":"#FF000000"
        }
    }
}
```

Add the following code to the application which has a MapControl named myMap.

```csharp
Uri uri = new Uri("ms-appx:///Assets/MyStyle.json");
StorageFile file = await StorageFile.GetFileFromApplicationUriAsync(uri);
string jsonText = await FileIO.ReadTextAsync(file);
myMap.StyleSheet = MapStyleSheet.Combine(new List<MapStyleSheet>
{
    MapStyleSheet.RoadLight(),
    MapStyleSheet.ParseFromJson(jsonText)
});
```
