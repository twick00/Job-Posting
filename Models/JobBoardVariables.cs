using System;
using System.Collections.Generic;

namespace JobBoard.Models
{
    public class JobBoardVariable
    {
        private string _jobPostTitle;
        private string _jobPostDescription;
        private static List<JobBoardVariable> _jobList = new List<JobBoardVariable> {};

        public JobBoardVariable(string jobPostTitle, string jobPostDescription)
        {
            _jobPostDescription = jobPostDescription;
            _jobPostTitle = jobPostTitle;
        }
        public string GetJobPost()
        {
            return _jobPostTitle;
        }
        public string GetJobDescription()
        {
            return _jobPostDescription;
        }
        public static List<JobBoardVariable> GetAll()
        {
            return _jobList;
        }
        public void Save()
        {
            _jobList.Add(this);
        }
        
        public static void ClearAll()
        {
            _jobList.Clear();
        }
    }
}