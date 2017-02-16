---
-api-id: M:Windows.System.UserProfile.UserInformation.SetAccountPicturesFromStreamsAsync(Windows.Storage.Streams.IRandomAccessStream,Windows.Storage.Streams.IRandomAccessStream,Windows.Storage.Streams.IRandomAccessStream)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.System.UserProfile.SetAccountPictureResult> SetAccountPicturesFromStreamsAsync(Windows.Storage.Streams.IRandomAccessStream smallImage, Windows.Storage.Streams.IRandomAccessStream largeImage, Windows.Storage.Streams.IRandomAccessStream video)
-->

# Windows.System.UserProfile.UserInformation.SetAccountPicturesFromStreamsAsync

## -description
Sets the pictures for the user's account using an [IRandomAccessStream](../windows.storage.streams/irandomaccessstream.md) object. Supports adding a small image, large image, and video.

> [!IMPORTANT]
> The [UserInformation](userinformation.md) class is not supported on Windows 10 or later. Use the [User](../windows.system/user.md) class instead. See Remarks in the [UserInformation](userinformation.md) class documentation.

## -parameters
### -param smallImage
A small version of the image.

### -param largeImage
A large version of the image.

### -param video
A video.

## -returns
A value that indicates the success or failure of the operation.

## -remarks
> [!IMPORTANT]
> The [UserInformation](userinformation.md) class is not supported on Windows 10 or later. Use the [User](../windows.system/user.md) class instead. See Remarks in the [UserInformation](userinformation.md) class documentation.

## -examples

## -see-also
[User](../windows.system/user.md)