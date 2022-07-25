---
-api-id: T:Windows.UI.Xaml.Controls.PivotSlideInAnimationGroup
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Xaml.Controls.PivotSlideInAnimationGroup : int
-->

# PivotSlideInAnimationGroup

## -description
Defines constants that specify the different slide-in animation groups that [Pivot](pivot.md) elements can belong to.



## -enum-fields
### -field Default:0
The element belongs to the default animation group. It slides in after the [Pivot](pivot.md) header.

### -field GroupOne:1
The element belongs to the first animation group. It slides in after elements in the default group.

### -field GroupTwo:2
The element belongs to the second animation group. It slides in after elements in the first group.

### -field GroupThree:3
The element belongs to the third animation group. It slides in after elements in the second group.


## -remarks
These values are used by the [Pivot.SlideInAnimationGroup](/uwp/api/windows.ui.xaml.controls.pivot.slideinanimationgroup) attached property.

## -examples

## -see-also

[Pivot.SlideInAnimationGroup](/uwp/api/windows.ui.xaml.controls.pivot.slideinanimationgroup)
