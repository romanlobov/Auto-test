using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using System.Diagnostics;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        IWebDriver Browser;
        
        public object chcp { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //открываем браузер
            Browser = new OpenQA.Selenium.Chrome.ChromeDriver();
                Browser.Manage().Window.Maximize();
            Browser.Navigate().GoToUrl("http://localhost:3000/");
        }

        private void button2_Click(object sender, EventArgs e)

        //Запускаем серверные приложения
        {
                string[] farmserv = { "chcp 855", "C:/1/Тестирование/feeding-farm-server/feeding-farm-server.exe"};
                File.WriteAllLines("coms1.bat", farmserv, Encoding.GetEncoding(855));
                Process.Start("coms1.bat");

                string[] datatransferfarm = { "chcp 855", "C:/1/Тестирование/feeding-datatransfer-farm/netcoreapp2.0/win7-x64/publishr/EkoPoint.Feed.DataTransposeFarm.exe.exe" };
                File.WriteAllLines("coms2.bat", datatransferfarm, Encoding.GetEncoding(855));
                Process.Start("coms2.bat");

                string[] diarycomp = { "chcp 855", "C:/1/Тестирование/feeding-diary-comp/feeding-diary-comp.exe" };
                File.WriteAllLines("coms3.bat", diarycomp, Encoding.GetEncoding(855));
                Process.Start("coms3.bat");

                string[] digistar = { "chcp 855", "C:/1/Тестирование/feeding-digi-star/feeding-digi-star.exe" };
                File.WriteAllLines("coms4.bat", digistar, Encoding.GetEncoding(855));
                Process.Start("coms4.bat");

                string[] transfer = { "chcp 855", "C:/1/Тестирование/feeding-farm-transfer-mapper/netcoreapp2.0/win7-x64/publish/Ekopoint.Feeding.Farm.TransferMapper.exe" };
                File.WriteAllLines("coms5.bat", transfer, Encoding.GetEncoding(855));
                Process.Start("coms5.bat");

                string[] Reports = { "chcp 855", "C:/1/Тестирование/feeding-reports/netcoreapp2.0/win7-x64/Ekopoint.Feeding.Reports.Api.exe" };
                File.WriteAllLines("coms6.bat", Reports, Encoding.GetEncoding(855));
                Process.Start("coms6.bat");

                string[] Tasks = { "chcp 855", "C:/1/Тестирование/feeding-task/netcoreapp2.0/win7-x64/publish/Ekopoint.Feeding.Tasks.exe" };
                File.WriteAllLines("coms7.bat", Tasks, Encoding.GetEncoding(855));
                Process.Start("coms7.bat");

                string[] liteserv = { "chcp 855", "cd C:/1/Тестирование/feeding-client", "lite-server" };
                File.WriteAllLines("coms8.bat", liteserv, Encoding.GetEncoding(855));
                Process.Start("coms8.bat");
            }

        private void button3_Click(object sender, EventArgs e)
        {
            string[] liteserv = { "chcp 855", "cd C:/1/Тестирование/feeding-client", "lite-server" };
            File.WriteAllLines("coms8.bat", liteserv, Encoding.GetEncoding(855));
            Process.Start("coms8.bat");
                  }
    }
}
