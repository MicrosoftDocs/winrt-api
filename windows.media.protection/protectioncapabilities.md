---
-api-id: T:Windows.Media.Protection.ProtectionCapabilities
-api-type: winrt class
---

<!-- Class syntax.
public class ProtectionCapabilities 
-->

# Windows.Media.Protection.ProtectionCapabilities

## -description
Exposes Microsoft PlayReady digital rights management (DRM) capabilities for video decoding, video display, and video output protection subsystems used by the Windows Media Foundation pipeline under a XAML [MediaElement](/uwp/api/Windows.UI.Xaml.Controls.MediaElement) or  C++ Media Engine to a WinRT caller.  The caller may use this information to select the most appropriate encoding of DRM’ed content for playback. 

## -remarks
Software DRM typically does not need this information, and may rely on **MediaElement** or Media Engine **CanPlayType**.  Capabilities for hardware DRM may be a constrained subset of those for software DRM, and are controlled by Graphics IHVs’ hardware and firmware.  For example, a specific graphics adapter’s decoder may be able to handle HEVC 10-bit video streams for software DRM and clear content, and not for hardware DRM.  The capability queries are therefore targeted at responses for hardware DRM, although the class does support limited queries for software DRM.

Individual elements of queries for DRM capabilities are referred to as features.  Each subsystem may have one or more features.PlayReady DRM is the only DRM system supported by this class.  Software DRM refers to the PlayReady mode of operation where hardware-based content key management, content decryption, license policy enforcement, and video buffer protection are not required.  Hardware DRM requires Graphics IHV hardware and firmware to enforce all of these parts of the content flow.

For hardware DRM, all of the video subystems must be GPU accelerated.  For software DRM, all of the video subsystems may be, and typically are, GPU accelerated.  This means that playback performance is not significantly different between them in the best case.  Hardware DRM’s goal is to provide a higher level of content protection robustness than software DRM.


## -see-also

## -examples

