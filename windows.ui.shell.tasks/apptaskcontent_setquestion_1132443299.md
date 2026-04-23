---
-api-id: M:Windows.UI.Shell.Tasks.AppTaskContent.SetQuestion(System.String)
-api-type: winrt method
---

# Windows.UI.Shell.Tasks.AppTaskContent.SetQuestion(System.String)

<!--
public void SetQuestion (string question);
-->


## -description

Sets a question to display to the user when the task needs attention.

## -parameters

### -param question

The question text to display to the user.

## -remarks

> [!IMPORTANT]
> **App task support will start gradually rolling out to Windows 11 starting May, 2026.** The experiences enabled by `Windows.UI.Shell.Tasks` APIs require that the corresponding app task feature be present in the version of Windows where the app runs. Otherwise, these APIs will not have any effect.

Use this method in combination with [AddButton](apptaskcontent_addbutton_519639533.md) or [SetTextInput](apptaskcontent_settextinput_1945138728.md) to prompt the user for input when the task requires a decision.

## -see-also

## -examples


