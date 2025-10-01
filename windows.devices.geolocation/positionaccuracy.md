---
-api-id: T:Windows.Devices.Geolocation.PositionAccuracy
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Devices.Geolocation.PositionAccuracy : int
-->

# PositionAccuracy

## -description
Indicates the requested accuracy level for the location data that the application uses.

## -enum-fields
### -field Default:0
Optimize for power, performance, and other cost considerations.

### -field High:1
Deliver the most accurate report possible. This includes using services that might charge money, or consuming higher levels of battery power or connection bandwidth. An accuracy level of `High` may degrade system performance and should be used only when necessary.


## -remarks

The [PositionAccuracy](positionaccuracy.md) setting controls the balance between location accuracy and power consumption.

### Accuracy vs power consumption

- `Default`: Balanced approach optimizing for typical scenarios. Uses the most appropriate available location source
  based on signal quality and power considerations.

- `High`: Maximum accuracy using all available location sources, including GNSS when possible. Consumes more battery
  power and may take longer to obtain a position.

> [!TIP]
> Use `Default` accuracy for most applications. Only use `High` when your app specifically requires the highest
> possible precision and the user experience justifies the additional power consumption.

> [!NOTE]
> For fine-grained accuracy control, use [DesiredAccuracyInMeters](geolocator_desiredaccuracyinmeters.md) instead of
> this enum to specify the accuracy requirement in meters.

## -examples

## -see-also

[Geolocator](geolocator.md)

## -capabilities
location
