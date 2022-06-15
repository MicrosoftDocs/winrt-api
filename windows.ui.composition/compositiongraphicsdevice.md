---
-api-id: T:Windows.UI.Composition.CompositionGraphicsDevice
-api-type: winrt class
---

<!-- Class syntax.
public class CompositionGraphicsDevice : Windows.UI.Composition.CompositionObject, Windows.UI.Composition.ICompositionGraphicsDevice, Windows.UI.Composition.ICompositionGraphicsDevice2
-->

# Windows.UI.Composition.CompositionGraphicsDevice

## -description
Used to create all hardware bound resources for a given DirectX device on a compositor session. CompositionGraphicsDevice contains a DirectX device that is used to perform the GPU operations. Developers can obtain a Graphics device from the compositor top level object.

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Composition.CompositionGraphicsDevice](/windows/winui/api/microsoft.ui.composition.compositiongraphicsdevice) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -remarks

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1703 | 15063 | CreateDrawingSurface2 |
| 1703 | 15063 | CreateVirtualDrawingSurface |
| 1903 | 18362 | CreateMipmapSurface |
| 1903 | 18362 | Trim |

## -examples

## -see-also
