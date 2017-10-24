using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Suggestion_Box.Models
{
    public class SuggestionModel
    {

        [Key]
        public int ID { get; set; }

        public string Comment { get; set; }

        //public string Topic { get; set; }

        public string Topic
        {
            get { return this.Topic; }
            set { this.Topic = value; }
        }

    }
}