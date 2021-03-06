using System;
using Newtonsoft.Json;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CraftsmanAssessment Data Structure.
    /// </summary>
    [Serializable]
    public class CraftsmanAssessment : AlipayObject
    {
        /// <summary>
        /// 子评分项
        /// </summary>
        [JsonProperty("sub_assessments")]
        [XmlArray("sub_assessments")]
        [XmlArrayItem("craftsman_sub_assessment")]
        public List<CraftsmanSubAssessment> SubAssessments { get; set; }

        /// <summary>
        /// 单个手艺人的评价总条数。
        /// </summary>
        [JsonProperty("total_no")]
        [XmlElement("total_no")]
        public long TotalNo { get; set; }

        /// <summary>
        /// 单个手艺人的总评分的均分
        /// </summary>
        [JsonProperty("total_score")]
        [XmlElement("total_score")]
        public long TotalScore { get; set; }
    }
}
