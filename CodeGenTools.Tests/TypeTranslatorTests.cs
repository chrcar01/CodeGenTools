using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Data;

namespace CodeGenTools.Tests
{
	[TestFixture]
	public class TypeTranslatorTests
	{
		[Test]
		public void CanConvertSqlServerTypeToSqlDbType()
		{
			Assert.AreEqual(SqlDbType.BigInt, TypeTranslator.ToSqlDbType("bigint"));
			Assert.AreEqual(SqlDbType.Binary, TypeTranslator.ToSqlDbType("binary"));
			Assert.AreEqual(SqlDbType.Bit, TypeTranslator.ToSqlDbType("bit"));
			Assert.AreEqual(SqlDbType.Char, TypeTranslator.ToSqlDbType("char"));
			Assert.AreEqual(SqlDbType.Date, TypeTranslator.ToSqlDbType("date"));
			Assert.AreEqual(SqlDbType.DateTime, TypeTranslator.ToSqlDbType("datetime"));
			Assert.AreEqual(SqlDbType.DateTime2, TypeTranslator.ToSqlDbType("datetime2"));
			Assert.AreEqual(SqlDbType.DateTimeOffset, TypeTranslator.ToSqlDbType("datetimeoffset"));
			Assert.AreEqual(SqlDbType.Decimal, TypeTranslator.ToSqlDbType("decimal"));
			Assert.AreEqual(SqlDbType.Float, TypeTranslator.ToSqlDbType("float"));
			Assert.AreEqual(SqlDbType.Image, TypeTranslator.ToSqlDbType("image"));
			Assert.AreEqual(SqlDbType.Int, TypeTranslator.ToSqlDbType("int"));
			Assert.AreEqual(SqlDbType.Money, TypeTranslator.ToSqlDbType("money"));
			Assert.AreEqual(SqlDbType.NChar, TypeTranslator.ToSqlDbType("nchar"));
			Assert.AreEqual(SqlDbType.NText, TypeTranslator.ToSqlDbType("ntext"));
			Assert.AreEqual(SqlDbType.Decimal, TypeTranslator.ToSqlDbType("numeric"));
			Assert.AreEqual(SqlDbType.NVarChar, TypeTranslator.ToSqlDbType("nvarchar"));
			Assert.AreEqual(SqlDbType.SmallDateTime, TypeTranslator.ToSqlDbType("smalldatetime"));
			Assert.AreEqual(SqlDbType.SmallInt, TypeTranslator.ToSqlDbType("smallint"));
			Assert.AreEqual(SqlDbType.SmallMoney, TypeTranslator.ToSqlDbType("smallmoney"));
			Assert.AreEqual(SqlDbType.Variant, TypeTranslator.ToSqlDbType("sql_variant"));
			Assert.AreEqual(SqlDbType.Text, TypeTranslator.ToSqlDbType("text"));
			Assert.AreEqual(SqlDbType.Time, TypeTranslator.ToSqlDbType("time"));
			Assert.AreEqual(SqlDbType.Timestamp, TypeTranslator.ToSqlDbType("timestamp"));
			Assert.AreEqual(SqlDbType.TinyInt, TypeTranslator.ToSqlDbType("tinyint"));
			Assert.AreEqual(SqlDbType.UniqueIdentifier, TypeTranslator.ToSqlDbType("uniqueidentifier"));
			Assert.AreEqual(SqlDbType.VarBinary, TypeTranslator.ToSqlDbType("varbinary"));
			Assert.AreEqual(SqlDbType.VarChar, TypeTranslator.ToSqlDbType("varchar"));
			Assert.AreEqual(SqlDbType.Xml, TypeTranslator.ToSqlDbType("xml"));
		}
		[Test]
		public void CanConvertSqlServerTypeToCSharpAlias()
		{
			Assert.AreEqual("long", TypeTranslator.ToCSharpAlias("bigint"));
			Assert.AreEqual("byte[]", TypeTranslator.ToCSharpAlias("binary"));
			Assert.AreEqual("bool", TypeTranslator.ToCSharpAlias("bit"));
			Assert.AreEqual("string", TypeTranslator.ToCSharpAlias("char"));
			Assert.AreEqual("System.DateTime", TypeTranslator.ToCSharpAlias("date"));
			Assert.AreEqual("System.DateTime", TypeTranslator.ToCSharpAlias("datetime"));
			Assert.AreEqual("System.DateTime", TypeTranslator.ToCSharpAlias("datetime2"));
			Assert.AreEqual("decimal", TypeTranslator.ToCSharpAlias("decimal"));
			Assert.AreEqual("double", TypeTranslator.ToCSharpAlias("float"));
			Assert.AreEqual("byte[]", TypeTranslator.ToCSharpAlias("image"));
			Assert.AreEqual("int", TypeTranslator.ToCSharpAlias("int"));
			Assert.AreEqual("double", TypeTranslator.ToCSharpAlias("money"));
			Assert.AreEqual("string", TypeTranslator.ToCSharpAlias("nchar"));
			Assert.AreEqual("string", TypeTranslator.ToCSharpAlias("ntext"));
			Assert.AreEqual("double", TypeTranslator.ToCSharpAlias("numeric"));
			Assert.AreEqual("string", TypeTranslator.ToCSharpAlias("nvarchar"));
			Assert.AreEqual("System.DateTime", TypeTranslator.ToCSharpAlias("smalldatetime"));
			Assert.AreEqual("short", TypeTranslator.ToCSharpAlias("smallint"));
			Assert.AreEqual("double", TypeTranslator.ToCSharpAlias("smallmoney"));
			Assert.AreEqual("object", TypeTranslator.ToCSharpAlias("sql_variant"));
			Assert.AreEqual("string", TypeTranslator.ToCSharpAlias("text"));
			Assert.AreEqual("System.DateTime", TypeTranslator.ToCSharpAlias("time"));
			Assert.AreEqual("byte[]", TypeTranslator.ToCSharpAlias("timestamp"));
			Assert.AreEqual("byte", TypeTranslator.ToCSharpAlias("tinyint"));
			Assert.AreEqual("System.Guid", TypeTranslator.ToCSharpAlias("uniqueidentifier"));
			Assert.AreEqual("byte[]", TypeTranslator.ToCSharpAlias("varbinary"));
			Assert.AreEqual("string", TypeTranslator.ToCSharpAlias("varchar"));
			Assert.AreEqual("string", TypeTranslator.ToCSharpAlias("xml"));
		}
		[Test]
		public void CaseInsensitiveDictionaryTests()
		{
			var dict = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
			dict.Add("test", "test");
			Assert.IsTrue(dict.ContainsKey("TeSt"));
		}
	}
}
