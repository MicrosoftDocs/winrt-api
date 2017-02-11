---
-api-id: M:Windows.Globalization.GeographicRegion.IsSupported(System.String)
-api-type: winrt method
---

<!-- Method syntax
public bool IsSupported(System.String geographicRegionCode)
-->

# Windows.Globalization.GeographicRegion.IsSupported

## -description
Determines whether a geographic region identifier is supported.

## -parameters
### -param geographicRegionCode
One of the ISO 3166-1 two-letter or three-letter codes that identify the country, or one of the three-digit UN-M49 codes that identify the geographical region.

## -returns
**True** if the ID is known; otherwise, ** false**. If this method returns **true**, an app can safely construct a region by using this region identifier. If it returns **false**, attempting to construct a region for the given code will throw an exception.

## -remarks

## -examples

## -see-also
