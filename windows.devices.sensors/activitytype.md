---
-api-id: T:Windows.Devices.Sensors.ActivityType
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Devices.Sensors.ActivityType : int
-->

# ActivityType

## -description
Specifies activity types of a sensor.

## -enum-fields
### -field Unknown:0
The sensor indicates an unknown activity.

### -field Idle:1
The sensor indicates it is active but in an idle state. It is not with the user and remaining still such as resting on a table.

### -field Stationary:2
The sensor indicates that it's not moving.

### -field Fidgeting:3
The sensor indicates that it making minor movements while the user is stationary.

### -field Walking:4
The sensor indicates the user is walking. The user travels at a moderate pace with one foot on the ground at all times.

### -field Running:5
The sensor indicates the user is traveling at a faster rate than walking and both feet are off the ground between steps.

### -field InVehicle:6
The sensor indicates the user is traveling in a motor vehicle on the ground.

### -field Biking:7
The sensor indicates the user is riding a bicycle on the ground.


## -remarks

## -examples

## -see-also