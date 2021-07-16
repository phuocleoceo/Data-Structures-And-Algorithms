using System;
using System.Collections.Generic;
using System.Text;

namespace GenericList
{
	class Account
	{
		public string UserName { get; set; }
		public string DisplayName { get; set; }
		public string PassWord { get; set; }
		public int Type { get; set; }
		public Account() { }
		public Account(string username, string displayname, string password, int type)
		{
			UserName = username;
			DisplayName = displayname;
			PassWord = password;
			Type = type;
		}

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public bool Equals(Account acc)
		{
			return UserName == acc.UserName && DisplayName == acc.DisplayName &&
				   PassWord == acc.PassWord && Type == acc.Type;
		}

		public override bool Equals(object obj)
		{
			return Equals(obj as Account);
		}

		public override string ToString()
		{
			return $"{UserName,10}\t{DisplayName,15}\t{PassWord,10}\t{Type}";
		}
	}
}
