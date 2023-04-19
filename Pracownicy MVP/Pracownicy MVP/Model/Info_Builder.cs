using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Newtonsoft.Json;
using System.Diagnostics.Contracts;
using System.Reflection;
using System.Xml.Serialization;

namespace Pracownicy_MVP.Model
{
    class Info_Builder
    {
        private string _name, _surname, _date, _salary, _job_title, _contract;
        public string result;

        public Info_Builder()
        {
            Clear();
        }

        public Info_Builder Add_info(string new_info, int integer)
        {
            //    new_info = new_info.Trim();
            if (integer == 0) _name = new_info;
            if (integer == 1) _surname = new_info;
            if (integer == 2) _date = new_info;
            if (integer == 3) _salary = new_info;
            if (integer == 4) _job_title = new_info;
            if (integer == 5)
            {
                switch (new_info)
                {
                    case "0":
                        _contract = "umowa na czas nieokreślony";
                        break;
                    case "1":
                        _contract = "umowa na czas określony";
                        break;
                    case "2":
                        _contract = "umowa zlecenie";
                        break;

                    default:
                        _contract = "Błąd";
                        break;
                }
            }

            integer++;
            return this;
        }



        public void Serialize()
        {
            employing worker = new employing
            {
                Name = _name,
                Surname = _surname,
                Date = _date,
                Salary = _salary,
                Job_title = _job_title,
                Contract = _contract
            };

            //File.WriteAllText(@"worker_data\" + _name + "_" + _surname + ".json", JsonConvert.SerializeObject(worker));

            XmlSerializer xmlSerializer = new XmlSerializer(worker.GetType());
            using (StreamWriter writer = new StreamWriter(@"worker_data\" + _name + "_" + _surname + ".xml"))
            {
                xmlSerializer.Serialize(writer, worker);
            }

            
            Clear();
        }



        public string Read(string file_name)
        {
            Clear();

            //employing old_worker = JsonConvert.DeserializeObject<employing>(File.ReadAllText(@"worker_data\" + file_name));

            employing old_worker = new employing();
            System.Xml.Serialization.XmlSerializer ser = new System.Xml.Serialization.XmlSerializer(typeof(employing));
            using (StreamReader sr = new StreamReader(@"worker_data\" + file_name))
            {
                old_worker = (employing)ser.Deserialize(sr);    
            }


            _name = old_worker.Name;
            _surname = old_worker.Surname;
            _date = old_worker.Date;
            _salary = old_worker.Salary;
            _job_title = old_worker.Job_title;
            _contract = old_worker.Contract;


            result = _name + ",  " + _surname + ",  " + _date + ",  " + _salary + ",  " + _job_title + ",  " + _contract + "\r\n";
            return result;
        }



        private void Clear()
        {
            _name = "";
            _surname = "";
            _date = "";
            _salary = "";
            _job_title = "";
            _contract = "";
            result = "";
        }
    }
}
