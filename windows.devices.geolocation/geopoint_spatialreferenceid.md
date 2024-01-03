---
-api-id: P:Windows.Devices.Geolocation.Geopoint.SpatialReferenceId
-api-type: winrt property
---

<!-- Property syntax
public uint SpatialReferenceId { get; }
-->

# Windows.Devices.Geolocation.Geopoint.SpatialReferenceId

## -description
The spatial reference identifier for the geographic point, corresponding to a spatial reference system based on the specific ellipsoid used for either flat-earth mapping or round-earth mapping.

## -property-value
The spatial reference identifier for the geographic point, corresponding to a spatial reference system based on the specific ellipsoid used for either flat-earth mapping or round-earth mapping.

## -remarks
The spatial reference id (SRID) corresponds to a spatial reference system based on the specific ellipsoid used for either flat-earth mapping or round-earth mapping. Spatial instances with the same SRID can be used when performing operations with spatial data methods on your data. The result of any spatial method derived from two spatial data instances is valid only if those instances have the same SRID that is based on the same unit of measurement, datum, and projection used to determine the coordinates of the instances. The most common units of measurement of a SRID are meters or square meters. The default SRID for the Windows platform is 4326 which is WGS84 ellipsoid.

The spatial reference identification system is defined by the [European Petroleum Survey Group (EPSG)](https://epsg.org/) standard, which is a set of standards developed for cartography, surveying, and geodetic data storage. This standard is owned by the Oil and Gas Producers (OGP) Surveying and Positioning Committee.

## -examples

## -see-also

## -capabilities
location
