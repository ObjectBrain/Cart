using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Domain.Entity;

namespace Service.WebApi.Client
{
    public class CartClientProxy<T> : HttpClient, ICartClientProxy<T> where T : EntityBase
    {
        private readonly string _serviceName;

        public CartClientProxy(IHttpClientConfiguration configuration, ServiceName serviceName)
        {
            _serviceName = serviceName.ToString();

            BaseAddress = configuration.ApiBaseUri;
            DefaultRequestHeaders.Accept.Clear();
            DefaultRequestHeaders.Accept.Add(configuration.MediaTypeWithQualityHeaderValue);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            var response = await GetAsync($"{_serviceName}");
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsAsync<IEnumerable<T>>();
        }

        public async Task<T> Get(int id)
        {
            var response = await GetAsync($"{_serviceName}/{id}");
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsAsync<T>();
        }

        public async Task Post(T entity)
        {
            var response = await this.PostAsJsonAsync($"{_serviceName}", entity);
            response.EnsureSuccessStatusCode();
        }

        public async Task Put(T entity)
        {
            var response = await this.PutAsJsonAsync($"{_serviceName}/{entity.Id}", entity);
            response.EnsureSuccessStatusCode();
        }

        public async Task Delete(T entity)
        {
            var response = await DeleteAsync($"{_serviceName}/{entity.Id}");
            response.EnsureSuccessStatusCode();
        }
    }
}