using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diary
{
    public class ClassAdd
    {
        public bool StoreData(String Path,String Content)
        {
            File.WriteAllText(Path, Content);
            return true;

        }
    }
}
