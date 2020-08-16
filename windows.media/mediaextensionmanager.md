---
-api-id: T:Windows.Media.MediaExtensionManager
-api-type: winrt class
---

<!-- Class syntax.
public class MediaExtensionManager : Windows.Media.IMediaExtensionManager, Windows.Media.IMediaExtensionManager2
-->

# Windows.Media.MediaExtensionManager

## -description

Registers a media parser or codec.

## -remarks

Media extensions have the following limitations.

+ A plugin can override inbox media formats.
+ The registration is local to the application and does not affect other applications.
+ The registration persists for the lifetime of the MediaExtensionManager instance. 
<!--ie the app process lifetime. Need to figure out what that means exactly in a MoApp with MoLifetime MoState MoManagement.-->

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1703 | 15063 | RegisterMediaExtensionForAppService |

## -examples

## -see-also

[Media extension sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Media%20extensions%20sample), [Transcoding media sample](https://go.microsoft.com/fwlink/p/?linkid=242136), [Real-Time communication sample](https://go.microsoft.com/fwlink/p/?linkid=245973), [Real-time communication sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=620600)
