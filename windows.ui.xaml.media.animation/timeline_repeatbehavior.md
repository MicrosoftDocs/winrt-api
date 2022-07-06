---
-api-id: P:Windows.UI.Xaml.Media.Animation.Timeline.RepeatBehavior
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Media.Animation.RepeatBehavior RepeatBehavior { get;  set; }
-->

# Windows.UI.Xaml.Media.Animation.Timeline.RepeatBehavior

## -description
Gets or sets the repeating behavior of this timeline.



## -xaml-syntax
```xaml
<timeline RepeatBehavior="repeatBehaviorValue"/>
```


## -xaml-values
<dl><dt>repeatBehaviorValue</dt><dd>repeatBehaviorValueA RepeatBehavior expressed as a string. This can be an iteration count or a timespan string. For more information, see RepeatBehavior.</dd>
</dl>
## -property-value
An iteration **Count** that specifies the number of times the timeline should play, a **TimeSpan** value that specifies the total length of this timeline's active period, or the special value **Forever**, which specifies that the timeline should repeat indefinitely. The default value is a [RepeatBehavior](repeatbehavior.md) with a **Count** value of 1, which indicates that the timeline plays once.
<!--Don't link Timespan above it is a projected type and an authored link introduces a bias.-->

## -remarks

For more info and examples, see the [RepeatBehavior](repeatbehavior.md) Struct.

## -examples

## -see-also
