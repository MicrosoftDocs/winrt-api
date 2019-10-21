---
-api-id: P:Windows.Gaming.Input.FlightStick.FlightSticks
-api-type: winrt property
---

<!-- Property syntax.
public IVectorView<FlightStick> FlightSticks { get; }
-->

# Windows.Gaming.Input.FlightStick.FlightSticks

## -description

The list of all connected flight sticks.

## -property-value

The list of all connected flight sticks.

## -remarks

**FlightStick** objects are managed by the system, therefore you don't have to create or initialize them. Instead, you can access connected flight sticks through this property. Because you might only be interested in some of the connected flight sticks, we recommend that you maintain your own collection.

This list is initially empty and will not list flight sticks even if they are already connected. After a short period this will return a complete list of flight sticks.

## -see-also

## -examples
