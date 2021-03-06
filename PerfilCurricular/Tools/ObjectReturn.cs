﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PerfilCurricular.Tools
{
    public class ObjectReturn<T>
    {
        public bool Success { get; set; }

        public Exception Ex { get; set; }

        public string Message { get; set; }

        public T Result { get; set; }
    }
}