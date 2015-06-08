using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Power_Control_v2.PowerCfg
{
    class Wrapper
    {
        #region VARIABLES
        private static string REGEX_ALL_SCHEMES = @": (?<guid>(.*?)) \((?<name>(.*?))\)";
        public static Scheme NullScheme = new Scheme("0", "0");
        private static Scheme currentScheme = NullScheme;
        private static Wrapper instance = new Wrapper();
        #endregion

        #region EVENTS
        public event EventHandler CurrentSchemeChangedEvent;
        protected virtual void OnCurrentSchemeChangedEvent(EventArgs e)
        {
            if (CurrentSchemeChangedEvent != null)
                CurrentSchemeChangedEvent(null, e);
        }
        #endregion

        #region PROPERTIES
        public Scheme CurrentScheme 
        { 
            get
            { 
                return currentScheme; 
            }
            private set
            {
                if (value.Guid != currentScheme.Guid)
                {
                    currentScheme = value;
                    OnCurrentSchemeChangedEvent(null);
                }
            }
        }
        public static Wrapper Instance
        {
            get { return instance; }
        }
        #endregion

        #region CONSTRUCTORS
        private Wrapper()
        {

        }
        #endregion

        #region METHODS
        public string ExecuteCommand(string argument)
        {
            return Misc.Execute("powercfg", argument);
        }

        public Scheme[] GetAllSchemes()
        {
            string data = ExecuteCommand("-list");
            string[] lines = Misc.SplitIntoLines(data);

            if (lines.Length == 0)
                return null;

            List<Scheme> schemes = new List<Scheme>();

            foreach(string line in lines)
            {
                Match mtch = Regex.Match(line, REGEX_ALL_SCHEMES, RegexOptions.IgnoreCase | RegexOptions.Multiline);
                if(mtch.Success)
                {
                    schemes.Add(new Scheme(mtch.Groups["name"].Value, mtch.Groups["guid"].Value));
                }
            }

            return schemes.ToArray();
        }

        private Scheme GetActiveScheme()
        {
            string data = ExecuteCommand("-getactivescheme");
            string[] lines = Misc.SplitIntoLines(data);

            if (lines.Length == 0)
                return NullScheme;

            List<Scheme> schemes = new List<Scheme>();

            foreach (string line in lines)
            {
                Match mtch = Regex.Match(line, REGEX_ALL_SCHEMES, RegexOptions.IgnoreCase | RegexOptions.Multiline);
                if (mtch.Success)
                {
                    return new Scheme(mtch.Groups["name"].Value, mtch.Groups["guid"].Value);
                }
            }

            return NullScheme;
        }

        public void RefreshInfo()
        {
            Scheme scheme = GetActiveScheme();
            CurrentScheme = scheme;
        }

        internal void SetActiveScheme(Scheme scheme)
        {
            ExecuteCommand(string.Format("-setactive {0}", scheme.Guid));
            RefreshInfo();
        }
        #endregion
    }
}
