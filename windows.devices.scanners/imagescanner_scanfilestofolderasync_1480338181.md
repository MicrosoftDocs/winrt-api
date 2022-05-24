---
-api-id: M:Windows.Devices.Scanners.ImageScanner.ScanFilesToFolderAsync(Windows.Devices.Scanners.ImageScannerScanSource,Windows.Storage.StorageFolder)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperationWithProgress<Windows.Devices.Scanners.ImageScannerScanResult, uint> ScanFilesToFolderAsync(Windows.Devices.Scanners.ImageScannerScanSource scanSource, Windows.Storage.StorageFolder storageFolder)
-->

# Windows.Devices.Scanners.ImageScanner.ScanFilesToFolderAsync

## -description
Starts a scan job with the specified scan source and writes one or multiple images to one multi-page file like TIFF, XPS, and PDF; or one or multiple single-page files like DIB, PNG, JPG, and TIFF to the specified folder location. Returns the progress of the scan.

## -parameters
### -param scanSource
The image scan source.

### -param storageFolder
The target folder location of the scanned file.

## -returns
The list of scanned image files from ImageScannerScanResult and the progress of the WIA scan job from UInt32, which indicates how many files were transferred to the target folder.

## -remarks
The files are named using temporary names, with a standard file extension that depends on the file format type.



> [!NOTE]
> In UWP app, when this method is invoked, the app must be visible and running in the foreground.

When the app cancels the async call, it initiates a cancellation request of the current scan job. There is no guarantee that if the app cancels the async call that the scan job will be canceled. If the cancellation goes through, the scanner may stop for these reasons:


+ It takes a few seconds before the scanner stops scanning.
+ It stops only when it runs out of paper (for a feeder acquisition).
+ It completes running the scan head to the end of the bed and then fully returns the scan head to its parked location (for a flatbed acquisition).


Internally the async cancelation will flag the current WIA 2.0 scan job as canceled from within the app. If the WIA device makes the next callback to the WIA service the job cancellation may or may not be successfully communicated to the WIA driver. But, even if the WIA driver receives the cancel request from one of its callbacks there is no guarantee that the driver can successfully stop the scanner from scanning, immediately or after any predictable period of time.

Here's the list of WIA specific HRESULT error codes as well as standard COM HRESULT error codes this function returns. 

> [!NOTE]
> (the API will call WinRTOriginateError and/or OriginateErrorWithResourceString (all specific WIA errors will have localizable error descriptions) for the WIA specific failure HRESULTs):

<table>
   <tr><td>WIA_ERROR_GENERAL_ERROR</td><td>WIA_ERROR_PAPER_JAM</td><td>WIA_ERROR_PAPER_EMPTY</td></tr>
   <tr><td>WIA_ERROR_PAPER_PROBLEM</td><td>WIA_ERROR_OFFLINE</td><td>WIA_ERROR_BUSY</td></tr>
   <tr><td>WIA_ERROR_WARMING_UP</td><td>WIA_ERROR_USER_INTERVENTION</td><td>WIA_ERROR_ITEM_DELETED</td></tr>
   <tr><td>WIA_ERROR_DEVICE_COMMUNICATION</td><td>WIA_ERROR_INVALID_COMMAND</td><td>WIA_ERROR_INCORRECT_HARDWARE_SETTING</td></tr>
   <tr><td>WIA_ERROR_DEVICE_LOCKED</td><td>WIA_ERROR_EXCEPTION_IN_DRIVER</td><td>WIA_ERROR_INVALID_DRIVER_RESPONSE</td></tr>
   <tr><td>WIA_ERROR_COVER_OPEN</td><td>WIA_ERROR_LAMP_OFF</td><td>WIA_ERROR_MULTI_FEED</td></tr>
</table>

There are two special cases:


+ The WIA’s HRESULT of S_FALSE will be translated to a canceled async call (AsyncStatus.Canceled).
+ The WIA’s WIA_ERROR_PAPER_EMPTY will be translated by this API to a successful return (AsyncStatus.Completed) with an empty list of files (IVectorView.Size set to 0).
To prevent orphan files, this method deletes any remaining orphan files used to transfer images upon failure, before the failure occurred. The method will save the transfer files as temporary files and keep them until the scan job completes. The app must instruct the user to rescan the document.

## -examples

## -see-also
