---
-api-id: T:Windows.Globalization.GeographicRegion
-api-type: winrt class
---

<!-- Class syntax.
public class GeographicRegion : Windows.Globalization.IGeographicRegion
-->

# Windows.Globalization.GeographicRegion

## -description

Describes a region. This is usually a country, but may be a macroregion.

## -remarks

For a list of standard country/region codes used by Microsoft, see the [Official Country/Region List](/windows/uwp/publish/supported-languages).

## -examples

```csharp
// Get the user's geographic region and its display name.
var geographicRegion = new Windows.Globalization.GeographicRegion();
var displayName = geographicRegion.DisplayName;
```

## -see-also

[Globalization preferences sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/GlobalizationPreferences)
