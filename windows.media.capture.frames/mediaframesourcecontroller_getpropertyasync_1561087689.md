---
-api-id: M:Windows.Media.Capture.Frames.MediaFrameSourceController.GetPropertyAsync(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Media.Capture.Frames.MediaFrameSourceGetPropertyResult> GetPropertyAsync(System.String propertyId)
-->

# Windows.Media.Capture.Frames.MediaFrameSourceController.GetPropertyAsync

## -description
Asynchronously gets an object that contains the value of a [MediaFrameSource](mediaframesource.md) property, if the property value is successfully retrieved, and describes the result status of the get operation.

## -parameters
### -param propertyId
The identifier of the media frame source property to be retrieved.

## -returns
An asynchronous operation that returns a [MediaFrameSourceGetPropertyResult](mediaframesourcegetpropertyresult.md) upon completion.

## -remarks
To set the value of a media frame source property, use [SetPropertyAsync](mediaframesourcecontroller_setpropertyasync.md).

## -examples

## -see-also