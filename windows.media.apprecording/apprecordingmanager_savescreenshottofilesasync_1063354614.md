---
-api-id: M:Windows.Media.AppRecording.AppRecordingManager.SaveScreenshotToFilesAsync(Windows.Storage.StorageFolder,System.String,Windows.Media.AppRecording.AppRecordingSaveScreenshotOption,Windows.Foundation.Collections.IIterable{System.String})
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<AppRecordingSaveScreenshotResult> AppRecordingManager.SaveScreenshotToFilesAsync(StorageFolder folder, String filenamePrefix, AppRecordingSaveScreenshotOption option, IIterable<String> requestedFormats)
-->

# Windows.Media.AppRecording.AppRecordingManager.SaveScreenshotToFilesAsync

## -description
Asynchronously saves an image file containing the current contents of the calling app.

## -parameters
### -param folder
The path to which the recorded media file is written.

### -param filenamePrefix
The prefix of the filename used for saved images. The system appends the appropriate extension to the filename for each format specified in the *requestedFormats* parameter.

### -param option
A value that specifies options for saving the screenshot. To help the system perform the proper colorspace conversions, apps should specify [HdrContentVisible](apprecordingsavescreenshotoption.md) if the content to be saved includes HDR content. Otherwise, apps should specify **None**.

### -param requestedFormats
A list of strings specifying the formats in which screenshot images should be saved. Get a list of the supported values for this parameter with the [SupportedScreenshotMediaEncodingSubtypes](apprecordingmanager_supportedscreenshotmediaencodingsubtypes.md) property.

## -returns
An asynchronous operation that returns an [AppRecordingSaveScreenshotResult](apprecordingsavescreenshotresult.md) upon completion that can be used to get information about the results of the save operation.

## -remarks
Images files saved using **AppRecordingManager** are not ingested into first-party experiences like GameDVR or the XBox app.

## -see-also

## -examples

