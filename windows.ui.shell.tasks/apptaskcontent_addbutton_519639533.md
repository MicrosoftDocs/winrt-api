---
-api-id: M:Windows.UI.Shell.Tasks.AppTaskContent.AddButton(System.String,Windows.Foundation.Uri)
-api-type: winrt method
---

# Windows.UI.Shell.Tasks.AppTaskContent.AddButton(System.String,Windows.Foundation.Uri)

<!--
public void AddButton (string text, System.Uri actionUri);
-->


## -description

Adds a button to the task content that the user can click to take an action.

## -parameters

### -param text

The text to display on the button.

### -param actionUri

The URI that is launched when the user clicks the button.

## -remarks

Use buttons when the task needs user attention and you want to provide simple action choices. The maximum number of buttons you can add is defined by [MaxButtons](apptaskcontent_maxbuttons.md). Typically used in combination with [SetQuestion](apptaskcontent_setquestion_1132443299.md) when the task state is `NeedsAttention`.

## -see-also

## -examples


