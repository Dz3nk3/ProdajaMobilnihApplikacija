using Flurl.Http;
using ProdajaMobilnihAplikacija.Model;
using ProdajaMobilnihAplikacija.Model.Requests;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace ProdajaMobilnihAplikacija.Mobile
{
    public class APIService
    {

        public static string Username { get; set; }
        public static string Password { get; set; }

        public static int UserID { get; set; }
        public static int UserRacunID { get; set; }
        public static int UserVoziloID { get; set; }
        public static int CijenaVozila { get; set; }

        public static Model.Klijent LogovaniKlijent { get; set; }

        private readonly string _route = null;

#if DEBUG
        private string _apiUrl = "http://localhost:5000/api";
#endif
#if RELEASE
       private string _apiUrl = "https://mywebsite.azure.com/api/";
#endif
        public APIService(string route)
        {
            _route = route;
        }


        public async Task<T> Get<T>(object search)
        {

            var url = $"{_apiUrl}/{_route}";

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
                    await Application.Current.MainPage.DisplayAlert("Greška", "Niste autenticifirani", "OK");
                }
                throw;
            }
        }

        public async Task<T> GetById<T>(object id)
        {

            var url = $"{_apiUrl}/{_route}/{id}";

            return await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();

        }




        public async Task<T> GetActionResponse<T>(string action, object search = null)
        {
            var url = $"{_apiUrl}/{_route}/{action}";

            if (search != null)
            {
                url += "?";
                url += await search.ToQueryString();
            }

            return await url.WithBasicAuth(Username, Password).GetJsonAsync<T>();
        }


        public async Task<T> PostActionResponse<T>(string action, object request)
        {
            var url = $"{_apiUrl}/{_route}/{action}";

            try
            {
                if (Username == null && Password == null)
                {
                    return await url.PostJsonAsync(request).ReceiveJson<T>();
                }
                return await url.WithBasicAuth(Username, Password).PostJsonAsync(request).ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {
                //var errors = await ex.GetResponseJsonAsync<Dictionary<string, string[]>>();
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, object>>();
                var stringBuilder = new StringBuilder();

                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }
                await Application.Current.MainPage.DisplayAlert("Greška", stringBuilder.ToString(), "OK");
                return default(T);
            }

        }



        public async Task<T> PutActionResponse<T>(string action, int id, object request)
        {
            var url = $"{_apiUrl}/{_route}/{action}/{id}";

            try
            {
                if (Username == null && Password == null)
                {
                    return await url.PostJsonAsync(request).ReceiveJson<T>();
                }
                return await url.WithBasicAuth(Username, Password).PutJsonAsync(request).ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, object>>();
                var stringBuilder = new StringBuilder();

                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }
                await Application.Current.MainPage.DisplayAlert("Greška", stringBuilder.ToString(), "OK");
                return default(T);
            }

        }


        // INSERT PREMA SERVERU -----------------------
        public async Task<T> Insert<T>(object request)
        {

            var url = $"{_apiUrl}/{_route}";
            try
            {
                return await url.WithBasicAuth(Username, Password).PostJsonAsync(request).ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, object>>();

                var stringBuilder = new StringBuilder();

                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }
                await Application.Current.MainPage.DisplayAlert("Greška", stringBuilder.ToString(), "OK");
                return default(T);
            }


        }


        // UPDATE PREMA SERVERU -----------------------
        public async Task<T> Update<T>(object id, object request)
        {

            try
            {
                var url = $"{_apiUrl}/{_route}/{id}";

                return await url.WithBasicAuth(Username, Password).PutJsonAsync(request).ReceiveJson<T>();
            }
            catch (FlurlHttpException ex)
            {
                var errors = await ex.GetResponseJsonAsync<Dictionary<string, object>>();

                var stringBuilder = new StringBuilder();
                foreach (var error in errors)
                {
                    stringBuilder.AppendLine($"{error.Key}, ${string.Join(",", error.Value)}");
                }
                await Application.Current.MainPage.DisplayAlert("Greška", stringBuilder.ToString(), "OK");
                return default(T);
            }
        }


    }
}
