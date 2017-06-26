using _19_命令模式.App_Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_命令模式
{
    /* 定义：
        将一个请求封装为一个对象，从而使你可用不同的请求对客户进行参数化；对请求排队或者记录日志，以及支持可撤销的操作
        命令模式可以把请求一个操作的对象与知道怎么执行一个操作的对象分割开
       作用：
        1. 他能较容易的设计一个命令队列
        2. 在需要的情况下，可以较容易的将命令记入日志
        3. 允许接收请求的一方决定是否要否决请求
        4. 可以容易的实现对请求的撤销和重做
        5. 由于加进新的具体命令类不影响其他的类，因此增加新的具体命令类很容易
       场景：
        在对列表进行操作时，将所有操作的命令保存下来，然后一起执行，期间可以撤销相关的操作
         */
    class Program
    {
        static void Main(string[] args)
        {
            Recorder recorder = new Recorder();
            Executer execute = new Executer();
            Command command1 = new MarrayCommand("孙小双", execute);
            Command command2 = new PhoneCommand("李娟娟", execute);
            Command command3 = new MarrayCommand("万星辉", execute);
            Command command4 = new PhoneCommand("尹晓畅", execute);
            recorder.SetOrder(command1);
            recorder.SetOrder(command2);
            recorder.SetOrder(command3);
            recorder.SetOrder(command4);
            recorder.Notify();

            Console.Read();
        }
    }
}
