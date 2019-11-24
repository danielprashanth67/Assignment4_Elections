using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Assignment4_Elections.Models

{
    public class Candidate
    {
        public string office_full { get; set; }
        public string state { get; set; }
        public int active_through { get; set; }
        public string name { get; set; }
        public string party_full { get; set; }
        [Key]
        public string candidate_id { get; set; }
        public List<Committee> Committees { get; set; }
    }

    public class Pagination
    {
        public int count { get; set; }
        public int pages { get; set; }
        public int per_page { get; set; }
        public int page { get; set; }
    }

    public class Candidates
    {
        public string api_version { get; set; }
        public List<Candidate> results { get; set; }
        public Pagination pagination { get; set; }
    }
}
