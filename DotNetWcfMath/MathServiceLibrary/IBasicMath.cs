﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MathServiceLibrary
{
    [ServiceContract(Namespace ="http://MyCompaany.com")]
    public interface IBasicMath
    {
        [OperationContract]
        int Add(int x, int y);
    }
}
