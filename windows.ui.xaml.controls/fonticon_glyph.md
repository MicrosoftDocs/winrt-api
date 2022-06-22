---
-api-id: P:Windows.UI.Xaml.Controls.FontIcon.Glyph
-api-type: winrt property
---

<!-- Property syntax
public string Glyph { get;  set; }
-->

# Windows.UI.Xaml.Controls.FontIcon.Glyph

## -description
Gets or sets the character code that identifies the icon glyph.



## -xaml-syntax
```xaml
<FontIcon Glyph="characterCode"/>
```


## -xaml-values
<dl><dt>characterCode</dt><dd>characterCodeThe hexadecimal character code for the icon glyph, such as "&amp;#x00FF;".</dd>
</dl>
## -property-value
The hexadecimal character code for the icon glyph.

## -remarks

## -examples

```csharp
var newAppBarButton = new AppBarButton();
var fontIcon = new FontIcon();
fontIcon.FontFamily = new FontFamily("Segoe MDL2 Assets");
fontIcon.Glyph = "\xE790";
newAppBarButton.Icon = fontIcon;
```

```cppwinrt
using namespace winrt::Windows::UI::Xaml;
...

auto newAppBarButton = Controls::AppBarButton{};
auto fontIcon = Controls::FontIcon{};
fontIcon.FontFamily(Media::FontFamily{ L"Segoe MDL2 Assets" });
fontIcon.Glyph(L"\xE790");
newAppBarButton.Icon(fontIcon);
```

## -see-also
