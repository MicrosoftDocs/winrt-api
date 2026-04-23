---
-api-id: M:Windows.UI.Shell.Tasks.AppTaskContent.SetTextInput(System.String,System.String)
-api-type: winrt method
---

# Windows.UI.Shell.Tasks.AppTaskContent.SetTextInput(System.String,System.String)

<!--
public void SetTextInput (string placeholderText, string actionUriTemplate);
-->


## -description

Sets up a text input field for the user to provide a free-form text response.

## -parameters

### -param placeholderText

The placeholder text displayed in the input field to guide the user.

### -param actionUriTemplate

A URI template string containing `{userTextInput}` that will be replaced with the user's escaped input text when submitted.

## -remarks

> [!IMPORTANT]
> **App task support will start gradually rolling out to Windows 11 starting May, 2026.** The experiences enabled by `Windows.UI.Shell.Tasks` APIs require that the corresponding app task feature be present in the version of Windows where the app runs. Otherwise, these APIs will not have any effect.

Use this method to collect text input from the user when the task needs attention. The `{userTextInput}` expression in the URI template is replaced with the URL-encoded user input. For example, if the template is `my-app:task/?response={userTextInput}` and the user enters "scope only", the resulting URI will be `my-app:task/?response=scope%20only`.

## -see-also

## -examples


