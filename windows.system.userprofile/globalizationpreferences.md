---
-api-id: T:Windows.System.UserProfile.GlobalizationPreferences
-api-type: winrt class
---

<!-- Class syntax.
public class GlobalizationPreferences 
-->

# Windows.System.UserProfile.GlobalizationPreferences

## -description

A static class for holding various user globalization preferences.

## -remarks

## -examples

```javascript
// Obtain the user's home geographic region.
var globalizationPreferences = Windows.System.UserProfile.GlobalizationPreferences;
var region = globalizationPreferences.homeGeographicRegion;
```

```csharp
// Obtain the user's home geographic region.
var region = Windows.System.UserProfile.GlobalizationPreferences.HomeGeographicRegion;
```

## -see-also

[Globalization preferences sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=624045), [OCR sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/OCR)