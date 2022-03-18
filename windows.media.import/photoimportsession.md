---
-api-id: T:Windows.Media.Import.PhotoImportSession
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class PhotoImportSession : Windows.Foundation.IClosable, Windows.Media.Import.IPhotoImportSession, Windows.Media.Import.IPhotoImportSession2
-->

# Windows.Media.Import.PhotoImportSession

## -description
Represents a photo import session with a photo import source.

## -remarks
Get an instance of this class by accessing the [PhotoImportOperation.Session](photoimportoperation_session.md) property or by calling [PhotoImportSource.CreateImportSession](photoimportsource_createimportsession_1938274523.md).

For how-to guidance for adding media import to your app, see [Import media from a device](/windows/uwp/audio-video-camera/import-media-from-a-device).

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | RememberDeselectedItems |
| 1607 | 14393 | SubfolderDateFormat |

## -examples

## -see-also
[IClosable](../windows.foundation/iclosable.md), [Import media from a device](/windows/uwp/audio-video-camera/import-media-from-a-device)
