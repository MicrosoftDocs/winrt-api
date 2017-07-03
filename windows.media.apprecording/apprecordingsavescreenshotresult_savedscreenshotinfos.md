---
-api-id: P:Windows.Media.AppRecording.AppRecordingSaveScreenshotResult.SavedScreenshotInfos
-api-type: winrt property
---

<!-- Property syntax.
public IVectorView<AppRecordingSavedScreenshotInfo> SavedScreenshotInfos { get; }
-->

# Windows.Media.AppRecording.AppRecordingSaveScreenshotResult.SavedScreenshotInfos

## -description
Gets a list of [**AppRecordingSavedScreenshotInfo**](C:\Users\drewbat\Source\Repos\winrt-api\windows.media.apprecording\apprecordingsavedscreenshotinfo_file.md) objects representing the image files saved from the screenshot operation.

## -property-value
A list of [**AppRecordingSavedScreenshotInfo**](C:\Users\drewbat\Source\Repos\winrt-api\windows.media.apprecording\apprecordingsavedscreenshotinfo_file.md) objects representing the image files saved from the screenshot operation.

## -remarks
[**SaveScreenshotToFilesAsync**](apprecordingmanager_savescreenshottofilesasync_1063354614.md) allows you to save multiple image files, each with different image encoding, with a single call. The **AppRecordingSavedScreenshotInfo** objects returned by this property allow you to access the **StorageFile** and encoding subtype for each saved image.

## -see-also

## -examples

