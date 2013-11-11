using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PetaPoco;

namespace PetaPoco.Tests
{
	[TestClass]
	public class SqlTest
	{
		[TestMethod]
		public void should_have_default_constructor()
		{
			Sql sql = new Sql();
			Assert.IsNotNull(sql);
		}

		[TestMethod]
		public void should_return_Sql_object_from_constructor_with_two_parameters()
		{
			string sqlStatemet = "SELECT * FROM User WHERE UserId = @0 AND UserName = @1";
			object[] arguments = new object[2]{ 1, "UserName"};
			Sql sql = new Sql(sqlStatemet, arguments);
			Assert.IsTrue(sql.SQL == sqlStatemet);
			Assert.IsTrue(sql.Arguments[0].Equals(1));
			Assert.IsTrue(sql.Arguments[1].Equals("UserName"));
		}
	}
}
