using System.Collections.Generic;

namespace StudentSystem.Utils
{
    public class InputCommandParser
    {
        string[] commands;
        public InputCommandParser(string[] commands)
        {
            this.commands = commands;
        }
        public string GetFilePath()
        {
            return commands[0];
        }
        public List<SearchCriteria> GetSearchCriteriaItems()
        {
            List<SearchCriteria> sc = new List<SearchCriteria>();
            if(commands.Length > 1)
            {
                for(int i = 1; i < commands.Length; i++)
                {
                    sc.Add(ParseSearchCriteriaItem(commands[i]));
                }                
            }
            return sc;
        }
        private SearchCriteria ParseSearchCriteriaItem(string s)
        {
            var values = s.Split('=');
            SearchCriteria item = new SearchCriteria(){
                Criteria = values[0],
                Value = values[1]
            };

            return item;
        }
    }
}