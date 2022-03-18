---
-api-id: M:Windows.UI.Xaml.Controls.Maps.MapStyleSheet.TryParseFromJson(System.String,Windows.UI.Xaml.Controls.Maps.MapStyleSheet@)
-api-type: winrt method
---

<!-- Method syntax.
public bool MapStyleSheet.TryParseFromJson(String styleAsJson, MapStyleSheet styleSheet)
-->

# Windows.UI.Xaml.Controls.Maps.MapStyleSheet.TryParseFromJson


## -description

Creates stylesheet by parsing a JSON markup string that defines a set of custom rules.

## -parameters

### -param styleAsJson

A JSON markup string that defines a set of custom rules.

### -param styleSheet

The [MapStyleSheet](mapstylesheet.md) that will represent the rules defined in JSON markup string.

## -returns

**true** if the operation completed successfully; otherwise, **false**.

## -remarks

To learn more about the properties that you can use in your JSON string to define styles, see [Map stylesheet reference](/windows/uwp/maps-and-location/elements-of-map-style-sheet).

If there's an error in the JSON markup string, this method does not throw an exception. Instead, it returns **false**.

## -see-also

## -examples

