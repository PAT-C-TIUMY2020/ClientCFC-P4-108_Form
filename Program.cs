using ServiceMtk_P2_20180140108;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientCFC_P4_20180140108_Form
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            BasicHttpBinding bind = new BasicHttpBinding();
            ChannelFactory<IMatematika> objChannel = new ChannelFactory<IMatematika>(bind, "http://localhost:1907");
            IMatematika obj = objChannel.CreateChannel();
            double hasilTambah = obj.Tambah(1, 2);
            Console.WriteLine("1 + 2 = " + hasilTambah);
            double hasilKurang = obj.Kurang(1, 2);
            Console.WriteLine("1 - 2 = " + hasilKurang);
            double hasilKali = obj.Kali(1, 2);
            Console.WriteLine("1 x 2 = " + hasilKali);
            double hasilBagi = obj.Bagi(1, 2);
            Console.WriteLine("1 / 2 = " + hasilBagi);
            Console.ReadLine();

            Koordinat objk = new Koordinat();
        }
    }
}
