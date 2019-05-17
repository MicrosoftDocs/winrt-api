---
-api-id: T:Windows.ApplicationModel.Chat.ChatMessageNotificationTriggerDetails
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class ChatMessageNotificationTriggerDetails : Windows.ApplicationModel.Chat.IChatMessageNotificationTriggerDetails, Windows.ApplicationModel.Chat.IChatMessageNotificationTriggerDetails2
-->

# Windows.ApplicationModel.Chat.ChatMessageNotificationTriggerDetails

## -description
Represents the message notification triggered from a registered background task. A chat app can receive notifications of incoming messages or send events by setting a task trigger and task entry point.

## -remarks
A chat app must register a background task to process notifications in order to serve as the default handler for incoming messages. In order to register a background task, the *Package.appxmanifest* file must contain a background task extension. Add the following code snippet into the `Application/Extensions` element.

```xml
<Extension Category="windows.backgroundTasks" Entry-Point="Tasks.ExampleBackgroundTask">
    <BackgroundTasks>
        <Task Type="chatMessageNotification"/>
        <Task Type="systemEvent"/>
    </BackgroundTasks>
</Extension>

```

The background task's [Run](../windows.applicationmodel.background/ibackgroundtask_run_2017283929.md) method receives a task instance with the notification trigger details. The [TriggerDetails](../windows.applicationmodel.background/ibackgroundtaskinstance_triggerdetails.md) property is cast to a ChatMessageNotificationTriggerDetails object. The trigger details for a chat message are obtained as shown in the following example.

```
public void Run(IBackgroundTaskInstance taskInstance)
{
    BackgroundTaskDeferral deferral = taskInstance.GetDeferral();
    ChatMessageNotificationTriggerDetails triggerDetails =
        (ChatMessageNotificationTriggerDetails) taskInstance.TriggerDetails;
    
    if (triggerDetails != null)
    {
        SendToast(triggerDetails.ChatMessage);
    }
}

```





## -examples

## -see-also

## -capabilities
chatSystem, smsSend, chat
