---
-api-id: T:Windows.UI.ViewManagement.Core.CoreInputViewOcclusionKind
-api-type: winrt enum
---

<!-- Enumeration syntax.
public enum CoreInputViewOcclusionKind : int 
-->

# Windows.UI.ViewManagement.Core.CoreInputViewOcclusionKind

## -description

Specifies the types of input panes supported by the [CoreInputViewOcclusion](coreinputviewocclusion.md) object.

> [!NOTE]
> Not supported on HoloLens.

## -enum-fields

### -field Docked:0

Docked panes such as a Soft Input Panel (SIP) like the **Touch keyboard and handwriting panel**.

### -field Floating:1

Undocked panes such as a toolbar, or a Soft Input Panel (SIP) like the **Touch keyboard and handwriting panel**.

### -field Overlay:2

Floating panes such as an inline Ink or Input Method Editor (IME) candidate window.

## -remarks

Used by frameworks (such as XAML) or custom text controls only.

## -see-also

## -examples
