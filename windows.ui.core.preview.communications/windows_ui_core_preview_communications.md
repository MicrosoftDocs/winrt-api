---
-api-id: N:Windows.UI.Core.Preview.Communications
-api-type: winrt namespace
---

## -description
Allows Teams or any other developer to write a plug-in VTC app for Surface Hub. 

## -remarks
On Windows Team Edition, an app can use the previewTeamView and teamEditionDeviceCredential capabilities along with the Windows.UI.Core.Preview.Communications API surface to become the default VTC handler on the Surface Hub device. When invoked by the shell, the default VTC app will be Launch activated. If the user has selected a specific meeting, the URI that was set in the OnlineMeetingLink field of the outlook item will be available to the app as its first launch argument.

Once activated, as long as the app has the appropriate capabilities in its manifest, it will be able to call the static function PreviewTeamView::GetForCurrentThread(). This function must be called from the app's UI thread. The PreviewTeamView class allows the app to sign up for event handlers that notify it if the user has invoked call control\screen sharing\etc UI in the shell that the app wouldn't otherwise be aware of. The app can also use functions available on this object to notify the shell that it wishes to begin a call, screen sharing or other activity. GetForCurrentThread will always return the same instance of PreviewTeamView for a given thread, so it's not necessary to cache an instance of it. The typical usage is to get the instance during app launch, and use it to sign up for all the event handlers. Though an instance of PreviewTeamView must be retrieved on the UI thread, it is generally a free-threaded object whose methods do not block. For instance, calling StartScreenSharing can return before the screen sharing border is actually drawn. For this reason, some properties have callbacks so the app may be notified when the action is actually complete.

If the app wishes to use the device credentials to authenticate the call using the device account, it can retrieve the plain text credentials for the device account by constructing an instance of PreviewTeamDeviceCredentials. Assuming the app has the appropriate capability, this object after construction will contain the unencrypted plain text device account credentials.

## -see-also

## -examples

