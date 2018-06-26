---
-api-id: P:Windows.Media.Casting.CastingSource.PreferredSourceUri
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.Foundation.Uri PreferredSourceUri { get;  set; }
-->

# Windows.Media.Casting.CastingSource.PreferredSourceUri

## -description
Gets or sets an alternative URI for the content for use with DLNA ByRef.

## -property-value
The alternative URI for the content.

## -remarks

## -examples
```cppwinrt
#include <winrt/Windows.Media.Casting.h>
...
Windows::UI::Xaml::Controls::MediaElement video;
video.Source(Windows::Foundation::Uri{ L"http://www.contoso.com/videos/video.mp4" });
video.GetAsCastingSource().PreferredSourceUri(Windows::Foundation::Uri{ L"http://www.contoso.com/catalogid=1234" });
```

## -see-also
