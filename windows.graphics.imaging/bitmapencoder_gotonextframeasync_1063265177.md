---
-api-id: M:Windows.Graphics.Imaging.BitmapEncoder.GoToNextFrameAsync(Windows.Foundation.Collections.IIterable{Windows.Foundation.Collections.IKeyValuePair{System.String,Windows.Graphics.Imaging.BitmapTypedValue}})
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction GoToNextFrameAsync(Windows.Foundation.Collections.IIterable<Windows.Foundation.Collections.IKeyValuePair<System.String, Windows.Graphics.Imaging.BitmapTypedValue>> encodingOptions)
-->

# Windows.Graphics.Imaging.BitmapEncoder.GoToNextFrameAsync

## -description
Asynchronously commits the current frame data and appends a new empty frame, with the specified encoding options, to be edited.

## -parameters
### -param encodingOptions
The specified encoding options. A collection of key-value pairs containing one or more codec-specific encoding options and the desired values.

## -returns
An object that manages the asynchronous operation of committing the current frame data and appending a new empty frame to be edited.

## -remarks
You can obtain a collection of key-value pairs that you can pass to the *encodingOptions* parameter by creating a new [BitmapPropertySet](bitmappropertyset.md).

See [CreateAsync(Guid, IRandomAccessStream, IIterable(IKeyValuePair))](bitmapencoder_createasync_415643468.md) for more information about using encoding options.

## -examples

## -see-also
[BitmapPropertySet](bitmappropertyset.md), [GoToNextFrameAsync](bitmapencoder_gotonextframeasync_718000702.md)