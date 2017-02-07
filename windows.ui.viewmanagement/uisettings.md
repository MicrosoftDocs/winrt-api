---
-api-id: T:Windows.UI.ViewManagement.UISettings
-api-type: winrt class
---

<!-- Class syntax.
public class UISettings : Windows.UI.ViewManagement.IUISettings, Windows.UI.ViewManagement.IUISettings2, Windows.UI.ViewManagement.IUISettings3
-->

# Windows.UI.ViewManagement.UISettings

## -description
Contains a set of common app user interface settings and operations.

## -remarks




```cpp
void SDKSample::HighContrast::UI::UIGetSettings_Click(Platform::Object^ sender, Windows::UI::Xaml::RoutedEventArgs^ e)
{ 
  Button^ b = safe_cast<Button^>(sender);
  if (b != nullptr)
  {
    UISettings^ pUserSettings = ref new UISettings();
    Platform::String^ Buffer;
    Windows::UI::Color Color;
        
        Buffer =  "Hand Preference " + (pUserSettings->HandPreference == HandPreference::RightHanded ? "right" : "left") + "\n";
        Buffer += "Cursor Size "  + pUserSettings->CursorSize.Width.ToString() + " x " + pUserSettings->CursorSize.Height.ToString() + "\n";
        Buffer += "Scrollbar Size "  + pUserSettings->ScrollBarSize.Width.ToString() + " x " + pUserSettings->ScrollBarSize.Height.ToString() + "\n";
        Buffer += "Scrollbar Arrow Size "   + pUserSettings->ScrollBarArrowSize.Width.ToString() + " x " + pUserSettings->ScrollBarArrowSize.Height.ToString() + "\n";
        Buffer += "Scrollbar Thumb Box Size " + pUserSettings->ScrollBarThumbBoxSize.Width.ToString() + " x " + pUserSettings->ScrollBarThumbBoxSize.Height.ToString() + "\n";
        Buffer += "Message Duration "  + pUserSettings->MessageDuration.ToString() + "\n";
        Buffer += "Animations Enabled "  + (pUserSettings->AnimationsEnabled ? "true" : "false") + "\n"; 
        Buffer += "Caret Browsing Enabled "  + (pUserSettings->CaretBrowsingEnabled ? "true" : "false") + "\n";
        Buffer += "Caret Blink Rate "  + pUserSettings->CaretBlinkRate.ToString() + "\n";
        Buffer += "Caret Width " + pUserSettings->CaretWidth.ToString() + "\n";
        Buffer += "Double Click Time " + pUserSettings->DoubleClickTime.ToString() + "\n";
        Buffer += "Mouse Hover Time " + pUserSettings->MouseHoverTime.ToString() + "\n";

        Buffer += "System Colors: \n";

        Color = pUserSettings->UIElementColor(UIElementType::ActiveCaption);
        Buffer += "Active Caption: " + Color.R.ToString() + ", " + Color.G.ToString() + ", " + Color.B.ToString() + "\n";
        Color = pUserSettings->UIElementColor(UIElementType::Background);
        Buffer += "Background: " + Color.R.ToString() + ", " + Color.G.ToString() + ", " + Color.B.ToString() + "\n";
        Color = pUserSettings->UIElementColor(UIElementType::ButtonFace);
        Buffer += "Button Face: " + Color.R.ToString() + ", " + Color.G.ToString() + ", " + Color.B.ToString() + "\n";
        Color = pUserSettings->UIElementColor(UIElementType::ButtonText);
        Buffer += "Button Text: " + Color.R.ToString() + ", " + Color.G.ToString() + ", " + Color.B.ToString() + "\n";
        Color = pUserSettings->UIElementColor(UIElementType::CaptionText);
        Buffer += "Caption Text: " + Color.R.ToString() + ", " + Color.G.ToString() + ", " + Color.B.ToString() + "\n";
        Color = pUserSettings->UIElementColor(UIElementType::GrayText);
        Buffer += "Gray Text: " + Color.R.ToString() + ", " + Color.G.ToString() + ", " + Color.B.ToString() + "\n";
        Color = pUserSettings->UIElementColor(UIElementType::Highlight);
        Buffer += "Highlight: " + Color.R.ToString() + ", " + Color.G.ToString() + ", " + Color.B.ToString() + "\n";
        Color = pUserSettings->UIElementColor(UIElementType::HighlightText);
        Buffer += "Highlight Text: " + Color.R.ToString() + ", " + Color.G.ToString() + ", " + Color.B.ToString() + "\n";
        Color = pUserSettings->UIElementColor(UIElementType::Hotlight);
        Buffer += "Hotlight: " + Color.R.ToString() + ", " + Color.G.ToString() + ", " + Color.B.ToString() + "\n";
        Color = pUserSettings->UIElementColor(UIElementType::InactiveCaption);
        Buffer += "Inactive Caption: " + Color.R.ToString() + ", " + Color.G.ToString() + ", " + Color.B.ToString() + "\n";
        Color = pUserSettings->UIElementColor(UIElementType::InactiveCaptionText);
        Buffer += "Inactive Caption Text: " + Color.R.ToString() + ", " + Color.G.ToString() + ", " + Color.B.ToString() + "\n";
        Color = pUserSettings->UIElementColor(UIElementType::Window);
        Buffer += "Window: " + Color.R.ToString() + ", " + Color.G.ToString() + ", " + Color.B.ToString() + "\n";
        Color = pUserSettings->UIElementColor(UIElementType::WindowText);
        Buffer += "Window Text: " + Color.R.ToString() + ", " + Color.G.ToString() + ", " + Color.B.ToString() + "\n";

    UIOutputTextBlock->Text = Buffer;
  }
}
```



## -examples

## -see-also
[UI contrast and settings sample](http://go.microsoft.com/fwlink/p/?linkid=258421)