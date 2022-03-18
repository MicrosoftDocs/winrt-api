---
-api-id: M:Windows.Media.Core.MediaStreamSample.CreateFromDirect3D11Surface(Windows.Graphics.DirectX.Direct3D11.IDirect3DSurface,Windows.Foundation.TimeSpan)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public MediaStreamSample MediaStreamSample.CreateFromDirect3D11Surface(IDirect3DSurface surface, TimeSpan timestamp)
-->

# Windows.Media.Core.MediaStreamSample.CreateFromDirect3D11Surface

## -description
Creates a [MediaStreamSample](mediastreamsample.md) from an [IDirect3DSurface](/uwp/api/Windows.Graphics.DirectX.Direct3D11.IDirect3DSurface).

## -parameters
### -param surface
The surface that contains the media data used to create the [MediaStreamSample](mediastreamsample.md).

### -param timestamp
The presentation time of this sample.

## -returns
The sample created from the data in *surface*.

## -remarks
For certain formats, the decode time and the presentation time of a [MediaStreamSample](mediastreamsample.md) are different. The decode time can be accessed through the [DecodeTimestamp](mediastreamsample_decodetimestamp.md) property.

## -see-also

## -examples

