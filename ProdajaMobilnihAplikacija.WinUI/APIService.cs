using Flurl.Http;
using Flurl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProdajaMobilnihAplikacija.Model;
using System.Threading.Tasks;

namespace ProdajaMobilnihAplikacija.WinUI
{
    public class APIService
    {
        public static int UserId { get; set; }

        public static string Username { get; set; }
        public static string Password { get; set; }
        public static int UserID { get; set; }


        private readonly string _route = null;
        public APIService(string route)
        {
            _route = route;
        }

        public async Task<T> Get<T>(object search)
        {

            var url = $"{Properties.Settings.Default.APIUrl}/{_route}";

            try
            {
                if (search != null)
                {
                    url += "?";
                    url += await search.ToQueryString();
                }
                return await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
            }
            catch (FlurlHttpException ex)
            {
                if (ex.Call.HttpStatus == System.Net.HttpStatusCode.Unauthorized)
                {
                    MessageBox.Show("Niste authentificirani");
                }
                throw;
            }
            
        }

        // GET BY ID PREMA SERVERU -----------------------
        public async Task<T> GetById<T>(object id)
        {

            var url = $"{Properties.Settings.Default.APIUrl}/{_route}/{id}";

            return await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();

        }

        // INSERT PREMA SERVERU -----------------------

        public async Task<T> Insert<T>(object request)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}";
            return await url.WithBasicAuth(Username, Password).PostJsonAsync(request).ReceiveJson<T>();
        }

        //public async Task<T> Insert<T>(object request)
        //{

        //    var url = $"{Properties.Settings.Default.APIUrl}/{_route}";

        //    try
        //    {
        //        return await url.WithBasicAuth(Username, Password).PostJsonAsync(request).ReceiveJson<T>();
        //    }
        //    catch (FlurlHttpException ex)
        //    {
        //        var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

        //        var stringBuilder = new StringBuilder();
        //        foreach (var error in errors)
        //        {
        //            stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
        //        }

        //        MessageBox.Show(stringBuilder.ToString(), "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        return default(T);
        //    }


        //}

        public async Task<T> InsertWithoutAuth<T>(object request)
        {
            var url = $"{Properties.Settings.Default.APIUrl}/{_route}";
            return await url.WithBasicAuth(Username, Password).PostJsonAsync(request).ReceiveJson<T>();
        }


        // UPDATE PREMA SERVERU -----------------------
        public async Task<T> Update<T>(object id, object request)
        {

            try
            {
                var url = $"{Properties.Settings.Default.APIUrl}/{_route}/{id}";

                return await url.WithBasicAuth(Username, Password).PutJsonAsync(request).ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }

                MessageBox.Show(stringBuilder.ToString(), "Greška", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return default(T);
            }
        }


        public async Task<T> GetActionResponse<T>(string action, object search = null)
        {
            //var url = $"{_apiUrl}/{_route}/{action}";

            var url = $"{Properties.Settings.Default.APIUrl}/{_route}";


            if (search != null)
            {
                url += "?";
                url += await search.ToQueryString();
            }

            return await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
        }
    }
}
