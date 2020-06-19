---
-api-id: T:Windows.Graphics.Display.DisplayPropertiesEventHandler
-api-type: winrt delegate
---

<!-- Delegate syntax.
public delegate void DisplayPropertiesEventHandler(System.Object sender)
-->

# Windows.Graphics.Display.DisplayPropertiesEventHandler

## -description

> [!NOTE]
> The [DisplayProperties](displayproperties.md) type and related event handlers may be altered or unavailable for releases after Windows 8.1. Instead, use [DisplayInformation](displayinformation.md).

Represents a method that handles display property events.

## -parameters
### -param sender
The object that raised the event.

## -remarks
We recommend that applications use a single delegate to handle most display events because in most cases the change to each display property requires that the application redraw itself. Also, many property changes result from a single mode change that affects the entire operating system.

The [Direct3D 11.1 Simple Stereo 3D Sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Direct3D%20stereoscopic%203D%20sample) shows how to handle system stereo changes.

## -examples

```cppwinrt
#include <winrt/Windows.Graphics.Display.h>
using namespace winrt;
using namespace Windows::Graphics::Display;
...
void GameRenderer::Initialize()
{
    DisplayProperties::StereoEnabledChanged({ this, &GameRenderer::OnStereoEnableChanged });
}

void GameRenderer::OnStereoEnableChanged(winrt::Windows::Foundation::IInspectable const& sender)
{
    UpdateForStereoChange();
}
```

```cppcx
void GameRenderer::Initialize()
{
    DisplayProperties::StereoEnabledChanged += 
        ref new DisplayPropertiesEventHandler(this, &GameRenderer::OnStereoEnableChanged);
}

void GameRenderer::OnStereoEnableChanged(_In_ Platform::Object^ sender)
{
    UpdateForStereoChange();
}
```

## -see-also
