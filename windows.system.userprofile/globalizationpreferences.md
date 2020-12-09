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

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1709 | 16299 | TrySetHomeGeographicRegion |
| 1709 | 16299 | TrySetLanguages |
| 1803 | 17134 | GetForUser |

## -examples

```csharp
// Obtain the user's home geographic region.
var region = Windows.System.UserProfile.GlobalizationPreferences.HomeGeographicRegion;
```

## -see-also

[Globalization preferences sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/GlobalizationPreferences), [OCR sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/OCR)
