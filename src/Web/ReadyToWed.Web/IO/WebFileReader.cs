using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadyToWed.IO
{
    public class WebFileReader : IFileReader
    {
        public WebFileReader(string workingDirectory)
        {
            if (workingDirectory == null)
            {
                throw new ArgumentNullException("workingDirectory");
            }
            if (!System.IO.Directory.Exists(workingDirectory))
            {
                throw new ArgumentOutOfRangeException("workingDirectory", "The workingDirectory specified does not exist.  Please specify a valid workingDirectory.");
            }
            this.workingDirectory = workingDirectory;
        }

        private readonly string workingDirectory;

        public async Task<Maybe<string>> ReadAsync(string fileName)
        {
            string path = System.IO.Path.Combine(this.workingDirectory, fileName);
            if (System.IO.File.Exists(path))
            {
                using (System.IO.StreamReader reader = new System.IO.StreamReader(path))
                {
                    string fileContents = await reader.ReadToEndAsync();
                    return new Maybe<string>(fileContents);
                }
            }
            return new Maybe<string>();
        }
                
    }
}
