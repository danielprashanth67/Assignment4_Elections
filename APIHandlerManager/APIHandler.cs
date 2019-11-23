using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using Newtonsoft.Json;
using Assignment4_Elections.Models;
using System.Threading.Tasks;

namespace Assignment4_Elections.APIHandlerManager
{
    public class APIHandler
    {
        // Obtaining the API key is easy. The same key should be usable across the entire
        // data.gov developer network, i.e. all data sources on data.gov.
        // https://www.nps.gov/subjects/developer/get-started.html

        static string BASE_URL = "https://api.open.fec.gov/v1";
        static string API_KEY = "mKkoYw1Nrwt5h6LfrzSMwB0AaAwKJRDLkQ7dNDnW"; //Add your API key here inside ""

        HttpClient httpClient;

        /// <summary>
        ///  Constructor to initialize the connection to the data source
        /// </summary>
        public APIHandler()
        {
            httpClient = new HttpClient();
            httpClient.DefaultRequestHeaders.Accept.Clear();
            httpClient.DefaultRequestHeaders.Add("X-Api-Key", API_KEY);
            httpClient.DefaultRequestHeaders.Accept.Add(
                new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }

        /// <summary>
        /// Method to receive data from API end point as a collection of objects
        /// 
        /// JsonConvert parses the JSON string into classes
        /// </summary> 
        /// <returns></returns>
        public Candidates GetCandidates()
        {
            string CANDIDATES_API_PATH = BASE_URL + "/candidates/?sort_nulls_last=false&sort_null_only=false&sort_hide_null=false&page=1&sort=name&per_page=50";
            string candidatesData = "";

            Candidates candidates = null;

            httpClient.BaseAddress = new Uri(CANDIDATES_API_PATH);

 
            // It can take a few requests to get back a prompt response, if the API has not received
            //  calls in the recent past and the server has put the service on hibernation
            try
            {
                HttpResponseMessage response = httpClient.GetAsync(CANDIDATES_API_PATH).GetAwaiter().GetResult();
                if (response.IsSuccessStatusCode)
                {
                    candidatesData = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                    Console.WriteLine(candidatesData);
                }

                if (!candidatesData.Equals(""))
                {
                    // JsonConvert is part of the NewtonSoft.Json Nuget package
                    candidates = JsonConvert.DeserializeObject<Candidates>(candidatesData);
                }
            }
            catch (Exception e)
            {
                // This is a useful place to insert a breakpoint and observe the error message
                Console.WriteLine(e.Message);
            }

            return candidates;
        }
        public Committees GetCommittees()
        {
            string COMMITTEES_API_PATH = BASE_URL + "/committees/?sort_nulls_last=false&sort_null_only=false&sort_hide_null=false&page=1&sort=name&per_page=50";
            string committeesData = "";

            Committees committees = null;

            httpClient.BaseAddress = new Uri(COMMITTEES_API_PATH);


            // It can take a few requests to get back a prompt response, if the API has not received
            //  calls in the recent past and the server has put the service on hibernation
            try
            {
                HttpResponseMessage response = httpClient.GetAsync(COMMITTEES_API_PATH).GetAwaiter().GetResult();
                if (response.IsSuccessStatusCode)
                {
                    committeesData = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                    Console.WriteLine(committeesData);
                }

                if (!committeesData.Equals(""))
                {
                    // JsonConvert is part of the NewtonSoft.Json Nuget package
                    committees = JsonConvert.DeserializeObject<Committees>(committeesData);
                }
            }
            catch (Exception e)
            {
                // This is a useful place to insert a breakpoint and observe the error message
                Console.WriteLine(e.Message);
            }

            return committees;
        }
        public Filings GetFilings()
        {
            string FILINGS_API_PATH = BASE_URL + "/filings/?sort_nulls_last=false&sort_null_only=false&sort_hide_null=false&page=1&sort=-receipt_date";
            string filingsData = "";

            Filings filings = null;

            httpClient.BaseAddress = new Uri(FILINGS_API_PATH);


            // It can take a few requests to get back a prompt response, if the API has not received
            //  calls in the recent past and the server has put the service on hibernation
            try
            {
                HttpResponseMessage response = httpClient.GetAsync(FILINGS_API_PATH).GetAwaiter().GetResult();
                if (response.IsSuccessStatusCode)
                {
                    filingsData = response.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                    Console.WriteLine(filingsData);
                }

                if (!filingsData.Equals(""))
                {
                    // JsonConvert is part of the NewtonSoft.Json Nuget package
                    filings = JsonConvert.DeserializeObject<Filings>(filingsData);
                }
            }
            catch (Exception e)
            {
                // This is a useful place to insert a breakpoint and observe the error message
                Console.WriteLine(e.Message);
            }

            return filings;
        }
    }
}
