using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment4_Elections.Models
{
    public class Filing
    {
        public object election_year { get; set; }
        public int? most_recent_file_number { get; set; }
        public DateTime? coverage_start_date { get; set; }
        public string request_type { get; set; }
        public int cycle { get; set; }
        public int? file_number { get; set; }
        public object net_donations { get; set; }
        public object receipt_date { get; set; }
        public int report_year { get; set; }
        public int? amendment_version { get; set; }
        public bool most_recent { get; set; }
        public string committee_name { get; set; }
        public string office { get; set; }
        public string report_type { get; set; }
        public object document_type_full { get; set; }
        public string form_category { get; set; }
        public double? debts_owed_by_committee { get; set; }
        public double? total_communication_cost { get; set; }
        public double? debts_owed_to_committee { get; set; }
        public object candidate_id { get; set; }
        public object senate_personal_funds { get; set; }
        public string committee_type { get; set; }
        public string report_type_full { get; set; }
        public int? previous_file_number { get; set; }
        public bool? is_amended { get; set; }
        public string means_filed { get; set; }
        public string primary_general_indicator { get; set; }
        public string ending_image_number { get; set; }
        public object treasurer_name { get; set; }
        public DateTime update_date { get; set; }
        public DateTime coverage_end_date { get; set; }
        public string committee_id { get; set; }
        public string beginning_image_number { get; set; }
        public double? cash_on_hand_beginning_period { get; set; }
        public object opposition_personal_funds { get; set; }
        public object total_independent_expenditures { get; set; }
        public object document_type { get; set; }
        public double? total_disbursements { get; set; }
        public string html_url { get; set; }
        public string csv_url { get; set; }
        public object amendment_chain { get; set; }
        public object party { get; set; }
        public string amendment_indicator { get; set; }
        public string form_type { get; set; }
        public double? cash_on_hand_end_period { get; set; }
        public string pdf_url { get; set; }
        public string fec_url { get; set; }
        public string document_description { get; set; }
        public object total_individual_contributions { get; set; }
        public int? pages { get; set; }
        public double? total_receipts { get; set; }
        public string fec_file_id { get; set; }
        public object house_personal_funds { get; set; }
        public string sub_id { get; set; }
        public object candidate_name { get; set; }
        public object state { get; set; }
    }


    public class Filings
    {
        public string api_version { get; set; }
        public List<Filing> results { get; set; }
        public Pagination pagination { get; set; }
    }
}
