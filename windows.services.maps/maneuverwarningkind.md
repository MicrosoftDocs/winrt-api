---
-api-id: T:Windows.Services.Maps.ManeuverWarningKind
-api-type: winrt enumeration
---

<!-- Enumeration syntax.
public enum ManeuverWarningKind : int {
	Accident = 1
	AdministrativeDivisionChange = 2
	Alert = 3
	BlockedRoad = 4
	CheckTimetable = 5
	Congestion = 6
	Construction = 7
	CountryChange = 8
	DisabledVehicle = 9
	GateAccess = 10
	GetOffTransit = 11
	GetOnTransit = 12
	IllegalUTurn = 13
	MassTransit = 14
	Miscellaneous = 15
	NoIncident = 16
	None = 0
	Other = 17
	OtherNews = 18
	OtherTrafficIncidents = 19
	PlannedEvent = 20
	PrivateRoad = 21
	RestrictedTurn = 22
	RoadClosures = 23
	RoadHazard = 24
	ScheduledConstruction = 25
	SeasonalClosures = 26
	Tollbooth = 27
	TollRoad = 28
	TollZoneEnter = 29
	TollZoneExit = 30
	TrafficFlow = 31
	TransitLineChange = 32
	UnpavedRoad = 33
	UnscheduledConstruction = 34
	Weather = 35
}
-->

# Windows.Services.Maps.ManeuverWarningKind

## -description
Specifies the type of potential issue along a route leg.
## -enum-fields

## -field Weather:35
There is significant weather at this location.

## -field UnscheduledConstruction:34
There is construction along the route that does not have any specific start and end dates.

## -field UnpavedRoad:33
The road is unpaved.

## -field TransitLineChange:32
There is a transit line change but a change of vehicle is not required.

## -field TrafficFlow:31
The warning is about traffic flow.

## -field TollZoneExit:30
The exit of a toll zone.

## -field TollZoneEnter:29
The entrance to a toll zone.

## -field TollRoad:28
The road is a toll road.

## -field Tollbooth:27
A toll is required at this location to continue along the route.

## -field SeasonalClosures:26
A seasonal closure occurs at this location.

## -field ScheduledConstruction:25
There is construction along the route that has specific start and end dates.

## -field RoadHazard:24
There is a road hazard.

## -field RoadClosures:23
There are road closures at this location.

## -field RestrictedTurn:22
The turn may be restricted.

## -field PrivateRoad:21
The road being travelled on is private.

## -field PlannedEvent:20
There are scheduled events in the area.

## -field OtherTrafficIncidents:19
There are other traffic incidents at this location.

## -field OtherNews:18
There is additional traffic incident information.

## -field Other:17
There is a warning at this location that cannot be classified as any other type of warning.
## -field None:0
There is no warning at this location.
## -field NoIncident:16
There is no incident at this location.

## -field Miscellaneous:15
A miscellaneous warning is available for this location.

## -field MassTransit:14
There is mass transit incident.

## -field IllegalUTurn:13
A U-turn is illegal at this location.

## -field GetOnTransit:12
Get on the transit at this location.

## -field GetOffTransit:11
Get off the transit at this location.
## -field GateAccess:10
A gate blocks the road and access is required to continue along the route.

## -field DisabledVehicle:9
There is a disabled vehicle.

## -field CountryChange:8
The route has left one country and entered another.

## -field Construction:7
There is construction along the route. This value is used for any type of construction and not just construction that has specific start and end dates.

## -field Congestion:6
The traffic is slow.

## -field CheckTimetable:5
Check a time table. This usually refers to a ferry or auto rail time table.

## -field BlockedRoad:4
The road is closed or blocked.

## -field Alert:3
There is an alert.

## -field AdministrativeDivisionChange:2
The route has left one administrative division and entered another.

## -field Accident:1
There is a traffic accident.

## -remarks

## -see-also

## -examples
