using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fitbit.API.Model.Body;
using Fitbit.API.Model.Common.Enums.Collections;

namespace Fitbit.API.Client
{
    public partial class FitbitClient : BaseClient
    {
        #region GetBodyMeasurements
        public async Task<GetBodyMeasurementsResponse> GetBodyMeasurements_DEPRECATED(DateTime date)
        {
            string query = string.Format("1/user/-/date/{0:yyyy-MM-dd}.json", date);
            return await GetAsync<GetBodyMeasurementsResponse>(query);
        }

        public async Task<GetBodyMeasurementsResponse> GetBodyMeasurements_DEPRECATED(DateTime date, int userid)
        {
            string query = string.Format("1/user/{0}/date/{1:yyyy-MM-dd}.json", userid, date);
            return await GetAsync<GetBodyMeasurementsResponse>(query);
        }
        #endregion

        #region GetBodyWeight
        public async Task<GetBodyWeightResponse> GetBodyWeightLog(DateTime date)
        {
            string query = string.Format("/1/user/-/body/log/weight/date/{0:yyyy-MM-dd}.json", date);
            return await GetAsync<GetBodyWeightResponse>(query);
        }

        public async Task<GetBodyWeightResponse> GetBodyWeightLog(DateTime start, DateTime end)
        {
            string query = string.Format("/1/user/-/body/log/weight/date/{0:yyyy-MM-dd}/{1:yyyy-MM-dd}.json", start, end);
            return await GetAsync<GetBodyWeightResponse>(query);
        }

        public async Task<GetBodyWeightResponse> GetBodyWeightLog(DateTime date, CollectionTimespan range)
        {
            string query = string.Format("/1/user/-/body/log/weight/date/{0:yyyy-MM-dd}/{1}.json", date, ConvertCollectionTimespanToString(range));
            return await GetAsync<GetBodyWeightResponse>(query);
        }

        public async Task<GetBodyWeightResponse> GetBodyWeightLog(int userid, DateTime date)
        {
            string query = string.Format("/1/user/{1}/body/log/weight/date/{0:yyyy-MM-dd}.json", date, userid);
            return await GetAsync<GetBodyWeightResponse>(query);
        }

        public async Task<GetBodyWeightResponse> GetBodyWeightLog(int userid, DateTime start, DateTime end)
        {
            string query = string.Format("/1/user/{2}/body/log/weight/date/{0:yyyy-MM-dd}/{1:yyyy-MM-dd}.json", start, end, userid);
            return await GetAsync<GetBodyWeightResponse>(query);
        }

        public async Task<GetBodyWeightResponse> GetBodyWeightLog(int userid, DateTime date, CollectionTimespan range)
        {
            string query = string.Format("/1/user/{2}/body/log/weight/date/{0:yyyy-MM-dd}/{1}.json", date, ConvertCollectionTimespanToString(range), userid);
            return await GetAsync<GetBodyWeightResponse>(query);
        }
        #endregion

        #region GetBodyWeightGoal
        public async Task<GetBodyWeightGoalResponse> GetBodyWeightGoal()
        {
            string query = "/1/user/-/body/log/weight/goal.json";
            return await GetAsync<GetBodyWeightGoalResponse>(query);
        }
        #endregion

        #region GetBodyFat
        public async Task<GetBodyFatResponse> GetBodyFatLog(DateTime date)
        {
            string query = string.Format("/1/user/-/body/log/fat/date/{0:yyyy-MM-dd}.json", date);
            return await GetAsync<GetBodyFatResponse>(query);
        }

        public async Task<GetBodyFatResponse> GetBodyFatLog(DateTime start, DateTime end)
        {
            string query = string.Format("/1/user/-/body/log/fat/date/{0:yyyy-MM-dd}/{1:yyyy-MM-dd}.json", start, end);
            return await GetAsync<GetBodyFatResponse>(query);
        }

        public async Task<GetBodyFatResponse> GetBodyFatLog(DateTime date, CollectionTimespan range)
        {
            string query = string.Format("/1/user/-/body/log/weight/fat/{0:yyyy-MM-dd}/{1}.json", date, ConvertCollectionTimespanToString(range));
            return await GetAsync<GetBodyFatResponse>(query);
        }

        public async Task<GetBodyFatResponse> GetBodyFatLog(int userid, DateTime date)
        {
            string query = string.Format("/1/user/{1}/body/log/fat/date/{0:yyyy-MM-dd}.json", date, userid);
            return await GetAsync<GetBodyFatResponse>(query);
        }

        public async Task<GetBodyFatResponse> GetBodyFatLog(int userid, DateTime start, DateTime end)
        {
            string query = string.Format("/1/user/{2}/body/log/fat/date/{0:yyyy-MM-dd}/{1:yyyy-MM-dd}.json", start, end, userid);
            return await GetAsync<GetBodyFatResponse>(query);
        }

        public async Task<GetBodyFatResponse> GetBodyFatLog(int userid, DateTime date, CollectionTimespan range)
        {
            string query = string.Format("/1/user/{2}/body/log/fat/date/{0:yyyy-MM-dd}/{1}.json", date, ConvertCollectionTimespanToString(range), userid);
            return await GetAsync<GetBodyFatResponse>(query);
        }
        #endregion

        #region GetBodyFatGoal
        public async Task<GetBodyFatGoalResponse> GetBodyFatGoal()
        {
            string query = "/1/user/-/body/log/fat/goal.json";
            return await GetAsync<GetBodyFatGoalResponse>(query);
        }
        #endregion
    }
}
