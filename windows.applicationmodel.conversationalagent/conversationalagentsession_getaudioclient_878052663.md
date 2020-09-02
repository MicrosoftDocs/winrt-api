---
-api-id: M:Windows.ApplicationModel.ConversationalAgent.ConversationalAgentSession.GetAudioClient
-api-type: winrt method
ms.custom: 19H1
---

<!-- Method syntax.
public object ConversationalAgentSession.GetAudioClient()
-->

# Windows.ApplicationModel.ConversationalAgent.ConversationalAgentSession.GetAudioClient

## -description

Synchronously retrieves an [IAudioClient](/windows/desktop/api/audioclient/nn-audioclient-iaudioclient) object that creates and initializes an audio stream between your application and the audio rendering device.

> [!Important]
> To avoid possible concurrency issues, we recommend using [GetAudioClientAsync](conversationalagentsession_getaudioclientasync_428364567.md) instead.

## -returns

The [IAudioClient](/windows/desktop/api/audioclient/nn-audioclient-iaudioclient) object.

## -remarks

## -see-also

[GetAudioClientAsync](conversationalagentsession_getaudioclientasync_428364567.md), [GetAudioRenderDeviceIdAsync](conversationalagentsession_getaudiorenderdeviceidasync_1057232923.md)

## -examples
