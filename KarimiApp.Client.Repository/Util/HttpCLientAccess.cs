using System;
using System.Configuration;
using System.Net.Http;
using System.Threading.Tasks;


namespace KarimiApp.Client.Repository.Util
{
    public class HttpClientAccess
    {
        private readonly Uri baseAddress;
        Configuration config;
        AppSettingsSection app;
        /// <summary>
        /// Initializes a new instance of the <see cref="DataAccess"/> class.
        /// </summary>
        public HttpClientAccess()
        {
            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            app = config.AppSettings;
            //chaikenar/////// this.baseAddress = new Uri("http://192.168.1.63:4321/api/");
            // this.baseAddress = new Uri("http://192.168.1.30:4321/api/");
            // this.baseAddress = new Uri("https://localhost:44369/api/");
            //  this.baseAddress = new Uri("http://192.168.1.63:4321/api/");
            this.baseAddress = new Uri(app.Settings["serverAddress"].Value);
            // this.baseAddress = new Uri("http://192.168.1.104:4321/api/");
            // this.baseAddress = new Uri("http://172.17.134.65:4321/api/");
        }

        /// <summary>
        /// Posts the specified model.
        /// </summary>
        /// <typeparam name="TModel">The type of the t model.</typeparam>
        /// <param name="model">The model.</param>
        /// <param name="uri">The URI.</param>
        public async Task<TOut> Post<TIn, TOut>(TIn model, string uri) where TOut : new()
        {
            TOut res = new TOut();

          //  if (model != null)
          //  {
          //      try
            //    {
                    HttpClient hc = new HttpClient
                    {
                        MaxResponseContentBufferSize = int.MaxValue,
                    };
                    hc.DefaultRequestHeaders.Accept.Clear();
                    hc.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                    hc.BaseAddress = this.baseAddress;
                    HttpResponseMessage hrm = await hc.PostAsJsonAsync<TIn>(uri, model).ConfigureAwait(false);
                    string s = await hrm.Content.ReadAsStringAsync();
                    if (hrm.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        res = await hrm.Content.ReadAsAsync<TOut>().ConfigureAwait(false);
                        return res;
                    }
                    else
                    {
                        var msg = await hrm.Content.ReadAsStringAsync();
                        throw new Exception(msg);
                    }
                    hc.Dispose();
             //   }
               // catch (Exception e)
              //  {

               //     System.Windows.Forms.MessageBox.Show(e.Message);
                    
             //   }
             // /  
            //}
            
        }

        public async Task<string> PostReturnString<TModel>(TModel model, string uri)
          where TModel : new()
        {
            string msg = "";
            if (model != null)
            {
                HttpClient hc = new HttpClient();
                hc.DefaultRequestHeaders.Accept.Clear();
                hc.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
                hc.BaseAddress = this.baseAddress;
                HttpResponseMessage hrm = await hc.PostAsJsonAsync<TModel>(uri, model).ConfigureAwait(false);
                if (hrm.IsSuccessStatusCode == true)
                {
                    if (hrm.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        msg = await hrm.Content.ReadAsAsync<string>().ConfigureAwait(false);
                    }

                }
                hc.Dispose();
            }
            return msg;
        }


        /// <summary>
        /// Gets the specified URI.
        /// </summary>
        /// <typeparam name="TModel">The type of the t model.</typeparam>
        /// <param name="uri">The URI.</param>
        /// <returns>Task&lt;List&lt;TModel&gt;&gt;.</returns>
        public async Task<TOut> Get<TOut>(string uri) 
           where TOut : new()
        {
            TOut tmp = new TOut();
            HttpClient hc = new HttpClient();
            hc.DefaultRequestHeaders.Accept.Clear();
            hc.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            hc.BaseAddress = this.baseAddress;
            HttpResponseMessage hrm = await hc.GetAsync(uri).ConfigureAwait(false);
            if (hrm.IsSuccessStatusCode == true)
            {
                if (hrm.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    tmp = await hrm.Content.ReadAsAsync<TOut>().ConfigureAwait(false);
                }
            }

            hc.Dispose();
            return tmp;
        }
        public async Task<string> GetString(string uri)
        {
            string result = "";
            HttpClient hc = new HttpClient();
            hc.DefaultRequestHeaders.Accept.Clear();
            hc.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
            hc.BaseAddress = this.baseAddress;
            HttpResponseMessage hrm = await hc.GetAsync(uri).ConfigureAwait(false);
            if (hrm.IsSuccessStatusCode == true)
            {
                if (hrm.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    result = await hrm.Content.ReadAsAsync<string>().ConfigureAwait(false);
                }
            }

            hc.Dispose();
            return result;
        }
    }
}
