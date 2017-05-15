using System;
using System.Collections.Generic;
using System.Configuration;
using System.Reflection;

namespace _22_享元模式.Demo
{
    public class PersonFactory
    {
        private readonly Dictionary<PersonType, Person> _list = new Dictionary<PersonType, Person>();
        private readonly Dictionary<PersonType, string> _dic;

        public PersonFactory()
        {
            var data = ConfigurationManager.AppSettings["ShareData"];
            _dic = Newtonsoft.Json.JsonConvert.DeserializeObject<Dictionary<PersonType, string>>(data);
        }

        public Person CreatePerson(PersonType type, string name)
        {
            if (_list.ContainsKey(type))
            {
                return _list[type];
            }
            var person = (Person)Assembly.GetExecutingAssembly().CreateInstance(_dic[type], true, BindingFlags.Default, null, new object[] { name }, null, null);
            _list.Add(type, person);
            return person;
        }
    }
}