---
-api-id: T:Windows.UI.Composition.CompositionDrawingSurface
-api-type: winrt class
---

<!-- Class syntax.
public class CompositionDrawingSurface : Windows.UI.Composition.CompositionObject, Windows.UI.Composition.ICompositionDrawingSurface, Windows.UI.Composition.ICompositionDrawingSurface2, Windows.UI.Composition.ICompositionSurface
-->

# Windows.UI.Composition.CompositionDrawingSurface

## -description
A drawing surface for interoperation with Direct2D or Direct3D.

Equivalent WinUI class: [Microsoft.UI.Composition.CompositionDrawingSurface](/windows/winui/api/microsoft.ui.composition.compositiondrawingsurface).

## -remarks

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1703 | 15063 | Resize |
| 1703 | 15063 | Scroll(PointInt32) |
| 1703 | 15063 | Scroll(PointInt32,RectInt32) |
| 1703 | 15063 | ScrollWithClip(PointInt32,RectInt32) |
| 1703 | 15063 | ScrollWithClip(PointInt32,RectInt32,RectInt32) |
| 1703 | 15063 | SizeInt32 |

## -examples

See the code example in [Composition native interoperation with DirectX and Direct2D](/windows/uwp/composition/composition-native-interop).

## -see-also
[CompositionObject](compositionobject.md), [IClosable](../windows.foundation/iclosable.md), [ICompositionSurface](icompositionsurface.md)
