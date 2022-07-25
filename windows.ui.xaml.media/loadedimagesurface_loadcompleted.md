---
-api-id: E:Windows.UI.Xaml.Media.LoadedImageSurface.LoadCompleted
-api-type: winrt event
---

<!-- Event syntax.
public event TypedEventHandler LoadCompleted<LoadedImageSurface, LoadedImageSourceLoadCompletedEventArgs>
-->

# Windows.UI.Xaml.Media.LoadedImageSurface.LoadCompleted

## -description
Occurs when the image has been downloaded, decoded and loaded to the underlying [ICompositionSurface](../windows.ui.composition/icompositionsurface.md).



## -xaml-syntax
```xaml
<LoadedImageSurface LoadCompleted="eventhandler"/>
```

## -remarks
The [LoadedImageSurface](loadedimagesurface.md) instance will not have a loaded image or sizing information, until this 
event fires. The **LoadCompleted** event fires regardless of success or failure and the [LoadedImageSourceLoadCompletedEventArgs](loadedimagesourceloadcompletedeventargs.md)
can be used to determine the status.

The **LoadCompleted** event fires every time that the surface of an instance of **LoadedImageSurface** gets populated with an image. This includes:

* The first time that a **LoadedImageSurface** is initialized
* The device recovers from a lost state
* A DPI change causes a different image source to load
* The app recovers from a low memory state

Common uses of the **LoadCompleted** event are to put up a temporary image if the image source may take a long time to load or resize a visual exactly to the decoded
size of the **LoadedImageSurface**.

## -see-also

## -examples
In this example, we set the size of a [SpriteVisual](../windows.ui.composition/spritevisual.md) to exactly match the decoded size of a successfully loaded [LoadedImageSurface](loadedimagesurface.md).

```csharp
private Load_Completed(LoadedImageSurface sender, LoadedImageSourceLoadCompletedEventArgs e)
{
    if(e.Status == LoadedImageSourceLoadStatus.Success){
        // imageVisual is a SpriteVisual than has been previously created and whose brush references the LoadedImageSurface
        Size decodedSize = sender.DecodedSize;
        imageVisual.Size = new Vector2((float)decodedSize.Width, (float)decodedSize.Height);
        
    } else {
        // Handle a load failure
    }
}
```

