using System;
using System.Data;
using System.Configuration;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using DevExpress.Web.ASPxGauges;
using DevExpress.Web.ASPxGauges.Gauges.Circular;
using DevExpress.XtraGauges.Base;
using DevExpress.XtraGauges.Core.Model;
using DevExpress.XtraGauges.Core.Base;
using System.Collections.Generic;
using System.Drawing;
using DevExpress.XtraGauges.Core.Drawing;
using DevExpress.Web.ASPxGauges.Gauges;

public partial class _Default : System.Web.UI.Page 
{
    protected void Page_Load(object sender, EventArgs e)
    {
        CreateCircularGauge();
    }

    private void CreateCircularGauge() {
        ASPxGaugeControl gaugeControl = new ASPxGaugeControl();
        CircularGauge gauge = (CircularGauge)gaugeControl.AddGauge(GaugeType.Circular);
        gauge.AddDefaultElements();
        ArcScaleComponent scale = gauge.Scales[0];
        scale.BeginUpdate();
        scale.Ranges.AddRange(CreateRanges(scale.MaxValue - scale.MinValue, scale.MinValue));
        scale.EndUpdate();
        Page.Form.Controls.Add(gaugeControl);
    }

    private Color[] rangeContentColors = { Color.Red, Color.Yellow, Color.Green };

    private IRange[] CreateRanges(float ticks, float start) {
        int range = (int)Math.Floor((double)(ticks / rangeContentColors.Length));
        List<IRange> ranges = new List<IRange>();
        for (int i = 0; i < rangeContentColors.Length; )
            ranges.Add(CreateRange(rangeContentColors[i], (int)(range * i + start), (int)(range * ++i + start)));
        return ranges.ToArray();
    }

    private IRange CreateRange(Color contentColor, int startValue, int endValue) {
        IRange result = new ArcScaleRangeWeb();
        result.AppearanceRange.ContentBrush = new SolidBrushObject(contentColor);
        result.StartValue = startValue;
        result.EndValue = endValue;
        result.StartThickness = 0f;
        result.EndThickness = 50f;
        return result;
    }
}
