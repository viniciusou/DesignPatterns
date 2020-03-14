using System;

namespace Proxy
{
    /// <summary>
    /// Proxy lets you provide a substitute or placeholder for another object. A proxy 
    /// controls access to the original object, allowing you to perform something either 
    /// before or after the request gets through to the original object.
    /// 
    /// Proxy is a class that functions as an interface to a particular resource. That
    /// resource may be remote, expensive to construct, or may require logging or some
    /// other added functionality.
    /// 
    /// You do not add new members, you only add new functionalities to the existing
    /// members. Proxy provides an identical interface.
    /// In this case CarProxy adds functionality to the existing method Drive().
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var driver = new Driver(17);
            ICar carProxy = new CarProxy(driver);
            carProxy.Drive();
        }
    }
}
