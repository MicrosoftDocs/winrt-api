---
-api-id: P:Windows.UI.Xaml.Controls.Maps.MapElement.MapStyleSheetEntryState
-api-type: winrt property
---

<!-- Property syntax.
public string MapStyleSheetEntryState { get;  set; }
-->

# Windows.UI.Xaml.Controls.Maps.MapElement.MapStyleSheetEntryState

## -description
Gets or sets the name of the state of this [MapElement](mapelement.md). If the style sheet defines a style for that state, that style is applied to this element. Values defined in the style sheet for the state override values defined in the [MapStyleSheetEntry](mapelement_mapstylesheetentry.md).

## -property-value
The name of the state of this [MapElement](mapelement.md). 

## -remarks
Set this property to a string or to any of the property values available in the [MapStyleSheetEntryStates](mapstylesheetentrystates.md) class.

To learn more about entries in a map style sheet, see [Map style sheet reference](/windows/uwp/maps-and-location/elements-of-map-style-sheet#version).

## -see-also

## -examples

```csharp
string myStyleSheetJson = @"{""version"": ""1.*"",
  ""extensions"":{
    ""myNamespace"":{
      ""myState"":{
        ""fillColor"":""#FF0000""}}}}";

this.map.StyleSheet = MapStyleSheet.ParseFromJson(myStyleSheetJson);
this.map.MapElements.Add(new MapIcon
{
  Location = new Geopoint(new BasicGeoposition { Latitude = 44, Longitude = -120 }),
  MapStyleSheetEntry = MapStyleSheetEntries.FoodPoint,
  MapStyleSheetEntryState = MapStyleSheetEntryStates.Selected,
});
this.map.MapElements.Add(new MapIcon
{
  Location = new Geopoint(new BasicGeoposition { Latitude = 47, Longitude = -120 }),
  MapStyleSheetEntry = MapStyleSheetEntries.FoodPoint,
  MapStyleSheetEntryState = "myNamespace.myState",
});
```
