using System;
using System.Net.Http;
using System.Text;

namespace LinkarRESTAPITest
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                HttpClient client = new HttpClient();
				//JSON
                //HttpContent httpContent = new StringContent("{ \"APIKey\" : \"my_apikey\", \"Data\" : { \"CALCULATED\" : \"False\", \"CONVERSION\" : \"False\", \"FORMAT_SPEC\" : \"False\", \"ORIGINAL_RECORDS\" : \"False\" ,\"CUSTOM_VARS\" : \"\" ,\"OUTPUT_FORMAT\" : \"JSON\" ,\"FILE_NAME\" : \"LK.CUSTOMERS\" ,\"RECORDS\" : [ { \"LKITEMID\" : \"2\" }, { \"LKITEMID\" : \"3\" } ] ,\"DICT_CLAUSE\" : \"\"} }", Encoding.UTF8, "application/json");
                //XML 
				HttpContent httpContent = new StringContent("<LkCommand><APIKey>my_apikey</APIKey><Data><CALCULATED>False</CALCULATED><CONVERSION>False</CONVERSION><FORMAT_SPEC>False</FORMAT_SPEC><ORIGINAL_RECORDS>False</ORIGINAL_RECORDS><CUSTOM_VARS></CUSTOM_VARS><OUTPUT_FORMAT>JSON</OUTPUT_FORMAT><FILE_NAME>LK.CUSTOMERS</FILE_NAME><RECORDS><RECORD><LKITEMID>2</LKITEMID></RECORD><RECORD><LKITEMID>3</LKITEMID></RECORD></RECORDS><DICT_CLAUSE></DICT_CLAUSE></Data></LkCommand>", Encoding.UTF8, "text/xml");
                HttpResponseMessage response = client.PostAsync("http://yourdomain.com:11201/api/read", httpContent).Result;
                response.EnsureSuccessStatusCode();
                string responseBody = response.Content.ReadAsStringAsync().Result;

                Console.WriteLine(responseBody);
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
            }
            Console.ReadKey();
        }
    }
}
