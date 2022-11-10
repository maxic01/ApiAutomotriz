﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrontAutoProg.Servicios
{
    internal class ClienteSingleton
    {
        private static ClienteSingleton instancia;
        private HttpClient client;
        private ClienteSingleton()
        {
            client = new HttpClient();
        }
        public static ClienteSingleton GetInstance()
        {
            if (instancia == null)
                instancia = new ClienteSingleton();
            return instancia;
        }
        public async Task<string> GetAsync(string url)
        {
            var result = await client.GetAsync(url);
            var content = "";
            if (result.IsSuccessStatusCode)
                content = await result.Content.ReadAsStringAsync();
            return content;
        }
        public async Task<string> PostAsync(string url, string data)
        {
            StringContent content = new StringContent(data, Encoding.UTF8,
            "application/json");
            var result = await client.PostAsync(url, content);
            var response = "";
            if (result.IsSuccessStatusCode)
                response = await result.Content.ReadAsStringAsync();
            return response;
        }
        public async Task<string> PutAsync(string url, string data)
        {
            StringContent content = new StringContent(data, Encoding.UTF8,
            "application/json");
            var result = await client.PutAsync(url,content);
            var response = "";
            if (result.IsSuccessStatusCode)
                response = await result.Content.ReadAsStringAsync();
            return response;
        }
        public async Task<string> DeleteAsync(string url)
        {
            var result = await client.DeleteAsync(url);
            var response = "";
            if (result.IsSuccessStatusCode)
                response = await result.Content.ReadAsStringAsync();
            return response;
        }
    }
}
