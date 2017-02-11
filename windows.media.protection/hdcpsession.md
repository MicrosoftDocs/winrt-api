---
-api-id: T:Windows.Media.Protection.HdcpSession
-api-type: winrt class
---

<!-- Class syntax.
public class HdcpSession : Windows.Foundation.IClosable, Windows.Media.Protection.IHdcpSession
-->

# Windows.Media.Protection.HdcpSession

## -description
Allows apps to set and query the current state of High-bandwidth Digital Content Protection (HDCP) between the graphics hardware and the display.

## -remarks
You may want to turn on HDCP for your app, even though you're using neither the low-level Media Core Media Pipeline APIs for OPM, nor PlayReady DRM.

Different ISVs (Independent Software Vendors) may need different levels of protection. An ISV with a legal requirement for "simple In-Transit protection" might use HTTPS with Auth for streaming and HDCP for display output protection. Other ISVs build sophisticated pipelines and require direct control of HDCP from within those pipelines. They may enforce the stricter HDCP2 for some content, but not require it for other content.

ISVs may want to set HDCP state and check that it has been established. If the system is unable to establish HDCP, they may opt to implement business logic which will constrain the bitrate or resolution, or not play at all. They build their business logic based on their legal obligations.

Once the app is done with playback that must be HDCP protected, they may opt to turn it back off (for trailers, for example, or as part of a clean exit).

The **HdcpSession** APIs accommodate all of the above scenarios, allowing you to tweak your app's HDCP settings to suit your particular needs.

## -examples
The following example sets HDCP and then reacts when it's completed.

First, we make some declarations:



[!code-csharp[HdcpSessionDeclarations](../windows.media.protection/code/HdcpSession/csharp/MainPage.xaml.cs#SnippetHdcpSessionDeclarations)]



[!code-csharp[HdcpSessionMethod](../windows.media.protection/code/HdcpSession/csharp/MainPage.xaml.cs#SnippetHdcpSessionMethod)]

## -see-also
[IClosable](../windows.foundation/iclosable.md)
