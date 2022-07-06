---
-api-id: P:Windows.UI.Xaml.Media.Animation.Timeline.SpeedRatio
-api-type: winrt property
---

<!-- Property syntax
public double SpeedRatio { get;  set; }
-->

# Windows.UI.Xaml.Media.Animation.Timeline.SpeedRatio

## -description
Gets or sets the rate, relative to its parent, at which time progresses for this [Timeline](timeline.md).



## -xaml-syntax
```xaml
<timeline SpeedRatio="double"/>
```


## -property-value
A finite value greater than 0 that specifies the rate at which time progresses for this timeline, relative to the speed of the timeline's parent. If this timeline is a root timeline, specifies the default timeline speed. The value is expressed as a factor where 1 represents normal speed, 2 is double speed, 0.5 is half speed, and so on. The default value is 1.

## -remarks

## -examples

## -see-also
