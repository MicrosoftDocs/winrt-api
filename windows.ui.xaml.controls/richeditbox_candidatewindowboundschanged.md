---
-api-id: E:Windows.UI.Xaml.Controls.RichEditBox.CandidateWindowBoundsChanged
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler CandidateWindowBoundsChanged<Windows.UI.Xaml.Controls.RichEditBox,  Windows.UI.Xaml.Controls.CandidateWindowBoundsChangedEventArgs>
-->

# Windows.UI.Xaml.Controls.RichEditBox.CandidateWindowBoundsChanged

## -description
Occurs when the Input Method Editor (IME) window open, updates, or closes.



## -xaml-syntax
```xaml
<RichEditBox CandidateWindowBoundsChanged="eventhandler" />
```


## -remarks
For event data, see [CandidateWindowBoundsChangedEventArgs](candidatewindowboundschangedeventargs.md).

Users sometimes enter text through an Input Method Editor (IME) that shows in a window just below a text input box (typically for East Asian languages). The Input Method Editor (IME) window can cover important parts of your app UI that the user might need to see while entering text. This event notifies your app of the coordinates where the Input Method Editor (IME) window is currently displayed. You can use this info to draw your UI in a location that doesn't conflict with the Input Method Editor (IME) window.

You can also use the [DesiredCandidateWindowAlignment](richeditbox_desiredcandidatewindowalignment.md) property to specify a preferred placement of the Input Method Editor (IME) window in relation to the text input box.

## -examples
Here, a rectangle is placed below a [RichEditBox](richeditbox.md). When the Input Method Editor (IME) window bounds change, the bottom [Margin](../windows.ui.xaml/frameworkelement_margin.md) of the [RichEditBox](richeditbox.md) is increased by the height of the Input Method Editor (IME) candidate window. As a result, the rectangle is pushed down by that amount and is not covered by the candidate window.

```xaml
<Grid Background="{ThemeResource ApplicationPageBackgroundThemeBrush}">
    <StackPanel>
        <RichEditBox x:Name="editBox1" Width="300" HorizontalAlignment="Left" 
                 DesiredCandidateWindowAlignment="BottomEdge"
                 CandidateWindowBoundsChanged="OnCandidateWindowBoundsChanged"/>
        <Rectangle Height="100" Width="100" Fill="Red" 
                   HorizontalAlignment="Left"/>
    </StackPanel>
</Grid> 

```

```csharp
private void OnCandidateWindowBoundsChanged(RichEditBox sender, CandidateWindowBoundsChangedEventArgs args) 
{ 
    editBox1.Margin = new Thickness 
    { 
        Left = 0, 
        Top = 0, 
        Right = 0, 
        Bottom = Math.Max(0, args.Bounds.Bottom - editBox1.ActualHeight) 
    };
} 

```



## -see-also
[DesiredCandidateWindowAlignment](richeditbox_desiredcandidatewindowalignment.md), [CandidateWindowBoundsChangedEventArgs](candidatewindowboundschangedeventargs.md)
