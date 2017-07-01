---
-api-id: T:Windows.Media.AppRecording.AppRecordingSaveScreenshotOption
-api-type: winrt enum
---

<!-- Enumeration syntax.
public enum AppRecordingSaveScreenshotOption : int 
-->

# Windows.Media.AppRecording.AppRecordingSaveScreenshotOption

## -description
Specifies the options used for saving a screenshot with [**SaveScreenshotToFilesAsync**](apprecordingmanager_savescreenshottofilesasync_1063354614.md).

## -enum-fields
### -field None:0
No option is specified.

### -field HdrContentVisible:1
The contents of the app window includes High Dynamic Range (HDR) content.

## -remarks
Specifying this value provides the system with a hint to help it perform the proper colorspace conversions when saving a screenshot. If the content of the app window contains HDR content, the app should specify **HdrContentVisible**, otherwise the app should specify **None**. 

## -see-also
[**SaveScreenshotToFilesAsync**](apprecordingmanager_savescreenshottofilesasync_1063354614.md)

## -examples

