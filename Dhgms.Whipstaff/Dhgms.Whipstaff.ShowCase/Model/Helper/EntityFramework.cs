namespace Dhgms.Whipstaff.Model.Helper
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.Data.Entity;
    using System.Diagnostics;
    using System.Diagnostics.CodeAnalysis;
    using System.Runtime.Serialization;
    using System.Xml;
    using System.Xml.Linq;

        // ********** WARNING **********
        // This code is automatically generated! Any Changes you make to this file will be lost!
        // To make changes edit the corresponding .tt file!

    #region our methods

    /// <summary>
    /// Helper methods for using POCO and Entity Framework
    /// </summary>
    public class Server
                : Dhgms.DataManager.Model.Helper.EntityFramework.Base<Dhgms.Whipstaff.Model.Info.Server>
    {
/// <summary>
/// Maps the information class to the entity framework model
/// </summary>
/// <param name="modelBuilder">
/// model builder object
/// </param>
/// <param name="schemaName">
/// The schema Name in the database
/// </param>
/// <param name="tableName">
/// The table Name in the database
/// </param>
public override void DoEntityFrameworkModel(DbModelBuilder modelBuilder, string schemaName, string tableName)
{
    if (modelBuilder == null)
    {
        throw new ArgumentNullException("modelBuilder");
    }

    if (tableName == null)
    {
        throw new ArgumentNullException("tableName");
    }

    modelBuilder.Entity<Dhgms.Whipstaff.Model.Info.Server>().ToTable(tableName, schemaName);
    modelBuilder.Entity<Dhgms.Whipstaff.Model.Info.Server>().HasKey(x => x.Id);
    modelBuilder.Entity<Dhgms.Whipstaff.Model.Info.Server>().Property(x => x.Id).IsRequired();
    modelBuilder.Entity<Dhgms.Whipstaff.Model.Info.Server>().Property(x => x.Name).IsRequired();
    modelBuilder.Entity<Dhgms.Whipstaff.Model.Info.Server>().Property(x => x.Description).IsRequired();
    modelBuilder.Entity<Dhgms.Whipstaff.Model.Info.Server>().Property(x => x.Population).IsRequired();
    modelBuilder.Entity<Dhgms.Whipstaff.Model.Info.Server>().Property(x => x.Status).IsRequired();
}

    }
        #endregion
}
