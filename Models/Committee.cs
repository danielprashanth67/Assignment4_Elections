using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assignment4_Elections.Models
{
    public class Committee
    {
        public string committee_type_full { get; set; }
        public string name { get; set; }
        public string state { get; set; }
        public string party_full { get; set; }
        [Key]
        public string committee_id { get; set; }
        [ForeignKey("Candidate")]
        public string candidate_id { get; set; }
        [NotMapped]
        public List<string> candidate_ids { get; set; }
        public Candidate Candidate { get; set; }
       
    }

    public class Committees
    {
        public string api_version { get; set; }
        public List<Committee> results { get; set; }
        public Pagination pagination { get; set; }
    }
}
