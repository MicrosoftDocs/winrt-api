---
-api-id: E:Windows.UI.WebUI.WebUIApplication.BackgroundActivated
-api-type: winrt event
ms.custom: RS5
---

<!-- Event syntax.
static public event BackgroundActivatedEventHandler BackgroundActivated
-->

# Windows.UI.WebUI.WebUIApplication.BackgroundActivated

## -description
Invoked when the application is activated in the background.

## -remarks
`BackgroundActivated` is a special UWP background task that runs as a handler on the view thread (or *background script*, see below). Unlike a regular background task running on a worker thread, this provides access to the DOM and referenece to foreground views.

This event is the web app equivalent of the Windows.UI.Xaml [Application.OnBackgroundActivated](../windows.ui.xaml/application_onbackgroundactivated_431338129.md) event. In the web app case specifically, if there is no running view thread (the app is not running), the event will activate the app's [background script](/microsoft-edge/dev-guide#progressive-web-apps) and fire there.

Similar to XAML, to denote a background script as background activation, a `null` taskEntryPoint is provided to [BackgroundTaskBuilder](../windows.applicationmodel.background/backgroundtaskbuilder.md). This background task is registered programmatically (rather than declared in the *appxmanifest*):

```javascript
let builder = new Windows.ApplicationModel.Background.BackgroundTaskBuilder();
builder.name = 'WwaHostBGActivated';
builder.setTrigger(new background.SystemTrigger(background.SystemTriggerType.timeZoneChange, false));
let backgroundTaskRegistration = builder.register();
```

## -see-also

## -examples

