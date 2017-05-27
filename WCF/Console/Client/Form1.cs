using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Services;

namespace Client
{
    public partial class Form1 : Form
    {
        private IUser _service;
        public Form1()
        {
            InitializeComponent();
            //DemoInit();
            ConfigInit();
            btnPrint.Click += (a, b) =>
            {
                MessageBox.Show(_service.ShowName(txtName.Text));
            };
        }

        // 代码加载方式
        private void DemoInit()
        {
            var factory = new ChannelFactory<IUser>(new BasicHttpBinding());
            factory.Endpoint.Address = new EndpointAddress(new Uri("http://localhost:8801/UserService"));
            _service = factory.CreateChannel();
        }

        // 配置文件加载方式
        private void ConfigInit()
        {
            var factory = new ChannelFactory<IUser>("myConfig");
            _service = factory.CreateChannel();
        }
    }
}
