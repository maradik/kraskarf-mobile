using System;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;

namespace Kraskarf.Mobile.Repositories
{
    public class BaseRepository
    {
        protected T GetEntityFromFile<T>(string fileName)
        {
            T entity;

            try
            {
                using (var memoryStream = new MemoryStream(Encoding.UTF8.GetBytes(File.ReadAllText(fileName))))
                {
                    entity = (T)new DataContractJsonSerializer(typeof(T)).ReadObject(memoryStream);
                }
            }
            catch (Exception e)
            {
                throw new ReadEntityException("Не удалось прочитать объект " + typeof(T) + " из файла '" + fileName + "'", e);
            }

            return entity;
        }
    }
}