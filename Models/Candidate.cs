using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4_Elections.Models
{
    public class Candidate
    {
        public string office_full { get; set; }
        public bool federal_funds_flag { get; set; }
        public string flags { get; set; }
        public DateTime load_date { get; set; }
        public bool has_raised_funds { get; set; }
        public int district_number { get; set; }
        public bool candidate_inactive { get; set; }
        public string state { get; set; }
        public int active_through { get; set; }
        public string candidate_status { get; set; }
        public string district { get; set; }
        public string name { get; set; }
        public string incumbent_challenge_full { get; set; }
        public string first_file_date { get; set; }
        public List<int> cycles { get; set; }
        public string incumbent_challenge { get; set; }
        public string party { get; set; }
        public string last_f2_date { get; set; }
        public string office { get; set; }
        public string party_full { get; set; }
        public List<string> election_districts { get; set; }
        public string last_file_date { get; set; }
        public string candidate_id { get; set; }
        public int? inactive_election_years { get; set; }
        public List<int> election_years { get; set; }
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
