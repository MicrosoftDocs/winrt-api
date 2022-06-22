---
-api-id: T:Windows.UI.Xaml.Controls.CandidateWindowAlignment
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Xaml.Controls.CandidateWindowAlignment : int
-->

# CandidateWindowAlignment

## -description
Defines constants that specify how the Input Method Editor (IME) window for text predictions is aligned with a text edit control.



## -xaml-syntax
```xaml
<object property="enumMemberName"/>
```


## -enum-fields
### -field Default:0
When the hardware keyboard is used, the Input Method Editor (IME) follows the cursor. When the Soft Input Panel (SIP) is used, the Input Method Editor (IME) is docked to the Soft Input Panel (SIP).

### -field BottomEdge:1
When the hardware keyboard is used, the Input Method Editor (IME) aligns to the bottom edge and left side of the text edit control. When the Soft Input Panel (SIP) is used, the Input Method Editor (IME) is docked to the Soft Input Panel (SIP).


## -remarks
This enumeration is used by the [TextBox.DesiredCandidateWindowAlignment](textbox_desiredcandidatewindowalignment.md) and [RichEditBox.DesiredCandidateWindowAlignment](richeditbox_desiredcandidatewindowalignment.md) properties.

## -examples

## -see-also
