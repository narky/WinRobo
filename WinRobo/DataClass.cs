using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace WinRobo
{
    class DataClass
    {
        private SQLiteConnection conn;
        private SQLiteCommand cmmd;
        private const string pathTable="pathcache";
        private const string filterTable = "filterlist";
        private const string settingsTable = "settings";

        /// <summary>
        /// 构造函数，建立数据连接
        /// </summary>
        /// <param name="dbpath">数据库文件地址</param>
        public DataClass(string dbpath)
        {
            try
            {
                conn = new SQLiteConnection("Data Source=" + dbpath);
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "严重错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(Environment.ExitCode);
            }
        }

        /// <summary>
        /// 关闭数据库连接
        /// </summary>
        public void Close()
        {
            conn.Close();
        }

        private DataTable DataBySQL(string sqlstr,string field,bool enable_base64)
        {
            if (sqlstr == "") return null;
            SQLiteDataAdapter adapter = new SQLiteDataAdapter();
            DataTable dt = new DataTable();
            try
            {
                cmmd = new SQLiteCommand(sqlstr, conn);
                adapter.SelectCommand = cmmd;
                adapter.Fill(dt);
                //BASE64解码
                if (enable_base64)
                {
                    foreach (DataRow dr in dt.Rows)
                    {
                        dr[field] = Base64.DecodeBase64(dr[field].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "严重错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(Environment.ExitCode);

            }
            return dt;
        }

        private DataTable DataBySQL(string sqlstr, string field)
        {
            return DataBySQL(sqlstr, field, true);
        }

        private DataTable DataBySQL(string sqlstr)
        {
            return DataBySQL(sqlstr, "",false);
        }

        private void QueryByStr(string sqlstr)
        {
            if (sqlstr == "") return;
            try
            {
                cmmd = conn.CreateCommand();
                cmmd.CommandText = sqlstr;
                cmmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "严重错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(Environment.ExitCode);
            }
        }

        private bool HasData(string sqlstr)
        {
            cmmd = conn.CreateCommand();
            cmmd.CommandText = sqlstr;
            return cmmd.ExecuteReader().HasRows;
        }

        private bool hasPath(string pathString, int pathType)
        {
            string sqlStr = string.Concat(new object[] { "Select id from ", pathTable, " where pathString='", pathString, "' and pathType=", pathType });
            return this.HasData(sqlStr);
        }

        /// <summary>
        /// 按照不同的类别取得路径值列表
        /// </summary>
        /// <param name="pathType">路径类别：1.来源路径，2.目标路径</param>
        /// <returns>返回一个DataTable</returns>
        public DataTable PathData(int pathType)
        {
            string topNum = "";
            Dictionary<string, string> myDict = SettingsDict();
            if (Int32.Parse(myDict["path_list_num"]) > 0) topNum = " Limit 0," + myDict["path_list_num"].ToString();
            string field = "pathString";
            string sqlStr = string.Concat(new object[] { "SELECT " , field , " FROM " , pathTable , " where pathType=" , pathType , " order by id desc" , topNum });
            return this.DataBySQL(sqlStr, field);
        }

        /// <summary>
        /// 重载PathData(int pathType)
        /// </summary>
        /// <returns></returns>
        public DataTable PathData()
        {
            return PathData(1);
        }

        public DataTable FilterList(int flag)
        {
            string field = "filter";
            string sqlStr = "SELECT " + field + " FROM " + filterTable + " order by id desc";
            DataTable dt = DataBySQL(sqlStr, field,false);
            if (flag == 1) {
                DataRow dr = dt.NewRow();
                //dr["id"] = "0";
                dr[field] = "*.*";
                dt.Rows.Add(dr);
            }
            return dt;
        }

        public DataTable FilterList()
        {
            return FilterList(1);
        }

        /// <summary>
        /// 将路径信息按照类别存入配置数据库
        /// </summary>
        /// <param name="pathString">路径字符串</param>
        /// <param name="pathType">路径类别</param>
        public void SavePath(string pathString,int pathType)
        {
            if (hasPath(pathString, pathType) == false)
            {
                string sqlStr = string.Concat(new object[] { "INSERT INTO " , pathTable , " (pathString,pathType,useTimes) VALUES('" , pathString , "'," , pathType , ",1)" });
                this.QueryByStr(sqlStr);
            }
        }

        /// <summary>
        /// 重载SavePath(string pathString,int pathType)
        /// </summary>
        /// <param name="pathString">路径字符串</param>
        public void SavePath(string pathString)
        {
            SavePath(pathString,1);
        }

        public void clearPath(int pathType)
        {
            string sqlstr = string.Concat(new object[] { "Delete From ",pathTable," where pathType=",pathType });
            this.QueryByStr(sqlstr);
        }

        public bool setFilter(string filter, int flag)
        {
            string sql = "";
            switch (flag)
            {
                //add
                case 1:
                    if (HasData("select id from " + filterTable + " where filter='" + filter + "'"))
                    {
                        return false;
                    }
                    else {
                        sql = "Insert Into " + filterTable + "(filter) Values ('" + filter + "')";
                        QueryByStr(sql);
                        return true;
                    }
                    //break;
                //delete
                case 2:
                    sql = "Delete From " + filterTable + " where filter='" + filter + "'";
                    QueryByStr(sql);
                    return true;
                    //break;
                default:
                    return false;
            }
        }

        public void saveSetting(Dictionary<string, string> dict)
        {
            SQLiteDataAdapter adapter = new SQLiteDataAdapter("Select * From " + settingsTable, conn);
            DataTable dt = new DataTable();
            SQLiteCommandBuilder cmb = new SQLiteCommandBuilder(adapter);
            adapter.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                if (dr["key"].ToString() == "path_list_num") dr["value"] = dict["path_list_num"];
            }
            adapter.Update(dt);
        }

        public Dictionary<string, string> SettingsDict()
        {
            string sqlstr = "Select key,value From " + settingsTable;
            DataTable dt = DataBySQL(sqlstr);
            Dictionary<string, string> myDict = new Dictionary<string, string>();
            foreach (DataRow dr in dt.Rows)
            {
                myDict.Add(dr["key"].ToString(), dr["value"].ToString());
            }
            return myDict;
        }
    }
}
