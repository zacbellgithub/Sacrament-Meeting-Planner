﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SacramentMeetingPlanner.Models
{
    public class SpeakToPlan
    {
        [Display(Name = "Speaker To Plan ID")]
        public int SpeakToPlanID { get; set; }

        [Display(Name = "Speaker Placement")]
        public int SpeakerPlacement { get; set; }

        [Display(Name = "Plan")]
        public Plans Plans { get; set; }

        [Display(Name = "Member")]
        public Member Member { get; set; }

        [Display(Name = "Subject")]
        public Subject Subject { get; set; }
    }
}
