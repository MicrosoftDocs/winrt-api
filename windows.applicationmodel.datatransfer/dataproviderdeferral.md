---
-api-id: T:Windows.ApplicationModel.DataTransfer.DataProviderDeferral
-api-type: winrt class
---

<!-- Class syntax.
public class DataProviderDeferral : Windows.ApplicationModel.DataTransfer.IDataProviderDeferral
-->

# Windows.ApplicationModel.DataTransfer.DataProviderDeferral

## -description
Used by a source app's deferral delegate to notify a [DataPackage](datapackage.md) object that the source app will produce data from another asynchronous function.

## -remarks
Source apps have the option of promising data formats to target apps, instead of supplying the format immediately. A common example is when a source app supports an image format, such as JPG, but doesn't create the format unless the target app requests it. You might want to download our [Sharing content source app sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/ShareSource). 

## -examples
The following code shows how to use a DataProviderDeferral object to defer a request from a target app.

```javascript
async private void OnDeferredImageRequestedHandler(DataProviderRequest request)
{
    if (this.imageFile != null)
    {
        // A deferral object is required because this method uses "await" before setting the 
        // data in the DataPackage.
        var deferral = request.GetDeferral();

        var imageStream = await this.imageFile.OpenAsync(FileAccessMode.Read);

        // Decode the image.
        var imageDecoder = await BitmapDecoder.CreateAsync(imageStream);

        // Re-encode the image at 50% width and height.
        var inMemoryStream = new InMemoryRandomAccessStream();
        var imageEncoder = await BitmapEncoder.CreateForTranscodingAsync(inMemoryStream, imageDecoder);
        imageEncoder.BitmapTransform.ScaledWidth = (uint)(imageDecoder.OrientedPixelWidth * 0.5);
        imageEncoder.BitmapTransform.ScaledHeight = (uint)(imageDecoder.OrientedPixelHeight * 0.5);
        await imageEncoder.FlushAsync();

        request.SetData(RandomAccessStreamReference.CreateFromStream(inMemoryStream));

        await log(OutputText, "Image has been set via deferral");

        // The data is set. Signal that the operation is complete.
        deferral.Complete();
    }
    else
    {
        await log(OutputText, "Error: imageFile is null");
    }
}

```



## -see-also
