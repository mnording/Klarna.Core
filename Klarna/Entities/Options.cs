using Newtonsoft.Json;

namespace Klarna.Entities
{
    public class Options
    {

        [JsonProperty(PropertyName = "color_border_selected")]
        public string ColorBorderSelected { get; set; }
        [JsonProperty(PropertyName = "color_border")]
        public string ColorBorder { get; set; }
        [JsonProperty(PropertyName = "color_button")]
        public string ColorButton { get; set; }
        [JsonProperty(PropertyName = "color_button_text")]
        public string ColorButtonText { get; set; }
        [JsonProperty(PropertyName = "color_checkbox")]
        public string ColorCheckbox { get; set; }
        [JsonProperty(PropertyName = "color_checkbox_checkmark")]
        public string ColorCheckboxCheckmark { get; set; }
        [JsonProperty(PropertyName = "color_details")]
        public string ColorDetails { get; set; }
        [JsonProperty(PropertyName = "color_header")]
        public string ColorHeader { get; set; }
        [JsonProperty(PropertyName = "color_link")]
        public string ColorLink { get; set; }
        [JsonProperty(PropertyName = "color_text")]
        public string ColorText { get; set; }
        [JsonProperty(PropertyName = "color_text_secondary")]
        public string ColorTextSecondary { get; set; }
        [JsonProperty(PropertyName = "radius_border")]
        public string RadiusBorder { get; set; }
    }
}
