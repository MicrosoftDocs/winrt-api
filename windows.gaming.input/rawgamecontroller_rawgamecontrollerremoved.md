---
-api-id: E:Windows.Gaming.Input.RawGameController.RawGameControllerRemoved
-api-type: winrt event
---

<!-- Event syntax.
static public event EventHandler RawGameControllerRemoved<RawGameController>
-->

# Windows.Gaming.Input.RawGameController.RawGameControllerRemoved

## -description

Signals when a raw game controller is disconnected.

## -remarks

The following example stops tracking a raw game controller that's been removed.

```cppwinrt
#include <algorithm>
#include <winrt/Windows.Gaming.Input.h>
using namespace winrt;
using namespace Windows::Gaming::Input;
...
std::vector<RawGameController> m_myRawGameControllers;
...
RawGameController::RawGameControllerRemoved([this](IInspectable const& /* sender */, RawGameController const& args)
    {
        std::remove(m_myRawGameControllers.begin(), m_myRawGameControllers.end(), args);
    });
```

```cppcx
// `myRawGameControllers` is a `Vector<RawGameController^>` that contains the raw game controllers that your game is tracking.
RawGameController::RawGameControllerRemoved += 
    ref new EventHandler<RawGameController^>(
        [] (Platform::Object^, RawGameController^ args)
{
    unsigned int indexRemoved;

    if (myRawGameControllers->IndexOf(args, &indexRemoved))
    {
        myRawGameControllers->RemoveAt(indexRemoved);
    }
});
```

## -see-also

## -examples
