---
-api-id: T:Windows.Gaming.UI.GameChatOverlay
-api-type: winrt class
---

<!-- Class syntax.
public class GameChatOverlay 
-->

# Windows.Gaming.UI.GameChatOverlay

## -description

Represents the game chat overlay.

## -remarks

This class provides methods to get the default game chat overlay instance, set the desired position of the overlay, and add messages to it. 

## -see-also
[Windows.Gaming.UI.GameChatOverlayPosition](gamechatoverlayposition.md)

## -examples

This sample demonstrates setting up game chat and adding text messages to it.

```cppwinrt
#include <winrt/Windows.Gaming.UI.h>
using namespace winrt;
using namespace Windows::Gaming::UI;
...
GameChatOverlay m_gameChatOverlay{nullptr};
...
void ChatSample::SetUpGameChat(GameChatOverlayPosition position)
{
    // Get the default game chat overlay object. Platforms that don't support
    // it will return null.
    m_gameChatOverlay = GameChatOverlay::GetDefault();

    if (m_gameChatOverlay)
    {
        // Position the overlay in the given position.
        m_gameChatOverlay.DesiredPosition(position);
    }
}

// This method typically would be wired to a text entry box in order to send
// text messages.
void ChatSample::SendTextMessage(std::wstring gamertag, std::wstring message)
{
    if (m_gameChatOverlay)
    {
        // Render the text in the overlay.
        m_gameChatOverlay.AddMessage(
            gamertag,
            message,
            GameChatMessageOrigin::Text);
    }
    else
    {
        // The game should render the outgoing message in its own UI.
    }
}
```

```cppcx
void ChatSample::SetUpGameChat(GameChatOverlayPosition position)
{
    // Get the default game chat overlay object. Platforms that don't support
    // it will return null.
    m_gameChatOverlay = GameChatOverlay::GetDefault();

    if (m_gameChatOverlay)
    {
        // Position the overlay in the given position.
        m_gameChatOverlay->DesiredPosition = position;
    }
}

// This method typically would be wired to a text entry box in order to send
// text messages.
void ChatSample::SendTextMessage(String^ gamertag, String^ message) 
{
    if (m_gameChatOverlay)
    {
        // Render the text in the overlay.
        m_gameChatOverlay->AddMessage(
            gamertag, 
            message, 
            GameChatMessageOrigin::Text);
    }
    else 
    { 
        // The game should render the outgoing message in its own UI.
    } 
}
```