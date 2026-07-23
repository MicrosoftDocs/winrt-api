---
-api-id: M:Windows.UI.Shell.Tasks.AppTaskInfo.Create(System.String,System.String,Windows.Foundation.Uri,Windows.Foundation.Uri,Windows.UI.Shell.Tasks.AppTaskContent)
-api-type: winrt method
---

# Windows.UI.Shell.Tasks.AppTaskInfo.Create(System.String,System.String,Windows.Foundation.Uri,Windows.Foundation.Uri,Windows.UI.Shell.Tasks.AppTaskContent)

<!--
public static Windows.UI.Shell.Tasks.AppTaskInfo Create (string title, string subtitle, System.Uri deepLink, System.Uri iconUri, Windows.UI.Shell.Tasks.AppTaskContent content);
-->


## -description

Creates a new app task with the specified parameters.

## -parameters

### -param title

The title of the task. This value is required and is used to group related tasks.

### -param subtitle

An optional subtitle for the task that provides additional context. Can be an empty string.

### -param deepLink

A URI that launches the app in the context of this task when the user clicks on the task representation in the Shell.

### -param iconUri

The path to an icon that represents the task.
### -param content

The initial content to display for this task, created using one of the [AppTaskContent](apptaskcontent.md) factory methods.

## -returns

A new [AppTaskInfo](apptaskinfo.md) object that represents the task.

## -remarks

The title is required; this method throws an exception if the title is not provided.

## -see-also

[Title](apptaskinfo_title.md), [Subtitle](apptaskinfo_subtitle.md), [DeepLink](apptaskinfo_deeplink.md), [IconUri](apptaskinfo_iconuri.md), [AppTaskContent](apptaskcontent.md)

## -examples


