using System;
using System.Data;
using System.Collections.Generic;

namespace CodeGenTools
{
	public static class TypeTranslator
	{
		public static string ToClrTypeName(string sqlServerDataType)
		{
			throw new NotImplementedException();
		}
		public static string ToCSharpAlias(string sqlServerDataType)
		{
			var dict = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
			dict.Add("bigint", "long");
			dict.Add("binary", "byte[]");
			dict.Add("bit", "bool");
			dict.Add("char", "string");
			dict.Add("date", "System.DateTime");
			dict.Add("datetime", "System.DateTime");
			dict.Add("datetime2", "System.DateTime");
			dict.Add("decimal", "decimal");
			dict.Add("float", "double");
			dict.Add("image", "byte[]");
			dict.Add("int", "int");
			dict.Add("money", "double");
			dict.Add("nchar", "string");
			dict.Add("ntext", "string");
			dict.Add("numeric", "double");
			dict.Add("nvarchar", "string");
			dict.Add("smalldatetime", "System.DateTime");
			dict.Add("smallint", "short");
			dict.Add("smallmoney", "double");
			dict.Add("sql_variant", "object");
			dict.Add("text", "string");
			dict.Add("time", "System.DateTime");
			dict.Add("timestamp", "byte[]");
			dict.Add("tinyint", "byte");
			dict.Add("uniqueidentifier", "System.Guid");
			dict.Add("varbinary", "byte[]");
			dict.Add("varchar", "string");
			dict.Add("xml", "string");
			if (!dict.ContainsKey(sqlServerDataType))
				throw new KeyNotFoundException(sqlServerDataType + " is not mapped.");

			return dict[sqlServerDataType];
		}
		public static SqlDbType ToSqlDbType(string sqlServerDataType)
		{
			var dict = new Dictionary<string, SqlDbType>(StringComparer.OrdinalIgnoreCase);
			dict.Add("bigint", SqlDbType.BigInt);
			dict.Add("binary", SqlDbType.Binary);
			dict.Add("bit", SqlDbType.Bit);
			dict.Add("char", SqlDbType.Char);
			dict.Add("date", SqlDbType.Date);
			dict.Add("datetime", SqlDbType.DateTime);
			dict.Add("datetime2", SqlDbType.DateTime2);
			dict.Add("datetimeoffset", SqlDbType.DateTimeOffset);
			dict.Add("decimal", SqlDbType.Decimal);
			dict.Add("float", SqlDbType.Float);
			dict.Add("image", SqlDbType.Image);
			dict.Add("int", SqlDbType.Int);
			dict.Add("money", SqlDbType.Money);
			dict.Add("nchar", SqlDbType.NChar);
			dict.Add("ntext", SqlDbType.NText);
			dict.Add("numeric", SqlDbType.Decimal);
			dict.Add("nvarchar", SqlDbType.NVarChar);
			dict.Add("smalldatetime", SqlDbType.SmallDateTime);
			dict.Add("smallint", SqlDbType.SmallInt);
			dict.Add("smallmoney", SqlDbType.SmallMoney);
			dict.Add("sql_variant", SqlDbType.Variant);
			dict.Add("text", SqlDbType.Text);
			dict.Add("time", SqlDbType.Time);
			dict.Add("timestamp", SqlDbType.Timestamp);
			dict.Add("tinyint", SqlDbType.TinyInt);
			dict.Add("uniqueidentifier", SqlDbType.UniqueIdentifier);
			dict.Add("varbinary", SqlDbType.VarBinary);
			dict.Add("varchar", SqlDbType.VarChar);
			dict.Add("xml", SqlDbType.Xml);

			if (!dict.ContainsKey(sqlServerDataType))
				throw new KeyNotFoundException(sqlServerDataType + " is not mapped.");

			return dict[sqlServerDataType];
		}
	}
}
