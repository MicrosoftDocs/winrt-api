---
-api-id: M:Windows.UI.Xaml.Controls.Maps.MapModel3D.CreateFrom3MFAsync(Windows.Storage.Streams.IRandomAccessStreamReference)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<MapModel3D> MapModel3D.CreateFrom3MFAsync(IRandomAccessStreamReference source)
-->

# Windows.UI.Xaml.Controls.Maps.MapModel3D.CreateFrom3MFAsync

## -description
Creates an instance of a [MapModel3D](mapmodel3d.md) by importing a 3D object from a [3D Manufacturing Format (3MF)](https://3mf.io/spec/) file.

## -parameters
### -param source
A [3D Manufacturing Format (3MF) file](https://3mf.io/spec/) file that describes a 3D object.

## -returns
A 3D model object.

## -remarks
Set the [Model](mapelement3d_model.md) property of the [MapElement3D](mapelement3d.md) to this object.

## -see-also

## -examples
