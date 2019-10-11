using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DormitoryManageSystem.Common
{
    public class CommonUsing
    {
        public static string ImagePath()
        {
            string rs = "";
            string currentPath = Directory.GetCurrentDirectory();
            string[] pathComponent = currentPath.Split('\\');
            int i = 0;
            foreach (string str in pathComponent)
            {
                i++;
                if (str.Equals("DormitoryManageSystem"))
                {
                    for (int j = 0; j < i; j++)
                    {
                        rs = rs + pathComponent[j] + @"\";
                    }
                    break;
                }
            }
            rs = rs + @"Images\";
            return rs;
        }
    }
}
