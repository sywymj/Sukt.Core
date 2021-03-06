﻿using Microsoft.Extensions.DependencyInjection;
using Sukt.Core.MongoDB;
using Sukt.Core.MongoDB.DbContexts;
using Sukt.Core.Shared.Extensions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Sukt.Core.API.Startups
{
    public class MongoDBModelule : MongoDBModuleBase
    {
        protected override void AddDbContext(IServiceCollection services)
        {
            var dbpath = services.GetConfiguration()["SuktCore:DbContext:MongoDBConnectionString"];
            var basePath = Microsoft.DotNet.PlatformAbstractions.ApplicationEnvironment.ApplicationBasePath; //获取项目路径
            var dbcontext = Path.Combine(basePath, dbpath);
            if (!File.Exists(dbcontext))
            {
                throw new Exception("未找到存放数据库链接的文件");
            }
            var connection = File.ReadAllText(dbcontext).Trim();
            services.AddMongoDbContext<DefaultMongoDbContext>(options =>
            {
                options.ConnectionString = connection;
            });
        }
    }
}
