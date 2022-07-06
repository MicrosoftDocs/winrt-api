---
-api-id: T:Windows.UI.Xaml.Media.Animation.FillBehavior
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Xaml.Media.Animation.FillBehavior : int
-->

# FillBehavior

## -description
Specifies how a [Timeline](timeline.md) behaves when it is outside its active period but its parent is inside its active or hold period.



## -xaml-syntax
```xaml
<object property="enumMemberName"/>
```


## -enum-fields
### -field HoldEnd:0
After it reaches the end of its active period, the timeline holds its progress until the end of its parent's active and hold periods.

### -field Stop:1
The timeline stops if it is outside its active period while its parent is inside its active period.


## -remarks

## -examples

## -see-also
