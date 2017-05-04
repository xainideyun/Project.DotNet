using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_访问者模式.App_Code
{
    public class ObjStructure
    {
        private IList<Person> list = new List<Person>();
        public void Attach(Person person)
        {
            list.Add(person);
        }
        public void Remove(Person person)
        {
            list.Remove(person);
        }
        public void Action(MyAction action)
        {
            foreach (var item in list)
            {
                item.Active(action);
            }
        }
    }
}
