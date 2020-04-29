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

The following example stops tracking a flight stick that's been removed.

```cppwinrt
#include <algorithm>
#include <winrt/Windows.Gaming.Input.h>
using namespace winrt;
using namespace Windows::Gaming::Input;
...
std::vector<FlightStick> m_myFlightSticks;
...
FlightStick::FlightStickRemoved([this](IInspectable const& /* sender */, FlightStick const& args)
    {
        std::remove(m_myFlightSticks.begin(), m_myFlightSticks.end(), args);
    });
```

```cppcx
FlightStick::FlightStickRemoved += 
    ref new EventHandler<FlightStick^>([] (Platform::Object^, FlightStick^ args)
{
    unsigned int indexRemoved;

    // `myFlightSticks` is a `Vector<FlightStick^>` that contains the flight sticks that your game is tracking.

    if (myFlightSticks->IndexOf(args, &indexRemoved))
    {
        myFlightSticks->RemoveAt(indexRemoved);
    }
});
```

## -see-also

## -examples
