---
-api-id: T:Windows.UI.Core.Preview.Communications.PreviewTeamView
-api-type: winrt class
---

## -description
Allows the app to sign up for event handlers that notifies when the user invokes call control\screen sharing\etc UI in the shell that the app wouldn't otherwise be aware of.

## -remarks
Though an instance of PreviewTeamView must be retrieved on the UI thread, it is generally a free-threaded object whose methods do not block. For instance, calling StartScreenSharing can return before the screen sharing border is actually drawn. For this reason, some properties have callbacks so the app may be notified when the action is actually complete.

## -see-also

## -examples

