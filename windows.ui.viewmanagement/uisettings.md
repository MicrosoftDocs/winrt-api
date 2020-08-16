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

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1703 | 15063 | AdvancedEffectsEnabled |
| 1703 | 15063 | AdvancedEffectsEnabledChanged |
| 1903 | 18362 | AutoHideScrollBars |
| 1903 | 18362 | AutoHideScrollBarsChanged |
| 2004 | 19041 | AnimationsEnabledChanged |
| 2004 | 19041 | MessageDurationChanged |

## -examples

```cppwinrt
void MainPage::ClickHandler(IInspectable const&, RoutedEventArgs const&)
{
    Windows::UI::ViewManagement::UISettings uiSettings;

    std::wstringstream buffer;
    Windows::UI::Color color{ uiSettings.UIElementColor(UIElementType::ActiveCaption) };

    buffer << L"Hand Preference " << (uiSettings.HandPreference() == HandPreference::RightHanded ? L"right" : L"left") << std::endl;
    buffer << L"Cursor Size " << uiSettings.CursorSize().Width << L" x " << uiSettings.CursorSize().Height << std::endl;
    buffer << L"Scrollbar Size " << uiSettings.ScrollBarSize().Width << L" x " << uiSettings.ScrollBarSize().Height << std::endl;
    buffer << L"Scrollbar Arrow Size " << uiSettings.ScrollBarArrowSize().Width << L" x " << uiSettings.ScrollBarArrowSize().Height << std::endl;
    buffer << L"Scrollbar Thumb Box Size " << uiSettings.ScrollBarThumbBoxSize().Width << L" x " << uiSettings.ScrollBarThumbBoxSize().Height << std::endl;
    buffer << L"Message Duration " << uiSettings.MessageDuration() << std::endl;
    buffer << L"Animations Enabled " << (uiSettings.AnimationsEnabled() ? L"true" : L"false") << std::endl;
    buffer << L"Caret Browsing Enabled " << (uiSettings.CaretBrowsingEnabled() ? L"true" : L"false") << std::endl;
    buffer << L"Caret Blink Rate " << uiSettings.CaretBlinkRate() << std::endl;
    buffer << L"Caret Width " << uiSettings.CaretWidth() << std::endl;
    buffer << L"Double Click Time " << uiSettings.DoubleClickTime() << std::endl;
    buffer << L"Mouse Hover Time " << uiSettings.MouseHoverTime() << std::endl;

    buffer << L"System Colors: " << std::endl;

    buffer << L"Active Caption: " << color.R << L", " << color.G << L", " << color.B << std::endl;
    color = uiSettings.UIElementColor(UIElementType::Background);
    buffer << L"Background: " << color.R << L", " << color.G << L", " << color.B << std::endl;
    color = uiSettings.UIElementColor(UIElementType::ButtonFace);
    buffer << L"Button Face: " << color.R << L", " << color.G << L", " << color.B << std::endl;
    color = uiSettings.UIElementColor(UIElementType::ButtonText);
    buffer << L"Button Text: " << color.R << L", " << color.G << L", " << color.B << std::endl;
    color = uiSettings.UIElementColor(UIElementType::CaptionText);
    buffer << L"Caption Text: " << color.R << L", " << color.G << L", " << color.B << std::endl;
    color = uiSettings.UIElementColor(UIElementType::GrayText);
    buffer << L"Gray Text: " << color.R << L", " << color.G << L", " << color.B << std::endl;
    color = uiSettings.UIElementColor(UIElementType::Highlight);
    buffer << L"Highlight: " << color.R << L", " << color.G << L", " << color.B << std::endl;
    color = uiSettings.UIElementColor(UIElementType::HighlightText);
    buffer << L"Highlight Text: " << color.R << L", " << color.G << L", " << color.B << std::endl;
    color = uiSettings.UIElementColor(UIElementType::Hotlight);
    buffer << L"Hotlight: " << color.R << L", " << color.G << L", " << color.B << std::endl;
    color = uiSettings.UIElementColor(UIElementType::InactiveCaption);
    buffer << L"Inactive Caption: " << color.R << L", " << color.G << L", " << color.B << std::endl;
    color = uiSettings.UIElementColor(UIElementType::InactiveCaptionText);
    buffer << L"Inactive Caption Text: " << color.R << L", " << color.G << L", " << color.B << std::endl;
    color = uiSettings.UIElementColor(UIElementType::Window);
    buffer << L"Window: " << color.R << L", " << color.G << L", " << color.B << std::endl;
    color = uiSettings.UIElementColor(UIElementType::WindowText);
    buffer << L"Window Text: " << color.R << L", " << color.G << L", " << color.B << std::endl;

    UIOutputTextBlock().Text(buffer.str().c_str());
}
```

```cppcx
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

## -see-also
[UI contrast and settings sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/411c271e537727d737a53fa2cbe99eaecac00cc0/Official%20Windows%20Platform%20Sample/Windows%208%20app%20samples/%5BC%2B%2B%5D-Windows%208%20app%20samples/C%2B%2B/Windows%208%20app%20samples/UI%20contrast%20and%20settings%20sample%20(Windows%208))
