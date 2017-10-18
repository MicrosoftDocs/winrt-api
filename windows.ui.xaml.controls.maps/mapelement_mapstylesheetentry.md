---
-api-id: P:Windows.UI.Xaml.Controls.Maps.MapElement.MapStyleSheetEntry
-api-type: winrt property
---

<!-- Property syntax.
public string MapStyleSheetEntry { get;  set; }
-->

# Windows.UI.Xaml.Controls.Maps.MapElement.MapStyleSheetEntry

## -description
Gets or sets the name of the entry of this [MapElement](mapelement.md) in the style sheet. If the style sheet defines a style for that entry, that style is applied to this element.

## -property-value
The name of the entry of this [MapElement](mapelement.md) in the style sheet. 

## -remarks
Set this property to a string or to any of the property values available in the [MapStyleSheetEntries](mapstylesheetentries.md) class.

To learn more about entries in a map style sheet, see [Map style sheet reference](https://docs.microsoft.com/windows/uwp/maps-and-location/elements-of-map-style-sheet#version).

## -see-also

## -examples

```csharp
string myStyleSheetJson = @"{""version"": ""1.*"",
  ""extensions"":{
    ""myNamespace"":{
      ""myFoodPoint"":{
        ""parent"":""foodPoint"",
        ""scale"":2}}}}";

this.map.StyleSheet = MapStyleSheet.ParseFromJson(myStyleSheetJson);
this.map.MapElements.Add(new MapIcon
{
  Location = new Geopoint(new BasicGeoposition { Latitude = 44, Longitude = -120 }),
  MapStyleSheetEntry = MapStyleSheetEntries.FoodPoint,
});
this.map.MapElements.Add(new MapIcon
{
  Location = new Geopoint(new BasicGeoposition { Latitude = 47, Longitude = -120 }),
  MapStyleSheetEntry = "myNamespace.myFoodPoint",
});
```
