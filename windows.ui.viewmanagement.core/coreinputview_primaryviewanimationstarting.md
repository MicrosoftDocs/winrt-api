---
-api-id: E:Windows.UI.ViewManagement.Core.CoreInputView.PrimaryViewAnimationStarting
-api-type: winrt event
---

# Windows.UI.ViewManagement.Core.CoreInputView.PrimaryViewAnimationStarting

<!--
public event Windows.Foundation.TypedEventHandler<Windows.UI.ViewManagement.Core.CoreInputView,Windows.UI.ViewManagement.Core.CoreInputViewAnimationStartingEventArgs> PrimaryViewAnimationStarting;
-->

## -description

Animations in the application that occur in response to the showing or hiding of the [CoreInputView](coreinputview.md) primary view.

## -remarks

Primary view refers to either of the [CoreInputViewKind.Keyboard](https://github.com/MicrosoftDocs/winrt-api/blob/docs/windows.ui.viewmanagement.core/coreinputviewkind.md#-field-keyboard1) or [CoreInputViewKind.Handwriting](https://github.com/MicrosoftDocs/winrt-api/blob/docs/windows.ui.viewmanagement.core/coreinputviewkind.md#-field-handwriting2) views, while CoreInputView can be any of the values from [CoreInputViewKind](coreinputviewkind.md).

> [!Important]
> The application should use this value when setting any animation durations that are based on the showing or hiding of the CoreInputView. If coordinating animations between the application and the CoreInputView, ensure the application animation does not complete before the CoreInputView animation to avoid seeing any inconsistent background visuals in the space between the application content and the input pane.

The application UI reflows based on the [CoreInputViewOcclusion.OccludingRect](coreinputviewocclusion_occludingrect.md), which is an empty rect when hiding.

The input pane animates to the screen more quickly at the beginning, while gradually slowing towards the end (the exact opposite occurs when it animates off screen). 

If the current app window is positioned as shown in the following image (**1** indicates the height of the bottom edge), the height of the CoreInputViewOcclusion for the PrimaryViewAnimationStarting event is indicated by **2** and the AnimationDuration is indicated by **3**. In this scenaro, primary view's height equals (Height **1** + Height **2**).

:::row:::
   :::column:::
      :::image type="content" source="images/coreinputview-primaryviewanimationstarting-pane-heights.png" alt-text="CoreInputView PrimaryViewAnimationStarting pane heights.":::
   :::column-end:::
   :::column:::
      :::image type="content" source="images/coreinputview-primaryviewanimationstarting-duration.png" alt-text="CoreInputView PrimaryViewAnimationStarting duration.":::
   :::column-end:::
:::row-end:::

In turn, the AnimationDuration of the PrimaryViewAnimationHiding event is indicated by **4** in the following image, with an occlusion height of 0.

:::image type="content" source="images/coreinputview-primaryviewanimationhiding-duration.png" alt-text="The AnimationDuration of the PrimaryViewAnimationHiding event is indicated by #4":::

> [!NOTE]
> Floating input pane occlusion doesn’t need to be handled, so the AnimationDuration is always 0.

## -see-also

[CoreInputViewAnimationStartingEventArgs](coreinputviewanimationstartingeventargs.md), [TryShow](coreinputview_tryshow_1077566544.md),  [TryShow(CoreInputViewKind type)](coreinputview_tryshow_154132369.md),[TryHide](coreinputview_tryhide_42550069.md)

## -examples
