---
-api-id: P:Windows.UI.Xaml.Controls.Maps.MapElement.MapStyleSheetEntry
-api-type: winrt property
---

<!-- Property syntax.
public string MapStyleSheetEntry { get;  set; }
-->

# Windows.UI.Xaml.Controls.Maps.MapElement.MapStyleSheetEntry

## -description
Gets or sets the name of an entry in the map's style sheet that you'd like to apply to this [MapElement](mapelement.md).

## -property-value
The name of the entry in the map's style sheet that you'd like to apply to this [MapElement](mapelement.md). This name may be an existing map element (see remarks) that acts like an existing base map element of that type. Or the name may be an extension that is not used by the base map but is set by the style sheet creator and can be changed without affecting the base map (see the example code).

## -remarks
Set this property to a string or to any of the property values available in the [MapStyleSheetEntries](mapstylesheetentries.md) class.

To learn more about entries in a map style sheet, see [Map style sheet reference](/windows/uwp/maps-and-location/elements-of-map-style-sheet#version) and [Map style sheet extensions](/bingmaps/styling/map-style-sheet-extensions).

## -see-also

## -examples

```csharp
string myStyleSheetJson = @"{""version"": ""1.*"",
  ""elements"":{
    ""foodPoint"":{
      ""iconColor"":""#FF000000""}},
  ""extensions"":{
    ""myNamespace"":{
      ""myFoodPoint"":{
        ""parent"":""foodPoint"",
        ""scale"":2}}}}";

myMap.StyleSheet = MapStyleSheet.ParseFromJson(myStyleSheetJson);
myMap.MapElements.Add(new MapIcon
{
  Location = new Geopoint(new BasicGeoposition { Latitude = 50, Longitude = -120 }),
  MapStyleSheetEntry = MapStyleSheetEntries.FoodPoint,
});
myMap.MapElements.Add(new MapIcon
{
  Location = new Geopoint(new BasicGeoposition { Latitude = 44, Longitude = -120 }),
  MapStyleSheetEntry = "myNamespace.myFoodPoint",
});
```