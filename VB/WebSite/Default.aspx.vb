Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Configuration
Imports System.Web
Imports System.Web.Security
Imports System.Web.UI
Imports System.Web.UI.WebControls
Imports System.Web.UI.WebControls.WebParts
Imports System.Web.UI.HtmlControls
Imports DevExpress.Web.ASPxGauges
Imports DevExpress.Web.ASPxGauges.Gauges.Circular
Imports DevExpress.XtraGauges.Base
Imports DevExpress.XtraGauges.Core.Model
Imports DevExpress.XtraGauges.Core.Base
Imports System.Collections.Generic
Imports System.Drawing
Imports DevExpress.XtraGauges.Core.Drawing
Imports DevExpress.Web.ASPxGauges.Gauges

Partial Public Class _Default
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		CreateCircularGauge()
	End Sub

	Private Sub CreateCircularGauge()
		Dim gaugeControl As New ASPxGaugeControl()
		Dim gauge As CircularGauge = CType(gaugeControl.AddGauge(GaugeType.Circular), CircularGauge)
		gauge.AddDefaultElements()
		Page.Form.Controls.Add(gaugeControl)
		Dim scale As ArcScaleComponent = gauge.Scales(0)
		scale.BeginUpdate()
		scale.Ranges.AddRange(CreateRanges(scale.MaxValue - scale.MinValue, scale.MinValue))
		scale.EndUpdate()
	End Sub

	Private rangeContentColors() As Color = { Color.Red, Color.Yellow, Color.Green }

	Private Function CreateRanges(ByVal ticks As Single, ByVal start As Single) As IRange()
		Dim range As Integer = CInt(Fix(Math.Floor(CDbl(ticks / rangeContentColors.Length))))
		Dim ranges As New List(Of IRange)()
		Dim i As Integer = 0
        Do While i < rangeContentColors.Length
            ranges.Add(CreateRange(rangeContentColors(i), CInt(Fix(range * i + start)), CInt(Fix(range * (i + 1) + start))))
            i += 1
        Loop
		Return ranges.ToArray()
	End Function

	Private Function CreateRange(ByVal contentColor As Color, ByVal startValue As Integer, ByVal endValue As Integer) As IRange
		Dim result As IRange = New ArcScaleRangeWeb()
		result.AppearanceRange.ContentBrush = New SolidBrushObject(contentColor)
		result.StartValue = startValue
		result.EndValue = endValue
		result.StartThickness = 0f
		result.EndThickness = 50f
		result.ShapeOffset = 0
		Return result
	End Function
End Class
