using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20_职责链模式.App_Code
{
    /// <summary>
    /// 定义管理者抽象类，包含管理者的名字与他的上级
    /// </summary>
    public abstract class Manager
    {
        protected string _name;
        protected Manager _superior;
        public Manager( string name)
        {
            this._name = name;
        }
        /// <summary>
        /// 设置管理者的上级
        /// </summary>
        /// <param name="manager"></param>
        public void SetSuperior(Manager manager)
        {
            _superior = manager;
        }
        /// <summary>
        /// 处理请求
        /// </summary>
        /// <param name="type">请求类型</param>
        /// <param name="num">请求数量</param>
        public abstract void ProcessingRequest(RequestType type, int num);
    }
}
