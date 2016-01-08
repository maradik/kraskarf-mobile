using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.DynamicData;
using Microsoft.Ajax.Utilities;
using NLog;
using Sider;

namespace Kraskarf.Mobile.Accessors
{
    public class BaseAccessor
    {
        protected T GetFromCache<T>(string key)
        {
            try
            {
                var redisClient = new RedisClient<T>();

                return redisClient.Get(key);
            }
            catch (Exception e)
            {
                throw new GettingFromCacheException(
                    string.Format("Не удалось прочитать значение из кэша по ключу '{0}'", key),
                    e);
            }
        }

        protected bool PutToCache<T>(string key, T value)
        {
            try
            {
                var redisClient = new RedisClient<T>();

                return redisClient.Set(key, value);
            }
            catch (Exception e)
            {
                throw new PuttingToCacheException(
                    string.Format("Не удалось записать значение '{0}' в кэш по ключу '{1}'", value, key),
                    e);
            }
        }
    }
}