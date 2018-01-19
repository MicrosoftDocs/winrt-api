---
-api-id: M:Windows.ApplicationModel.Background.BackgroundExecutionManager.RequestAccessKindAsync(Windows.ApplicationModel.Background.BackgroundAccessRequestKind,System.String)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<bool> BackgroundExecutionManager.RequestAccessKindAsync(BackgroundAccessRequestKind requestedAccess, String reason)
-->

# Windows.ApplicationModel.Background.BackgroundExecutionManager.RequestAccessKindAsync

## -description
Prompts the user whether they consent to allow the app to perform background activity in the background.

## -parameters
### -param requestedAccess
The type of background activity the app wishes to perform.

### -param reason
The string to display in the prompt that the system will raise to the user to describe why it is requesting to run in the background. For example, the string that appears after "The app says:"
    <img src="../images/BackgroundPrompt.png" alt="Example background activity user prompt" />

## -returns
**True** indicates that the user approved the requested background activity; **false**, otherwise.

## -remarks

## -see-also

## -examples
