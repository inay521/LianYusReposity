﻿using System.Data.Common;
using System.Data.Entity;
using Abp.Zero.EntityFramework;
using ABPDemoProject.Authorization.Roles;
using ABPDemoProject.Authorization.Users;
using ABPDemoProject.entity;
using ABPDemoProject.MultiTenancy;

namespace ABPDemoProject.EntityFramework
{
    public class ABPDemoProjectDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */

        public virtual IDbSet<Task> Tasks { get; set; }
        public virtual IDbSet<Person> People { get; set; }
        public ABPDemoProjectDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in ABPDemoProjectDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of ABPDemoProjectDbContext since ABP automatically handles it.
         */
        public ABPDemoProjectDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public ABPDemoProjectDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public ABPDemoProjectDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //全局约定   定义name为Id的键为主键
            modelBuilder.Properties().Where(p => p.Name == "Id").Configure(config=>config.IsKey());

        }
    }
}
