---
-api-id: P:Windows.Gaming.Input.Preview.LegacyGipGameControllerProvider.AppCompatVersion
-api-type: winrt property
---

# Windows.Gaming.Input.Preview.LegacyGipGameControllerProvider.AppCompatVersion

<!--
public uint AppCompatVersion { get; }
-->

## -description

Gets the app compat version reported by the GIP (Gaming Input Protocol) driver.

## -property-value

The current app compat version of the GIP driver.

## -remarks

The app compat version may be used to determine whether the GIP driver is new enough to support a given feature.

Features supported as of each version:

|Version  |Features  |
|---------|---------|
|2     |Initial release         |

## -see-also

## -examples

:::code language="csharp" source="code/csharp/EnumerateControllerPropertiesSample.cs":::
