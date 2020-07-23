﻿using Microsoft.Extensions.DependencyInjection;
using Sukt.Core.Domain.DataDictionary;
using Sukt.Core.Domain.Models.SystemFoundation.DataDictionary;
using Sukt.Core.EntityFrameworkCore;
using Sukt.Core.Shared.Attributes.Dependency;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sukt.Core.DomainRealization.DataDictionary
{
    [Dependency(ServiceLifetime.Scoped)]
    public class DataDictionaryRealization : BaseRepository<DataDictionaryEntity, Guid>, IDataDictionaryDomain
    {
        public DataDictionaryRealization(IServiceProvider serviceProvider) : base(serviceProvider)
        {
        }
    }
}
