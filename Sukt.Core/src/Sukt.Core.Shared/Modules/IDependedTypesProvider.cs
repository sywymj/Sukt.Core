﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Sukt.Core.Shared.Modules
{
    public interface IDependedTypesProvider
    {
        /// <summary>
        /// 得到依赖类型集合
        /// </summary>
        /// <returns></returns>
        Type[] GetDependedTypes();
    }
}
