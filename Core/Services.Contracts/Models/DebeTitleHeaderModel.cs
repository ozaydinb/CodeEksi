﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using Services.Contracts.Binding;

namespace Services.Contracts.Models
{
    [DataContract]
    [Bind("ol.stats.topic-list.partial > li > a")]
    public class DebeTitleHeaderModel
    {
        [Bind("span", ElementValueSelector = ElementValueSelector.InnerText)]
        [DataMember(Name = "title")]
        public string Title { get; set; }

        [Bind(null, AttributeName = "href")]
        [DataMember(Name = "link")]
        public string Link { get; set; }

        [DataMember(Name = "entry_id")]
        public string EntryId { get; set; }

        [DataMember(Name = "debe_entry_detail_model")]
        public EntryDetailModel DebeEntryDetailModel { get; set; }
    }
}