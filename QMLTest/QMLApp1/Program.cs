using System;
using System.Threading;
using Qml.Net;
using Qml.Net.Runtimes;

namespace QMLTest
{
    class Program
    {
        public class NetObject
        {
            public void Method()
            {
                // Called from QML.
            }
        }

        static int Main(string[] args)
        {
            RuntimeManager.DiscoverOrDownloadSuitableQtRuntime();
            using (var app = new QGuiApplication(args))
            {
                using (var engine = new QQmlApplicationEngine())
                {
                    Qml.Net.Qml.RegisterType<NetObject>("test", 1, 1);

                    engine.Load("Main.qml");
                    
                    return app.Exec();
                }
            }
        }
    }
}
