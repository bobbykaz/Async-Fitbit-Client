using Fitbit.API.Model.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fitbit.API.Client
{
    public partial class FitbitClient : BaseClient
    {
        public async Task<GetUserResponse> GetUser()
        {
            string query = "/1/user/-/profile.json";
            return await GetAsync<GetUserResponse>(query);
        }

        public async Task<GetUserResponse> GetUser(int userid)
        {
            string query = string.Format("/1/user/{0}/profile.json", userid);
            return await GetAsync<GetUserResponse>(query);
        } 

        public async Task<GetUserResponse> UpdateUser(UpdateUserRequest request)
        {
            string query = "/1/user/-/profile.json?";
            string queryParams = SerializeToQueryString<UpdateUserRequest>(request);
            return await PostAsync<GetUserResponse>(query+queryParams);
        }

    }
}
