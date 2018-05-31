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

## -examples

```javascript
// Get the user's geographic region and its display name.
var geographicRegion = new Windows.Globalization.GeographicRegion;
var displayName = geographicRegion.displayName;
```

```csharp
// Get the user's geographic region and its display name.
var geographicRegion = new Windows.Globalization.GeographicRegion();
var displayName = geographicRegion.DisplayName;
```

## -see-also

[Globalization preferences sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=624045)