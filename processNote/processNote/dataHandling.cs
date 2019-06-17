using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace processNote
{
    public sealed class DataHandling
    {
        private static DataHandling instance = null;
        private static readonly object padlock = new object();
        private int selectedIndex;
        public int SelectedIndex
        {
            get
            {
                return this.selectedIndex;
            }
            set
            {
                this.selectedIndex = value;
            }
        }
        private Process[] processList;
        public Process[] ProcessList
        {
            get
            {
                Process[] copy = new Process[processList.Length];
                Array.Copy(processList, copy, processList.Length);
                return copy;
            }
            private set { }
        }

        Dictionary<int, string> Comments = new Dictionary<int, string>();

        public static DataHandling Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new DataHandling();
                    }
                    return instance;
                }
            }
        }

        private DataHandling()
        {
            processList = Process.GetProcesses();
        }

        public void Set(int key, string value)
        {
            if (Comments.ContainsKey(key))
            {
                Comments[key] = value;
            }
            else
            {
                Comments.Add(key, value);
            }
        }

        public string Get(int key)
        {
            string result = "";

            if (Comments.ContainsKey(key))
            {
                result = Comments[key];
            }

            return result;
        }

        public bool ContainsID(int ID)
        {
            return Comments.Keys.Contains(ID);
        }
    }
}
