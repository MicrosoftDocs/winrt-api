---
-api-id: M:Windows.UI.Xaml.Controls.Maps.MapStyleSheet.ParseFromJson(System.String)
-api-type: winrt method
---

<!-- Method syntax.
public MapStyleSheet MapStyleSheet.ParseFromJson(String styleAsJson)
-->

# Windows.UI.Xaml.Controls.Maps.MapStyleSheet.ParseFromJson


## -description

Creates a stylesheet by parsing a JSON markup string that defines a set of custom rules.

## -parameters

### -param styleAsJson

A JSON markup string that defines a set of custom rules.

## -returns

A [MapStyleSheet](mapstylesheet.md) that represents the rules defined in JSON markup string.

## -remarks

## -see-also

## -examples

The following example uses the ParseFromJson method to create a [MapStyleSheet](mapstylesheet.md) and then applies that style sheet to the map control.

To learn more about the properties used in this example, see [Map stylesheet reference](/windows/uwp/maps-and-location/elements-of-map-style-sheet).

```csharp
string jsonString = @"{
  ""version"": ""1.*"",
  ""settings"":{
    ""rasterRegionsVisible"":true,
    ""spaceColor"":""#000000""
  },
  ""elements"":{
    ""majorRoad"":{
      ""labelColor"":""#490B7D"",
      ""labelScale"":1.5,
      ""font"": ""Comic Sans MS""
    }
  }
}";

MapStyleSheet myCustomStyleSheet = MapStyleSheet.ParseFromJson(jsonString);
myMap.StyleSheet = myCustomStyleSheet;

```

