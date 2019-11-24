using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace Assignment4_Elections.Models
{
    public class Filing
    {
        
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Key]
        public Int64 ending_image_number { get; set; }
        public int report_year { get; set; }
        public DateTime update_date { get; set; }
        [ForeignKey("Committee")] 
        
        public string committee_id { get; set; }
        public string document_description { get; set; }
        public string report_type_full { get; set; }

        public Committee Committee { get; set; }
    }


    public class Filings
    {
        public string api_version { get; set; }
        public List<Filing> results { get; set; }
        public Pagination pagination { get; set; }
    }
}
