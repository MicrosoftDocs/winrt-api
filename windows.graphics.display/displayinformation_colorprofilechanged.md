---
-api-id: E:Windows.Graphics.Display.DisplayInformation.ColorProfileChanged
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler ColorProfileChanged<Windows.Graphics.Display.DisplayInformation,  object>
-->

# Windows.Graphics.Display.DisplayInformation.ColorProfileChanged

## -description
Occurs when the physical display's color profile changes.

## -remarks
The [ColorProfileChanged](displayinformation_colorprofilechanged.md) event is only triggered when the display’s color profile changes. You must then call the [DisplayInformation::GetColorProfileAsync](displayinformation_getcolorprofileasync.md) method to asynchronously retrieve the new color profile.

<!--[jjacks - WinBlue bug 381377 says to remove this comment because the issue is fixed for blue] If there is no physical display (such as when the app runs over remote desktop or in the Simulator), don't register a handler for this event because the operation will fail with HRESULT E_FAIL.
-->

## -examples

## -see-also
