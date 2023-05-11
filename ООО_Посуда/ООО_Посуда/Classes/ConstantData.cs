using System;
using System.Collections.Generic;
using System.Text;

namespace ООО_Посуда.Classes
{
    class ConstantData
    {
        public static Windows.Autorization auth;
        public static string Article;
        public static MySql.Data.MySqlClient.MySqlConnection con = new MySql.Data.MySqlClient.MySqlConnection("server=localhost;user=root;pwd=ELINA2030;database=trade2");
    }
}
