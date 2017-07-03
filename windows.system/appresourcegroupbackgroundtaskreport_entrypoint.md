---
-api-id: P:Windows.System.AppResourceGroupBackgroundTaskReport.EntryPoint
-api-type: winrt property
---

<!-- Property syntax.
public string EntryPoint { get; }
-->

# Windows.System.AppResourceGroupBackgroundTaskReport.EntryPoint

## -description
Gets the name of the background task entry point.

## -property-value
The name of the entry point as specified in the app manifest.

## -remarks
The entry point string is taken from the definition in the manifest. For example, the EntryPoint string will be `"Tasks.BackgroundTaskClass"` for a manifest that contains the following declaration:
```xml
<Extension Category="windows.backgroundTasks" EntryPoint="Tasks.BackgroundTaskClass">
    <BackgroundTasks>
        <Task Type="systemEvent" />
        <Task Type="pushNotification" />
    </BackgroundTasks>
</Extension>
```

For JavaScript tasks, the entry point string is taken from the value of the **StartPage** attribute in the background task registration. For example, the entry point string will be `"js\completionGroupBackgroundTask.js"` for a manifest that contains the following declaration:

```xml
<Extension Category="windows.backgroundTasks" StartPage="js\completionGroupBackgroundTask.js">
  <BackgroundTasks>
    <Task Type="general" />
  </BackgroundTasks>
</Extension>
```

## -see-also

## -examples

## -capabilities
appDiagnostics
