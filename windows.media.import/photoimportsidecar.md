---
-api-id: T:Windows.Media.Import.PhotoImportSidecar
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class PhotoImportSidecar : Windows.Media.Import.IPhotoImportSidecar
-->

# Windows.Media.Import.PhotoImportSidecar

## -description
Represents a sidecar file or a sibling file to a [PhotoImportItem](photoimportitem.md).

## -remarks
Get an instance of this class by accessing the [PhotoImportItem.Sibling](photoimportvideosegment_sibling.md) property or the [PhotoImportItem.Sidecars](photoimportitem_sidecars.md) property.

A Sidecar is a file that is not a JPEG nor a RAW file, nor a LRV file in the item is a video, that shares the same base-name as the main file it refers to, but with a different file extension. Sidecars can contain additional metadata (.XMP), a thumbnail (.THM), an audio annotation (.WAV) or possibly any other additional data, such as for example a GPS track alongside a video file, in the form of a text file containing NMEA sentences. As an example, a JPEG file named DSC_0001.JPG might have a DSC_0001.WAV audio annotation. The correlation can be done on the path + base name. The timestamps of sidecars may be similar or identical to the timestamp of the main files, however, in case of .XMP sidecars (metadata) and possibly others, it is conceivable that the sidecar has been edited, say to rate the image, at a later point in time. There may be more than one sidecar for any given file, for example a thumbnail, an audio annotation, and an XMP metadata sidecar, all attached to the same file.

For photos, a sibling is the RAW file associated with a matching JPEG file produced by digital cameras set to RAW+JPEG shooting mode, where the camera produces two distinct files for every picture taken. The Windows.Media.Import APIs considers the JPEG file to be the main item of the pair, and the RAW to be the sibling.

For video, a sibling is a low-resolution version of the main video, for example .mp4 + .lrv pairs. The Windows.Media.Import APIs considers the .MP4 to be the main item of the pair, and the low-resolution version to be the sibling.

There can be at most one sibling attached to a given importable item.

## -examples

## -see-also
