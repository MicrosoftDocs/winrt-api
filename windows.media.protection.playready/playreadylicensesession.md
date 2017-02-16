---
-api-id: T:Windows.Media.Protection.PlayReady.PlayReadyLicenseSession
-api-type: winrt class
---

<!-- Class syntax.
public class PlayReadyLicenseSession : Windows.Media.Protection.PlayReady.IPlayReadyLicenseSession, Windows.Media.Protection.PlayReady.IPlayReadyLicenseSession2
-->

# Windows.Media.Protection.PlayReady.PlayReadyLicenseSession

## -description
Creates a media session and binds license acquisition to that media session.

## -remarks
You must maintain the **PlayReadyLicenseSession** instance until playback has completed. If the app fails to do this, the garbage collector may, at its discretion, release the object. This can cause playback to fail.

## -examples

## -see-also
[IPlayReadyLicenseSession](iplayreadylicensesession.md)