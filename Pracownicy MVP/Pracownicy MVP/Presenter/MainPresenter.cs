using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pracownicy_MVP.Presenter
{
    class MainPresenter
    {
        private View.Form1 _view;
        private Model.MainModel _model;
        private int integer = 0;
        public bool was_error = false;

        public MainPresenter(View.Form1 view, Model.MainModel model)
        {
            _view = view;
            _model = model;

            _view.Add_info += _view_Add_info;
            _view.Serialize += _view_Serialize_Element;
            _view.Read += _view_Read;
        }


        private void _view_Serialize_Element()
        {
            if (was_error == false)
            {
                _model.InfoBuildetTmp.Serialize();
                _view_Read();
            }

            integer = 0;
            was_error = false;
        }


        private void _view_Add_info(string info)
        {
            if (info == "" || (integer == 5 && info != "0" && info != "1" && info != "2"))
            {
                if (was_error == false)
                {
                    _view.ShowMessage("Błąd! ");
                    was_error = true;
                }
            }
            else
            {
                info = info.Trim();
                if (integer == 0 || integer == 1) info = $"{info[0].ToString().ToUpper()}{info.Substring(1)}";
                _model.InfoBuildetTmp.Add_info(info, integer);
                integer++;
            }
        }


        private void _view_Read()
        {
            _view.DisplayText = "";

            DirectoryInfo dir = new DirectoryInfo(@"worker_data\");
            FileInfo[] Files = dir.GetFiles("*.xml");
            foreach (FileInfo file in Files)
            {
                _view.DisplayText += _model.InfoBuildetTmp.Read(file.ToString());
            }
        }
    }
}
