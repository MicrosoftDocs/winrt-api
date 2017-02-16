---
-api-id: E:Windows.Devices.Perception.PerceptionDepthFrameSourceWatcher.SourceAdded
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler SourceAdded<Windows.Devices.Perception.PerceptionDepthFrameSourceWatcher,  Windows.Devices.Perception.PerceptionDepthFrameSourceAddedEventArgs>
-->

# Windows.Devices.Perception.PerceptionDepthFrameSourceWatcher.SourceAdded

## -description
Subscribes to the SourceAdded event.

## -remarks
When the Start method is called, this event is fired for every depth frame source already known to the system, then the EnumerationCompleted event is fired. New depth frame sources that are subsequently added will trigger additional SourceAdded events.

## -examples

## -see-also
