using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace DatenSpeichernUndLaden
{
    class ToDoItem
    {

        [JsonProperty("userId")]
        public int UserId { get; set; }

        [PrimaryKey,AutoIncrement]

        [JsonProperty("id")]
        public int Id { get; set; }

        [MaxLength(255)]

        [JsonProperty("title")]
        public string Title { get; set; }
        [JsonProperty("completed")]
        public bool Completed { get; set; }
    }

}
