using System;
using System.Collections.Generic;
using System.Text;

namespace WPYAK.Model.Data
{
    public class Featuredlocation
    {
        public string peekID { get; set; }
        public string location { get; set; }
        public string inactive { get; set; }
        public string isFictional { get; set; }
        public string canSubmit { get; set; }
        public string canVote { get; set; }
        public string canReply { get; set; }
        public string canReport { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public string isLocal { get; set; }
        public string delta { get; set; }
    }

    public class Otherlocation
    {
        public string peekID { get; set; }
        public string location { get; set; }
        public string inactive { get; set; }
        public string canSubmit { get; set; }
        public string canVote { get; set; }
        public string canReply { get; set; }
        public string canReport { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public string isLocal { get; set; }
        public string delta { get; set; }
    }

}
