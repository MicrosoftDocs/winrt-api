---
-api-id: M:Windows.UI.Xaml.Media.Animation.DoubleKeyFrameCollection.ReplaceAll(Windows.UI.Xaml.Media.Animation.DoubleKeyFrame[])
-api-type: winrt method
---

<!-- Method syntax
public void ReplaceAll(Windows.UI.Xaml.Media.Animation.DoubleKeyFrame[] items)
-->

# Windows.UI.Xaml.Media.Animation.DoubleKeyFrameCollection.ReplaceAll

## -description
Initially clears the collection, then inserts the provided array as new items.



## -parameters
### -param items
The new collection items.

## -remarks
For implementations that track a *changed* event, the initial reset raises an event, but the items added do not fire discrete events.

## -examples

## -see-also
