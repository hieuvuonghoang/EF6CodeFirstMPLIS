using System;
using System.IO;
using System.Text;
using System.Collections.Generic;

namespace EF6CodeFirstMPLIS
{
    public class CreateClass
    {
        public static void Main(string[] args)
        {
            CreateFile(ReadFileTableStruct(), "HT_XA_NGUOIDUNG");
        }
        public static List<ColumnConfig> ReadFileTableStruct()
        {
            string path = @"D:\MPLIS\EF6CodeFirstMPLIS\EF6CodeFirstMPLIS\Temp\TableStruct.txt";
            string[] lines = File.ReadAllLines(path);
            List<ColumnConfig> columnConfigs = new List<ColumnConfig>();
            foreach (string line in lines)
            {
                ColumnConfig columnConfigTemp = new ColumnConfig(line.Split(' ')[0].Replace("\"", string.Empty));
                try
                {
                    columnConfigTemp.Length = line.Split('(')[1].Split(')')[0].Split(' ')[0];
                }
                catch (Exception)
                {
                    columnConfigTemp.Length = null;
                }
                columnConfigs.Add(columnConfigTemp);
            }
            return columnConfigs;
        }
        public static void CreateFile(List<ColumnConfig> columnConfigs, string className)
        {
            string classConfig = className + "_Configuration";

            string path = @"D:\MPLIS\EF6CodeFirstMPLIS\EF6CodeFirstMPLIS\Temp\" + classConfig + ".cs";
            string strUsing = String.Format("\n\t{0}\n\t{1}", "using Models;", "using System.Data.Entity.ModelConfiguration;");
            string strProperties = "";
            foreach (ColumnConfig columnConfig in columnConfigs)
            {
                if (columnConfig.Length != null)
                {
                    strProperties += String.Format("\n\t\t\tthis.Property(t => t.{0})\n\t\t\t\t.HasColumnName(\"{1}\")\n\t\t\t\t.IsUnicode(false)\n\t\t\t\t.HasMaxLength({2});", columnConfig.Name, columnConfig.Name, columnConfig.Length);
                } else
                {
                    strProperties += String.Format("\n\t\t\tthis.Property(t => t.{0})\n\t\t\t\t.HasColumnName(\"{1}\");", columnConfig.Name, columnConfig.Name);
                }
                
            }
            string strRelationship = String.Format("\n\t\t\tthis.HasRequired<>(t => t.)\n\t\t\t\t.WithMany(m => m.{0})\n\t\t\t\t.HasForeignKey(m => m.); ", className);
            string publicClassInitBody = String.Format("\n\t\t\t{0} \n\t\t\t{1} \n\t\t\t{2} \n\n\t\t\t{3}", "this.HasKey(t => t.);", strProperties, strRelationship, "this.ToTable(\"" + className + "\");");
            string publicClassInit = String.Format("\n\t\t{0} \n\t\t{1} {2} \n\t\t{3}", "public " + classConfig + "()", "{", publicClassInitBody, "}");
            string publicClass = String.Format("\n\t{0} : {1} \n\t{2} {3} \n\t{4}", "public class " + classConfig, "EntityTypeConfiguration<" + className + ">", "{", publicClassInit, "}");
            string bodyNameSpace = String.Format("{0} {1}", strUsing, publicClass);
            string nameSpace = String.Format("namespace EF6CodeFirstMPLIS.Configuration \n{0} {1} \n{2}", "{", bodyNameSpace, "}");

            File.WriteAllText(path, nameSpace);
        }
    }

    public class ColumnConfig
    {
        public ColumnConfig(string name)
        {
            Name = name;
            Length = null;
        }
        public string Name { get; set; }
        public string Length { get; set; }
    }
}
