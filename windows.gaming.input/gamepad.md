---
-api-id: T:Windows.Gaming.Input.Gamepad
-api-type: winrt class
---

<!-- Class syntax.
public class Gamepad : Windows.Gaming.Input.IGameController, Windows.Gaming.Input.IGamepad, Windows.Gaming.Input.IGamepad2
-->

# Windows.Gaming.Input.Gamepad

## -description

Represents a gamepad.

## -remarks

Instances of the **Gamepad** class cannot be created directly; instead, instances of the **Gamepad** class are retrieved through the [Gamepad.Gamepads](gamepad_gamepads.md) property listing all connected gamepads or through the [Gamepad.GamepadAdded](gamepad_gamepadadded.md) event.

### Supported Devices

**Gamepad** supports any GIP (Gaming Input Protocol) or XUSB compatible gamepad.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | GetButtonLabel |
| 1703 | 15063 | FromGameController |
| 1703 | 15063 | TryGetBatteryReport |

## -examples

The following code snippet shows how to loop through the **Gamepad.Gamepads** list and add each one to a vector. You'll need to put a lock on the vector, because things can change at any time (a controller might be disconnected or reconnected, for example).

```cppwinrt
#include <concrt.h>
#include <winrt/Windows.Gaming.Input.h>
using namespace winrt;
using namespace Windows::Gaming::Input;
...
std::vector<Gamepad> myGamepads;
concurrency::critical_section myLock{};

for (auto const& gamepad : Gamepad::Gamepads())
{
    // Test whether the gamepad is already in myGamepads; if it isn't, add it.
    concurrency::critical_section::scoped_lock lock{ myLock };
    auto it{ std::find(begin(myGamepads), end(myGamepads), gamepad) };

    if (it == end(myGamepads))
    {
        // This code assumes that you're interested in all gamepads.
        myGamepads.push_back(gamepad);
    }
}
```

```cppcx
auto myGamepads = ref new Vector<Gamepad^>();
critical_section myLock{};

for (auto gamepad : Gamepad::Gamepads)
{
    // Test whether the gamepad is already in myGamepads; if it isn't, add it.
    critical_section::scoped_lock lock{ myLock };
    auto it = std::find(begin(myGamepads), end(myGamepads), gamepad);

    if (it == end(myGamepads))
    {
        // This code assumes that you're interested in all gamepads.
        myGamepads->Append(gamepad);
    }
}
```

## -see-also

[Windows.Gaming.Input.IGameController](igamecontroller.md),
[Gamepad and vibration](/windows/uwp/gaming/gamepad-and-vibration),
[Input practices for games](/windows/uwp/gaming/input-practices-for-games)
