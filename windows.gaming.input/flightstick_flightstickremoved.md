---
-api-id: E:Windows.Gaming.Input.FlightStick.FlightStickRemoved
-api-type: winrt event
---

<!-- Event syntax.
static public event EventHandler FlightStickRemoved<FlightStick>
-->

# Windows.Gaming.Input.FlightStick.FlightStickRemoved

## -description

Signals when a flight stick is disconnected.

## -remarks

The following example stops tracking a flight stick that's been removed. `myFlightSticks` is a `Vector<FlightStick^>` that contains the flight sticks that your game is tracking.

```cpp
FlightStick::FlightStickRemoved += 
    ref new EventHandler<FlightStick^>([] (Platform::Object^, FlightStick^ args)
{
    unsigned int indexRemoved;

    if (myFlightSticks->IndexOf(args, &indexRemoved))
    {
        myFlightSticks->RemoveAt(indexRemoved);
    }
});
```

## -see-also

## -examples
