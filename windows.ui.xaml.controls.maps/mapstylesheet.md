---
-api-id: T:Windows.UI.Xaml.Controls.Maps.MapStyleSheet
-api-type: winrt class
---

<!-- Class syntax.
public class MapStyleSheet : DependencyObject, DependencyObject
-->

# Windows.UI.Xaml.Controls.Maps.MapStyleSheet

## -description
Represents a set of rules that define the style of the map in a [map control](mapcontrol.md). This class provides methods to:
1. Retrieve common base map styles.
2. Load custom sheets through [ParseFromJson](mapstylesheet_parsefromjson_1626148147.md) and [TryParseFromJson](mapstylesheet_tryparsefromjson_599503431.md).  To learn more about JSON style sheets, see [Map stylesheet reference](/windows/uwp/maps-and-location/elements-of-map-style-sheet).  
3. Combine multiple sheets, where later sheets override earlier sheets, using the [Combine](mapstylesheet_combine_123662630.md) method.  Usually a common base map style is be combined with custom JSON to create a customized map style.

## -remarks

## -see-also

## -examples
