using System;
using Gtk;
using Nomina.Datos;

namespace Nomina
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Application.Init();
            MainWindow win = new MainWindow();
            win.Show();
            /*conexion cn = new conexion();
            cn.Open();
            cn.Close();*/
            Application.Run();
        }
    }
}
