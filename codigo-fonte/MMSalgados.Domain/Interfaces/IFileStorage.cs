using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMSalgados.Domain.Interfaces
{
    public interface IFileStorage
    {
        Task<string> UploadAsync(Stream Content, string Name, string ContentType);
    }
}
