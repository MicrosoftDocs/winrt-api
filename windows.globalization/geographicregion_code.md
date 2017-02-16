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


## -remarks

## -examples

## -see-also
