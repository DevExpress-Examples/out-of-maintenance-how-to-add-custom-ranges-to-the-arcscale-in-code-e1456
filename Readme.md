<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128614656/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1456)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Default.aspx.cs](./CS/WebSite/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/WebSite/Default.aspx.vb))
<!-- default file list end -->
# How to add custom ranges to the ArcScale in code
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/e1456/)**
<!-- run online end -->


<p>The <a href="http://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraGaugesCoreModelArcScaletopic">ArcScale</a> element has the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraGaugesCoreModelArcScale_Rangestopic">Ranges</a> property, providing access to the collection of custom ranges. You can populate this collection with instances of the ArcScaleRangeWeb class. This class has the following properties:</p><p>The <strong>AppearanceRange</strong> property provides the capability to define the BorderColor, BorderWidth and ContentColor of the ArcScaleRangeWeb.<br />
The <strong>StartValue</strong> and <strong>EndValue</strong> properties allow you to set coordinates of the start and end points of the ArcScaleRangeWeb. These coordinates depend on the ArcScaleComponent.MinValue and ArcScaleComponent.MaxValue properties. Suppose, the ArcScaleComponent.MinValue = 30 and ArcScaleComponent.MaxValue = 90. For example, you can create two ArcScaleRangeWeb elements and set these StartValue and EndValue properties to the (30, 60) and (60, 90) to have two ranges, splitting the scale into two even parts.<br />
The <strong>StartThickness</strong> and <strong>EndThickness</strong> properties allow you to define the thickness of the start and end of the ArcScaleRangeWeb.<br />
The <strong>ShapeOffset</strong> property represents the spacing between the ArcScaleRangeWeb and the scale's edge. Setting negative values to this property moves the range to the center.</p>

<br/>


