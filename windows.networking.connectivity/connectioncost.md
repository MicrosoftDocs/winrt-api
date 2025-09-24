---
-api-id: T:Windows.Networking.Connectivity.ConnectionCost
-api-type: winrt class
---

<!-- Class syntax.
public class ConnectionCost : Windows.Networking.Connectivity.IConnectionCost, Windows.Networking.Connectivity.IConnectionCost2
-->

# Windows.Networking.Connectivity.ConnectionCost

## -description
Provides access to property values that indicate the current cost characteristics of a network connection, enabling applications 
to make intelligent decisions about network usage based on cost constraints.

## -remarks
[ConnectionCost](connectioncost.md) objects are obtained from [ConnectionProfile.GetConnectionCost](connectionprofile_getconnectioncost_2051899034.md) 
and provide detailed information about the cost characteristics of a network connection. This information helps applications 
optimize their network behavior based on the user's data plan and network conditions.

### Cost properties and decision making

The [ConnectionCost](connectioncost.md) class provides several key properties for cost assessment:

**Core cost information:**
- [NetworkCostType](connectioncost_networkcosttype.md): Indicates whether the connection is unrestricted, fixed, or variable cost
- [Roaming](connectioncost_roaming.md): Indicates if the connection is currently roaming
- [OverDataLimit](connectioncost_overdatalimit.md): Indicates if the connection has exceeded its data limit
- [ApproachingDataLimit](connectioncost_approachingdatalimit.md): Indicates if the connection is nearing its data limit

**Background data restrictions (Windows 10 and later):**
- [BackgroundDataUsageRestricted](connectioncost_backgrounddatausagerestricted.md): Indicates if background data usage is 
  restricted by user settings or system policies

[!IMPORTANT]
Applications should always check [ConnectionCost](connectioncost.md) properties before performing large data transfers or 
background operations. Respecting cost constraints helps preserve user data allowances and provides a better user experience.

### Cost-based application behavior

Based on the [NetworkCostType](connectioncost_networkcosttype.md), applications should adjust their behavior:

**Unrestricted networks:**
- Perform full synchronization and updates
- Download large content and media
- Execute all background tasks

**Fixed cost networks:**
- Perform regular operations but consider deferring large downloads
- Respect user preferences for automatic updates

**Variable cost networks:**
- Minimize non-essential data usage
- Defer large downloads unless user-initiated
- Reduce sync frequency and content quality

**Additional restrictions:**
- When [OverDataLimit](connectioncost_overdatalimit.md) is true, minimize all non-critical operations
- When [ApproachingDataLimit](connectioncost_approachingdatalimit.md) is true, warn users before large operations
- When [BackgroundDataUsageRestricted](connectioncost_backgrounddatausagerestricted.md) is true, avoid background data usage

## -examples

## -see-also
[ConnectionProfile.GetConnectionCost](connectionprofile_getconnectioncost_2051899034.md),
[NetworkCostType](networkcosttype.md),
[DataPlanStatus](dataplanstatus.md),
[NetworkInformation](networkinformation.md)
