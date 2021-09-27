---
-api-id: M:Windows.ApplicationModel.ConversationalAgent.ConversationalAgentSession.GetMissingPrerequisitesAsync
-api-type: winrt method
---

# Windows.ApplicationModel.ConversationalAgent.ConversationalAgentSession.GetMissingPrerequisitesAsync

<!--
public Windows.Foundation.IAsyncOperation<System.Collections.Generic.IReadOnlyList<Windows.ApplicationModel.ConversationalAgent.ConversationalAgentVoiceActivationPrerequisiteKind>> GetMissingPrerequisitesAsync ();
-->

## -description

Gets missing prerequisites for voice activation to become available and function properly.

## -returns

The collection of missing prerequisites.

## -remarks

Note that the permission for voice activation still needs to be granted separately and is not part of the prerequisites.

Missing prerequisites may prevent granting the voice activation permission.

## -see-also

## -examples
