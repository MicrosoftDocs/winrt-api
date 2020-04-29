---
-api-id: E:Windows.Gaming.Input.FlightStick.FlightStickAdded
-api-type: winrt event
---

<!-- Event syntax.
static public event EventHandler FlightStickAdded<FlightStick>
-->

# Windows.Gaming.Input.FlightStick.FlightStickAdded

## -description

Signals when a new flight stick is connected.

## -remarks

To identify flight sticks that have already been added, you query the list of connected flight sticks using [FlightStick.FlightSticks](flightstick_flightsticks.md). However, because you might only be interested in some of the connected flight sticks, we recommend that you maintain your own collection instead of accessing them through **FlightSticks**.

## -see-also

## -examples

The following example starts tracking a flight stick that's been added.

```cppwinrt
#include <winrt/Windows.Gaming.Input.h>
using namespace winrt;
using namespace Windows::Gaming::Input;
...
std::vector<FlightStick> m_myFlightSticks;
...
FlightStick::FlightStickAdded([this](IInspectable const& /* sender */, FlightStick const& args)
    {
        m_myFlightSticks.push_back(args);
    });
```

```cppcx
FlightStick::FlightStickAdded += 
    ref new EventHandler<FlightStick^>([] (Platform::Object^, FlightStick^ args)
{
    // This code assumes that you're interested in all new flight sticks.
    // `myFlightSticks` is a `Vector<FlightStick^>` that contains the flight sticks that your game is tracking.
    myFlightSticks->Append(args);
});
```