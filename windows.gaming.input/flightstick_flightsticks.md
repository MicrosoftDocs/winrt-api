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

## -see-also

## -examples

The following example copies all connected flight sticks into a new collection:

```cpp
auto myFlightSticks = ref new Vector<FlightStick^>();

for (auto flightStick : FlightStick::FlightSticks)
{
    // This code assumes that you're interested in all flight sticks.
    myFlightSticks->Append(flightStick);
}
```