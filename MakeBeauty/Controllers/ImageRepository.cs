// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ImageRepository.cs" company="">
//   
// </copyright>
// <summary>
//   Defines the ImageRepository type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MakeBeauty.Controllers
{
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Web;

    public class ImageRepository
    {
        public IEnumerable<string> GetAllImages(HttpServerUtilityBase server)
        {
            if (server != null)
            {
                var files = Directory.GetFiles(server.MapPath("~/Images/"));

                return files.Select(file => "/Images/" + Path.GetFileName(file)).ToArray();
            }

            return new string[0];
        }
    }
}