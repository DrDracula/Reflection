using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Reflection;

namespace Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            datasetMetodlari();
            Console.ReadLine();
        }
        public static void datasetMetodlari()
        {
            Type tip = typeof(DataSet);
            MethodInfo[] metotlar = tip.GetMethods(System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Instance);
            foreach  ( MethodInfo m in metotlar)
            {
                Console.WriteLine($"Method Adi : {m.Name}");
                MethodBody mbody = m.GetMethodBody();
                IList<LocalVariableInfo> lv = mbody.LocalVariables;
                //Console.WriteLine($"Method Adi : {mbody}");
                foreach (var item in lv)
                {
                    Console.WriteLine($"Local variables: {item.LocalType}");
                }
            }
        }
    }
}
