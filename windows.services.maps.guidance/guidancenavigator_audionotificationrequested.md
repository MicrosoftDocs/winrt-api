---
-api-id: E:Windows.Services.Maps.Guidance.GuidanceNavigator.AudioNotificationRequested
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler AudioNotificationRequested<Windows.Services.Maps.Guidance.GuidanceNavigator,  Windows.Services.Maps.Guidance.GuidanceAudioNotificationRequestedEventArgs>
-->

# Windows.Services.Maps.Guidance.GuidanceNavigator.AudioNotificationRequested

## -description
Occurs when audio notifications are appropriate for navigational guidance, such as prior to an upcoming turn or exit.

> [!NOTE]
> This API is not available to all Windows apps. Unless your developer account is specially provisioned by Microsoft, calls to this API will fail at runtime. For more information about the [Windows.Services.Maps.Guidance](windows_services_maps_guidance.md) namespace, please work with your Microsoft Account Team representative.

## -remarks
Registering to handle this event turns off automatic audio notifications. Use the [GuidanceAudioNotificationRequestedEventArgs](guidanceaudionotificationrequestedeventargs.md) to provide your own audio notifications.

## -examples

## -see-also
