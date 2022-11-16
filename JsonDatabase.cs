using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdsSolution
{
    public interface IDatabaseJSON<T>
    {
        bool DatabaseExists();
      //  void AddElement(T entry);
        void DatabaseCreate();
        T LoadElement(int Key);
        void CreateNewElement(T entry);
        GroupBox CreateContainer(T entry);
        List<T> GetElements();
    }
}
