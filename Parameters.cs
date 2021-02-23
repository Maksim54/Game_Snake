using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Game_Snakes
{
    class Parameters
        {

        private string resourcesFolder;

        public Parameters()
        {
            var ind = Directory.GetCurrentDirectory().ToString()
                .IndexOf("bin", StringComparison.Ordinal); // Получить индекс папки bin

            string binFolder =
                Directory.GetCurrentDirectory().ToString().Substring(0, ind)
                    .ToString(); // путь до указанной в инкесе папки

            resourcesFolder = binFolder + "Resources\\";
        }

        public string GetResourceFolder()
        {
            return resourcesFolder;
        }
    }
}
