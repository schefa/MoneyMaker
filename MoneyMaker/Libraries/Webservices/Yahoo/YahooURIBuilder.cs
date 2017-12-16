using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Windows.Forms;

namespace MoneyMaker.Libraries.Yahoo
{

    /// <summary>
    /// Methods to build a Yahoo Finance URL
    /// @author : Fjodor Schäfer
    /// </summary>
    public class YahooURIBuilder
    { 
        /// <summary>
        /// executes the web request
        /// </summary>
        public static string executeUrl(string url)
        {
            string result = null;

            var request = WebRequest.Create(url);
            request.ContentType = "application/json; charset=utf-8";

            try
            {
                using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
                using (var sr = new StreamReader(response.GetResponseStream()))
                {
                    result = sr.ReadToEnd();
                }
            }
            catch (WebException webException) {
                MessageBox.Show("Fehlerhafte URL \"" + url + "\"\n" + webException.Message);
            }

            return result;
        }

        /// <summary>
        /// Adds more parameter to the URL
        /// </summary>
        public static string createUrl(string query)
        {
            NameValueCollection param = new NameValueCollection();
            param.Add("q", query);
            param.Add("env", "http://datatables.org/alltables.env");
            param.Add("format", "json"); 
            return "http://query.yahooapis.com/v1/public/yql" + toQueryString(param);
        }

        /// <summary>
        /// Method to encode the URL string
        /// </summary>
        private static string toQueryString(NameValueCollection nvc)
        {
            var array = (from key in nvc.AllKeys
                         from value in nvc.GetValues(key)
                         select string.Format("{0}={1}", HttpUtility.UrlEncode(key), HttpUtility.UrlEncode(value)))
                .ToArray();
            return "?" + string.Join("&", array);
        }
         
    }
}
