using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ReadyToWed.Models;

namespace ReadyToWed.Data
{
    public class FileModelReader : IModelReader
    {

        public FileModelReader(IO.IFileReader fileReader, Serialization.IDeserializer deserializer, string fileExtension)
        {
            if (fileReader == null)
            {
                throw new ArgumentNullException("fileReader");
            }
            if (deserializer == null)
            {
                throw new ArgumentNullException("deserializer");
            }
            if (fileExtension == null)
            {
                throw new ArgumentNullException("fileExtension");
            }
            this.fileReader = fileReader;
            this.deserializer = deserializer;
            this.fileExtension = fileExtension;
        }

        private readonly Serialization.IDeserializer deserializer;
        private readonly IO.IFileReader fileReader;
        private readonly string fileExtension;

        public async Task<Maybe<T>> ReadAsync<T>(int id) where T : Model
        {
            Maybe<string> fileContents = await this.fileReader.ReadAsync(typeof(T).FullName + fileExtension);
            if (fileContents.Any())
            {
                IEnumerable<T> list = await this.deserializer.DeserializeObjectAsync<IEnumerable<T>>(fileContents.Single());
                T value = (from i in list where i.Id == id select i).FirstOrDefault();
                if (value != null)
                {
                    return new Maybe<T>(value);
                }
            }
            return new Maybe<T>();
        }

    }
}
