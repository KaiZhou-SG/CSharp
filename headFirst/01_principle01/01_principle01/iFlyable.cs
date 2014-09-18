using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_principle01
{
    /// <summary>
    /// 2014-09-17 Zhou Kai adds this interface, to 
    /// represent a behavior of flying. As different 
    /// animal flys in a different way, so it's separated
    /// from the Animal base class as an independent
    /// interface. Notice that the functions inside an 
    /// interface cannot have a function body, and they
    /// have no acess modifiers because they are 
    /// default as public.
    /// </summary>
    public interface iFlyable
    {
        string fly();
    }
}
