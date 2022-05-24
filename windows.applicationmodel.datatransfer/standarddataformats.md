---
-api-id: T:Windows.ApplicationModel.DataTransfer.StandardDataFormats
-api-type: winrt class
---

<!-- Class syntax.
public class StandardDataFormats 
-->

# Windows.ApplicationModel.DataTransfer.StandardDataFormats

## -description
Contains static properties that return string values. Each string corresponds to a known format ID. Use this class to avoid errors in using string constants to specify data formats.

## -remarks
The [DataPackage](datapackage.md) class supports several format types. Whenever you need to specify a format, we recommend using the properties of the **StandardDataFormats** class, instead of string values. Doing so ensures consistency between source and target applications.

The [DataPackage](datapackage.md) class supports a number of legacy formats for interoperability between UWP app and desktop apps. To retrieve these formats, you pass one of the following strings to the [DataPackageView.GetDataAsync](datapackageview_getdataasync_225712847.md) method instead of a value from the **StandardDataFormats** class. <table>
   <tr><th>If format name is:</th><th>GetDataAsync() retrieves:</th></tr>
   <tr><td>"AnsiText"</td><td>String for CF_TEXT.</td></tr>
   <tr><td>"DeviceIndependentBitmap"</td><td>Stream for HGLOBAL corresponding to CF_DIB.</td></tr>
   <tr><td>"DeviceIndependentBitmapV5"</td><td>Stream for HGLOBAL corresponding to CF_DIBV5.</td></tr>
   <tr><td>"DataInterchangeFormat"</td><td>Stream for HGLOBAL corresponding to CF_DIF.</td></tr>
   <tr><td>"EnhancedMetafile"</td><td>Stream for HENHMETAFILE corresponding to CF_ENHMETAFILE.</td></tr>
   <tr><td>"Locale"</td><td>Stream for HGLOBAL corresponding to CF_LOCALE</td></tr>
   <tr><td>"OEMText"</td><td>String for CF_OEMTEXT.</td></tr>
   <tr><td>"PenData"</td><td>Stream for HGLOBAL corresponding to CF_PENDATA</td></tr>
   <tr><td>"RiffAudio"</td><td>Stream for HGLOBAL corresponding to CF_RIFF.</td></tr>
   <tr><td>"SymbolicLink"</td><td>Stream for HGLOBAL corresponding to CF_SYLK.</td></tr>
   <tr><td>"TaggedImageFileFormat"</td><td>Stream for HGLOBAL corresponding to CF_TIFF.</td></tr>
   <tr><td>"WaveAudio"</td><td>Stream for HGLOBAL corresponding to CF_WAVE.</td></tr>
</table>

The Windows Runtime provides limited support for metafiles. Specifically, the Windows Runtime:
+ Supports rendering metafiles, but not creating them.
+ Supports the CF_ENHMETAFILE format ("EnhancedMetafile"), but not CF_METAFILEPICT.
+ Supports requesting data in "EnhancedMetafile" format, but not providing it; that is, calling `SetData("EnhancedMetafile", <data>)` won't work.
+ Provides limited support through the clipboard API for exchanging metafiles between UWP app and desktop apps.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1803 | 17134 | UserActivityJsonArray |

## -examples

This example shows how to retrieve shared text (by using **StandardDataFormats.Text**) or a shared file or folder (by using **StandardDataFormats.StorageItems**). For more examples, see the [Clipboard sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/Clipboard) and the [ShareTarget sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/ShareTarget).

[!code-cs[HowToReceiveShare](../windows.applicationmodel.datatransfer.sharetarget/code/ShareTargetBeta/cs/MainPage.xaml.cs#Snippetcs_HandleShare)]

## -see-also
