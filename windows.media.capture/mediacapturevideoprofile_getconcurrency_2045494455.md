---
-api-id: M:Windows.Media.Capture.MediaCaptureVideoProfile.GetConcurrency
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.Collections.IVectorView<Windows.Media.Capture.MediaCaptureVideoProfile> GetConcurrency()
-->

# Windows.Media.Capture.MediaCaptureVideoProfile.GetConcurrency

## -description
Gets the list of [MediaCaptureVideoProfile](mediacapturevideoprofile.md) objects that can be used concurrently with this video profile.

## -returns
The list of [MediaCaptureVideoProfile](mediacapturevideoprofile.md) objects that can be used concurrently with this video profile.

## -remarks
You can get a list of video profiles that support concurrency by calling [MediaCapture.FindConcurrentProfiles](mediacapture_findconcurrentprofiles_834250833.md).

## -examples

## -see-also
[MediaCapture.FindConcurrentProfiles](mediacapture_findconcurrentprofiles_834250833.md)
## -capabilities
backgroundMediaRecording
