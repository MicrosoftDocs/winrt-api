---
-api-id: M:Windows.Media.Editing.MediaOverlayLayer.#ctor(Windows.Media.Effects.IVideoCompositorDefinition)
-api-type: winrt method
---

<!-- Method syntax
public MediaOverlayLayer(Windows.Media.Effects.IVideoCompositorDefinition compositorDefinition)
-->

# Windows.Media.Editing.MediaOverlayLayer.MediaOverlayLayer

## -description
Initializes a new instance of the [MediaOverlayLayer](mediaoverlaylayer.md) class.

## -parameters
### -param compositorDefinition
The definition of the custom compositor associated with the media overlay layer.  This is 
typically an instance of the [VideoCompositorDefinition] class.

## -remarks

## -examples

    var propertySet = new PropertySet
    {
       ["Feather"] = true,
       ["Tolerance"] = 0.2f,
       ["Color"] = Colors.Blue
    };

    // the name of a sealed class in a Windows Runtime Component project that implements 
    // the IVideoCompositor interface.
    var className = "Effects.ChromaKeyVideoCompositor";

    var compositorDefinition = new VideoCompositorDefinition(className, propertySet);

    var layer = new MediaOverlayLayer(compositorDefinition);'
## -see-also
