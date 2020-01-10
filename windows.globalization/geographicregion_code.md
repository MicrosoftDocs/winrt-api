---
-api-id: P:Windows.Globalization.GeographicRegion.Code
-api-type: winrt property
---

<!-- Property syntax
public string Code { get; }
-->

# Windows.Globalization.GeographicRegion.Code

## -description

Gets the string that contains the best available identifier that represents the region.

## -property-value

Returns a string that contains:

+ The two-letter identifier code, if one exists (and is not "ZZ");
+ otherwise, the three-letter identifier code, if one exists (and is not "ZZZ");
+ otherwise, the three-digit numeric identifier code, if one exists (and is not "999");
+ otherwise, "ZZ".

For a list of standard country/region codes used by Microsoft, see the [Official Country/Region List](/openspecs/windows_protocols/ms-lcid/a9eac961-e77d-41a6-90a5-ce1a8b0cdb9c).

## -remarks

## -examples

## -see-also
