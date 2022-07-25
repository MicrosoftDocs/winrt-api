---
-api-id: P:Windows.UI.Xaml.Controls.RichEditBox.DesiredCandidateWindowAlignment
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Controls.CandidateWindowAlignment DesiredCandidateWindowAlignment { get;  set; }
-->

# Windows.UI.Xaml.Controls.RichEditBox.DesiredCandidateWindowAlignment

## -description
Gets or sets a value that indicates the preferred alignment of the Input Method Editor (IME).



## -xaml-syntax
```xaml
<RichEditBox DesiredCandidateWindowAlignment="candidateWindowAlignmentMemberName"/>
```


## -xaml-values
<dl><dt>candidateWindowAlignmentMemberName</dt><dd>candidateWindowAlignmentMemberNameA named constant of the CandidateWindowAlignment enumeration, for example BottomEdge.</dd>
</dl>
## -property-value
A value of the enumeration that indicates the preferred alignment of the Input Method Editor (IME). The default is **Default**.

## -remarks
Users sometimes enter text through an Input Method Editor (IME) that shows in a window just below a text input box (typically for East Asian languages). The Input Method Editor (IME) window can cover important parts of your app UI that the user might need to see while entering text. Use the DesiredCandidateWindowAlignment property to specify a preferred placement of the Input Method Editor (IME) window in relation to the text input box.

By default, when the hardware keyboard is used, the Input Method Editor (IME) follows the cursor. You can set DesiredCandidateWindowAlignment to [BottomEdge](candidatewindowalignment.md) to align the Input Method Editor (IME) to the bottom edge and left side of the text edit control.

When the Soft Input Panel (SIP) is used, DesiredCandidateWindowAlignment doesn't have any effect. The Input Method Editor (IME) remains docked to the Soft Input Panel (SIP) whenever the Soft Input Panel (SIP) is used.

You can also handle the [CandidateWindowBoundsChanged](richeditbox_candidatewindowboundschanged.md) event to adapt your UI to the placement of the Input Method Editor (IME).

## -examples

## -see-also
[CandidateWindowBoundsChanged](richeditbox_candidatewindowboundschanged.md)
