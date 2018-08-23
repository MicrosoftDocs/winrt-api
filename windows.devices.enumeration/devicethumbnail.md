---
-api-id: T:Windows.Devices.Enumeration.DeviceThumbnail
-api-type: winrt class
---

<!-- Class syntax.
public class DeviceThumbnail : Windows.Foundation.IClosable, Windows.Storage.Streams.IContentTypeProvider, Windows.Storage.Streams.IInputStream, Windows.Storage.Streams.IOutputStream, Windows.Storage.Streams.IRandomAccessStream, Windows.Storage.Streams.IRandomAccessStreamWithContentType
-->

# Windows.Devices.Enumeration.DeviceThumbnail

## -description
Represents the thumbnail image for a device.

## -remarks
Call [DeviceInformation.GetThumbnailAsync](deviceinformation_getthumbnailasync_241227233.md) and handle the completion event as shown in the example.

## -examples


```javascript
// Takes a parameter of type DeviceInformation
// and retrieves a DeviceThumbnail to pass to displayImage().
function getImage (device) {   

    var thumbnail = null;
    if (device){
        device.getThumbnailAsync().then(
            function (thumbnail) {
                if (thumbnail){      
                    if (thumbnail.size > 0) {
                        displayImage(thumbnail);
                    }                                                                      
                 }     
             });
    }                                                                                     
}

function displayImage(imageFile) {
   
    try {
        // Setting 2nd parameter to 'false' cleans up 
        // the URL after first use.
        // We set this because we only need to load the URL
        // into the image tag once.
        document.getElementById("deviceImage").src = 
            window.URL.createObjectURL(imageFile, false);
    } catch (e) {
        document.getElementById("statusMessage").innerHTML = 
            "Could not display image, error: " + e.message;
    }
                
}
```



## -see-also