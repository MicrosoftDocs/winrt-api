---
-api-id: M:Windows.Graphics.Holographic.HolographicSpace.CreateForCoreWindow(Windows.UI.Core.CoreWindow)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Graphics.Holographic.HolographicSpace CreateForCoreWindow(Windows.UI.Core.CoreWindow window)
-->

# Windows.Graphics.Holographic.HolographicSpace.CreateForCoreWindow

## -description
Creates a HolographicSpace that corresponds with the specified window's CoreApplicationView.

## -parameters
### -param window
The window to create a HolographicSpace for.

## -returns
The HolographicSpace.

## -remarks
Calling this method permanently assigns the CoreApplicationView to be holographic. You may no longer call IDXGIFactory2::CreateSwapChainForCoreWindow after calling this method, or vice versa.

## -examples

## -see-also
