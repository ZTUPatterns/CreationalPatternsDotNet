using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp1
{
    public class Core
    {
        string paramsFileName = "params.dat";
        private static Core? instance = null;
        private Core ()
        {
        }
        public static Core Instance
        {
            get
            {
                if (instance == null)
                    instance = new Core ();
                return instance;
            }
        }
        public string? LoadDataFromFile()
        {          
            if (File.Exists(paramsFileName))            
                return File.ReadAllText(paramsFileName);                         
            else
                return null;
        }

    }
}
