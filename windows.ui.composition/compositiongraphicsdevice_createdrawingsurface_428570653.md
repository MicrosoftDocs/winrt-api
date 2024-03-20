---
-api-id: M:Windows.UI.Composition.CompositionGraphicsDevice.CreateDrawingSurface(Windows.Foundation.Size,Windows.Graphics.DirectX.DirectXPixelFormat,Windows.Graphics.DirectX.DirectXAlphaMode)
-api-type: winrt method
---

<!-- Method syntax
public Windows.UI.Composition.CompositionDrawingSurface CreateDrawingSurface(Windows.Foundation.Size sizePixels, Windows.Graphics.DirectX.DirectXPixelFormat pixelFormat, Windows.Graphics.DirectX.DirectXAlphaMode alphaMode)
-->

# Windows.UI.Composition.CompositionGraphicsDevice.CreateDrawingSurface

## -description
Creates an instance of [CompositionDrawingSurface](compositiondrawingsurface.md).



## -parameters
### -param sizePixels
The size in pixels of the surface.

### -param pixelFormat
The pixel format of the surface.

### -param alphaMode
How the alpha channel should be handled.

## -returns
The created [CompositionDrawingSurface](compositiondrawingsurface.md).

## -remarks
If the requested pixel format is unsupported by the graphics device, an exception will be thrown.

## -examples

## -see-also
